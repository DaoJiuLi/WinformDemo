using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoDanFRM
{
    public partial class Form1 : Form
    {
        static string connStr = "server=.;database=BaoDan;uid=sa;pwd=131417;";
        SqlConnection conn = new SqlConnection(connStr);
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            string sql = "select * from tb_baodan";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            //报单文件路径
            report.Load(Application.StartupPath + @"\Report\baodan.frx");

            DataTable dt = new DataTable();
            DataRow dr;
            //数据表新建列
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("age");
            //便利数据到报单中
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dgvdr = dataGridView1.Rows[i];
                dr = dt.NewRow();
                dr["id"] = dgvdr.Cells["id"].Value.ToString();
                dr["name"] = dgvdr.Cells["name"].Value.ToString();
                dr["age"] = dgvdr.Cells["age"].Value.ToString();
                dt.Rows.Add(dr);
            }
            //绑定报单中的数据源
            dt.TableName = "tb_baodan";
            report.RegisterData(dt, "tb_baodan");
            DataBand band = report.FindObject("Data1") as DataBand;
            band.DataSource = report.GetDataSource("tb_baodan");
            report.Show();
        }
    }
}
