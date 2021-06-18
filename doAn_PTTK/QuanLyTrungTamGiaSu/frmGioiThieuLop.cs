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
    public partial class frmGioiThieuLop : Form
    {
        public frmGioiThieuLop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGiaSu f = new frmGiaSu();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbVan.Checked == true)
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {
                    
                    HOCVIEN hv1= db.HOCVIENs.Where(t => t.MONDANGKY.Trim() == "VĂN").FirstOrDefault();
                    if (hv1 == null)
                    {
                        MessageBox.Show("không có học viên trống!!!");
                    }
                    else{
                    var lst = (from hv in db.HOCVIENs.Where(s=>s.MONDANGKY.Trim().ToString()=="VĂN")
                               select new
                               {
                                   hv.MAHV, hv.TENHV, hv.NGAYSINH, hv.TRUONG, hv.LOP, hv.DIACHI, hv.DIENTHOAI, hv.HOCLUC, hv.CCCD, hv.MONDANGKY, hv.GHICHU, hv.MAPH
                               });
                    grvGS_GT.DataSource = lst;
                }
                }
            }
            if(rbToan.Checked==true)
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {

                    HOCVIEN hv1 = db.HOCVIENs.Where(t => t.MONDANGKY.Trim() == "TOÁN").FirstOrDefault();
                    if (hv1 == null)
                    {
                        MessageBox.Show("không có học viên trống!!!");
                    }
                    else
                    {
                        var lst = (from hv in db.HOCVIENs.Where(s => s.MONDANGKY.Trim().ToString() == "TOÁN")
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
                        grvGS_GT.DataSource = lst;
                    }
                }
            }
            if (rbAnh.Checked == true)
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {

                    HOCVIEN hv1 = db.HOCVIENs.Where(t => t.MONDANGKY.Trim() == "ANH").FirstOrDefault();
                    if (hv1 == null)
                    {
                        MessageBox.Show("không có học viên trống!!!");
                    }
                    else
                    {
                        var lst = (from hv in db.HOCVIENs.Where(s => s.MONDANGKY.Trim().ToString() == "ANH")
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
                        grvGS_GT.DataSource = lst;
                    }
                }
            }
            if (rbLy.Checked == true)
            {
                using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
                {

                    HOCVIEN hv1 = db.HOCVIENs.Where(t => t.MONDANGKY.Trim() == "Lý").FirstOrDefault();
                    if (hv1 == null)
                    {
                        MessageBox.Show("không có học viên trống!!!");
                    }
                    else
                    {
                        var lst = (from hv in db.HOCVIENs.Where(s => s.MONDANGKY.Trim().ToString() == "LÝ")
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
                        grvGS_GT.DataSource = lst;
                    }
                }
                    }
                }
            }
        }
        
