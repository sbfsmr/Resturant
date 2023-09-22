using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Resturant
{
    public class GlobalData
    {
        public static string UserName;
        public static string Password;
        public static string BillNumber;
        public static string BTtotal;
        public static DataSet Ds = new DataSet();
        public static SqlDataAdapter Da = new SqlDataAdapter();
        public static SqlDataReader Dr;
        public static SqlCommandBuilder Cb = new SqlCommandBuilder();

    }
}
