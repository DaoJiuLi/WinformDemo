using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserControl1 userControl = new UserControl1();
            userControl.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(userControl);
        }
    }
}
