namespace Chat2
{
    partial class Form_id
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(10, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(360, 21);
            this.tb_id.TabIndex = 0;
            this.tb_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_id_KeyDown);
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(376, 20);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(96, 21);
            this.btn_id.TabIndex = 1;
            this.btn_id.Text = "Enter";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // Form_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 61);
            this.Controls.Add(this.btn_id);
            this.Controls.Add(this.tb_id);
            this.Name = "Form_id";
            this.Text = "Enter your ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_id;
    }
}