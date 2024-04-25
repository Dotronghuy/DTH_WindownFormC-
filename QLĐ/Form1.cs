using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLĐ
{
    public partial class Form1 : Form
    {
        public Form1()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Monhoc", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                string sql = "INSERT INTO MonHoc VALUES (@MaMH, @TenMH, @Sotiet)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txTenMH.Text);
                cmd.Parameters.AddWithValue("@Sotiet", tbSotiet.Text);

                cmd.ExecuteNonQuery();
            }
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                string sql = "UPDATE MonHoc SET TenMH = @tenmh, Sotiet = @sotiet WHERE MaMH = @mamh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenmh", txTenMH.Text);
                cmd.Parameters.AddWithValue("@sotiet", tbSotiet.Text);
                cmd.Parameters.AddWithValue("@mamh", tbMaMH.Text);
                cmd.ExecuteNonQuery();
            }
            loadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.RowCount - 1)
            {
                tbMaMH.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                txTenMH.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbSotiet.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            }
            else
            {
                txTenMH.Clear();
                tbMaMH.Clear();
                tbSotiet.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maMH = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    DeleteMonHoc(maMH);
                    loadData(); 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteMonHoc(string maMH)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                string sql = "DELETE FROM MonHoc WHERE MaMH = @mamh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mamh", maMH);
                cmd.ExecuteNonQuery();
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

    }
}
