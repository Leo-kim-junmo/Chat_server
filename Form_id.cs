using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat2
{
    public partial class Form_id : Form
    {
        string ID;

        public Form_id()
        {
            InitializeComponent();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            if(tb_id.Text.Equals(string.Empty))
            {
                MessageBox.Show("ID 를 입력해주세요");
            }
            else
            {
                ID = tb_id.Text;
                Form_client clientform = new Form_client(ID);
                this.Hide();
                clientform.ShowDialog();
            }
        }

        private void tb_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) btn_id_Click(sender, e);
        }
    }
}
