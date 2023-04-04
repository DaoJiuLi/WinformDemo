using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    public abstract class Data
    {
        //打开数据库连接
        public abstract int Open();

        //关闭数据库连接
        public abstract void Close();

        //开始一个事务
        public abstract void BeginTransaction();

        //提交一个事务
        public abstract void CommitTransaction();

        //回滚一个事务
        public abstract void RollbackTransaction();

        //GetDataSet（1）由指定的SQL语句，返回一个数据表
        public abstract DataSet GetDataSet(string commandText);

        //GetDataTable（1）由指定的SQL语句，返回一个数据表
        public abstract DataTable GetDataTable(string commandText);
    }
}
