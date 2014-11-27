namespace Login
{
    partial class Thembangcap
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
            this.txtmbc = new System.Windows.Forms.TextBox();
            this.txttbc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblmbc = new System.Windows.Forms.Label();
            this.lbltbc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bằng cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bằng cấp:";
            // 
            // txtmbc
            // 
            this.txtmbc.Location = new System.Drawing.Point(146, 58);
            this.txtmbc.Name = "txtmbc";
            this.txtmbc.Size = new System.Drawing.Size(148, 20);
            this.txtmbc.TabIndex = 3;
            this.txtmbc.Leave += new System.EventHandler(this.txtmbc_Leave);
            // 
            // txttbc
            // 
            this.txttbc.Location = new System.Drawing.Point(146, 84);
            this.txttbc.Name = "txttbc";
            this.txttbc.Size = new System.Drawing.Size(148, 20);
            this.txttbc.TabIndex = 4;
            this.txttbc.Leave += new System.EventHandler(this.txttbc_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmbc
            // 
            this.lblmbc.AutoSize = true;
            this.lblmbc.ForeColor = System.Drawing.Color.Red;
            this.lblmbc.Location = new System.Drawing.Point(324, 61);
            this.lblmbc.Name = "lblmbc";
            this.lblmbc.Size = new System.Drawing.Size(0, 13);
            this.lblmbc.TabIndex = 7;
            // 
            // lbltbc
            // 
            this.lbltbc.AutoSize = true;
            this.lbltbc.ForeColor = System.Drawing.Color.Red;
            this.lbltbc.Location = new System.Drawing.Point(324, 87);
            this.lbltbc.Name = "lbltbc";
            this.lbltbc.Size = new System.Drawing.Size(0, 13);
            this.lbltbc.TabIndex = 8;
            // 
            // Thembangcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.lbltbc);
            this.Controls.Add(this.lblmbc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttbc);
            this.Controls.Add(this.txtmbc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thembangcap";
            this.Text = "Thembangcap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmbc;
        private System.Windows.Forms.TextBox txttbc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblmbc;
        private System.Windows.Forms.Label lbltbc;
    }
}