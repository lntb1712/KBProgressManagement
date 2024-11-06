using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using KBProgressManagement.DAO;
using KBProgressManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBProgressManagement.UI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DXValidationProvider dxValidationProvider = new DXValidationProvider();

        DataTable UserLogin = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
            dxValidationProvider.ValidationMode = ValidationMode.Manual;
            InitValidationRules();
        }
        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Vui lòng nhập thông tin";

            dxValidationProvider.SetValidationRule(txtUserName, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtUserName, ErrorIconAlignment.MiddleRight);

            dxValidationProvider.SetValidationRule(txtPassword, notEmptyValidationRule);
            dxValidationProvider.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (dxValidationProvider.Validate() == false)
            {
                return;
            }

            string Username = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();


            UserLogin = AccountManagementDAO.Instance.GetAccountLogin(Username, Password);
            if (UserLogin.Rows.Count > 0)
            {

                Properties.Settings.Default.Username = UserLogin.Rows[0]["UserID"].ToString();
                Properties.Settings.Default.GroupID = UserLogin.Rows[0]["GroupID"].ToString();
                Properties.Settings.Default.FullName = UserLogin.Rows[0]["FullName"].ToString();
                Properties.Settings.Default.Save();
                if (chkRememberPassword.Checked == true)
                {
                    //int bit = Convert.ToInt32(chkRemember.Enabled);
                    //SaveLastLog(username, password, bit);
                    Properties.Settings.Default.Username = txtUserName.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else if (chkRememberPassword.Checked == false)
                {
                    Properties.Settings.Default.Username = txtUserName.Text;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.Save();
                }
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Username or Password invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            if(txtPassword.Text.Equals(""))
            {
                chkRememberPassword.Checked = false;
            }
            else
            {
                chkRememberPassword.Checked = true;
            }

            if (DataProvider.ReadConfig() == false)
            {
                XtraMessageBox.Show("Please config database connection! \nVui lòng thiết lập kết nối cơ sở dữ liệu", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ConnectionString = "Data Source=" + SQLConfig.ServerName + ";Initial Catalog=" + SQLConfig.DBName + ";User ID=" + SQLConfig.LoginName + ";Password=" + SQLConfig.Password;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Vui lòng thiết lập kết nối cơ sở dữ liệu \n" + ex.ToString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}