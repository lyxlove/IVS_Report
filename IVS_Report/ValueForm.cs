using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;
using UserTools;
using IBLL;
using System.Reflection;
using System.IO;

namespace IVS_Report
{
    public partial class ValueForm : Form
    {
        public ValueForm(string strJCLSH)
        {
            InitializeComponent();
         
            LoadBaseData(strJCLSH); 
            LoadBrakeData(strJCLSH);

            combJCXType.Items.Add(new JCXType(1));
            combJCXType.Items.Add(new JCXType(2));



            #region 灯光
            LoadLampData(strJCLSH);
            #endregion
        }


        private string m_RowTag = "1";

        private RESULT_VEHICLE_INFO m_RESULT_VEHICLE_INFO = null;
        private RESULT_BRAKE m_RESULT_BRAKE = null;
        private RESULT_LAMP m_RESULT_LAMP = null;


        private void MarkRowTag(object sender,EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Tag != null && textBox.Tag.ToString().Split(',').Length > 0)
            {
                m_RowTag = textBox.Tag.ToString().Split(',')[0];
               // MessageBox.Show(m_RowTag);
            }
        }

        #region 制动
        private void LoadBrakeData(string strJCLSH)
        {
            IRESULT_BRAKE_BLL bll = ObjectFactory.CreateObject<IRESULT_BRAKE_BLL>();
            m_RESULT_BRAKE = bll.GetEntityByJCLSH(strJCLSH);

            PropertyInfo[] propertyInfo = m_RESULT_BRAKE.GetType().GetProperties();
            foreach (Control cols in tabBrake.Controls)
            {
                if (cols is TableLayoutPanel)
                {
                    foreach (Control col in cols.Controls)
                    {
                        if (col is TextBox)
                        {
                            TextBox textBox = (TextBox)col;
                            foreach (PropertyInfo p in propertyInfo)
                            {
                                if (p.Name == textBox.Name)
                                {
                                    textBox.TextChanged -= GetXCZDL;
                                    textBox.Text = Convert.ToString(p.GetValue(m_RESULT_BRAKE, null));
                                    textBox.TextChanged += GetXCZDL;
                                    textBox.Click += MarkRowTag;
                                }
                            }
                        }
                    }
                }

            }
        }
        private BreakeEntity breakeEntity = null;

