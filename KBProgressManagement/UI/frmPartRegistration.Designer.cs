namespace KBProgressManagement.UI
{
    partial class frmPartRegistration
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxQty = new DevExpress.XtraEditors.TextEdit();
            this.txtPartNameVN = new DevExpress.XtraEditors.TextEdit();
            this.txtPartNameJP = new DevExpress.XtraEditors.TextEdit();
            this.txtPartCode = new DevExpress.XtraEditors.TextEdit();
            this.dgProcess = new DevExpress.XtraGrid.GridControl();
            this.gvProcess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgPartRegistration = new DevExpress.XtraGrid.GridControl();
            this.gvPartRegistration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameVN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameJP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.txtBoxQty);
            this.layoutControl1.Controls.Add(this.txtPartNameVN);
            this.layoutControl1.Controls.Add(this.txtPartNameJP);
            this.layoutControl1.Controls.Add(this.txtPartCode);
            this.layoutControl1.Controls.Add(this.dgProcess);
            this.layoutControl1.Controls.Add(this.dgPartRegistration);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1779, 766);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.delete;
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(1034, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 36);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.refresh;
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.Location = new System.Drawing.Point(1390, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(377, 36);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Cancel_32x32;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(679, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(351, 36);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.save__1_;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(327, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(348, 36);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Add_32x32;
            this.btnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNew.Location = new System.Drawing.Point(12, 77);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(311, 36);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Thêm";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Location = new System.Drawing.Point(1298, 41);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(469, 32);
            this.txtBoxQty.StyleController = this.layoutControl1;
            this.txtBoxQty.TabIndex = 9;
            // 
            // txtPartNameVN
            // 
            this.txtPartNameVN.Location = new System.Drawing.Point(454, 41);
            this.txtPartNameVN.Name = "txtPartNameVN";
            this.txtPartNameVN.Size = new System.Drawing.Size(410, 32);
            this.txtPartNameVN.StyleController = this.layoutControl1;
            this.txtPartNameVN.TabIndex = 8;
            // 
            // txtPartNameJP
            // 
            this.txtPartNameJP.Location = new System.Drawing.Point(868, 41);
            this.txtPartNameJP.Name = "txtPartNameJP";
            this.txtPartNameJP.Size = new System.Drawing.Size(426, 32);
            this.txtPartNameJP.StyleController = this.layoutControl1;
            this.txtPartNameJP.TabIndex = 7;
            // 
            // txtPartCode
            // 
            this.txtPartCode.Location = new System.Drawing.Point(12, 41);
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.Size = new System.Drawing.Size(438, 32);
            this.txtPartCode.StyleController = this.layoutControl1;
            this.txtPartCode.TabIndex = 6;
            this.txtPartCode.TextChanged += new System.EventHandler(this.txtPartCode_TextChanged);
            // 
            // dgProcess
            // 
            this.dgProcess.Location = new System.Drawing.Point(12, 403);
            this.dgProcess.MainView = this.gvProcess;
            this.dgProcess.Name = "dgProcess";
            this.dgProcess.Size = new System.Drawing.Size(1755, 351);
            this.dgProcess.TabIndex = 5;
            this.dgProcess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProcess});
            // 
            // gvProcess
            // 
            this.gvProcess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcessID,
            this.colProcessNameVN,
            this.colProcessNameJP,
            this.colNumberProcess});
            this.gvProcess.GridControl = this.dgProcess;
            this.gvProcess.Name = "gvProcess";
            // 
            // colProcessID
            // 
            this.colProcessID.Caption = "Mã Công Đoạn ";
            this.colProcessID.FieldName = "ProcessID";
            this.colProcessID.MinWidth = 25;
            this.colProcessID.Name = "colProcessID";
            this.colProcessID.Visible = true;
            this.colProcessID.VisibleIndex = 0;
            this.colProcessID.Width = 94;
            // 
            // colProcessNameVN
            // 
            this.colProcessNameVN.Caption = "Tên Công Đoạn (Tiếng Việt)";
            this.colProcessNameVN.FieldName = "ProcessNameVN";
            this.colProcessNameVN.MinWidth = 25;
            this.colProcessNameVN.Name = "colProcessNameVN";
            this.colProcessNameVN.Visible = true;
            this.colProcessNameVN.VisibleIndex = 1;
            this.colProcessNameVN.Width = 94;
            // 
            // colProcessNameJP
            // 
            this.colProcessNameJP.Caption = "Tên Công Đoạn(Tiếng Nhật)";
            this.colProcessNameJP.FieldName = "ProcessNameJP";
            this.colProcessNameJP.MinWidth = 25;
            this.colProcessNameJP.Name = "colProcessNameJP";
            this.colProcessNameJP.Visible = true;
            this.colProcessNameJP.VisibleIndex = 2;
            this.colProcessNameJP.Width = 94;
            // 
            // colNumberProcess
            // 
            this.colNumberProcess.Caption = "Thứ Tự Công Đoạn ";
            this.colNumberProcess.FieldName = "ProcessNumber";
            this.colNumberProcess.MinWidth = 25;
            this.colNumberProcess.Name = "colNumberProcess";
            this.colNumberProcess.Visible = true;
            this.colNumberProcess.VisibleIndex = 3;
            this.colNumberProcess.Width = 94;
            // 
            // dgPartRegistration
            // 
            this.dgPartRegistration.Location = new System.Drawing.Point(12, 117);
            this.dgPartRegistration.MainView = this.gvPartRegistration;
            this.dgPartRegistration.Name = "dgPartRegistration";
            this.dgPartRegistration.Size = new System.Drawing.Size(1755, 282);
            this.dgPartRegistration.TabIndex = 4;
            this.dgPartRegistration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartRegistration});
            // 
            // gvPartRegistration
            // 
            this.gvPartRegistration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartCode,
            this.colPartNameVN,
            this.colPartNameJP,
            this.colBoxQty});
            this.gvPartRegistration.GridControl = this.dgPartRegistration;
            this.gvPartRegistration.Name = "gvPartRegistration";
            this.gvPartRegistration.OptionsBehavior.Editable = false;
            this.gvPartRegistration.OptionsSelection.MultiSelect = true;
            this.gvPartRegistration.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colPartCode
            // 
            this.colPartCode.Caption = "Mã Linh Kiện ";
            this.colPartCode.FieldName = "PartCode";
            this.colPartCode.MinWidth = 25;
            this.colPartCode.Name = "colPartCode";
            this.colPartCode.Visible = true;
            this.colPartCode.VisibleIndex = 1;
            this.colPartCode.Width = 94;
            // 
            // colPartNameVN
            // 
            this.colPartNameVN.Caption = "Tên Linh Kiện (Tiếng Việt)";
            this.colPartNameVN.FieldName = "PartNameVN";
            this.colPartNameVN.MinWidth = 25;
            this.colPartNameVN.Name = "colPartNameVN";
            this.colPartNameVN.Visible = true;
            this.colPartNameVN.VisibleIndex = 2;
            this.colPartNameVN.Width = 94;
            // 
            // colPartNameJP
            // 
            this.colPartNameJP.Caption = "Tên Linh Kiện (Tiếng Nhật)";
            this.colPartNameJP.FieldName = "PartNameJP";
            this.colPartNameJP.MinWidth = 25;
            this.colPartNameJP.Name = "colPartNameJP";
            this.colPartNameJP.Visible = true;
            this.colPartNameJP.VisibleIndex = 3;
            this.colPartNameJP.Width = 94;
            // 
            // colBoxQty
            // 
            this.colBoxQty.Caption = "Số Lượng Tiêu Chuẩn";
            this.colBoxQty.FieldName = "BoxQty";
            this.colBoxQty.MinWidth = 25;
            this.colBoxQty.Name = "colBoxQty";
            this.colBoxQty.Visible = true;
            this.colBoxQty.VisibleIndex = 4;
            this.colBoxQty.Width = 94;
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
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1779, 766);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgPartRegistration;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 105);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1759, 286);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dgProcess;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 391);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1759, 355);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.txtPartCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(442, 65);
            this.layoutControlItem3.Text = " Mã Linh Kiện ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(259, 26);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.txtPartNameJP;
            this.layoutControlItem4.Location = new System.Drawing.Point(856, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(430, 65);
            this.layoutControlItem4.Text = "Tên Linh Kiện (Tiếng Nhật)";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(259, 26);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem5.Control = this.txtPartNameVN;
            this.layoutControlItem5.Location = new System.Drawing.Point(442, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(414, 65);
            this.layoutControlItem5.Text = "Tên Linh Kiện (Tiếng Việt)";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(259, 26);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem6.Control = this.txtBoxQty;
            this.layoutControlItem6.Location = new System.Drawing.Point(1286, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(473, 65);
            this.layoutControlItem6.Text = "Số Lượng Tiêu Chuẩn";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(259, 26);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnNew;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(315, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCancel;
            this.layoutControlItem9.Location = new System.Drawing.Point(667, 65);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(355, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnDelete;
            this.layoutControlItem11.Location = new System.Drawing.Point(1022, 65);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(356, 40);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(315, 65);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(352, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnRefresh;
            this.layoutControlItem10.Location = new System.Drawing.Point(1378, 65);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(381, 40);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // frmPartRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1779, 766);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPartRegistration";
            this.Text = "Khai báo linh kiện";
            this.Load += new System.EventHandler(this.frmPartRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameVN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNameJP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtBoxQty;
        private DevExpress.XtraEditors.TextEdit txtPartNameVN;
        private DevExpress.XtraEditors.TextEdit txtPartNameJP;
        private DevExpress.XtraEditors.TextEdit txtPartCode;
        private DevExpress.XtraGrid.GridControl dgProcess;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProcess;
        private DevExpress.XtraGrid.GridControl dgPartRegistration;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartRegistration;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxQty;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberProcess;
    }
}