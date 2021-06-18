using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamGiaSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocVien f = new frmHocVien();
            this.Hide();
            f.Show();
            
        }

        private void thôngTinGiaSưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaSu f = new frmGiaSu();
            this.Hide();
            f.Show();
        }

      

        private void tìmGiaSưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"C:\Users\CongHau\Desktop\DoAn_PTTK\doAn_PTTK\QuanLyTrungTamGiaSu\gioithieu.pdf");
        }
        
    }
}
