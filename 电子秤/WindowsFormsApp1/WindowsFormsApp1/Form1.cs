using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;  // 串口对象
        public Form1()
        {
            InitializeComponent();

            // 初始化串口对象
            serialPort = new SerialPort();
            serialPort.PortName = "COM1";  // 电子秤连接的串口号
            serialPort.BaudRate = 9600;   // 串口波特率
            serialPort.Parity = Parity.None;  // 校验位
            serialPort.DataBits = 8;      // 数据位
            serialPort.StopBits = StopBits.One;  // 停止位
        }
        // 打开串口连接
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    txtResult.Text = "串口连接已打开";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 关闭串口连接
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    txtResult.Text = "串口连接已关闭";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 发送数据
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // 发送数据
                    serialPort.Write(txtSen.Text);

                    // 等待响应
                    string response = serialPort.ReadLine();

                    // 显示响应
                    txtResult.Text = "响应数据为：" + response;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
