using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKUP_RESTORE
{
    class DBconnect
    {
        public static SqlConnection SqlConnect(String tk,String mk)
        {
            String strConn = "Data Source=DESKTOP-9RHI76C;MultipleActiveResultSets=True;User ID=" + tk + ";Password=" + mk + "";
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
        public void ExcuteNonquery(string str,SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        } 
    }
}
