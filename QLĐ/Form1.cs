﻿using System;
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
        void timvitriluoi(string ma)
        {
            int i = 0;
            while (i < dataGridView1.Rows.Count)
            {
                if (ma.Trim().Equals(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
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
                string sql = "INSERT INTO MonHoc VALUES (@MaMH, @TenMH, @Sotiet)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
                cmd.Parameters.AddWithValue("@TenMH", txTenMH.Text);
                cmd.Parameters.AddWithValue("@Sotiet", tbSotiet.Text);
                cmd.ExecuteNonQuery();
                timvitriluoi(tbMaMH.Text);
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
                string sql = "UPDATE MonHoc SET TenMH = @tenmh, Sotiet = @sotiet WHERE MaMH = @mamh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tenmh", txTenMH.Text);
                cmd.Parameters.AddWithValue("@sotiet", tbSotiet.Text);
                cmd.Parameters.AddWithValue("@mamh", tbMaMH.Text);
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
                tbMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txTenMH.Text = row.Cells["TenMH"].Value.ToString();
                tbSotiet.Text = row.Cells["Sotiet"].Value.ToString();
            }
            else
            {
                tbMaMH.Clear();
                txTenMH.Clear();
                tbSotiet.Clear();
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        
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
            tbMaMH.Clear();
            txTenMH.Clear();
            tbSotiet.Clear();
            tbMaMH.Focus();

        }

        private void tbMaMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                HienThiDuLieuTuDataGridViewLenThanhNhap(selectedRow);
            }
        }
    }
}
