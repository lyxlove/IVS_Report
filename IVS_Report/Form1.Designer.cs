namespace IVS_Report
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtDB = new IVS_Report.FieldTxt();
            this.txtPwd = new IVS_Report.FieldTxt();
            this.txtUser = new IVS_Report.FieldTxt();
            this.txtServer = new IVS_Report.FieldTxt();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 156);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(829, 464);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnection);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(590, 49);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtDB
            // 
            this.txtDB.HeadText = "DB";
            this.txtDB.Location = new System.Drawing.Point(271, 49);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(225, 26);
            this.txtDB.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.HeadText = "Pwd";
            this.txtPwd.Location = new System.Drawing.Point(6, 49);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(225, 26);
            this.txtPwd.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.HeadText = "User";
            this.txtUser.Location = new System.Drawing.Point(271, 17);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(225, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.HeadText = "Server";
            this.txtServer.Location = new System.Drawing.Point(6, 17);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(225, 26);
            this.txtServer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private FieldTxt txtServer;
        private FieldTxt txtDB;
        private FieldTxt txtPwd;
        private FieldTxt txtUser;
        private System.Windows.Forms.Button btnConnection;
    }
}

