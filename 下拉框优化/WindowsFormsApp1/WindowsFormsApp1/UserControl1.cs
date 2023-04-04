using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private int counterValue = 0;
        public UserControl1()
        {
            InitializeComponent(); 
            btnIncrement.Click += new EventHandler(btnIncrement_Click);
            btnDecrement.Click += new EventHandler(btnDecrement_Click);
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            counterValue++;
            lblCounter.Text = counterValue.ToString();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            counterValue--;
            lblCounter.Text = counterValue.ToString();
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
