using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamGiaSu
{
    
    public class GioiThieuGS
    {
        
        public SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-B1ALK3E\\CHINHANH1;Initial Catalog=QL_TTGiaSu;User ID=sa;Password=sa2012"); 

        public void LoadGiaSu(int mon,int lop,DataGridView data)
        {
            cnn.Open();
            string CauLenh = "EXEC SEARCHGS "+mon+","+lop+"";
            SqlDataAdapter da = new SqlDataAdapter(CauLenh,cnn);
            DataSet ds = new DataSet();
            da.Fill(ds,"GIASU");
            data.DataSource = ds.Tables["GIASU"];
            cnn.Close();
        }

    }
}
