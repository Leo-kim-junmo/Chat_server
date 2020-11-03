namespace Chat2
{
    partial class Form_server
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_console = new System.Windows.Forms.GroupBox();
            this.list_console = new System.Windows.Forms.ListBox();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.gb_control = new System.Windows.Forms.GroupBox();
            this.btn_control = new System.Windows.Forms.Button();
            this.tb_control = new System.Windows.Forms.TextBox();
            this.gb_console.SuspendLayout();
            this.gb_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_console
            // 
            this.gb_console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_console.Controls.Add(this.list_console);
            this.gb_console.Controls.Add(this.rtb_console);
            this.gb_console.Location = new System.Drawing.Point(13, 13);
            this.gb_console.Name = "gb_console";
            this.gb_console.Size = new System.Drawing.Size(625, 369);
            this.gb_console.TabIndex = 0;
            this.gb_console.TabStop = false;
            this.gb_console.Text = "Console";
            // 
            // list_console
            // 
            this.list_console.FormattingEnabled = true;
            this.list_console.ItemHeight = 12;
            this.list_console.Location = new System.Drawing.Point(513, 21);
            this.list_console.Name = "list_console";
            this.list_console.Size = new System.Drawing.Size(106, 340);
            this.list_console.TabIndex = 1;
            // 
            // rtb_console
            // 
            this.rtb_console.Location = new System.Drawing.Point(7, 21);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(500, 340);
            this.rtb_console.TabIndex = 0;
            this.rtb_console.Text = "";
            // 
            // gb_control
            // 
            this.gb_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_control.Controls.Add(this.btn_control);
            this.gb_control.Controls.Add(this.tb_control);
            this.gb_control.Location = new System.Drawing.Point(13, 389);
            this.gb_control.Name = "gb_control";
            this.gb_control.Size = new System.Drawing.Size(625, 60);
            this.gb_control.TabIndex = 1;
            this.gb_control.TabStop = false;
            this.gb_control.Text = "Control";
            // 
            // btn_control
            // 
            this.btn_control.Location = new System.Drawing.Point(513, 21);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(106, 21);
            this.btn_control.TabIndex = 1;
            this.btn_control.Text = "Enter";
            this.btn_control.UseVisualStyleBackColor = true;
            this.btn_control.Click += new System.EventHandler(this.ControlEnter);
            // 
            // tb_control
            // 
            this.tb_control.Location = new System.Drawing.Point(7, 21);
            this.tb_control.Name = "tb_control";
            this.tb_control.Size = new System.Drawing.Size(500, 21);
            this.tb_control.TabIndex = 0;
            this.tb_control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlInput_KeyDown);
            // 
            // Form_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 461);
            this.Controls.Add(this.gb_control);
            this.Controls.Add(this.gb_console);
            this.Name = "Form_server";
            this.Text = "Chat_server";
            this.Load += new System.EventHandler(this.ChatServerForm_Load);
            this.gb_console.ResumeLayout(false);
            this.gb_control.ResumeLayout(false);
            this.gb_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_console;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.ListBox list_console;
        private System.Windows.Forms.GroupBox gb_control;
        private System.Windows.Forms.TextBox tb_control;
        private System.Windows.Forms.Button btn_control;
    }
}

