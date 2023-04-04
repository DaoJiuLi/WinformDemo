namespace ExeclDemo
{
    partial class Form1
    {
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecexlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_execlDataSet = new ExeclDemo.tb_execlDataSet();
            this.tbUserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report1 = new FastReport.Report();
            this.ecexlTableAdapter = new ExeclDemo.tb_execlDataSetTableAdapters.ecexlTableAdapter();
            this.ecexlTableAdapter1 = new ExeclDemo.tb_execlDataSetTableAdapters.ecexlTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecexlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_execlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(43, 24);
            this.toolStripButton2.Text = "导出";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel1.Text = "导入";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel2.Text = "打印";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel3.Text = "导出";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.姓名,
            this.年龄});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 423);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "name";
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 6;
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 年龄
            // 
            this.年龄.DataPropertyName = "age";
            this.年龄.HeaderText = "年龄";
            this.年龄.MinimumWidth = 6;
            this.年龄.Name = "年龄";
            this.年龄.ReadOnly = true;
            // 
            // ecexlBindingSource
            // 
            this.ecexlBindingSource.DataMember = "ecexl";
            this.ecexlBindingSource.DataSource = this.tb_execlDataSet;
            // 
            // tb_execlDataSet
            // 
            this.tb_execlDataSet.DataSetName = "tb_execlDataSet";
            this.tb_execlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUserInfoBindingSource
            // 
            this.tbUserInfoBindingSource.DataMember = "tb_UserInfo";
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.tb_execlDataSet, "tb_execlDataSet");
            // 
            // ecexlTableAdapter
            // 
            this.ecexlTableAdapter.ClearBeforeFill = true;
            // 
            // ecexlTableAdapter1
            // 
            this.ecexlTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecexlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_execlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private FastReport.Report report1;
        //private ZJ_NB_RXJXCCPKGLDataSet zJ_NB_RXJXCCPKGLDataSet;
        private System.Windows.Forms.BindingSource tbUserInfoBindingSource;
        private tb_execlDataSet tb_execlDataSet;
        private System.Windows.Forms.BindingSource ecexlBindingSource;
        private tb_execlDataSetTableAdapters.ecexlTableAdapter ecexlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄;
        private tb_execlDataSetTableAdapters.ecexlTableAdapter ecexlTableAdapter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        //private ZJ_NB_RXJXCCPKGLDataSetTableAdapters.tb_UserInfoTableAdapter tb_UserInfoTableAdapter;
    }
}

