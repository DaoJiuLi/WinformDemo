using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TuBiao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            // 连接数据库，查询数据
            //string connectionString = "server=.;database=tb_execl;uid=sa;pwd=131417;";
            //string queryString = "SELECt  name,shuju FROM shuju";
            //SqlDataAdapter adapter = new SqlDataAdapter(queryString, connectionString);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //// 绑定数据到Chart控件
            //chart1.DataSource = table;
            //chart1.Titles.Add("图表标题");
            //chart1.Series[0].XValueMember = "name";
            //chart1.Series[0].YValueMembers = "shuju";
            //// 配置Chart控件
            //chart1.ChartAreas[0].AxisX.Title = "名称";
            //chart1.ChartAreas[0].AxisY.Title = "Y轴";
            ////数据间隔位置
            //chart1.ChartAreas[0].AxisX.Interval = 1;
            ////Y轴的方向
            //chart1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;

            ////int yi = 1000;
            ////int er = 700;
            ////chart1.Size = new Size(yi, er);
            ////chart1.ChartAreas[0].Position.Width = yi; // 设置图表区域的宽度
            ////chart1.ChartAreas[0].Position.Height = er; // 设置图表区域的高度
            ////间隔类型
            ////chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;

            //int columnSpacing = 20; // 设置列与列之间的间距为10像素
            //chart1.Series[0].CustomProperties = "PointWidth=" + (chart1.ChartAreas[0].AxisX.Interval - columnSpacing).ToString(); // 设置列之间的间距



            ////chart1.ChartAreas[0].AxisX.ScaleView.SizeType = 20;
            ////chart1.Series[0].ChartType = SeriesChartType.Line;
            ////chart1.Series[0].ChartType = SeriesChartType.Pie;
            ////chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            //// 显示图表
            //chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要执行操作吗？", "提示", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel||result==DialogResult.No)
            {
                MessageBox.Show("您已取消操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Form2 newf=new Form2();
            if (newf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("内容", "标题", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> XList = new List<int>();
            List<int> YList = new List<int>();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet; //设置网格类型为虚线
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash; //设置网格类型为虚线
            chart1.Series[0].IsValueShownAsLabel = true;//设置显示示数
            chart1.Legends[0].Enabled = false;//取消图例
            Random ran = new Random();
            for (int i = 0; i < 6; i++)
            {
                XList.Add(i);
                YList.Add(ran.Next(10, 100));
            }
            chart1.Series["Series1"].Points.DataBindXY(XList, YList);
        }
    }
}
