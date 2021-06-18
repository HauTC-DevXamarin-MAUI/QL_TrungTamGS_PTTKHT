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

namespace QuanLyTrungTamGiaSu
{
    public partial class frmLogin : Form
    {
        TAIKHOAN tk = new TAIKHOAN();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-63IDQSE\SQLEXPRESS;Initial Catalog=QL_TrungTam;Integrated Security=True");
            //SqlDataAdapter da =new SqlDataAdapter("select * from  TaiKhoan where UserName='"+txtUserName.Text+"'and PassWord ='"+txtPassWord.Text+"'",cn);
            //DataTable dt =new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Đăng Nhập Thành Công!!!", "Thông Báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    frmMain fm = new frmMain();
            //    fm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng điền thông tin!!!");
            //}
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(t => t.Users.ToString().Trim().Equals(txtUserName.Text.ToString().Trim())).FirstOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Sai username or password");
                    return;
                }
                if (tk.Pass.Trim() == txtPassWord.Text.ToString().Trim())
                {
                    frmMain m = new frmMain();
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Sai username or password");
                    return;
                }
            }
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {
                    TAIKHOAN tk = db.TAIKHOANs.Where(t => t.Users.ToString().Trim().Equals(txtUserName.Text.ToString().Trim())).FirstOrDefault();
                    if (tk == null)
                    {
                        MessageBox.Show("Sai username or password");
                        return;
                    }
                    if (tk.Pass.Trim() == txtPassWord.Text.ToString().Trim())
                    {
                        frmMain m = new frmMain();
                        this.Hide();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai username or password");
                        return;
                    }
                }
            }
        }
    }
}
