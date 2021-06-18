using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamGiaSu
{
    public class DangKyHV
    {
        public SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-B1ALK3E\\CHINHANH1;Initial Catalog=QL_TTGiaSu;User ID=sa;Password=sa2012");

        public int KTHV(string cmnd)
        {
            
                cnn.Open();
                string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[KTHV] @cccd = N'"+cmnd+"' SELECT @return_value";
                SqlCommand cmd = new SqlCommand(CauLenh, cnn);
                int kq = (int)cmd.ExecuteScalar();
                return kq;
                cnn.Close();
                
                
            
        }
    }
}
