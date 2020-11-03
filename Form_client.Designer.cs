namespace Chat2
{
    partial class Form_client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_client = new System.Windows.Forms.RichTextBox();
            this.list_client = new System.Windows.Forms.ListBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_client
            // 
            this.rtb_client.Location = new System.Drawing.Point(10, 10);
            this.rtb_client.Name = "rtb_client";
            this.rtb_client.Size = new System.Drawing.Size(500, 400);
            this.rtb_client.TabIndex = 0;
            this.rtb_client.Text = "";
            // 
            // list_client
            // 
            this.list_client.FormattingEnabled = true;
            this.list_client.ItemHeight = 12;
            this.list_client.Location = new System.Drawing.Point(516, 10);
            this.list_client.Name = "list_client";
            this.list_client.Size = new System.Drawing.Size(122, 400);
            this.list_client.TabIndex = 1;
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(10, 425);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(500, 21);
            this.tb_msg.TabIndex = 2;
            this.tb_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_msg_KetDown);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(516, 425);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(58, 20);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(580, 425);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(58, 20);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Disconnect);
            // 
            // Form_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 461);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.list_client);
            this.Controls.Add(this.rtb_client);
            this.Name = "Form_client";
            this.Text = "Chat_client";
            this.Load += new System.EventHandler(this.Form_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_client;
        private System.Windows.Forms.ListBox list_client;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_close;
    }
}