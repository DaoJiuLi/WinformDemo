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

        delegate void MyDelegate();
        MyDelegate myDelegate = new MyDelegate(yi);
        MyDelegate myDelegate1 = new MyDelegate(er);
        public Form1()
        {
            InitializeComponent();
        }
        static void yi()
        {
            string aaaa= "一";
            MessageBox.Show(aaaa);
        }
        static void er()
        {
            string aaaa = "二";
            MessageBox.Show(aaaa);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnKO_Click(object sender, EventArgs e)
        {
            myDelegate1();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            myDelegate();
        }
    }
}
