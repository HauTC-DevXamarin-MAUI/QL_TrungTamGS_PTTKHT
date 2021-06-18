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
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimHV_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                if (rdcccd_TimHV.Checked == true)
                {
                    var lst = (from hv in db.HOCVIENs
                               where hv.CCCD.Trim().Contains(txtTTimKiem_HVX.Text.Trim())
                               select new
                               {
                                   hv.MAHV,
                                   hv.TENHV,
                                   hv.NGAYSINH,
                                   hv.TRUONG,
                                   hv.LOP,
                                   hv.DIACHI,
                                   hv.DIENTHOAI,
                                   hv.HOCLUC,
                                   hv.CCCD,
                                   hv.MONDANGKY,
                                   hv.GHICHU,
                                   hv.MAPH
                               });
                    grvHVX.DataSource = lst;

                }
                else if (rbtetn_TimHV.Checked == true)
                {
                    var lst = (from hv in db.HOCVIENs
                               where hv.TENHV.Trim().Contains(txtTTimKiem_HVX.Text.Trim())
                               select new
                               {
                                   hv.MAHV,
                                   hv.TENHV,
                                   hv.NGAYSINH,
                                   hv.TRUONG,
                                   hv.LOP,
                                   hv.DIACHI,
                                   hv.DIENTHOAI,
                                   hv.HOCLUC,
                                   hv.CCCD,
                                   hv.MONDANGKY,
                                   hv.GHICHU,
                                   hv.MAPH
                               });
                    grvHVX.DataSource = lst;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tìm kiếm theo mục nào!!!");
                }
            }
        }

        private void txtSDTHVX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại không được nhập chữ hoặc ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Close();
            f.Show();
        }

        void loadHV()
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                var lst = (from hv in db.HOCVIENs select new { hv.MAHV, hv.TENHV, hv.NGAYSINH, hv.TRUONG, hv.LOP, hv.DIACHI, hv.DIENTHOAI, hv.HOCLUC, hv.CCCD, hv.MONDANGKY, hv.GHICHU, hv.MAPH });
                grvHV.DataSource = lst;
                grvHVX.DataSource = lst;

                //
                cbMaPHX.DataSource = db.PHUHUYNHs.Select(t => t.MAPH).ToList();
                cbMonHocHVX.DataSource = db.MONs.Select(t => t.TENMON).ToList();

            }
        }

        private void frmHocVien_Load(object sender, EventArgs e)
        {
            loadHV();

            //Tab_ttsv
            txtTenHV.Enabled = false;
            txtTruongHV.Enabled = false;
            dateHV.Enabled = false;
            txtDiaChiHV.Enabled = false;
            txtSDTHV.Enabled = false;
            cbMonDKHocHV.Enabled = false;
            //tab_hieuChinhSV
            txtMaHVX.Enabled = false;
            cbMaPHX.Enabled = false;


        }

        private void grvHV_SelectionChanged(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {

                txtTenHV.Text = grvHV.CurrentRow.Cells[1].Value.ToString();
                txtTruongHV.Text = grvHV.CurrentRow.Cells[3].Value.ToString();
                dateHV.Text = grvHV.CurrentRow.Cells[2].Value.ToString();
                txtDiaChiHV.Text = grvHV.CurrentRow.Cells[5].Value.ToString();
                txtSDTHV.Text = grvHV.CurrentRow.Cells[6].Value.ToString();

                cbMonDKHocHV.Text = grvHV.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void grvHVX_SelectionChanged(object sender, EventArgs e)
        {
            
            txtMaHVX.Text = grvHVX.CurrentRow.Cells[0].Value.ToString();
            txtTenHVX.Text = grvHVX.CurrentRow.Cells[1].Value.ToString();
            dateHVX.Text = grvHVX.CurrentRow.Cells[2].Value.ToString();
            txtTruongHVX.Text = grvHVX.CurrentRow.Cells[3].Value.ToString();
            txtLopHVX.Text = grvHVX.CurrentRow.Cells[4].Value.ToString();
            txtDiaChiHVX.Text = grvHVX.CurrentRow.Cells[5].Value.ToString();
            txtSDTHVX.Text = grvHVX.CurrentRow.Cells[6].Value.ToString();
            txtHocLucHVX.Text = grvHVX.CurrentRow.Cells[7].Value.ToString();
            txtcccd.Text = grvHVX.CurrentRow.Cells[8].Value.ToString();
            cbMonHocHVX.Text = grvHVX.CurrentRow.Cells[9].Value.ToString();
            txtGhiChuHVX.Text = grvHVX.CurrentRow.Cells[10].Value.ToString();
            cbMaPHX.Text = grvHVX.CurrentRow.Cells[11].Value.ToString();
            

            cbMonHocHVX.Enabled = true;
            ////Hien Phụ Huynh
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                string maph = cbMaPHX.Text.Trim();
                return;
            }
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                DialogResult qd = MessageBox.Show("Ban co chac muon sua hoc vien nay khong?", "Confirm", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                        HOCVIEN hv = db.HOCVIENs.Where(t => t.MAHV == int.Parse(txtMaHVX.Text)).FirstOrDefault();
                        if (hv == null)
                        {
                            MessageBox.Show("Khong tim thay hoc vien nay");
                            return;
                        }
                        hv.TENHV = txtTenHVX.Text;
                        hv.TRUONG = txtTruongHV.Text;
                        hv.NGAYSINH = dateHVX.Value;
                        hv.DIACHI = txtDiaChiHVX.Text;
                        hv.DIENTHOAI = txtSDTHVX.Text;
                        hv.MONDANGKY = cbMonHocHVX.Text;
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Da Sua thanh cong");
                            loadHV();
                        }
                        catch
                        {
                            MessageBox.Show("Co loi xay ra trong qua trinh sua");
                        }
                }
                        

                }
            }        

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                DialogResult qd = MessageBox.Show("Ban co chac muon xoa hoc vien nay khong?", "Confirm", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    try
                    {                       
                        HOCVIEN hv = db.HOCVIENs.Where(s => s.MAHV == int.Parse(txtMaHVX.Text)).FirstOrDefault();
                        if (hv == null)
                        {
                            MessageBox.Show("Khong tim thay hoc vien nay");
                            return;
                        }
                        db.HOCVIENs.DeleteOnSubmit(hv);
                        db.SubmitChanges();

                        MessageBox.Show("Da xoa thanh cong");
                        loadHV();

                    }
                    catch
                    {
                        MessageBox.Show("Khong the xoa, da co loi xay ra", "Co loi xay ra");
                    }
                }
               
            }
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            frmDangKyHV f = new frmDangKyHV();
            this.Hide();
            f.Show();
        }

        private void grvHVX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHVX.Text = grvHVX.CurrentRow.Cells[0].Value.ToString();
            txtTenHVX.Text = grvHVX.CurrentRow.Cells[1].Value.ToString();
            dateHVX.Text = grvHVX.CurrentRow.Cells[2].Value.ToString();
            txtTruongHVX.Text = grvHVX.CurrentRow.Cells[3].Value.ToString();
            txtLopHVX.Text = grvHVX.CurrentRow.Cells[4].Value.ToString();
            txtDiaChiHVX.Text = grvHVX.CurrentRow.Cells[5].Value.ToString();
            txtSDTHVX.Text = grvHVX.CurrentRow.Cells[6].Value.ToString();
            txtHocLucHVX.Text = grvHVX.CurrentRow.Cells[7].Value.ToString();
            txtcccd.Text = grvHVX.CurrentRow.Cells[8].Value.ToString();
            cbMonHocHVX.Text = grvHVX.CurrentRow.Cells[9].Value.ToString();
            txtGhiChuHVX.Text = grvHVX.CurrentRow.Cells[10].Value.ToString();
            cbMaPHX.Text = grvHVX.CurrentRow.Cells[11].Value.ToString();

            cbMonHocHVX.Enabled = true;


            cbMonHocHVX.Enabled = true;
            ////Hien Phụ Huynh
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                string maph = cbMaPHX.Text.Trim();
                //var phuhuynh = from ph in db.PHUHUYNHs
                //               where ph.MAPH == int.Parse(maph)
                //               select ph;
                //grvPhuHuynh.DataSource = phuhuynh;
                grvPhuHuynh.DataSource = db.PHUHUYNHs.Where(t => t.MAPH == int.Parse(maph)).ToList();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmGioiThieuGS f = new frmGioiThieuGS();
            //this.Hide();
            //f.Show();
        }

      

       

    }
}
