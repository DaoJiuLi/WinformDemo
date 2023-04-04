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
            //X坐标
            string mousePositionX = System.Windows.Forms.Control.MousePosition.X + "";
            //Y坐标
            string mousePositionY = System.Windows.Forms.Control.MousePosition.Y + "";
            textBox1.Text=mousePositionX;
            textBox2.Text=mousePositionY;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { 
            //X坐标
            string mousePositionX = System.Windows.Forms.Control.MousePosition.X + "";
            //Y坐标
            string mousePositionY = System.Windows.Forms.Control.MousePosition.Y + "";
            textBox1.Text = mousePositionX;
            textBox2.Text = mousePositionY;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //X坐标
            string mousePositionX = System.Windows.Forms.Control.MousePosition.X + "";
            //Y坐标
            string mousePositionY = System.Windows.Forms.Control.MousePosition.Y + "";
            textBox1.Text = mousePositionX;
            textBox2.Text = mousePositionY;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //X坐标
            string mousePositionX = System.Windows.Forms.Control.MousePosition.X + "";
            //Y坐标
            string mousePositionY = System.Windows.Forms.Control.MousePosition.Y + "";
            textBox1.Text = mousePositionX;
            textBox2.Text = mousePositionY;
        }
    }
}
