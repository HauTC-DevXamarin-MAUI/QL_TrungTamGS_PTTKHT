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
    public partial class frmDangKyHV : Form
    {
        QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext();
        DangKyHV dkhv = new DangKyHV();
        public frmDangKyHV()
        {
            InitializeComponent();
        }
         
        private void cbMaPH_DK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void frmDangKyHV_Load(object sender, EventArgs e)
        {
           
            cbMaPH_DK.DataSource = db.PHUHUYNHs.Select(t => t.MAPH).ToList();
        }

        private void btnKtra_DK_Click(object sender, EventArgs e)
        {
            if (dkhv.KTHV(txtCMNDHV_KT.Text)==1)
            {
                MessageBox.Show("HV mới , mời nhập thông tin!");
                txtTenHV_DK.Enabled = true;
                txtCMNDHV_DK.Text = txtCMNDHV_KT.Text;
                txtCMNDHV_DK.Enabled = true;
                dateNgaySinhHV_DK.Enabled = true;
                txtTruongHV_DK.Enabled = true;
                cbMonDKHoc_DK.DataSource = db.MONs.Select(t => t.MAMON).ToList();
                cbMonDKHoc_DK.Enabled = true;
                comboBox1.DataSource = db.LOPs.Select(t => t.MALOP).ToList();
                comboBox1.Enabled = true;
                
                txtDiaChiHV_DK.Enabled = true;
                txtSDTHV_DK.Enabled = true;
                txtHocLucHV_DK.Enabled = true;
                txtGhiChuHV_DK.Enabled = true;
                cbMaPH_DK.Enabled = true;

                btnThemHV_DK.Enabled = true;
            }
            else
            {
                MessageBox.Show("HV đã tồn tại!");
                txtCMNDHV_KT.Text = txtCMNDHV_KT.Text.Trim();
            }


            //using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            //{
            //    HOCVIEN kt = db.HOCVIENs.Where(s => s.CCCD.Trim().ToString().Equals(txtCMNDHV_KT.Text.ToString().Trim())).FirstOrDefault();
              
            //    if (kt == null)
            //    {

            //        MessageBox.Show("HV mới , mời nhập thông tin!");
            //        txtTenHV_DK.Enabled = true;
            //        txtCMNDHV_DK.Text = txtCMNDHV_KT.Text;
            //        txtCMNDHV_DK.Enabled = true;
            //        dateNgaySinhHV_DK.Enabled = true;
            //        txtTruongHV_DK.Enabled = true;
            //        cbMonDKHoc_DK.DataSource = db.MONs.Select(t => t.MAMON).ToList();
            //        cbMonDKHoc_DK.Enabled = true;
            //        comboBox1.DataSource = db.LOPs.Select(t => t.MALOP).ToList();
            //        txtLopHV_DK.Enabled = true;
            //        txtDiaChiHV_DK.Enabled = true;
            //        txtSDTHV_DK.Enabled = true;
            //        txtHocLucHV_DK.Enabled = true;
            //        txtGhiChuHV_DK.Enabled = true;
            //        cbMaPH_DK.Enabled = true;

            //        btnThemHV_DK.Enabled = true;
            //    }

            //    else
            //    {
            //        MessageBox.Show("HV đã tồn tại!");
            //        txtCMNDHV_KT.Text = txtCMNDHV_KT.Text.Trim();
            //    }
            //}
        }

        private void btnThemHV_DK_Click(object sender, EventArgs e)
        {
            if (txtTenHV_DK.Text == "" || dateNgaySinhHV_DK.Value == null || txtTruongHV_DK.Text == "" || cbMonDKHoc_DK.Text == ""
                 || txtDiaChiHV_DK.Text == "" || txtSDTHV_DK.Text == "" 
                || txtCMNDHV_DK.Text == "" || txtGhiChuHV_DK.Text == "" || cbMaPH_DK.Text == "" || txtHocLucHV_DK.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin HV!!!");
            }
            else
            {
                //Thực hiện thêm HV
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {
                    HOCVIEN hv = new HOCVIEN();
                    hv.TENHV = txtTenHV_DK.Text;
                    hv.NGAYSINH = dateNgaySinhHV_DK.Value;
                    hv.TRUONG = txtTruongHV_DK.Text;
                    hv.MONDANGKY = cbMonDKHoc_DK.Text;
                    hv.LOP = comboBox1.Text;
                    hv.DIACHI = txtDiaChiHV_DK.Text;
                    hv.DIENTHOAI = txtSDTHV_DK.Text;
                    hv.HOCLUC = txtHocLucHV_DK.Text;
                    hv.CCCD = txtCMNDHV_DK.Text;
                    hv.GHICHU = txtGhiChuHV_DK.Text;
                    hv.MAPH = int.Parse(cbMaPH_DK.Text);
                    
                    try
                    {
                        //db.HOCVIENs.InsertOnSubmit(hv);
                        //db.SubmitChanges();
                        //MessageBox.Show("Thêm thành công!!!");

                        //frmHocVien f = new frmHocVien();
                        //f.Show();

                        frmGioiThieuGS f = new frmGioiThieuGS(cbMonDKHoc_DK.SelectedValue.ToString(),comboBox1.SelectedValue.ToString());
                        f.Show();

                    }
                    catch
                    {
                        MessageBox.Show("Them khong Thanh Cong", "Khong Thanh Cong");
                    }
                }
            }
        }

        private void txtCMNDHV_KT_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnKtra_DK.Enabled = true;
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                
                e.Handled = true;
                MessageBox.Show("Số điện thoại không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            txtTenHV_DK.Enabled = false;
            txtCMNDHV_DK.Enabled = false;
            dateNgaySinhHV_DK.Enabled = false;
            txtTruongHV_DK.Enabled = false;
            cbMonDKHoc_DK.DataSource = db.MONs.Select(t => t.TENMON).ToList();
            cbMonDKHoc_DK.Enabled = false;
            txtDiaChiHV_DK.Enabled = false;
            txtSDTHV_DK.Enabled = false;
            txtHocLucHV_DK.Enabled = false;
            txtGhiChuHV_DK.Enabled = false;
            cbMaPH_DK.Enabled = false;

            btnThemHV_DK.Enabled = true;
        }

        private void btnThoat_DK_Click(object sender, EventArgs e)
        {
            frmHocVien f = new frmHocVien();
            this.Close();
            f.Show();
        }

      

       
    }
}
