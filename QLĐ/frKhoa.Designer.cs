
namespace QLĐ
{
    partial class frKhoa
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
            this.btnResert = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.dgwKhoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResert
            // 
            this.btnResert.Location = new System.Drawing.Point(532, 100);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(75, 33);
            this.btnResert.TabIndex = 28;
            this.btnResert.Text = "Đặt lại";
            this.btnResert.UseVisualStyleBackColor = true;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 100);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(333, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(231, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(128, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenK
            // 
            this.txtTenK.AutoSize = true;
            this.txtTenK.Location = new System.Drawing.Point(28, 64);
            this.txtTenK.Name = "txtTenK";
            this.txtTenK.Size = new System.Drawing.Size(68, 17);
            this.txtTenK.TabIndex = 22;
            this.txtTenK.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 20;
            // 
            // txtMK
            // 
            this.txtMK.AutoSize = true;
            this.txtMK.Location = new System.Drawing.Point(28, 17);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(64, 17);
            this.txtMK.TabIndex = 19;
            this.txtMK.Text = "Mã Khoa";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(106, 59);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(667, 22);
            this.tbTK.TabIndex = 18;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(106, 12);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(667, 22);
            this.tbMK.TabIndex = 16;
            // 
            // dgwKhoa
            // 
            this.dgwKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKhoa.Location = new System.Drawing.Point(2, 153);
            this.dgwKhoa.Name = "dgwKhoa";
            this.dgwKhoa.RowHeadersWidth = 51;
            this.dgwKhoa.RowTemplate.Height = 24;
            this.dgwKhoa.Size = new System.Drawing.Size(798, 294);
            this.dgwKhoa.TabIndex = 15;
            this.dgwKhoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKhoa_RowEnter);
            // 
            // frKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.dgwKhoa);
            this.Name = "frKhoa";
            this.Text = "frKhoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frKhoa_FormClosing);
            this.Load += new System.EventHandler(this.frKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtTenK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMK;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.DataGridView dgwKhoa;
    }
}