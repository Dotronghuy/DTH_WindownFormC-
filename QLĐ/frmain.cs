using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLĐ
{
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();

        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frKhoa fr = new frKhoa();
            fr.Show();

        }


        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhvien fr = new frmSinhvien();
            fr.Show();

        }

        private void frmain_Load(object sender, EventArgs e)
        {

        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frKQ  fr = new frKQ();
            fr.Show();

        }
    }
}
