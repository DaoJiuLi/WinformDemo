using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace ErWeiMa
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShengCheng_Click(object sender, EventArgs e)
        {
            #region  QRCoder包的
            // 获取要生成二维码的文本
            string text = tbZhi.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入二维码内容！");
                return;
            }
            // 创建QRCode生成器对象
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            // 根据文本创建QRCode数据矩阵
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            // 创建QRCode码图像
            QRCode qrCode = new QRCode(qrCodeData);
            // 将QRCode码图像转换为Bitmap图像
            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            // 显示QRCode码图像
            picTuPian.Image = qrCodeImage;
            // 启用保存二维码按钮
            btnBaoCun.Enabled = true;
            #endregion
            ////获取二维码内容
            //string content = tbZhi.Text.Trim();
            ////如果内容为空则提示并返回
            //if (string.IsNullOrEmpty(content))
            //{
            //    MessageBox.Show("请输入二维码内容！");
            //    return;
            //}
            ////生成二维码图片
            //BarcodeWriter writer = new BarcodeWriter()
            //{
            //    Format = BarcodeFormat.QR_CODE,
            //    Options = new ZXing.Common.EncodingOptions
            //    {
            //        Width = 300,
            //        Height = 300,
            //        Margin = 1
            //    }
            //};
            //Bitmap bitmap = writer.Write(content);
            ////显示二维码图片
            //picTuPian.Image = bitmap;
            //btnBaoCun.Enabled = true;
        }

        /// <summary>
        /// 保存二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBaoCun_Click(object sender, EventArgs e)
        {
            // 创建SaveFileDialog对象
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG图像 (*.png)|*.png";
            // 显示SaveFileDialog对话框
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // 获取要保存的文件名
                string fileName = saveFileDialog.FileName;
                // 获取要保存的QRCode码图像
                Bitmap qrCodeImage = (Bitmap)picTuPian.Image;
                // 保存QRCode码图像
                qrCodeImage.Save(fileName, ImageFormat.Png);
                // 提示用户保存成功
                MessageBox.Show("保存成功！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 选择二维码解码
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    Bitmap bitmap = new Bitmap(openFileDialog.FileName);
            //    BarcodeReader barcodeReader = new BarcodeReader();
            //    Result result = barcodeReader.Decode(bitmap);
            //    if (result != null)
            //    {
            //        MessageBox.Show(result.Text, "解码成功");
            //    }
            //    else
            //    {
            //        MessageBox.Show("未能识别二维码", "解码失败");
            //    }
            //}
            #endregion
            //解码生成的图片
            Bitmap bitmap = (Bitmap)picTuPian.Image;
            BarcodeReader barcodeReader = new BarcodeReader();
            barcodeReader.Options.CharacterSet = "UTF-8"; // 设置字符集为UTF-8，支持中文解码
            Result result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                MessageBox.Show(result.Text, "解码成功");
            }
            else
            {
                MessageBox.Show("未能识别二维码", "解码失败");
            }
        }

        private void frmDemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 按下ctrl和s时
            {
                string code = "dayudgauyg";
                MessageBox.Show(code);
            }

        }
    }
}
