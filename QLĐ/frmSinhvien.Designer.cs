
namespace QLĐ
{
    partial class frmSinhvien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbTSV = new System.Windows.Forms.Label();
            this.lbHSV = new System.Windows.Forms.Label();
            this.lbMSV = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.dpkNS = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNAM = new System.Windows.Forms.RadioButton();
            this.txtTSV = new System.Windows.Forms.TextBox();
            this.txtHSV = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.dgwSV = new System.Windows.Forms.DataGridView();
            this.btnResert = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKhoa);
            this.groupBox1.Controls.Add(this.lbNS);
            this.groupBox1.Controls.Add(this.lbTSV);
            this.groupBox1.Controls.Add(this.lbHSV);
            this.groupBox1.Controls.Add(this.lbMSV);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.dpkNS);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNAM);
            this.groupBox1.Controls.Add(this.txtTSV);
            this.groupBox1.Controls.Add(this.txtHSV);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(420, 121);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(41, 17);
            this.lbKhoa.TabIndex = 11;
            this.lbKhoa.Text = "Khoa";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Location = new System.Drawing.Point(405, 78);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(73, 17);
            this.lbNS.TabIndex = 10;
            this.lbNS.Text = "Ngày Sinh";
            // 
            // lbTSV
            // 
            this.lbTSV.AutoSize = true;
            this.lbTSV.Location = new System.Drawing.Point(6, 128);
            this.lbTSV.Name = "lbTSV";
            this.lbTSV.Size = new System.Drawing.Size(55, 17);
            this.lbTSV.TabIndex = 9;
            this.lbTSV.Text = "Tên SV";
            // 
            // lbHSV
            // 
            this.lbHSV.AutoSize = true;
            this.lbHSV.Location = new System.Drawing.Point(6, 80);
            this.lbHSV.Name = "lbHSV";
            this.lbHSV.Size = new System.Drawing.Size(48, 17);
            this.lbHSV.TabIndex = 8;
            this.lbHSV.Text = "Họ SV";
            // 
            // lbMSV
            // 
            this.lbMSV.AutoSize = true;
            this.lbMSV.Location = new System.Drawing.Point(6, 40);
            this.lbMSV.Name = "lbMSV";
            this.lbMSV.Size = new System.Drawing.Size(49, 17);
            this.lbMSV.TabIndex = 7;
            this.lbMSV.Text = "Mã SV";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(478, 121);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(226, 24);
            this.cmbKhoa.TabIndex = 6;
            // 
            // dpkNS
            // 
            this.dpkNS.CustomFormat = "dd/MM/yyyy";
            this.dpkNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNS.Location = new System.Drawing.Point(478, 73);
            this.dpkNS.Name = "dpkNS";
            this.dpkNS.Size = new System.Drawing.Size(226, 22);
            this.dpkNS.TabIndex = 5;
            this.dpkNS.ValueChanged += new System.EventHandler(this.dpkNS_ValueChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(593, 34);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNAM
            // 
            this.radNAM.AutoSize = true;
            this.radNAM.Location = new System.Drawing.Point(518, 34);
            this.radNAM.Name = "radNAM";
            this.radNAM.Size = new System.Drawing.Size(58, 21);
            this.radNAM.TabIndex = 3;
            this.radNAM.TabStop = true;
            this.radNAM.Text = "Nam";
            this.radNAM.UseVisualStyleBackColor = true;
            this.radNAM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtTSV
            // 
            this.txtTSV.Location = new System.Drawing.Point(87, 125);
            this.txtTSV.Name = "txtTSV";
            this.txtTSV.Size = new System.Drawing.Size(236, 22);
            this.txtTSV.TabIndex = 2;
            // 
            // txtHSV
            // 
            this.txtHSV.Location = new System.Drawing.Point(87, 75);
            this.txtHSV.Name = "txtHSV";
            this.txtHSV.Size = new System.Drawing.Size(236, 22);
            this.txtHSV.TabIndex = 1;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(87, 35);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(236, 22);
            this.txtMSV.TabIndex = 0;
            // 
            // dgwSV
            // 
            this.dgwSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSV.Location = new System.Drawing.Point(12, 230);
            this.dgwSV.Name = "dgwSV";
            this.dgwSV.RowHeadersWidth = 51;
            this.dgwSV.RowTemplate.Height = 24;
            this.dgwSV.Size = new System.Drawing.Size(767, 208);
            this.dgwSV.TabIndex = 1;
            this.dgwSV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSV_RowEnter);
            // 
            // btnResert
            // 
            this.btnResert.Location = new System.Drawing.Point(521, 191);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(75, 33);
            this.btnResert.TabIndex = 33;
            this.btnResert.Text = "Đặt lại";
            this.btnResert.UseVisualStyleBackColor = true;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(322, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(220, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(117, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgwSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSinhvien";
            this.Text = "Cập nhập sinh viên";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNAM;
        private System.Windows.Forms.TextBox txtTSV;
        private System.Windows.Forms.TextBox txtHSV;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DateTimePicker dpkNS;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DataGridView dgwSV;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbTSV;
        private System.Windows.Forms.Label lbHSV;
        private System.Windows.Forms.Label lbMSV;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}