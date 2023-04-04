using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTableDBhelper db=new DataTableDBhelper();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//列自动调整模式
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//行选中的样式
            string connStr = "server=.;database=tb_execl;uid=sa;pwd=131417;";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string sql = "select id ID,name 姓名,shuju 数据,shijian 时间 from shuju";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                List<MyClass> list = db.ConvertDataTableToList<MyClass>(dataTable);
                dataGridView1.DataSource = list;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
