using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //初始化第一个下拉框
            string sql = "select * from yi";
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember= "name";
            DataTable dt = DBHelper.Select(sql);
            comboBox1.DataSource = dt;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from er where yi_id=" + comboBox1.SelectedValue;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "name";
            comboBox2.DataSource = DBHelper.Select(sql);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from san where er_id=" + comboBox2.SelectedValue;
            comboBox3.ValueMember = "id";
            comboBox3.DisplayMember = "name";
            comboBox3.DataSource = DBHelper.Select(sql);
        }
    }
}
