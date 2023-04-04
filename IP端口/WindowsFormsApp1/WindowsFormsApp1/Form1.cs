using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            // 获取本地主机的所有 IP 地址
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            // 遍历每个 IP 地址
            foreach (IPAddress ipAddress in localIPs)
            {
                // 检查地址族是否是 IPv4
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    // 打印出 IPv4 地址
                    textBox1.Text += ipAddress.ToString()+"\r\n";
                }
            }
            ////获取本机端口号
            //int port = ((IPEndPoint)tcpListener.LocalEndpoint).Port;
            //// 打印
            //textBox1.Text += port.ToString() + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            //获取所有TCP连接
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = ipGlobalProperties.GetActiveTcpConnections();

            //获取所有TCP监听器
            IPEndPoint[] tcpListeners = ipGlobalProperties.GetActiveTcpListeners();

            //查找正在使用的本地端口
            foreach (TcpConnectionInformation info in tcpConnections)
            {
                if (info.LocalEndPoint.Address.Equals(IPAddress.Parse("127.0.0.1")))
                {
                    textBox2.Text += info.LocalEndPoint.Port.ToString() + "\r\n";
                }
            }

            foreach (IPEndPoint endpoint in tcpListeners)
            {
                if (endpoint.Address.Equals(IPAddress.Parse("127.0.0.1")))
                {
                    Console.WriteLine("正在使用的本机端口：" + endpoint.Port.ToString());
                    textBox2.Text += endpoint.Port.ToString() + "\r\n";
                }
            }
        }
    }
}
