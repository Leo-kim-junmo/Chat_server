using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Chat2
{
    public partial class Form_client : Form
    {
        string ID;
        NetworkStream stream = default(NetworkStream);
        TcpClient client = new TcpClient();

        public Form_client(string ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        void Connect(string s)
        {
            char split = ' ';
            string[] parsedIP = s.Split(split); // 1 : client, 2 : server, 3 : port

            try
            {
                IPEndPoint clientAddr = new IPEndPoint(IPAddress.Parse(parsedIP[1]), 0);
                IPEndPoint serverAddr = new IPEndPoint(IPAddress.Parse(parsedIP[2]), Int32.Parse(parsedIP[3]));
                client = new TcpClient(clientAddr);
                client.Connect(serverAddr);
                stream = client.GetStream();
                Display("Chat Server Connected...");
            }
            catch (Exception e)
            {
                Display("Failed to Connect...");
            }
            if (!client.Connected)
            {
                MessageBox.Show("usage : /connect 클라이언트IP 서버IP 서버PORT");
                tb_msg.Text = string.Empty;
                tb_msg.Focus();
            }
            else
            {
                byte[] buffer = Encoding.Default.GetBytes(ID);
                stream.Write(buffer, 0, buffer.Length);

                Thread clientThread = new Thread(Receiver);
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        void Display(string msg)
        {
            CheckForIllegalCrossThreadCalls = false;
            rtb_client.AppendText(msg + "\r\n");
            rtb_client.Select(rtb_client.Text.Length, 0);
            rtb_client.ScrollToCaret();
        }

        void Receiver()
        {
            try
            {
                while (true)
                {
                    int bufferSize = client.ReceiveBufferSize;
                    byte[] buffer = new byte[bufferSize];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string msg = Encoding.Default.GetString(buffer, 0, bytes);
                    if (!isControlMsg(msg)) Display(msg);
                }
            }
            catch (IOException e)
            {
                //
            }
        }

        bool isControlMsg(string msg)
        {
            bool isCtrl = true;
            if (msg.StartsWith("**user list** "))
            {
                list_client.Items.Clear();
                char split = ' ';
                string[] userlist = msg.Split(split);
                foreach (string s in userlist)
                {
                    if (s.StartsWith("**")) continue;
                    list_client.Items.Add(s);
                }
            }
            else isCtrl = false;
            return isCtrl;
        }

        void Refresherlist(string[] ul)
        {

        }

        void Sender(string s)
        {
            byte[] buffer = Encoding.Default.GetBytes(s);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }

        void Controller(string s)
        {
            if (s.StartsWith("/connect "))
            {
                Connect(s);
            }
            else if (!client.Connected)
            {
                MessageBox.Show("서버에 먼저 연결해주세요.");
                tb_msg.Text = string.Empty;
                tb_msg.Focus();
            }
            else if (s.Equals("/exit"))
            {
                Disconnect();
            }
            else
            {
                Sender(s);
            }
        }

        void Disconnect()
        {
            byte[] buffer = Encoding.Default.GetBytes("/exit");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            stream.Close();
            client.Close();
            Application.ExitThread();
            this.Close();
        }

        void Disconnect(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes("/exit");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            stream.Close();
            client.Close();
            Application.ExitThread();
            this.Close();
        }

        private void tb_msg_KetDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btn_enter_Click(sender, e);
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string input = tb_msg.Text;
            Controller(input);
            tb_msg.Text = string.Empty;
            tb_msg.Focus();
        }

        private void Form_client_Load(object sender, EventArgs e)
        {

        }
    }
}
