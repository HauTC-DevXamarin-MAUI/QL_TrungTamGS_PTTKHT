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
    public partial class frmGiaSu : Form
    {
        bool tt = true;
        bool tt1 = false;

        void loadGS()
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                var lst = (from gs in db.GIASUs select new { gs.MAGS, gs.TENGS, gs.GIOITINH,gs.NGAYSINH,gs.CCCD,gs.NGUYENQUAN,
                                                            gs.DIACHI,gs.EMAIL,gs.DIENTHOAI,gs.TRUONG,gs.NGANHHOC,gs.NAMTOTNGHIEP,gs.NGHENGHIEP,
                                                             gs.MONDANGDAY,gs.UUDIEM,gs.SOBUOIDAY,gs.TRANGTHAI});
                grvGS.DataSource = lst;
                grvGSX.DataSource = lst;

                ////
                //cbMaPHX.DataSource = db.PHUHUYNHs.Select(t => t.MAPH).ToList();
                cbMonDKDayGSX.DataSource = db.MONs.Select(t => t.TENMON).ToList();

            }
        }

        public frmGiaSu()
        {
            InitializeComponent();
        }

        private void txtSDTGSX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmGiaSu_Load(object sender, EventArgs e)
        {
            loadGS();
        }

        private void grvGS_SelectionChanged(object sender, EventArgs e)
        {
            txtMaGS.Text = grvGS.CurrentRow.Cells[0].Value.ToString();
            txtTenGS.Text = grvGS.CurrentRow.Cells[1].Value.ToString();
            dateGS.Text = grvGS.CurrentRow.Cells[3].Value.ToString();
            txtDiaChiGS.Text = grvGS.CurrentRow.Cells[6].Value.ToString();
            txtSDTGS.Text = grvGS.CurrentRow.Cells[8].Value.ToString();
            txtCCCDGS.Text = grvGS.CurrentRow.Cells[4].Value.ToString();
            if (grvGS.CurrentRow.Cells[2].Value.ToString().Trim() == "NAM")
            {
                rbNamGS.Checked = true;
            }
            else
            {
                rbNuGS.Checked = true;
            }
        }

        private void grvGSX_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnTimGS_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                if (rdcccd_TimGS.Checked == true)
                {
                    var lst = (from gs in db.GIASUs
                               where gs.CCCD.Trim().Contains(txtTTimKiem_GSX.Text.Trim())
                               select new
                               {
                                   gs.MAGS,
                                   gs.TENGS,
                                   gs.GIOITINH,
                                   gs.NGAYSINH,
                                   gs.CCCD,
                                   gs.NGUYENQUAN,
                                   gs.DIACHI,
                                   gs.EMAIL,
                                   gs.DIENTHOAI,
                                   gs.TRUONG,
                                   gs.NGANHHOC,
                                   gs.NAMTOTNGHIEP,
                                   gs.NGHENGHIEP,
                                   gs.MONDANGDAY,
                                   gs.UUDIEM,
                                   gs.SOBUOIDAY,
                                   gs.TRANGTHAI
                               });
                    grvGSX.DataSource = lst;

                }
                else if (rbtetn_TimGS.Checked == true)
                {
                    var lst = (from gs in db.GIASUs
                               where gs.TENGS.Trim().Contains(txtTTimKiem_GSX.Text.Trim())
                               select new
                               {
                                   gs.MAGS,
                                   gs.TENGS,
                                   gs.GIOITINH,
                                   gs.NGAYSINH,
                                   gs.CCCD,
                                   gs.NGUYENQUAN,
                                   gs.DIACHI,
                                   gs.EMAIL,
                                   gs.DIENTHOAI,
                                   gs.TRUONG,
                                   gs.NGANHHOC,
                                   gs.NAMTOTNGHIEP,
                                   gs.NGHENGHIEP,
                                   gs.MONDANGDAY,
                                   gs.UUDIEM,
                                   gs.SOBUOIDAY,
                                   gs.TRANGTHAI
                               });
                    grvGSX.DataSource = lst;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tìm kiếm theo mục nào!!!");
                }
            }
        }

        private void btnSuaGS_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                DialogResult qd = MessageBox.Show("Ban co chac muon sua Gia Su nay khong?", "Confirm", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    GIASU gs = db.GIASUs.Where(t => t.MAGS == int.Parse(txtMaGSX.Text)).FirstOrDefault();
                    if (gs == null)
                    {
                        MessageBox.Show("Khong tim thay hoc vien nay");
                        return;
                    }
                    
                    try
                    {
                        gs.TENGS = txtTenGSX.Text;
                        gs.NGAYSINH=dateGSX.Value ;
                        gs.CCCD=txtCCCDGSX.Text;
                        gs.NGUYENQUAN=txtNQGSX.Text ;
                        gs.DIACHI=txtDiaChiGSX.Text ;
                        gs.EMAIL=txtEmailGSX.Text ;
                        gs.DIENTHOAI=txtSDTGSX.Text ;
                        gs.TRUONG=txttTruongGSX.Text ;
                        gs.NGANHHOC=txtNganhHocGSX.Text ;
                        gs.NAMTOTNGHIEP=int.Parse(txtNamTNGSX.Text);
                        gs.NGHENGHIEP=txtNgheNghiepGSX.Text ;
                        gs.MONDANGDAY=cbMonDKDayGSX.Text ;
                        gs.UUDIEM=txtUuDiemGSX.Text ;
                        gs.SOBUOIDAY=int.Parse(txtSoDuoiDayGSX.Text);
                        if (txtTrangThaiGSX.Text == "True")
                        {
                            gs.TRANGTHAI = tt;
                        }
                        else
                        {
                            gs.TRANGTHAI = tt1;
                        }
                        if (rbNamGSX.Checked == true)
                        {
                            gs.GIOITINH = "Nam";
                        }
                        else
                        {
                            gs.GIOITINH = "Nu";
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Da Sua thanh cong");
                        loadGS();
                    }
                    catch
                    {
                        MessageBox.Show("Co loi xay ra trong qua trinh sua");
                    }
                }


            }
        }

        private void btnXoaGS_Click(object sender, EventArgs e)
        {
            using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            {
                DialogResult qd = MessageBox.Show("Ban co chac muon xoa Gia Su nay khong?", "Confirm", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    try
                    {
                        GIASU gs = db.GIASUs.Where(t => t.MAGS == int.Parse(txtMaGSX.Text)).FirstOrDefault();
                        if (gs == null)
                        {
                            MessageBox.Show("Khong tim thay Gia Su nay");
                            return;
                        }
                        db.GIASUs.DeleteOnSubmit(gs);
                        db.SubmitChanges();

                        MessageBox.Show("Da xoa thanh cong");
                        loadGS();

                    }
                    catch
                    {
                        MessageBox.Show("Khong the xoa, da co loi xay ra", "Co loi xay ra");
                    }
                }
            }
        }

        private void grvGSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGSX.Text = grvGSX.CurrentRow.Cells[0].Value.ToString();
            txtTenGSX.Text = grvGSX.CurrentRow.Cells[1].Value.ToString();
            dateGSX.Text = grvGSX.CurrentRow.Cells[3].Value.ToString();
            txtCCCDGSX.Text = grvGSX.CurrentRow.Cells[4].Value.ToString();
            txtNQGSX.Text = grvGSX.CurrentRow.Cells[5].Value.ToString();
            txtDiaChiGSX.Text = grvGSX.CurrentRow.Cells[6].Value.ToString();
            txtEmailGSX.Text = grvGSX.CurrentRow.Cells[7].Value.ToString();
            txtSDTGSX.Text = grvGSX.CurrentRow.Cells[8].Value.ToString();
            txttTruongGSX.Text = grvGSX.CurrentRow.Cells[9].Value.ToString();
            txtNganhHocGSX.Text = grvGSX.CurrentRow.Cells[10].Value.ToString();
            txtNamTNGSX.Text = grvGSX.CurrentRow.Cells[11].Value.ToString();
            txtNgheNghiepGSX.Text = grvGSX.CurrentRow.Cells[12].Value.ToString();
            cbMonDKDayGSX.Text = grvGSX.CurrentRow.Cells[13].Value.ToString();
            txtUuDiemGSX.Text = grvGSX.CurrentRow.Cells[14].Value.ToString();
            txtSoDuoiDayGSX.Text = grvGSX.CurrentRow.Cells[15].Value.ToString();
            txtTrangThaiGSX.Text = grvGSX.CurrentRow.Cells[16].Value.ToString();
            if (grvGSX.CurrentRow.Cells[2].Value.ToString().Trim() == "NAM")
            {
                rbNamGSX.Checked = true;
            }
            else
            {
                rbNuGSX.Checked = true;
            }
        }

        private void btnThemGS_Click(object sender, EventArgs e)
        {
            frmDangKyGS f = new frmDangKyGS();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGioiThieuLop f = new frmGioiThieuLop();
            this.Hide();
            f.Show();
        }

      

       

        

       
    }
}
