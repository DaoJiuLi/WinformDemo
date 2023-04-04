using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class DBHelper
    {
        private static string connStr = "server=bj-cynosdbmysql-grp-dy0p2d94.sql.tencentcdb.com; port=24624;user id=root; password=Szh131417;database=Dizhi;pooling=true;";
        private static MySqlConnection conn=new MySqlConnection(connStr);

        public static DataTable Select(string sql)
        {
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,conn);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int NoSelect(string sql)
        {
            conn.Open();
            MySqlCommand cmd=new MySqlCommand(sql,conn);
            int num=cmd.ExecuteNonQuery();
            conn.Close();
            return num;
        }
    }
}
