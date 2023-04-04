using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Data;

namespace ZanCunDemo
{
    public partial class Form1 : Form
    {
        SQLData db=new SQLData();
        public Form1()
        {
            InitializeComponent();
            string sql = "select * from tb_zhu";
            dataGridView1.DataSource = db.GetDataTable(sql);
        }
    }
}
