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
    public partial class frKQ : Form
    {
        public frKQ()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM KetQua", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvKQ.DataSource = dt;
            }
        }
        private void frKQ_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void timvitriluoi(string ma)
        {
            int i = 0;
            while (i < dgvKQ.Rows.Count)
            {
                if (ma.Trim().Equals(dgvKQ.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    dgvKQ.CurrentCell = dgvKQ.Rows[i].Cells[0];
                    break;
                }
                i++;
            }
        }
        private void HienThiDuLieuTuDataGridViewLenThanhNhap(DataGridViewRow row)
        {
            if (row != null)
            {
                tbDiem.Text = row.Cells["Diem"].Value.ToString();
                tbLT.Text = row.Cells["LanThi"].Value.ToString();
                tbMaSV.Text = row.Cells["MaSV"].Value.ToString();
                tbMMH.Text = row.Cells["MaMH"].Value.ToString();
            }
            else
            {
                tbDiem.Clear();
                tbLT.Clear();
                tbMaSV.Clear();
                tbMMH.Clear();
            }
        }

        private void dgvKQ_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKQ.RowCount - 1)
            {
                DataGridViewRow selectedRow = dgvKQ.Rows[e.RowIndex];
                HienThiDuLieuTuDataGridViewLenThanhNhap(selectedRow);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "INSERT INTO KetQua VALUES (@MaSV, @MaMH, @Lanthi,@Diem)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MaSV", tbMaSV.Text);
                    cmd.Parameters.AddWithValue("@MaMH", tbMMH.Text);
                    cmd.Parameters.AddWithValue("@Lanthi", tbLT.Text);
                    cmd.Parameters.AddWithValue("@Diem", tbDiem.Text);
                    cmd.ExecuteNonQuery();
                    timvitriluoi(tbMaSV.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }

            }

            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "UPDATE KetQua SET MaMH = @mamh, Lanthi = @lanthi, Diem = @diem WHERE MaSV = @masv";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@mamh", tbMMH.Text);
                    cmd.Parameters.AddWithValue("@lanthi", tbLT.Text);
                    cmd.Parameters.AddWithValue("@diem", tbDiem.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKQ.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maMH = dgvKQ.SelectedRows[0].Cells[0].Value.ToString();
                    DeleteKQ(maMH);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DeleteKQ(string maMH)
        {
            using (SqlConnection con = ketnoiCSDL())

            {
                try
                {
                    string sql = "DELETE FROM MonHoc WHERE MaMH = @mamh";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@mamh", maMH);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
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
            tbMaSV.Clear();
            tbMMH.Clear();
            tbLT.Clear();
            tbDiem.Clear();

        }
    }
}
