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
    public partial class frmGioiThieuGS : Form
    {
        string mon;
        string lop;
        GioiThieuGS gt = new GioiThieuGS();
        public frmGioiThieuGS(string mon,string lop)
        {
            InitializeComponent();
            this.mon = mon;
            this.lop = lop;
            Load();
        }
        public void Load()
        {
            gt.LoadGiaSu(int.Parse(mon), int.Parse(lop), grvGS_GT);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (rbVan.Checked == true)
            //{
            //    using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            //    {
                    
            //        GIASU gs = db.GIASUs.Where(t => t.MONDANGDAY.Trim() == "VĂN" && t.TRANGTHAI==false).FirstOrDefault();
            //        if (gs == null)
            //        {
            //            MessageBox.Show("không có gia sư trống!!!");
            //        }
            //        else{
            //            var lst = (from gs1 in db.GIASUs.Where(s => s.MONDANGDAY.Trim().ToString() == "VĂN" && s.TRANGTHAI == false)
            //                   select new
            //                   {
            //                       gs1.MAGS,
            //                       gs1.TENGS,
            //                       gs1.GIOITINH,
            //                       gs1.NGAYSINH,
            //                       gs1.CCCD,
            //                       gs1.NGUYENQUAN,
            //                       gs1.DIACHI,
            //                       gs1.EMAIL,
            //                       gs1.DIENTHOAI,
            //                       gs1.TRUONG,
            //                       gs1.NGANHHOC,
            //                       gs1.NAMTOTNGHIEP,
            //                       gs1.NGHENGHIEP,
            //                       gs1.MONDANGDAY,
            //                       gs1.UUDIEM,
            //                       gs1.SOBUOIDAY,
            //                       gs1.TRANGTHAI
            //                   });
            //        grvGS_GT.DataSource = lst;
            //    }
            //    }
            //}
            //if(rbToan.Checked==true)
            //{
            //    using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            //    {

            //        GIASU gs = db.GIASUs.Where(t => t.MONDANGDAY.Trim() == "TOÁN" && t.TRANGTHAI==false).FirstOrDefault();
            //        if (gs == null)
            //        {
            //            MessageBox.Show("không có gia sư trống!!!");
            //        }
            //        else
            //        {
            //            var lst = (from gs1 in db.GIASUs.Where(s => s.MONDANGDAY.Trim().ToString() == "TOÁN"&& s.TRANGTHAI==false)
            //                       select new
            //                       {
            //                           gs1.MAGS,
            //                           gs1.TENGS,
            //                           gs1.GIOITINH,
            //                           gs1.NGAYSINH,
            //                           gs1.CCCD,
            //                           gs1.NGUYENQUAN,
            //                           gs1.DIACHI,
            //                           gs1.EMAIL,
            //                           gs1.DIENTHOAI,
            //                           gs1.TRUONG,
            //                           gs1.NGANHHOC,
            //                           gs1.NAMTOTNGHIEP,
            //                           gs1.NGHENGHIEP,
            //                           gs1.MONDANGDAY,
            //                           gs1.UUDIEM,
            //                           gs1.SOBUOIDAY,
            //                           gs1.TRANGTHAI
            //                       });
            //            grvGS_GT.DataSource = lst;
            //        }
            //    }
            //}
            //if (rbAnh.Checked == true)
            //{
            //    using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            //    {

            //        GIASU gs = db.GIASUs.Where(t => t.MONDANGDAY.Trim() == "ANH" && t.TRANGTHAI == false).FirstOrDefault();
            //        if (gs == null)
            //        {
            //            MessageBox.Show("không có gia sư trống!!!");
            //        }
            //        else
            //        {
            //            var lst = (from gs1 in db.GIASUs.Where(s => s.MONDANGDAY.Trim().ToString() == "ANH" && s.TRANGTHAI==false)
            //                       select new
            //                       {
            //                           gs1.MAGS,
            //                           gs1.TENGS,
            //                           gs1.GIOITINH,
            //                           gs1.NGAYSINH,
            //                           gs1.CCCD,
            //                           gs1.NGUYENQUAN,
            //                           gs1.DIACHI,
            //                           gs1.EMAIL,
            //                           gs1.DIENTHOAI,
            //                           gs1.TRUONG,
            //                           gs1.NGANHHOC,
            //                           gs1.NAMTOTNGHIEP,
            //                           gs1.NGHENGHIEP,
            //                           gs1.MONDANGDAY,
            //                           gs1.UUDIEM,
            //                           gs1.SOBUOIDAY,
            //                           gs1.TRANGTHAI
            //                       });
            //            grvGS_GT.DataSource = lst;
            //        }
            //    }
            //}
            //if (rbLy.Checked == true)
            //{
            //    using (QL_TTGiaSuaDataContext db = new QL_TTGiaSuaDataContext())
            //    {

            //        GIASU gs = db.GIASUs.Where(t => t.MONDANGDAY.Trim() == "LÝ" && t.TRANGTHAI == false).FirstOrDefault();
            //        if (gs == null)
            //        {
            //            MessageBox.Show("không có gia sư trống!!!");
            //        }
            //        else
            //        {
            //            var lst = (from gs1 in db.GIASUs.Where(s => s.MONDANGDAY.Trim().ToString() == "LÝ" && s.TRANGTHAI == false)
            //                       select new
            //                       {
            //                           gs1.MAGS,
            //                           gs1.TENGS,
            //                           gs1.GIOITINH,
            //                           gs1.NGAYSINH,
            //                           gs1.CCCD,
            //                           gs1.NGUYENQUAN,
            //                           gs1.DIACHI,
            //                           gs1.EMAIL,
            //                           gs1.DIENTHOAI,
            //                           gs1.TRUONG,
            //                           gs1.NGANHHOC,
            //                           gs1.NAMTOTNGHIEP,
            //                           gs1.NGHENGHIEP,
            //                           gs1.MONDANGDAY,
            //                           gs1.UUDIEM,
            //                           gs1.SOBUOIDAY,
            //                           gs1.TRANGTHAI
            //                       });
            //            grvGS_GT.DataSource = lst;
            //        }
            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHocVien f = new frmHocVien();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
