namespace KBProgressManagement.UI
{
    partial class frmProgress
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gvProgressDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgProgress = new DevExpress.XtraGrid.GridControl();
            this.gvProgress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProgressBar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cboToDate = new DevExpress.XtraEditors.DateEdit();
            this.cboFromDate = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgressDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProgressDetail
            // 
            this.gvProgressDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcessID,
            this.colProcessNameVN,
            this.colProcessNameJP,
            this.colTotal,
            this.colCase,
            this.colNGQuantity,
            this.colCQty,
            this.colUpdateTime});
            this.gvProgressDetail.GridControl = this.dgProgress;
            this.gvProgressDetail.Name = "gvProgressDetail";
            this.gvProgressDetail.OptionsBehavior.Editable = false;
            this.gvProgressDetail.OptionsPrint.AutoWidth = false;
            // 
            // colProcessID
            // 
            this.colProcessID.Caption = "Mã công đoạn";
            this.colProcessID.FieldName = "ProcessID";
            this.colProcessID.MinWidth = 25;
            this.colProcessID.Name = "colProcessID";
            this.colProcessID.Visible = true;
            this.colProcessID.VisibleIndex = 0;
            this.colProcessID.Width = 94;
            // 
            // colProcessNameVN
            // 
            this.colProcessNameVN.Caption = "Tên công đoạn(Việt)";
            this.colProcessNameVN.FieldName = "ProcessNameVN";
            this.colProcessNameVN.MinWidth = 25;
            this.colProcessNameVN.Name = "colProcessNameVN";
            this.colProcessNameVN.Visible = true;
            this.colProcessNameVN.VisibleIndex = 1;
            this.colProcessNameVN.Width = 94;
            // 
            // colProcessNameJP
            // 
            this.colProcessNameJP.Caption = "Tên công đoạn (Nhật)";
            this.colProcessNameJP.FieldName = "ProcessNameJP";
            this.colProcessNameJP.MinWidth = 25;
            this.colProcessNameJP.Name = "colProcessNameJP";
            this.colProcessNameJP.Visible = true;
            this.colProcessNameJP.VisibleIndex = 2;
            this.colProcessNameJP.Width = 94;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Số lượng tổng ";
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            this.colTotal.Width = 94;
            // 
            // colCase
            // 
            this.colCase.Caption = "Tổng số box ";
            this.colCase.FieldName = "Case";
            this.colCase.MinWidth = 25;
            this.colCase.Name = "colCase";
            this.colCase.Visible = true;
            this.colCase.VisibleIndex = 4;
            this.colCase.Width = 94;
            // 
            // colNGQuantity
            // 
            this.colNGQuantity.Caption = "Số lượng hao hụt";
            this.colNGQuantity.FieldName = "NGQuantity";
            this.colNGQuantity.MinWidth = 25;
            this.colNGQuantity.Name = "colNGQuantity";
            this.colNGQuantity.Visible = true;
            this.colNGQuantity.VisibleIndex = 5;
            this.colNGQuantity.Width = 94;
            // 
            // colCQty
            // 
            this.colCQty.Caption = "Số lượng tiêu thụ";
            this.colCQty.FieldName = "CQty";
            this.colCQty.MinWidth = 25;
            this.colCQty.Name = "colCQty";
            this.colCQty.Visible = true;
            this.colCQty.VisibleIndex = 6;
            this.colCQty.Width = 94;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Caption = "Thời gian cập nhật";
            this.colUpdateTime.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colUpdateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUpdateTime.FieldName = "UpdateTime";
            this.colUpdateTime.MinWidth = 25;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 7;
            this.colUpdateTime.Width = 94;
            // 
            // dgProgress
            // 
            gridLevelNode1.LevelTemplate = this.gvProgressDetail;
            gridLevelNode1.RelationName = "Level1";
            this.dgProgress.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgProgress.Location = new System.Drawing.Point(12, 112);
            this.dgProgress.MainView = this.gvProgress;
            this.dgProgress.Name = "dgProgress";
            this.dgProgress.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.dgProgress.Size = new System.Drawing.Size(1699, 647);
            this.dgProgress.TabIndex = 4;
            this.dgProgress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProgress,
            this.gvProgressDetail});
            // 
            // gvProgress
            // 
            this.gvProgress.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLotNo,
            this.colProductCode,
            this.colProductName,
            this.colPartCode,
            this.colPartNameVN,
            this.colPartNameJP,
            this.colProgressBar,
            this.colDueDate});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDueDate;
            gridFormatRule1.Description = null;
            gridFormatRule1.Name = "ChangeCellDueDate";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "DateDiffDay(GetDate([DueDate]), Today()) >= 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvProgress.FormatRules.Add(gridFormatRule1);
            this.gvProgress.GridControl = this.dgProgress;
            this.gvProgress.Name = "gvProgress";
            this.gvProgress.OptionsBehavior.Editable = false;
            this.gvProgress.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gvProgress.OptionsPrint.AutoWidth = false;
            this.gvProgress.OptionsPrint.ExpandAllDetails = true;
            this.gvProgress.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gvProgress_MasterRowEmpty);
            this.gvProgress.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gvProgress_MasterRowExpanded);
            this.gvProgress.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvProgress_MasterRowGetChildList);
            this.gvProgress.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvProgress_MasterRowGetRelationName);
            this.gvProgress.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvProgress_MasterRowGetRelationCount);
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "Số lot";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.MinWidth = 25;
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 0;
            this.colLotNo.Width = 94;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "Mã sản phẩm";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.MinWidth = 25;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 1;
            this.colProductCode.Width = 94;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Tên sản phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 2;
            this.colProductName.Width = 94;
            // 
            // colPartCode
            // 
            this.colPartCode.Caption = "Mã linh kiện ";
            this.colPartCode.FieldName = "PartCode";
            this.colPartCode.MinWidth = 25;
            this.colPartCode.Name = "colPartCode";
            this.colPartCode.Visible = true;
            this.colPartCode.VisibleIndex = 3;
            this.colPartCode.Width = 94;
            // 
            // colPartNameVN
            // 
            this.colPartNameVN.Caption = "Tên linh kiện (Việt)";
            this.colPartNameVN.FieldName = "PartNameVN";
            this.colPartNameVN.MinWidth = 25;
            this.colPartNameVN.Name = "colPartNameVN";
            this.colPartNameVN.Visible = true;
            this.colPartNameVN.VisibleIndex = 4;
            this.colPartNameVN.Width = 94;
            // 
            // colPartNameJP
            // 
            this.colPartNameJP.Caption = "Tên linh kiện (Nhật)";
            this.colPartNameJP.FieldName = "PartNameJP";
            this.colPartNameJP.MinWidth = 25;
            this.colPartNameJP.Name = "colPartNameJP";
            this.colPartNameJP.Visible = true;
            this.colPartNameJP.VisibleIndex = 5;
            this.colPartNameJP.Width = 94;
            // 
            // colProgressBar
            // 
            this.colProgressBar.Caption = "Tiến độ hoàn thành ";
            this.colProgressBar.ColumnEdit = this.repositoryItemProgressBar1;
            this.colProgressBar.FieldName = "Progress";
            this.colProgressBar.MinWidth = 25;
            this.colProgressBar.Name = "colProgressBar";
            this.colProgressBar.Visible = true;
            this.colProgressBar.VisibleIndex = 7;
            this.colProgressBar.Width = 94;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Ngày dự kiến";
            this.colDueDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.MinWidth = 25;
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 6;
            this.colDueDate.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.btnExportExcel);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.cboToDate);
            this.layoutControl1.Controls.Add(this.cboFromDate);
            this.layoutControl1.Controls.Add(this.dgProgress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1723, 771);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(541, 31);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(1135, 77);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(576, 31);
            this.btnExportExcel.StyleController = this.layoutControl1;
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(557, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(574, 31);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboToDate
            // 
            this.cboToDate.EditValue = null;
            this.cboToDate.Location = new System.Drawing.Point(853, 41);
            this.cboToDate.Name = "cboToDate";
            this.cboToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboToDate.Size = new System.Drawing.Size(858, 32);
            this.cboToDate.StyleController = this.layoutControl1;
            this.cboToDate.TabIndex = 6;
            // 
            // cboFromDate
            // 
            this.cboFromDate.EditValue = null;
            this.cboFromDate.Location = new System.Drawing.Point(12, 41);
            this.cboFromDate.Name = "cboFromDate";
            this.cboFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFromDate.Size = new System.Drawing.Size(837, 32);
            this.cboFromDate.StyleController = this.layoutControl1;
            this.cboFromDate.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1723, 771);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgProgress;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1703, 651);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.cboFromDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(841, 65);
            this.layoutControlItem2.Text = "Từ ngày";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 26);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.cboToDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(841, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(862, 65);
            this.layoutControlItem3.Text = "Đến ngày";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 26);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnExportExcel;
            this.layoutControlItem5.Location = new System.Drawing.Point(1123, 65);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(580, 35);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSearch;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(545, 35);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRefresh;
            this.layoutControlItem4.Location = new System.Drawing.Point(545, 65);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(578, 35);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 771);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmProgress";
            this.Text = "Tiến độ";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProgressDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.DateEdit cboToDate;
        private DevExpress.XtraEditors.DateEdit cboFromDate;
        private DevExpress.XtraGrid.GridControl dgProgress;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProgress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProgressDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCase;
        private DevExpress.XtraGrid.Columns.GridColumn colNGQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameJP;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colProgressBar;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
    }
}