        private void FillCalEntity()
        {
            breakeEntity = new BreakeEntity();
            PropertyInfo[] propertyInfos = breakeEntity.GetType().GetProperties();
            foreach (Control cols in tabBrake.Controls)
            {
                if (cols is TableLayoutPanel)
                {
                    foreach (Control col in cols.Controls)
                    {
                        if (col is TextBox)
                        {
                            TextBox textBox = (TextBox)col;
                            foreach (PropertyInfo p in propertyInfos)
                            {
                                if (textBox.Tag != null && textBox.Tag.ToString().Split(',').Length > 1)
                                {
                                    if (p.Name == textBox.Tag.ToString().Split(',')[1] && m_RowTag == textBox.Tag.ToString().Split(',')[0])
                                    {
                                        if (p.CanWrite)
                                        {
                                            try
                                            {
                                                p.SetValue(breakeEntity, Convert.ChangeType(textBox.Text, p.PropertyType), null);
                                            }
                                            catch (Exception ex)
                                            {
                                            }
                                        }
                                        
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        private void FillCalEntiyToConl()
        {
            PropertyInfo[] propertyInfo = breakeEntity.GetType().GetProperties();
            foreach (Control cols in tabBrake.Controls)
            {
                if (cols is TableLayoutPanel)
                {
                    foreach (Control col in cols.Controls)
                    {
                        if (col is TextBox)
                        {
                            TextBox textBox = (TextBox)col;
                            if (textBox.Tag != null && textBox.Tag.ToString().Split(',').Length > 1)
                            {
                                foreach (PropertyInfo p in propertyInfo)
                                {
                                    if (p.Name == textBox.Tag.ToString().Split(',')[1] && m_RowTag == textBox.Tag.ToString().Split(',')[0])
                                    {
                                        textBox.TextChanged -= GetXCZDL;
                                        textBox.Text = Convert.ToString(p.GetValue(breakeEntity, null));
                                        textBox.TextChanged += GetXCZDL;

                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
      
        private void SaveBrakeData()
        {
            IRESULT_BRAKE_BLL bll = ObjectFactory.CreateObject<IRESULT_BRAKE_BLL>();
            PropertyInfo[] propertyInfos = m_RESULT_BRAKE.GetType().GetProperties();
            foreach (Control cols in tabBrake.Controls)
            {
                if (cols is TableLayoutPanel)
                {
                    foreach (Control col in cols.Controls)
                    {
                        if (col is TextBox)
                        {
                            TextBox textBox = (TextBox)col;
                            foreach (PropertyInfo p in propertyInfos)
                            {
                                if (p.Name == textBox.Name)
                                {
                                    p.SetValue(m_RESULT_BRAKE, Convert.ChangeType(textBox.Text, p.PropertyType), null);
                                }
                            }
                        }

                    }
                }
            }
            if (bll.UpdateResultBrakeEntity(m_RESULT_BRAKE))
                MessageBox.Show("更新成功");
            else
                MessageBox.Show("更新失败");
        }

        private void btnSaveBrake_Click(object sender, EventArgs e)
        {
            SaveBrakeData();
        }

        private void CalBPHL()
        {
           
        }

        private void GetEntity()
        {

        }

        private void GetXCZDL(object sender, EventArgs e)
        {
            FillCalEntity();
            FillCalEntiyToConl();
            //YZZDLV.Text = Math.Round(GetXCZDL(GetDecimalFormTextBox(YZZDTLH), GetDecimalFormTextBox(YZYDTLH), GetDecimalFormTextBox(YZZZDZDL), GetDecimalFormTextBox(YZYZDZDL)) * 100, 1).ToString();
        }

        private double GetXCZDL(double dZLH, double dYLH, double dZZDXCZDL, double dYZDXCZDL)
        {
            if((dZLH + dYLH) == 0)
            {
                return 0;
            }
            return (dZZDXCZDL + dYZDXCZDL) / (0.98 * (dZLH + dYLH));
        }

        private double GetDecimalFormTextBox(TextBox textBox)
        {
            Double d = 0;
            if(!Double.TryParse(textBox.Text,out d))
            {
                return 0;
            }
            return d;
        }
        #endregion

        #region 基础信息
        public void LoadBaseData(string strJCLSH)
        {
            IRESULT_VEHICLE_INFO_BLL bll = ObjectFactory.CreateObject<IRESULT_VEHICLE_INFO_BLL>();
            m_RESULT_VEHICLE_INFO = bll.GetResultVehicleInfoByJCLSH(strJCLSH);
            PropertyInfo[] propertyInfo = m_RESULT_VEHICLE_INFO.GetType().GetProperties();
            foreach (Control col in tabBase.Controls)
            {
                if (col is FieldTxt)
                {
                    FieldTxt fieldTxt = (FieldTxt)col;
                    foreach (PropertyInfo p in propertyInfo)
                    {
                        if (p.Name == fieldTxt.Name.Replace("txt", ""))
                        {
                            fieldTxt.Text = (string)p.GetValue(m_RESULT_VEHICLE_INFO, null);
                        }
                    }

                }
            }


        }

        public void SaveBaseData()
        {
            PropertyInfo[] propertyInfos = m_RESULT_VEHICLE_INFO.GetType().GetProperties();
            foreach (Control col in tabBase.Controls)
            {
                if (col is FieldTxt)
                {
                    FieldTxt fieldTxt = (FieldTxt)col;
                    foreach (PropertyInfo p in propertyInfos)
                    {
                        if (p.Name == fieldTxt.Name.Replace("txt", ""))
                        {
                            p.SetValue(m_RESULT_VEHICLE_INFO,Convert.ChangeType(fieldTxt.Text,p.PropertyType), null);
                        }
                    }

                }
            }
            IRESULT_VEHICLE_INFO_BLL bll = ObjectFactory.CreateObject<IRESULT_VEHICLE_INFO_BLL>();
            bll.UpdateResultVehicleInfo(m_RESULT_VEHICLE_INFO);

        }

        private void btnSaveBase_Click(object sender, EventArgs e)
        {
            SaveBaseData();
        }

        #endregion

        private void fieldTxt17_Load(object sender, EventArgs e)
        {

        }

        #region 转换
        private void btnChange_Click(object sender, EventArgs e)
        {
            string strSource = new System.Text.RegularExpressions.Regex("\\s+").Replace(rtbTxtName.Text, ",");

            string[] s = strSource.Split(',');

            //for (int i = 0; i < s.Length; i++)
            //{
            //    string str = s[i].ToString();
            //    str = str.Replace("ZWD", "");
            //    str = str.Replace("ZND", "");
            //    str = str.Replace("YWD", "");
            //    str = str.Replace("YND", "");
            //    s[i] += " = " + str;
            //}

            //System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex();


            string strKey = txtChangValue.Text.Trim();


            List<string> list = s.ToList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (!list[i].Contains(strKey))
                {
                    list.Remove(list[i]);

                }
                else
                {
                    list[i].Replace(strKey, "");
                }
                if (i == 0)
                {
                    int j = 0;
                }
            }

            string strResult = string.Join(",", list);
            rtbTxtResult.Text = strResult.Replace(strKey, "");
            //rtbTxtResult.Text = string.Join(",",s); ;
        }
        #endregion

        #region 灯光
        private int mColNum = 10;
        private int mRowNum = 5;
        private void LoadLampData(string strJCLSH)
        {
            #region 创建表格
            string strField = File.ReadAllText("灯光字段.txt", Encoding.UTF8);
            string strFieldValue = File.ReadAllText("灯光列.txt", Encoding.UTF8);
            string[] fields = strField.Split(',');
            string[] fieldValues = strFieldValue.Split(',');
            int index = 0;
            List<List<Tuple<string, string>>> listNames = new List<List<Tuple<string, string>>>();
            List<Tuple<string, string>> tuples = new List<Tuple<string, string>>();
           // List<string> list = new List<string>();
            for (int i = 0; i < fields.Length; i++)
            {
              
                if (!(index < 9))
                {
                    listNames.Add(tuples);
                    tuples = new List<Tuple<string, string>>();
                    index = 0;
                }
                tuples.Add(new Tuple<string, string>(fields[i], fieldValues[i]));
                if(i == fields.Length -1)
                {
                    listNames.Add(tuples);
                }
                index++;

            }
            int rowNum = listNames.Count; //fields.Length % 10 == 0 ? (int)fields.Length / 10 : (int)fields.Length / 10 + 1;



            List<TableLayoutPanel> layoutPanels = new List<TableLayoutPanel>();
            if (rowNum > 0)
            {
                for (int i = 0; i < rowNum; i++)
                {
                    List<string> dgNameList = new List<string>();
                    dgNameList.Add("左外灯");
                    dgNameList.Add("左内灯");
                    dgNameList.Add("右外灯");
                    dgNameList.Add("右内灯");
                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.Name = "lampTbale" + i;
                    //tableLayoutPanel.Size = new Size(lampLayout.Size.Width -100, 150);
                    tableLayoutPanel.RowCount = mRowNum;
                    tableLayoutPanel.ColumnCount = mColNum;
                    tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    tableLayoutPanel.Dock = DockStyle.Fill;
                    for (int x = 0; x < dgNameList.Count; x++)
                    {
                        Label label = new Label();
                        label.Text = dgNameList[x];
                        label.Dock = DockStyle.Fill;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel.Controls.Add(label, 0, x + 1);
                    }

                    for (int j = 0; j < tableLayoutPanel.RowCount; j++)
                    {
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    }
                    for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                    {
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    }
                    int iCol = 1;

                    List<string> dgList = new List<string>();
                    dgList.Add("ZWD");
                    dgList.Add("ZND");
                    dgList.Add("YWD");
                    dgList.Add("YND");
                
                    foreach (var item in listNames[i])
                    {
                        Label label = new Label();
                        label.Text = item.Item1;
                        label.Dock = DockStyle.Fill;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Font = new Font("微软雅黑",8f);
                        tableLayoutPanel.Controls.Add(label, iCol, 0);

                        for(int t = 1;t<5;t++)
                        {
                            TextBox textBox = new TextBox();

                            textBox.Name = item.Item2 != "DGJCCS" ? dgList[t - 1] + item.Item2 : "DG" + dgList[t - 1] + "JCCS";
                            textBox.TextAlign = HorizontalAlignment.Center;
                            textBox.BorderStyle = BorderStyle.None;
                            textBox.Dock = DockStyle.Fill;
                            textBox.Tag = t.ToString() + "," + item.Item2;
                            tableLayoutPanel.Controls.Add(textBox, iCol, t);
                        }
                        iCol++;
                    }
                    lampLayout.Controls.Add(tableLayoutPanel);

                }
            }
            #endregion


            #region 加载数据

            IRESULT_LAMP_BLL bll = ObjectFactory.CreateObject<IRESULT_LAMP_BLL>();
            m_RESULT_LAMP = bll.GetEntityByJCLSH(strJCLSH);
            PropertyInfo[] propertyInfo = m_RESULT_LAMP.GetType().GetProperties();
            foreach (Control cols in tabLamp.Controls)
            {
                if (cols is TableLayoutPanel)
                {
                    foreach (Control colLayout in cols.Controls)
                    {
                        if (colLayout is TableLayoutPanel)
                        {
                            foreach (Control col in colLayout.Controls)
                            {
                                if (col is TextBox)
                                {
                                    TextBox textBox = (TextBox)col;
                                    foreach (PropertyInfo p in propertyInfo)
                                    {
                                        if (p.Name == textBox.Name)
                                        {

                                            textBox.Text = Convert.ToString(p.GetValue(m_RESULT_LAMP, null));

                                            textBox.Click += MarkRowTag;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            #endregion


        }
        #endregion

        private void EZYZDZDL_TextChanged(object sender, EventArgs e)
        {

        }
    }


    public class JCXType
    {
        public int Type;
        public JCXType(int type)
        {
            this.Type = type;
        }
        public override string ToString()
        {
            return Type == 1 ? "滚筒" : "平板";
        }
    }

}
