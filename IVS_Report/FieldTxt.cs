using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IVS_Report
{
    public partial class FieldTxt : UserControl
    {
        

        public FieldTxt()
        {
            InitializeComponent();
        }


        [Description("显示的文本"), Category("自定义属性")]
        public string HeadText
        {
            get
            {
                return labHead.Text;
            }
            set
            {
                labHead.Text = value;
                this.Invalidate();
            }
        }
        
        [Description("输入框的值"), Category("自定义属性")]
        public override string Text
        {
            get
            {
                return txtValue.Text;
            }
            set
            {
                txtValue.Text = value;
                this.Invalidate();
            }
        }
    }
}
