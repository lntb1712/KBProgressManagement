using DevExpress.XtraEditors;
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
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";User ID=" + txtUserName.Text.Trim() + ";Password=" + txtPassword.Text.Trim();
            SqlConnection CheckConnect = new SqlConnection(connectionString);
            try
            {
                CheckConnect.Open();
                if (CheckConnect.State == ConnectionState.Open)
                {
                    XtraMessageBox.Show("Connect successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Connect failed! Please check your setting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                CheckConnect.Close();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (DataProvider.ReadConfig())
            {
                txtServerName.Text = SQLConfig.ServerName;
                txtDatabase.Text = SQLConfig.DBName;
                txtUserName.Text = SQLConfig.LoginName;
                txtPassword.Text = SQLConfig.Password;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";User ID=" + txtUserName.Text.Trim() + ";Password=" + txtPassword.Text.Trim();
            SqlConnection CheckConnect = new SqlConnection(connectionString);
            try
            {
                CheckConnect.Open();
                if (CheckConnect.State == ConnectionState.Open)
                {
                    bool Writeconfig = DataProvider.WriteConfig(txtServerName.Text.Trim(), txtDatabase.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text.Trim());
                    if (!Writeconfig)
                    {
                        XtraMessageBox.Show("Connect failed! Please check your setting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    DataProvider.ReadConfig();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Connect failed! Please check your setting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                CheckConnect.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();
            string databaseName = txtDatabase.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            DataProvider.ReadConfig();

            if (!serverName.Equals(SQLConfig.ServerName) || !databaseName.Equals(SQLConfig.DBName) || !userName.Equals(SQLConfig.LoginName) || !password.Equals(SQLConfig.Password))
            {
                if (XtraMessageBox.Show("Bạn chưa lưu thông tin chỉnh sửa. Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}