using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // 正则表达式 手机号码
            string pattern = @"^(13[0-9]|14[5-9]|15[0-3,5-9]|16[6]|17[0-8]|18[0-9]|19[1,8,9])\d{8}$";

            // 输入的文本
            string input = textBox1.Text;

            // 进行验证
            if (Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("输入的手机号码格式正确");
            }
            else
            {
                MessageBox.Show("输入的手机号码格式不正确");
            }
        }
    }
}
