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
    public partial class frmDangKyGS : Form
    {
        public frmDangKyGS()
        {
            InitializeComponent();
        }

        private void txtCMNDHV_KT_KeyPress(object sender, KeyPressEventArgs e)
        {

            btnKtra_DK.Enabled = true;
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
                MessageBox.Show("Số điện thoại không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            txtTenGS_DK.Enabled = false;
            txtGT_GSDK.Enabled = false;
            dateNgaySinh_Gs_DK.Enabled = false;
            txtNguyenQuan_GS_DK.Enabled = false;
            txttDiaChi_GS_DK.Enabled = false;
            txtEmail_GS_DK.Enabled = false;
            txtSDTT_GS_DK.Enabled = false;
            txtTruongGS_DK.Enabled = false;
            txtNgayHocGS_DK.Enabled = false;
            txtNamTN_GS_DK.Enabled = false;
            ttxttNgheNghiepGS_DK.Enabled = false;
            cbMonDKDayGS.Enabled = false;
            txtSoNuoiDay_DK.Enabled = false;
            txtUuDiemGS_dk.Enabled = false;
            txtCMND_gs_DK.Enabled = false;

        }

        private void btnKtra_DK_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                GIASU kt = db.GIASUs.Where(s => s.CCCD.Trim().ToString().Equals(txtCMNDHV_KT.Text.ToString().Trim())).FirstOrDefault();

                if (kt == null)
                {

                    MessageBox.Show("GS mới , mời nhập thông tin!");
                    txtTenGS_DK.Enabled = true;
                    txtGT_GSDK.Enabled = true;
                    dateNgaySinh_Gs_DK.Enabled = true;
                    txtNguyenQuan_GS_DK.Enabled = true;
                    txttDiaChi_GS_DK.Enabled = true;
                    txtEmail_GS_DK.Enabled = true;
                    txtSDTT_GS_DK.Enabled = true;
                    txtTruongGS_DK.Enabled = true;
                    txtNgayHocGS_DK.Enabled = true;
                    txtNamTN_GS_DK.Enabled = true;
                    ttxttNgheNghiepGS_DK.Enabled = true;
                    cbMonDKDayGS.Enabled = true;
                    txtSoNuoiDay_DK.Enabled = true;
                    txtUuDiemGS_dk.Enabled = true;
                    txtCMND_gs_DK.Enabled = true;
                    txtCMND_gs_DK.Text = txtCMNDHV_KT.Text;
                    cbMonDKDayGS.DataSource = db.MONs.Select(t => t.TENMON).ToList();
                    btnThemGS_DK.Enabled = true;

                }

                else
                {
                    MessageBox.Show("GS đã tồn tại!");
                    txtCMNDHV_KT.Text = txtCMNDHV_KT.Text.Trim();

                }
            }

        }

        private void btnThemGS_DK_Click(object sender, EventArgs e)
        {
            if (txtTenGS_DK.Text == "" || txtGT_GSDK.Text == "" || txtCMND_gs_DK.Text == "" ||
                txtNguyenQuan_GS_DK.Text == "" || txttDiaChi_GS_DK.Text == "" || txtEmail_GS_DK.Text == "" ||
                txtSDTT_GS_DK.Text == "" || txtTruongGS_DK.Text == "" || txtNgayHocGS_DK.Text == "" || txtNamTN_GS_DK.Text == "" ||
                ttxttNgheNghiepGS_DK.Text == "" || txtSoNuoiDay_DK.Text == "" || txtUuDiemGS_dk.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin HV!!!");
            }
            else
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {
                    GIASU gs = new GIASU();
                    gs.TENGS = txtTenGS_DK.Text;
                    gs.GIOITINH = txtGT_GSDK.Text;
                    gs.NGAYSINH = dateNgaySinh_Gs_DK.Value;
                    gs.CCCD = txtCMND_gs_DK.Text;
                    gs.NGUYENQUAN = txtNguyenQuan_GS_DK.Text;
                    gs.DIACHI = txttDiaChi_GS_DK.Text;
                    gs.EMAIL = txtEmail_GS_DK.Text;
                    gs.DIENTHOAI = txtSDTT_GS_DK.Text;
                    gs.TRUONG = txtTruongGS_DK.Text;
                    gs.NGANHHOC = txtNgayHocGS_DK.Text;
                    gs.NAMTOTNGHIEP = int.Parse(txtNamTN_GS_DK.Text);
                    gs.NGHENGHIEP = ttxttNgheNghiepGS_DK.Text;
                    gs.MONDANGDAY = cbMonDKDayGS.Text;
                    gs.SOBUOIDAY = int.Parse(txtSoNuoiDay_DK.Text);
                    gs.UUDIEM = txtUuDiemGS_dk.Text;
                    gs.TRANGTHAI = false;
                    try
                    {
                        db.GIASUs.InsertOnSubmit(gs);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công!!!");

                        frmGiaSu f = new frmGiaSu();
                        f.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Them khong Thanh Cong", "Khong Thanh Cong");
                    }
                }
            }
        }

        private void btnThoatGS_DK_Click(object sender, EventArgs e)
        {
            frmGiaSu F = new frmGiaSu();
            this.Hide();
            F.Show();
        }

        private void txtCMND_gs_DK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("CMND/CCCD được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSDTT_GS_DK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNamTN_GS_DK_TextChanged(object sender, EventArgs e)
        {
          
        }

        
    }
}
