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
    public partial class frKhoa : Form
    {
        public frKhoa()
        {
            InitializeComponent();
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Khoa", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgwKhoa.DataSource = dt;
            }
        }
        private void frKhoa_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "INSERT INTO Khoa VALUES (@MAKHOA, @TENKHOA)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MAKHOA", tbMK.Text);
                    cmd.Parameters.AddWithValue("@TENKHOA", tbTK.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "UPDATE Khoa SET TenKhoa = @tenkh WHERE MaKhoa = @makh";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@tenkh", tbTK.Text);
                    cmd.Parameters.AddWithValue("@makh", tbMK.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
            loadData();
        }
        private void HienThiDuLieuTuDataGridViewLenThanhNhap(DataGridViewRow row)
        {
            if (row != null)
            {
                tbMK.Text = row.Cells["MaKhoa"].Value.ToString();
                tbTK.Text = row.Cells["TenKhoa"].Value.ToString();
            }
            else
            {
                tbMK.Clear();
                tbTK.Clear();
            }
        }

        private void dgwKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgwKhoa.RowCount - 1)
            {
                DataGridViewRow selectedRow = dgwKhoa.Rows[e.RowIndex];
                HienThiDuLieuTuDataGridViewLenThanhNhap(selectedRow);
            }
        }
        private void DeleteKhoa(string maKhoa)
        {
            using (SqlConnection con = ketnoiCSDL())

            {
                try
                {
                    string sql = "DELETE FROM Khoa WHERE MaKhoa = @makh";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@makh", maKhoa);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgwKhoa.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maMH = dgwKhoa.SelectedRows[0].Cells[0].Value.ToString();
                    DeleteKhoa(maMH);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            tbTK.Clear();
            tbMK.Clear();

        }

        private void frKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
