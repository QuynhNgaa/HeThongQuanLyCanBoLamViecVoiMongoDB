namespace Login
{
    partial class Danhsachcanbo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mãCánBộDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họTênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.địaChỉDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giớiTínhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sốĐiệnThoạiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quốcGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dânTộcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngoạiNgữDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnVịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bằngCấpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vCanboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCBDataSet9 = new Login.QLCBDataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.vCanboTableAdapter = new Login.QLCBDataSet9TableAdapters.VCanboTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCanboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãCánBộDataGridViewTextBoxColumn,
            this.họTênDataGridViewTextBoxColumn,
            this.ngàySinhDataGridViewTextBoxColumn,
            this.địaChỉDataGridViewTextBoxColumn,
            this.giớiTínhDataGridViewCheckBoxColumn,
            this.sốĐiệnThoạiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.quốcGiaDataGridViewTextBoxColumn,
            this.dânTộcDataGridViewTextBoxColumn,
            this.ngoạiNgữDataGridViewTextBoxColumn,
            this.đơnVịDataGridViewTextBoxColumn,
            this.bằngCấpDataGridViewTextBoxColumn,
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.vCanboBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mãCánBộDataGridViewTextBoxColumn
            // 
            this.mãCánBộDataGridViewTextBoxColumn.DataPropertyName = "Mã cán bộ";
            this.mãCánBộDataGridViewTextBoxColumn.HeaderText = "Mã cán bộ";
            this.mãCánBộDataGridViewTextBoxColumn.Name = "mãCánBộDataGridViewTextBoxColumn";
            this.mãCánBộDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // họTênDataGridViewTextBoxColumn
            // 
            this.họTênDataGridViewTextBoxColumn.DataPropertyName = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.Name = "họTênDataGridViewTextBoxColumn";
            this.họTênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàySinhDataGridViewTextBoxColumn
            // 
            this.ngàySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngàySinhDataGridViewTextBoxColumn.Name = "ngàySinhDataGridViewTextBoxColumn";
            this.ngàySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // địaChỉDataGridViewTextBoxColumn
            // 
            this.địaChỉDataGridViewTextBoxColumn.DataPropertyName = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.Name = "địaChỉDataGridViewTextBoxColumn";
            this.địaChỉDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giớiTínhDataGridViewCheckBoxColumn
            // 
            this.giớiTínhDataGridViewCheckBoxColumn.DataPropertyName = "Giới tính";
            this.giớiTínhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.giớiTínhDataGridViewCheckBoxColumn.Name = "giớiTínhDataGridViewCheckBoxColumn";
            this.giớiTínhDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sốĐiệnThoạiDataGridViewTextBoxColumn
            // 
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.DataPropertyName = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.Name = "sốĐiệnThoạiDataGridViewTextBoxColumn";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quốcGiaDataGridViewTextBoxColumn
            // 
            this.quốcGiaDataGridViewTextBoxColumn.DataPropertyName = "Quốc gia";
            this.quốcGiaDataGridViewTextBoxColumn.HeaderText = "Quốc gia";
            this.quốcGiaDataGridViewTextBoxColumn.Name = "quốcGiaDataGridViewTextBoxColumn";
            this.quốcGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dânTộcDataGridViewTextBoxColumn
            // 
            this.dânTộcDataGridViewTextBoxColumn.DataPropertyName = "Dân tộc";
            this.dânTộcDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.dânTộcDataGridViewTextBoxColumn.Name = "dânTộcDataGridViewTextBoxColumn";
            this.dânTộcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngoạiNgữDataGridViewTextBoxColumn
            // 
            this.ngoạiNgữDataGridViewTextBoxColumn.DataPropertyName = "Ngoại ngữ";
            this.ngoạiNgữDataGridViewTextBoxColumn.HeaderText = "Ngoại ngữ";
            this.ngoạiNgữDataGridViewTextBoxColumn.Name = "ngoạiNgữDataGridViewTextBoxColumn";
            this.ngoạiNgữDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // đơnVịDataGridViewTextBoxColumn
            // 
            this.đơnVịDataGridViewTextBoxColumn.DataPropertyName = "Đơn vị";
            this.đơnVịDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.đơnVịDataGridViewTextBoxColumn.Name = "đơnVịDataGridViewTextBoxColumn";
            this.đơnVịDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bằngCấpDataGridViewTextBoxColumn
            // 
            this.bằngCấpDataGridViewTextBoxColumn.DataPropertyName = "Bằng cấp";
            this.bằngCấpDataGridViewTextBoxColumn.HeaderText = "Bằng cấp";
            this.bằngCấpDataGridViewTextBoxColumn.Name = "bằngCấpDataGridViewTextBoxColumn";
            this.bằngCấpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trạngTháiLàmViệcDataGridViewCheckBoxColumn
            // 
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn.DataPropertyName = "Trạng thái làm việc";
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn.HeaderText = "Trạng thái làm việc";
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn.Name = "trạngTháiLàmViệcDataGridViewCheckBoxColumn";
            this.trạngTháiLàmViệcDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(885, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sach can bo";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "cfghcfg";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // vCanboTableAdapter
            // 
            this.vCanboTableAdapter.ClearBeforeFill = true;
            // 
            // Danhsachcanbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Danhsachcanbo";
            this.Text = "Danh sách cán bộ";
            this.Load += new System.EventHandler(this.DScb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCanboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCBDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private QLCBDataSet9 qLCBDataSet9;
        private System.Windows.Forms.BindingSource vCanboBindingSource;
        private QLCBDataSet9TableAdapters.VCanboTableAdapter vCanboTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãCánBộDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn địaChỉDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn giớiTínhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốĐiệnThoạiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quốcGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dânTộcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngoạiNgữDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnVịDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bằngCấpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trạngTháiLàmViệcDataGridViewCheckBoxColumn;
    }
}