
namespace ErWeiMa
{
    partial class frmDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbZhi = new System.Windows.Forms.TextBox();
            this.picTuPian = new System.Windows.Forms.PictureBox();
            this.btnShengCheng = new System.Windows.Forms.Button();
            this.btnBaoCun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTuPian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "二维码的值";
            // 
            // tbZhi
            // 
            this.tbZhi.Location = new System.Drawing.Point(137, 12);
            this.tbZhi.Name = "tbZhi";
            this.tbZhi.Size = new System.Drawing.Size(125, 25);
            this.tbZhi.TabIndex = 1;
            // 
            // picTuPian
            // 
            this.picTuPian.Location = new System.Drawing.Point(346, 33);
            this.picTuPian.Name = "picTuPian";
            this.picTuPian.Size = new System.Drawing.Size(400, 351);
            this.picTuPian.TabIndex = 2;
            this.picTuPian.TabStop = false;
            // 
            // btnShengCheng
            // 
            this.btnShengCheng.Location = new System.Drawing.Point(61, 165);
            this.btnShengCheng.Name = "btnShengCheng";
            this.btnShengCheng.Size = new System.Drawing.Size(75, 23);
            this.btnShengCheng.TabIndex = 3;
            this.btnShengCheng.Text = "生成";
            this.btnShengCheng.UseVisualStyleBackColor = true;
            this.btnShengCheng.Click += new System.EventHandler(this.btnShengCheng_Click);
            // 
            // btnBaoCun
            // 
            this.btnBaoCun.Enabled = false;
            this.btnBaoCun.Location = new System.Drawing.Point(61, 246);
            this.btnBaoCun.Name = "btnBaoCun";
            this.btnBaoCun.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCun.TabIndex = 4;
            this.btnBaoCun.Text = "保存";
            this.btnBaoCun.UseVisualStyleBackColor = true;
            this.btnBaoCun.Click += new System.EventHandler(this.btBaoCun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBaoCun);
            this.Controls.Add(this.btnShengCheng);
            this.Controls.Add(this.picTuPian);
            this.Controls.Add(this.tbZhi);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmDemo";
            this.Text = "二维码生成";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDemo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picTuPian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZhi;
        private System.Windows.Forms.PictureBox picTuPian;
        private System.Windows.Forms.Button btnShengCheng;
        private System.Windows.Forms.Button btnBaoCun;
        private System.Windows.Forms.Button button1;
    }
}