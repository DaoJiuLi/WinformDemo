using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int Count = 20;
        public Form1()
        {
            InitializeComponent();
            DataTable dt = DataAccessLayer.GetData(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = "共" + (int)Math.Ceiling((double)Count / Convert.ToInt32(textBox2.Text)) + "页";
            dataGridView2.DataSource = dt;
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 1)
            {
                MessageBox.Show("这是第一条数据");
                return;
            }
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
            DataTable dt = DataAccessLayer.GetData(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = "共" + (int)Math.Ceiling((double)Count / Convert.ToInt32(textBox2.Text)) + "页";
            dataGridView2.DataSource = dt;
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == (int)Math.Ceiling((double)Count / Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("这是最后一条数据");
                return;
            }
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
            DataTable dt = DataAccessLayer.GetData(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = "共" + (int)Math.Ceiling((double)Count / Convert.ToInt32(textBox2.Text)) + "页";
            dataGridView2.DataSource = dt;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccessLayer.GetData(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = "共" + (int)Math.Ceiling((double)Count / Convert.ToInt32(textBox2.Text)) + "页";
            dataGridView2.DataSource = dt;
        }
    }
    // 数据访问层
    class DataAccessLayer
    {
        // 获取数据的方法
        public static DataTable GetData(int pageIndex, int pageSize)
        {
            // 连接数据库
            SqlConnection conn = new SqlConnection("server=.;database=tb_execl;uid=sa;pwd=131417;");

            // 构造 SQL 语句
            string sql = string.Format("SELECT * FROM shuju ORDER BY ID OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                (pageIndex - 1) * pageSize, pageSize);

            // 执行 SQL 语句，获取数据
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // 返回数据
            return dt;
        }
    }
}
