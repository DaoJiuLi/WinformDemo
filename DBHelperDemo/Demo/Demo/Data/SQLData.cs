using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    public class SQLData : Data
    {
        #region 变量和结构

        public SqlConnection Connection = null; //数据库连接对象
        public SqlTransaction Transaction = null; //数据库事务
        public bool IsInTransaction = false; //是否在事务中
        #endregion
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public SQLData()
        {
            string ConnectionText; //Store The Connection Sentence for Database
            if (Connection == null)
            {
                //ConnectionText = ReadConn();
                //ConnectionText = "server=.;database=demo;uid=sa;pwd=131417;";
                ConnectionText = "server=.;database=Dao;Integrated Security = true;";
                //加上“;MultipleActiveResultSets=True”是为了能多打开SqlDataReader
                Connection = new SqlConnection(ConnectionText + ";MultipleActiveResultSets=True");
                try
                {
                    Connection.Open();//Open Database
                }
                catch (Exception e)
                {
                    Connection = null;
                    throw new Exception("连接数据库失败！\n错误信息：" + e.Message);
                    //MessageBox.Show("连接数据库失败！\n错误信息：" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <returns></returns>
        public override int Open()
        {
            if (Connection == null)
            {
                return -2;
            }
            if (Connection.State == ConnectionState.Closed)
            {
                try
                {
                    Connection.Open();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public override void Close()
        {
            if (Connection != null)
            {
                Connection.Close();
                Connection.Dispose();
                Connection = null;
            }
        }

        public override void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public override void CommitTransaction()
        {
            throw new NotImplementedException();
        }


        public override void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public override DataSet GetDataSet(string commandText)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 返回一个数据表
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public override DataTable GetDataTable(string commandText)
        {
            SqlCommand cmd = new SqlCommand(commandText, Connection); //创建并初始化SqlCommand对象
            if (IsInTransaction) cmd.Transaction = Transaction;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw new Exception("\n错误：" + err.Message);
            }

            finally
            {
                cmd.Dispose();
                cmd = null;
                adapter.Dispose();
                adapter = null;
            }
        }
    }
}
