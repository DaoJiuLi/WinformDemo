namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
    {
        //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblCounter;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.btnIncrement.Location = new System.Drawing.Point(55, 23);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(75, 23);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "Increment";

            this.btnDecrement.Location = new System.Drawing.Point(55, 59);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(75, 23);
            this.btnDecrement.TabIndex = 1;
            this.btnDecrement.Text = "Decrement";

            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(67, 95);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.Text = "0";

            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.lblCounter);
            this.Name = "CounterControl";
            this.Size = new System.Drawing.Size(178, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
