using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using UserTools;
using IBLL;
using System.IO;

namespace IVS_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();

                LoadForm();

                LOGIN_VEHICLE_INFO_Entity entity = new LOGIN_VEHICLE_INFO_Entity();

                IRESULT_VEHICLE_INFO_BLL bll = ObjectFactory.CreateObject<IRESULT_VEHICLE_INFO_BLL>();
                dgvMain.DataSource = bll.GetVehicleResultDataSet().Tables[0];
                dgvMain.Columns[0].Width = 50;
                dgvMain.Columns[1].Width = 300;
                dgvMain.Columns[2].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForm()
        {
            if (!System.IO.File.Exists("DBConfig.txt"))
            {
                txtServer.Text = ".";
                txtUser.Text = "sa";
                txtPwd.Text = "123456";
                txtDB.Text = "IVS_BJXY";                     
            }
            else
            {
                string str = System.IO.File.ReadAllText("DBConfig.txt");
                string[] s = str.Split(';');
                foreach (string item in s)
                {
                    string[] s1 = item.Split('=');
                    if (s1[0].Trim() == "Server")
                        txtServer.Text = s1[1].Trim();
                    else if(s1[0].Trim() == "User Id")
                        txtUser.Text = s1[1].Trim();
                    else if (s1[0].Trim() == "Password")
                        txtPwd.Text = s1[1].Trim();
                    else if (s1[0].Trim() == "Initial Catalog")
                        txtDB.Text = s1[1].Trim();
                }   
            }
            ConnectionDataBase();

        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            string strJCLSH = (string)dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[1].Value;

            ValueForm form = new ValueForm(strJCLSH);
            form.ShowDialog(this);

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            ConnectionDataBase();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void ConnectionDataBase()
        {
            string strConnection = string.Format("Server = {0};User Id = {1}; Password = {2};Initial Catalog = {3}", txtServer.Text.Trim(), txtUser.Text.Trim(), txtPwd.Text.Trim(),txtDB.Text.Trim());
            SqlHelper.ConnectStr = strConnection;
            File.WriteAllText("DBConfig.txt", strConnection);

        }
    }



}
