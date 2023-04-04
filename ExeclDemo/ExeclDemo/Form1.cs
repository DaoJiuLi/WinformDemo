
using FastReport;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeclDemo
{
    public partial class Form1 : Form
    {
         //static string strConn = "server=bj-cynosdb-grp-dy0p2d94.sql.tencentcdb.com; port=24624;user id=root; password=Szh131417;database=tb_execl;pooling=true;";
         static string strConn = "server=.;uid=sa;pwd=131417;database=tb_execl;";
        SqlConnection conn = new SqlConnection(strConn);
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            string sql = "select id,name,age from ecexl";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.DataSource= dt;
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ////实例化对话框
            //OpenFileDialog open=new OpenFileDialog();
            //open.Filter = "Excel文件|*.xlsx;*.xls|Excel文件|*.xls|Excel文件|*.xlsx";
            //if (open.ShowDialog()==DialogResult.OK)
            //{
            //    //通过openFileDialog选择一个Excel文件，获取其文件路径filePath。
            //    string filePath = open.FileName;
            //    //连接参数
            //    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
            //    //创建一个OleDbConnection对象
            //    OleDbConnection connection = new OleDbConnection(connectionString);
            //    connection.Open();
            //    //通过connection.GetOleDbSchemaTable方法获取Excel文件中的所有表格的信息
            //    DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            //    //获取第一个表格的名称
            //    string sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString().Trim();
            //    string selectString = "select * from [" + sheetName + "]";
            //    //创建一个OleDbDataAdapter对象
            //    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectString, connection);
            //    DataTable dt = new DataTable();
            //    dataAdapter.Fill(dt);
            //    connection.Close();
            //    // 将DataTable中的数据绑定到DataGridView中
            //    dataGridView1.DataSource = dt;
            //}
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //实例化XSSF
            XSSFWorkbook workBook = new XSSFWorkbook();
            //创建一个sheet
            XSSFSheet sheet = (XSSFSheet)workBook.CreateSheet();
            // 添加表头
            IRow row = sheet.CreateRow(0);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                row.CreateCell(i).SetCellValue(dataGridView1.Columns[i].HeaderText);
            }

            //row.CreateCell(0).SetCellValue("ID");
            //row.CreateCell(1).SetCellValue("姓名");
            //row.CreateCell(2).SetCellValue("年龄");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                IRow rrow = sheet.CreateRow(i + 1);

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    rrow.CreateCell(j).SetCellValue(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                //rrow.CreateCell(0).SetCellValue(dataGridView1.Rows[i].Cells["id"].Value.ToString());
                //rrow.CreateCell(1).SetCellValue(dataGridView1.Rows[i].Cells["name"].Value.ToString());
                //rrow.CreateCell(2).SetCellValue(dataGridView1.Rows[i].Cells["age"].Value.ToString());
            }

            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "Excel文件|*.xlsx;*.xls|Excel文件|*.xls|Excel文件|*.xlsx"; ;
            open.Title = "保存文件";

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(open.FileName, FileMode.Create, FileAccess.Write))
                {
                    workBook.Write(fs);
                    workBook.Close();
                }
                MessageBox.Show("导出成功");
                //导出后打开ececl文件
                string filePath = open.FileName;
                System.Diagnostics.Process.Start(filePath);
            }
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            // 打开文件保存对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable dt = new DataTable();
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // 创建Excel文件
                    IWorkbook workbook = WorkbookFactory.Create(fileStream);
                    // 获取第一个工作表
                    ISheet sheet = workbook.GetSheetAt(0);
                    // 获取第一个工作表头
                    IRow headerRow = sheet.GetRow(0);
                    //便利表头
                    foreach (ICell cell in headerRow)
                    {
                        dt.Columns.Add(cell.ToString());
                    }
                    //便利表数据
                    for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        DataRow dataRow = dt.NewRow();
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            ICell cell = row.GetCell(j);
                            if (cell != null)
                            {
                                dataRow[j] = cell.ToString();
                            }
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tb_execlDataSet.ecexl”中。您可以根据需要移动或移除它。
            this.ecexlTableAdapter.Fill(this.tb_execlDataSet.ecexl);
            // TODO: 这行代码将数据加载到表“zJ_NB_RXJXCCPKGLDataSet.tb_UserInfo”中。您可以根据需要移动或移除它。
            //this.tb_UserInfoTableAdapter.Fill(this.zJ_NB_RXJXCCPKGLDataSet.tb_UserInfo);

            //sqlbulkcopy.writetoserver




        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            //实例化report
            Report report = new Report();
            //找路径
            report.Load(Application.StartupPath + @"\Reports\未命名.frx");

            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("age");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dgvdr = dataGridView1.Rows[i];
                dr = dt.NewRow();
                dr["id"] = dgvdr.Cells["id"].Value.ToString();
                dr["name"] = dgvdr.Cells["姓名"].Value.ToString();
                dr["age"] = dgvdr.Cells["年龄"].Value.ToString();
                dt.Rows.Add(dr);
            }
            dt.TableName = "ecexl";
            report.RegisterData(dt, "ecexl");
            report.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "*.xls|*.xls|*.xlsx|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string exName = saveFileDialog1.FileName.ToLower();
            exName = exName.Substring(exName.LastIndexOf('.') + 1);

            IWorkbook wk = null;
            switch (exName)
            {
                case "xls":
                    {
                        wk = new HSSFWorkbook();
                        break;
                    }
                case "xlsx":
                    {
                        wk = new XSSFWorkbook();
                        break;
                    }
            }

            ISheet sheet = wk.CreateSheet();
            int index = 0;
            IRow row = sheet.CreateRow(0);
            int num = 0;

            //循环列设置标题
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Visible == true)
                {
                    row.CreateCell(num).SetCellValue(dataGridView1.Columns[i].HeaderText.ToString());
                    num++;
                }
            }

            //设置内容
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                row = sheet.CreateRow(index + j + 1);
                num = 0;
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1.Columns[k].Visible == true)
                    {
                        if (dataGridView1.Columns[k].HeaderText.IndexOf("日期") > -1 || dataGridView1.Columns[k].DataPropertyName.IndexOf("date") > -1)
                        {
                            row.CreateCell(num).SetCellValue(Convert.ToDateTime(dataGridView1.Rows[j].Cells[k].Value.ToString()).ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            row.CreateCell(num).SetCellValue(dataGridView1.Rows[j].Cells[k].Value.ToString());
                        }

                        num++;
                    }
                }
            }
            for (int i = 0; i < num; i++)
            {
                sheet.AutoSizeColumn(i);
            }


            try
            {
                //写Excel
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    wk.Write(fs);
                    fs.Flush();
                    fs.Close();
                }

                System.Diagnostics.Process.Start(saveFileDialog1.FileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
