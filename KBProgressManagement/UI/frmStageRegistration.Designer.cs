namespace KBProgressManagement.UI
{
    partial class frmStageRegistration
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtProcessNameJP = new DevExpress.XtraEditors.TextEdit();
            this.txtProcessNameVN = new DevExpress.XtraEditors.TextEdit();
            this.txtProcessID = new DevExpress.XtraEditors.TextEdit();
            this.dgProcess = new DevExpress.XtraGrid.GridControl();
            this.gvProcess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessNameJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessNameVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.txtProcessNameJP);
            this.layoutControl1.Controls.Add(this.txtProcessNameVN);
            this.layoutControl1.Controls.Add(this.txtProcessID);
            this.layoutControl1.Controls.Add(this.dgProcess);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1392, 744);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.delete;
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(793, 75);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(317, 36);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.save__1_;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(282, 75);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 36);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.refresh;
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.Location = new System.Drawing.Point(1114, 75);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(268, 36);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Cancel_32x32;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(547, 75);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(242, 36);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Add_32x32;
            this.btnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNew.Location = new System.Drawing.Point(10, 75);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(268, 36);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Thêm";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtProcessNameJP
            // 
            this.txtProcessNameJP.Location = new System.Drawing.Point(914, 39);
            this.txtProcessNameJP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProcessNameJP.Name = "txtProcessNameJP";
            this.txtProcessNameJP.Size = new System.Drawing.Size(468, 32);
            this.txtProcessNameJP.StyleController = this.layoutControl1;
            this.txtProcessNameJP.TabIndex = 7;
            // 
            // txtProcessNameVN
            // 
            this.txtProcessNameVN.Location = new System.Drawing.Point(447, 39);
            this.txtProcessNameVN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProcessNameVN.Name = "txtProcessNameVN";
            this.txtProcessNameVN.Size = new System.Drawing.Size(463, 32);
            this.txtProcessNameVN.StyleController = this.layoutControl1;
            this.txtProcessNameVN.TabIndex = 6;
            // 
            // txtProcessID
            // 
            this.txtProcessID.Location = new System.Drawing.Point(10, 39);
            this.txtProcessID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProcessID.Name = "txtProcessID";
            this.txtProcessID.Size = new System.Drawing.Size(433, 32);
            this.txtProcessID.StyleController = this.layoutControl1;
            this.txtProcessID.TabIndex = 5;
            // 
            // dgProcess
            // 
            this.dgProcess.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgProcess.Location = new System.Drawing.Point(10, 115);
            this.dgProcess.MainView = this.gvProcess;
            this.dgProcess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgProcess.Name = "dgProcess";
            this.dgProcess.Size = new System.Drawing.Size(1372, 617);
            this.dgProcess.TabIndex = 4;
            this.dgProcess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProcess});
            // 
            // gvProcess
            // 
            this.gvProcess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcessID,
            this.colProcessNameVN,
            this.colProcessNameJP});
            this.gvProcess.DetailHeight = 337;
            this.gvProcess.GridControl = this.dgProcess;
            this.gvProcess.Name = "gvProcess";
            this.gvProcess.OptionsBehavior.Editable = false;
            this.gvProcess.OptionsEditForm.PopupEditFormWidth = 615;
            this.gvProcess.OptionsSelection.MultiSelect = true;
            this.gvProcess.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colProcessID
            // 
            this.colProcessID.Caption = "Mã Công Đoạn";
            this.colProcessID.FieldName = "ProcessID";
            this.colProcessID.MinWidth = 19;
            this.colProcessID.Name = "colProcessID";
            this.colProcessID.Visible = true;
            this.colProcessID.VisibleIndex = 1;
            this.colProcessID.Width = 72;
            // 
            // colProcessNameVN
            // 
            this.colProcessNameVN.Caption = "Tên Công Đoạn (Tiếng Việt)";
            this.colProcessNameVN.FieldName = "ProcessNameVN";
            this.colProcessNameVN.MinWidth = 19;
            this.colProcessNameVN.Name = "colProcessNameVN";
            this.colProcessNameVN.Visible = true;
            this.colProcessNameVN.VisibleIndex = 2;
            this.colProcessNameVN.Width = 72;
            // 
            // colProcessNameJP
            // 
            this.colProcessNameJP.Caption = "Tên Công Đoạn (Tiếng Nhật)";
            this.colProcessNameJP.FieldName = "ProcessNameJP";
            this.colProcessNameJP.MinWidth = 19;
            this.colProcessNameJP.Name = "colProcessNameJP";
            this.colProcessNameJP.Visible = true;
            this.colProcessNameJP.VisibleIndex = 3;
            this.colProcessNameJP.Width = 72;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1392, 744);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgProcess;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1376, 621);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.txtProcessID;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(437, 63);
            this.layoutControlItem2.Text = "Mã Công Đoạn";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(223, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.txtProcessNameVN;
            this.layoutControlItem3.Location = new System.Drawing.Point(437, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(467, 63);
            this.layoutControlItem3.Text = "Tên Công Đoạn(Tiếng Việt)";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(223, 25);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.txtProcessNameJP;
            this.layoutControlItem4.Location = new System.Drawing.Point(904, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(472, 63);
            this.layoutControlItem4.Text = "Tên Công Đoạn (Tiếng Nhật)";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(223, 25);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNew;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(272, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(537, 63);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(246, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnRefresh;
            this.layoutControlItem7.Location = new System.Drawing.Point(1104, 63);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(272, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(272, 63);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(265, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnDelete;
            this.layoutControlItem9.Location = new System.Drawing.Point(783, 63);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(321, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // frmStageRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 744);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmStageRegistration";
            this.Text = "Quản lí công đoạn";
            this.Load += new System.EventHandler(this.frmStageRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessNameJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessNameVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.TextEdit txtProcessNameJP;
        private DevExpress.XtraEditors.TextEdit txtProcessNameVN;
        private DevExpress.XtraEditors.TextEdit txtProcessID;
        private DevExpress.XtraGrid.GridControl dgProcess;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProcess;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameJP;
    }
}