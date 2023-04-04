using Demo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            // 初始化串口对象
            serialPort1.Close();
            serialPort1.PortName = "COM1"; // 设置串口号
            serialPort1.BaudRate = 9600; // 设置波特率
            serialPort1.Parity = Parity.None; // 设置校验位
            serialPort1.DataBits = 8; // 设置数据位
            serialPort1.StopBits = StopBits.One; // 设置停止位
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); // 注册数据接收事件
            serialPort1.Open(); // 打开串口
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private string dataBuffer = string.Empty; // 数据缓冲区
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 读取接收到的数据
            string data = serialPort1.ReadExisting();
            // 将数据添加到缓冲区
            dataBuffer += data;
            // 判断缓冲区是否包含完整数据
            if (dataBuffer.Contains("\r\n"))
            {
                // 从缓冲区中提取完整数据
                string barcode = dataBuffer.Substring(0, dataBuffer.IndexOf("\r\n"));
                // 处理条码数据
                ProcessBarcode(barcode);
                // 清空缓冲区
                dataBuffer = string.Empty;
            }
        }

        //private void ProcessBarcode(string barcode)
        //{
        //    // 在此处编写条码数据处理代码
        //    // 可以将条码数据添加到数据源，更新UI等操作
        //}


        private void ProcessBarcode(string barcode)
        {
            // 在此处编写条码数据处理代码
            // 可以将条码数据添加到数据源，更新UI等操作
            // 在UI线程中更新数据
            Invoke(new Action(() =>
            {
                // 更新UI控件
                textBox1.Text = barcode;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string Namea = "Demo.Data.text";
            MessageBox.Show(AssemblyName);
            MessageBox.Show(Namea);
            object qwe= (textqwe)Assembly.Load(AssemblyName).CreateInstance(Namea);
            MessageBox.Show(qwe.ToString());
        }

        

        private void Dis(object sender, EventArgs e)
        {
            DDiiss();
        }

        private textqwe DDiiss()
        {
            string AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string Namea = "Demo.Data.text";
            textBox1.Text= (string)Assembly.Load(AssemblyName).CreateInstance(Namea);
            return (textqwe)Assembly.Load(AssemblyName).CreateInstance(Namea);
        }
    }
}
