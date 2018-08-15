namespace IVS_Report
{
    partial class FieldTxt
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labHead = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Location = new System.Drawing.Point(3, 6);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(41, 12);
            this.labHead.TabIndex = 0;
            this.labHead.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(63, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(159, 21);
            this.txtValue.TabIndex = 1;
            // 
            // FieldTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.labHead);
            this.Name = "FieldTxt";
            this.Size = new System.Drawing.Size(225, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHead;
        private System.Windows.Forms.TextBox txtValue;
    }
}
