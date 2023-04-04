using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 写
        /// </summary>
        /// <param name="filePath"></param>
        private void WriteBinaryFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite)) // 创建一个文件流，用于写入二进制文件
            using (BinaryWriter writer = new BinaryWriter(fileStream, Encoding.UTF8)) // 创建一个二进制写入器，用于向文件中写入数据
            {
                int intValue = 123; // 整型数据
                double doubleValue = 3.14; // 浮点型数据
                string stringValue = "你好世界Hello,Wolrd"; // 字符串数据

                writer.Write(intValue); // 向文件中写入整型数据
                writer.Write(doubleValue); // 向文件中写入浮点型数据
                writer.Write(stringValue); // 向文件中写入字符串数据
            }
        }

        /// <summary>
        /// 读
        /// </summary>
        /// <param name="filePath"></param>
        private void ReadBinaryFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) // 创建一个文件流，用于读取二进制文件
            using (BinaryReader reader = new BinaryReader(fileStream, Encoding.UTF8)) // 创建一个二进制读取器，用于从文件中读取数据
            {
                int intValue = reader.ReadInt32(); // 从文件中读取整型数据
                double doubleValue = reader.ReadDouble(); // 从文件中读取浮点型数据
                string stringValue = reader.ReadString(); // 从文件中读取字符串数据

                MessageBox.Show($"Int value: {intValue}, Double value: {doubleValue}, String value: {stringValue}"); // 在消息框中显示读取到的数据
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // 创建一个保存文件对话框
            saveFileDialog.Filter = "Binary files (*.txt)|*.txt"; // 设置文件类型过滤器

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // 显示保存文件对话框，并判断用户是否点击了“确定”按钮
            {
                WriteBinaryFile(saveFileDialog.FileName); // 将数据写入指定的二进制文件
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // 创建一个打开文件对话框
            openFileDialog.Filter = "Binary files (*.txt)|*.txt"; // 设置文件类型过滤器

            if (openFileDialog.ShowDialog() == DialogResult.OK) // 显示打开文件对话框，并判断用户是否点击了“确定”按钮
            {
                ReadBinaryFile(openFileDialog.FileName); // 从指定的二进制文件中读取数据
            }
        }
        //C:\\Users\\30699\\Desktop\\data.bin
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\BinaryStreamTest.bin", FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs, Encoding.ASCII);

            //以二进制方式向创建的文件中写入内容 
            //w.Write(666);                   //  整型
            //w.Write(66.6f);                // 浮点型
            //w.Write(6.66);                // double型
            //w.Write(true);                 // 布尔型
            w.Write("六六六");         // 字符串型

            w.Close();
            fs.Close();

            //    // 打开一个文件流，用于写入二进制文件
            //    using (FileStream fs = new FileStream("C:\\Users\\30699\\Desktop\\data.bin", FileMode.Create))
            //    {

            //        using (BinaryWriter writer = new BinaryWriter(fs))
            //        {
            //            // 写入一个字符串的字节数组
            //            byte[] bytes = Encoding.UTF8.GetBytes("Hello, world!");
            //            writer.Write(bytes);
            //        }
            //    }
        }
    }
}
