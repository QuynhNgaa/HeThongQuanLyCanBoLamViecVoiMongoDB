namespace Login
{
    partial class Doimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcur = new System.Windows.Forms.TextBox();
            this.textnw = new System.Windows.Forms.TextBox();
            this.textrnw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmkc = new System.Windows.Forms.Label();
            this.lblmkm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // textcur
            // 
            this.textcur.Location = new System.Drawing.Point(179, 54);
            this.textcur.Name = "textcur";
            this.textcur.PasswordChar = '*';
            this.textcur.Size = new System.Drawing.Size(156, 20);
            this.textcur.TabIndex = 4;
            this.textcur.Leave += new System.EventHandler(this.textcur_Leave);
            // 
            // textnw
            // 
            this.textnw.Location = new System.Drawing.Point(179, 85);
            this.textnw.Name = "textnw";
            this.textnw.PasswordChar = '*';
            this.textnw.Size = new System.Drawing.Size(156, 20);
            this.textnw.TabIndex = 5;
            this.textnw.Leave += new System.EventHandler(this.textnw_Leave);
            // 
            // textrnw
            // 
            this.textrnw.Location = new System.Drawing.Point(179, 117);
            this.textrnw.Name = "textrnw";
            this.textrnw.PasswordChar = '*';
            this.textrnw.Size = new System.Drawing.Size(156, 20);
            this.textrnw.TabIndex = 6;
            this.textrnw.Leave += new System.EventHandler(this.textrnw_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hủy ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(341, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // lblmkc
            // 
            this.lblmkc.AutoSize = true;
            this.lblmkc.ForeColor = System.Drawing.Color.Red;
            this.lblmkc.Location = new System.Drawing.Point(341, 57);
            this.lblmkc.Name = "lblmkc";
            this.lblmkc.Size = new System.Drawing.Size(0, 13);
            this.lblmkc.TabIndex = 10;
            // 
            // lblmkm
            // 
            this.lblmkm.AutoSize = true;
            this.lblmkm.ForeColor = System.Drawing.Color.Red;
            this.lblmkm.Location = new System.Drawing.Point(341, 88);
            this.lblmkm.Name = "lblmkm";
            this.lblmkm.Size = new System.Drawing.Size(0, 13);
            this.lblmkm.TabIndex = 11;
            // 
            // Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.lblmkm);
            this.Controls.Add(this.lblmkc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textrnw);
            this.Controls.Add(this.textnw);
            this.Controls.Add(this.textcur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doimatkhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textcur;
        private System.Windows.Forms.TextBox textnw;
        private System.Windows.Forms.TextBox textrnw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmkc;
        private System.Windows.Forms.Label lblmkm;
    }
}