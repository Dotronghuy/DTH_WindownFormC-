using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLĐ
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        SqlConnection ketnoiCSDL()
        {
            string strCon = "Data Source=LAPTOP-29UG1RC2\\SQL;Initial Catalog=QLDiem;Integrated Security=True";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            return con;
        }
        void loadData()
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sinhvien", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgwSV.DataSource = dt;
            }
        }
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            loadDataCombo();
            loadData();
        }
        void loadDataCombo()
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Khoa", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbKhoa.DataSource = dt;
                cmbKhoa.DisplayMember = "TenKhoa";
                cmbKhoa.ValueMember = "MaKhoa";
                cmbKhoa.SelectedIndex = -1;
            }
        }

        private void dpkNS_ValueChanged(object sender, EventArgs e)
        {

        }
        void Timvitri(string Makhoa)
        {
            int i = 0;
            cmbKhoa.SelectedIndex = 0;
            while (!cmbKhoa.SelectedValue.ToString().Equals(Makhoa))
            {
                i++;
                cmbKhoa.SelectedIndex = i;
            }
        }
        void timvitriluoi(string ma)
        {
            int i = 0;
            while (i < dgwSV.Rows.Count)
            {
                if (ma.Trim().Equals(dgwSV.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    dgwSV.CurrentCell = dgwSV.Rows[i].Cells[0];
                    break;
                }
                i++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "INSERT INTO Sinhvien VALUES (@MASV, @HOSV, @TENSV,@PHAI,@NS,@MAKHOA)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MASV", txtMSV.Text);
                    cmd.Parameters.AddWithValue("@HOSV", txtHSV.Text);
                    cmd.Parameters.AddWithValue("@TENSV", txtTSV.Text);
                    cmd.Parameters.AddWithValue("@PHAI", radNAM.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@NS", dpkNS.Value);
                    cmd.Parameters.AddWithValue("@MAKHOA", cmbKhoa.SelectedValue);
                    cmd.ExecuteNonQuery();
                    loadData();
                    timvitriluoi(txtMSV.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }

    
        private void dgwSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < dgwSV.RowCount - 1)
            {
                txtMSV.Text = dgwSV.Rows[i].Cells[0].Value.ToString();
                txtHSV.Text = dgwSV.Rows[i].Cells[1].Value.ToString();
                txtTSV.Text = dgwSV.Rows[i].Cells[2].Value.ToString();
                string phai = dgwSV.Rows[i].Cells[3].Value.ToString().Trim();
                if (phai.ToLower().Equals("nam"))
                    radNAM.Checked = true;
                else
                    radNu.Checked = true;
                dpkNS.Value = DateTime.Parse(dgwSV.Rows[i].Cells[4].Value.ToString());
                Timvitri(dgwSV.Rows[i].Cells[5].Value.ToString());

            }
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "UPDATE Sinhvien set HoSV=@HOSV, TenSV=@TENSV,Phai=@PHAI,NS=@NS,Makhoa=@MAKHOA where MaSv=@MASV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MASV", txtMSV.Text);
                    cmd.Parameters.AddWithValue("@HOSV", txtHSV.Text);
                    cmd.Parameters.AddWithValue("@TENSV", txtTSV.Text);
                    cmd.Parameters.AddWithValue("@PHAI", radNAM.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@NS", dpkNS.Value);
                    cmd.Parameters.AddWithValue("@MAKHOA", cmbKhoa.SelectedValue);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "delete from Sinhvien where MaSV = @MaSV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MASV", txtMSV.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                    timvitriluoi(txtMSV.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            txtMSV.Clear();
            txtHSV.Clear();
            txtTSV.Clear();
            radNAM.Checked = true;
            dpkNS.Value = DateTime.Now;
            cmbKhoa.SelectedIndex = -1;
        }
    }
    
}
