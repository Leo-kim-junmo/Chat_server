using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chat2
{
    public partial class Form_server : Form
    {
        public string bufferedList;
        public List<string> users = new List<string>();
        TcpListener server;

        public void AddText(string text)
        {
            rtb_console.AppendText(text);
            rtb_console.Select(rtb_console.Text.Length, 0);
            rtb_console.ScrollToCaret();
        }

        void ControlEnter(object sender, EventArgs e)
        {
            string input = tb_control.Text;
            Controller(input);
            tb_control.Text = string.Empty;
            tb_control.Focus();
        }

        void RefreshChatters()
        {
            CheckForIllegalCrossThreadCalls = false;
            while(true)
            {
                bufferedList = "**userlist** ";
                list_console.Items.Clear();
                foreach(string user in users)
                {
                    list_console.Items.Add(user);
                    bufferedList += (user + " ");
                }
                Thread.Sleep(1000);
            }
        }

        void OpenServer(object s)
        {
            string serverIP = s.ToString().Substring("/open ".Length);
            TcpClient client = new TcpClient();
            const int Port = 12345;
            IPEndPoint serverAddr = new IPEndPoint(IPAddress.Parse(serverIP), Port);
            server = new TcpListener(serverAddr);
            try
            {
                server.Start();
            }
            catch(SocketException e)
            {
                MessageBox.Show("올바르지 않은 주소입니다.");
                return;
            }
            AddText(String.Format("Server Opened. [{0}\r\n", serverAddr.ToString()));
            while(true)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userID = Encoding.Default.GetString(buffer, 0, bytes);
                    users.Add(userID);
                    MyChatServer mychat = new MyChatServer(client, userID, this);
                    Thread serverThread = new Thread(new ThreadStart(mychat.Listen));
                    serverThread.IsBackground = true;
                    serverThread.Start();
                }
                catch(Exception e)
                {
                    break;
                }
            }
            client.Close();
            server.Stop();
        }

        void CloseServer()
        {
            // 서버 닫기
        }

        void Controller(string s)
        {
            if (s.Equals(string.Empty)) return;
            else if(s.Equals("/close"))
            {
                CloseServer();
                AddText("[Server] Closed.\r\n");
            }
            else if(s.StartsWith("/open "))
            {
                Thread open = new Thread(OpenServer);
                open.IsBackground = true;
                open.Start(s);
            }
        }

        public Form_server()
        {
            InitializeComponent();
        }

        private void ControlInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) ControlEnter(sender, e);
        }

        private void ChatServerForm_Load(object sender, EventArgs e)
        {
            Thread refresher = new Thread(RefreshChatters);
            refresher.IsBackground = true;
            refresher.Start();
        }
    }
}
