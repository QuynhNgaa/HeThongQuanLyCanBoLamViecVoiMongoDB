namespace Login
{
    partial class Themkhenthuongcanbo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbklcb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboktcb = new System.Windows.Forms.ComboBox();
            this.vCanboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCBDataSet9 = new Login.QLCBDataSet9();
            this.cbkt = new System.Windows.Forms.ComboBox();
            this.vKhenthuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCBDataSet2 = new Login.QLCBDataSet2();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.vCanboTableAdapter = new Login.QLCBDataSet9TableAdapters.VCanboTableAdapter();
            this.vKhenthuongTableAdapter = new Login.QLCBDataSet2TableAdapters.VKhenthuongTableAdapter();
            this.lblhtcb = new System.Windows.Forms.Label();
            this.lblkt = new System.Windows.Forms.Label();
            this.lblnk = new System.Windows.Forms.Label();
            this.lblld = new System.Windows.Forms.Label();
            this.lblht = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vCanboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKhenthuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // lbklcb
            // 
            this.lbklcb.AutoSize = true;
            this.lbklcb.Location = new System.Drawing.Point(46, 37);
            this.lbklcb.Name = "lbklcb";
            this.lbklcb.Size = new System.Drawing.Size(107, 13);
            this.lbklcb.TabIndex = 1;
            this.lbklcb.Text = "Khen thưởng cán bộ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khen thưởng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày khen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình thức:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 20);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboktcb
            // 
            this.cboktcb.DataSource = this.vCanboBindingSource;
            this.cboktcb.DisplayMember = "Họ tên";
            this.cboktcb.FormattingEnabled = true;
            this.cboktcb.Location = new System.Drawing.Point(152, 34);
            this.cboktcb.Name = "cboktcb";
            this.cboktcb.Size = new System.Drawing.Size(162, 21);
            this.cboktcb.TabIndex = 13;
            this.cboktcb.ValueMember = "Mã cán bộ";
            // 
            // vCanboBindingSource
            // 
            this.vCanboBindingSource.DataMember = "VCanbo";
            this.vCanboBindingSource.DataSource = this.qLCBDataSet9;
            // 
            // qLCBDataSet9
            // 
            this.qLCBDataSet9.DataSetName = "QLCBDataSet9";
            this.qLCBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbkt
            // 
            this.cbkt.DataSource = this.vKhenthuongBindingSource;
            this.cbkt.DisplayMember = "Tên khen thưởng";
            this.cbkt.FormattingEnabled = true;
            this.cbkt.Location = new System.Drawing.Point(152, 55);
            this.cbkt.Name = "cbkt";
            this.cbkt.Size = new System.Drawing.Size(162, 21);
            this.cbkt.TabIndex = 14;
            this.cbkt.ValueMember = "Mã khen thưởng";
            // 
            // vKhenthuongBindingSource
            // 
            this.vKhenthuongBindingSource.DataMember = "VKhenthuong";
            this.vKhenthuongBindingSource.DataSource = this.qLCBDataSet2;
            // 
            // qLCBDataSet2
            // 
            this.qLCBDataSet2.DataSetName = "QLCBDataSet2";
            this.qLCBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 86);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(162, 20);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // vCanboTableAdapter
            // 
            this.vCanboTableAdapter.ClearBeforeFill = true;
            // 
            // vKhenthuongTableAdapter
            // 
            this.vKhenthuongTableAdapter.ClearBeforeFill = true;
            // 
            // lblhtcb
            // 
            this.lblhtcb.AutoSize = true;
            this.lblhtcb.ForeColor = System.Drawing.Color.Red;
            this.lblhtcb.Location = new System.Drawing.Point(335, 37);
            this.lblhtcb.Name = "lblhtcb";
            this.lblhtcb.Size = new System.Drawing.Size(0, 13);
            this.lblhtcb.TabIndex = 16;
            // 
            // lblkt
            // 
            this.lblkt.AutoSize = true;
            this.lblkt.ForeColor = System.Drawing.Color.Red;
            this.lblkt.Location = new System.Drawing.Point(335, 58);
            this.lblkt.Name = "lblkt";
            this.lblkt.Size = new System.Drawing.Size(0, 13);
            this.lblkt.TabIndex = 17;
            // 
            // lblnk
            // 
            this.lblnk.AutoSize = true;
            this.lblnk.ForeColor = System.Drawing.Color.Red;
            this.lblnk.Location = new System.Drawing.Point(335, 89);
            this.lblnk.Name = "lblnk";
            this.lblnk.Size = new System.Drawing.Size(0, 13);
            this.lblnk.TabIndex = 18;
            // 
            // lblld
            // 
            this.lblld.AutoSize = true;
            this.lblld.ForeColor = System.Drawing.Color.Red;
            this.lblld.Location = new System.Drawing.Point(335, 116);
            this.lblld.Name = "lblld";
            this.lblld.Size = new System.Drawing.Size(0, 13);
            this.lblld.TabIndex = 19;
            // 
            // lblht
            // 
            this.lblht.AutoSize = true;
            this.lblht.ForeColor = System.Drawing.Color.Red;
            this.lblht.Location = new System.Drawing.Point(335, 142);
            this.lblht.Name = "lblht";
            this.lblht.Size = new System.Drawing.Size(0, 13);
            this.lblht.TabIndex = 20;
            // 
            // Themkhenthuongcanbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.lblht);
            this.Controls.Add(this.lblld);
            this.Controls.Add(this.lblnk);
            this.Controls.Add(this.lblkt);
            this.Controls.Add(this.lblhtcb);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cbkt);
            this.Controls.Add(this.cboktcb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbklcb);
            this.Controls.Add(this.label1);
            this.Name = "Themkhenthuongcanbo";
            this.Text = "Themkhenthuongcanbo";
            this.Load += new System.EventHandler(this.Themkhenthuongcanbo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vCanboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKhenthuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbklcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboktcb;
        private System.Windows.Forms.ComboBox cbkt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private QLCBDataSet9 qLCBDataSet9;
        private System.Windows.Forms.BindingSource vCanboBindingSource;
        private QLCBDataSet9TableAdapters.VCanboTableAdapter vCanboTableAdapter;
        private QLCBDataSet2 qLCBDataSet2;
        private System.Windows.Forms.BindingSource vKhenthuongBindingSource;
        private QLCBDataSet2TableAdapters.VKhenthuongTableAdapter vKhenthuongTableAdapter;
        private System.Windows.Forms.Label lblhtcb;
        private System.Windows.Forms.Label lblkt;
        private System.Windows.Forms.Label lblnk;
        private System.Windows.Forms.Label lblld;
        private System.Windows.Forms.Label lblht;
    }
}