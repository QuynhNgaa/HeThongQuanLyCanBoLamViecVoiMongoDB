namespace Login
{
    partial class Themkyluatcanbo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboklcb = new System.Windows.Forms.ComboBox();
            this.cbokl = new System.Windows.Forms.ComboBox();
            this.vkyluatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCBDataSet3 = new Login.QLCBDataSet3();
            this.vkyluatTableAdapter = new Login.QLCBDataSet3TableAdapters.VkyluatTableAdapter();
            this.lblklcb = new System.Windows.Forms.Label();
            this.lblkl = new System.Windows.Forms.Label();
            this.lblnkl = new System.Windows.Forms.Label();
            this.lblld = new System.Windows.Forms.Label();
            this.lblht = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vkyluatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet3)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Kỷ luật cán bộ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kỷ luật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày kỷ luật:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình thức:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboklcb
            // 
            this.cboklcb.FormattingEnabled = true;
            this.cboklcb.Location = new System.Drawing.Point(128, 38);
            this.cboklcb.Name = "cboklcb";
            this.cboklcb.Size = new System.Drawing.Size(177, 21);
            this.cboklcb.TabIndex = 13;
            // 
            // cbokl
            // 
            this.cbokl.DataSource = this.vkyluatBindingSource;
            this.cbokl.DisplayMember = "Tên kỷ luật";
            this.cbokl.FormattingEnabled = true;
            this.cbokl.Location = new System.Drawing.Point(128, 61);
            this.cbokl.Name = "cbokl";
            this.cbokl.Size = new System.Drawing.Size(177, 21);
            this.cbokl.TabIndex = 14;
            this.cbokl.ValueMember = "Mã kỷ luật";
            // 
            // vkyluatBindingSource
            // 
            this.vkyluatBindingSource.DataMember = "Vkyluat";
            this.vkyluatBindingSource.DataSource = this.qLCBDataSet3;
            // 
            // qLCBDataSet3
            // 
            this.qLCBDataSet3.DataSetName = "QLCBDataSet3";
            this.qLCBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vkyluatTableAdapter
            // 
            this.vkyluatTableAdapter.ClearBeforeFill = true;
            // 
            // lblklcb
            // 
            this.lblklcb.AutoSize = true;
            this.lblklcb.ForeColor = System.Drawing.Color.Red;
            this.lblklcb.Location = new System.Drawing.Point(342, 41);
            this.lblklcb.Name = "lblklcb";
            this.lblklcb.Size = new System.Drawing.Size(0, 13);
            this.lblklcb.TabIndex = 15;
            // 
            // lblkl
            // 
            this.lblkl.AutoSize = true;
            this.lblkl.ForeColor = System.Drawing.Color.Red;
            this.lblkl.Location = new System.Drawing.Point(342, 64);
            this.lblkl.Name = "lblkl";
            this.lblkl.Size = new System.Drawing.Size(0, 13);
            this.lblkl.TabIndex = 16;
            // 
            // lblnkl
            // 
            this.lblnkl.AutoSize = true;
            this.lblnkl.ForeColor = System.Drawing.Color.Red;
            this.lblnkl.Location = new System.Drawing.Point(342, 90);
            this.lblnkl.Name = "lblnkl";
            this.lblnkl.Size = new System.Drawing.Size(0, 13);
            this.lblnkl.TabIndex = 17;
            // 
            // lblld
            // 
            this.lblld.AutoSize = true;
            this.lblld.ForeColor = System.Drawing.Color.Red;
            this.lblld.Location = new System.Drawing.Point(342, 116);
            this.lblld.Name = "lblld";
            this.lblld.Size = new System.Drawing.Size(0, 13);
            this.lblld.TabIndex = 18;
            // 
            // lblht
            // 
            this.lblht.AutoSize = true;
            this.lblht.ForeColor = System.Drawing.Color.Red;
            this.lblht.Location = new System.Drawing.Point(342, 141);
            this.lblht.Name = "lblht";
            this.lblht.Size = new System.Drawing.Size(0, 13);
            this.lblht.TabIndex = 19;
            // 
            // Themkyluatcanbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.lblht);
            this.Controls.Add(this.lblld);
            this.Controls.Add(this.lblnkl);
            this.Controls.Add(this.lblkl);
            this.Controls.Add(this.lblklcb);
            this.Controls.Add(this.cbokl);
            this.Controls.Add(this.cboklcb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Themkyluatcanbo";
            this.Text = "Themkyluatcanbo";
            this.Load += new System.EventHandler(this.Themkyluatcanbo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vkyluatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboklcb;
        private System.Windows.Forms.ComboBox cbokl;
        private QLCBDataSet3 qLCBDataSet3;
        private System.Windows.Forms.BindingSource vkyluatBindingSource;
        private QLCBDataSet3TableAdapters.VkyluatTableAdapter vkyluatTableAdapter;
        private System.Windows.Forms.Label lblklcb;
        private System.Windows.Forms.Label lblkl;
        private System.Windows.Forms.Label lblnkl;
        private System.Windows.Forms.Label lblld;
        private System.Windows.Forms.Label lblht;
    }
}