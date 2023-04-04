using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取 Redis 连接字符串
            string redisConnectionString = ConfigurationManager.ConnectionStrings["RedisConnectionString"].ConnectionString;

            // 创建 Redis 连接
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(redisConnectionString);

            // 获取 Redis 数据库
            IDatabase db = redis.GetDatabase();
            //db.KeyDelete("Dao");
            //// 存储数据到 Redis 中
            //db.StringSet("Dao", "道九离");

            // 从 Redis 中获取数据
            string value = db.StringGet("Dao");
            MessageBox.Show(value);
        }
    }
}
