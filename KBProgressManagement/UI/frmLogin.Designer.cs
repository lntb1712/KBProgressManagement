namespace KBProgressManagement.UI
{
    partial class frmLogin
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.cboRememberPassword = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRememberPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Location = new System.Drawing.Point(14, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(371, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Location = new System.Drawing.Point(14, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(371, 35);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 204);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 144);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 21);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên Đăng Nhập";
            // 
            // btnSetting
            // 
            this.btnSetting.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Appearance.Options.UseBackColor = true;
            this.btnSetting.Appearance.Options.UseForeColor = true;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.setting_64;
            this.btnSetting.Location = new System.Drawing.Point(313, 391);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSetting.Size = new System.Drawing.Size(72, 50);
            this.btnSetting.TabIndex = 15;
            // 
            // cboRememberPassword
            // 
            this.cboRememberPassword.Location = new System.Drawing.Point(256, 265);
            this.cboRememberPassword.Name = "cboRememberPassword";
            this.cboRememberPassword.Properties.Caption = "Ghi nhớ mật khẩu";
            this.cboRememberPassword.Size = new System.Drawing.Size(129, 24);
            this.cboRememberPassword.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(372, 28);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(13, 171);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(372, 28);
            this.txtUserName.TabIndex = 11;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::KBProgressManagement.Properties.Resources.logo;
            this.pictureEdit1.Location = new System.Drawing.Point(123, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 128);
            this.pictureEdit1.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 463);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboRememberPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.IconOptions.Image = global::KBProgressManagement.Properties.Resources.logo;
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.cboRememberPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSetting;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.CheckEdit cboRememberPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}