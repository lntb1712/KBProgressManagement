namespace KBProgressManagement.UI
{
    partial class frmProgressHistory
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dgProgressHistory = new DevExpress.XtraGrid.GridControl();
            this.gvProgressHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBoxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgressHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgressHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
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
            this.colDueDate.VisibleIndex = 12;
            this.colDueDate.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.dgProgressHistory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1790, 766);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.refresh;
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1766, 36);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgProgressHistory
            // 
            this.dgProgressHistory.Location = new System.Drawing.Point(12, 52);
            this.dgProgressHistory.MainView = this.gvProgressHistory;
            this.dgProgressHistory.Name = "dgProgressHistory";
            this.dgProgressHistory.Size = new System.Drawing.Size(1766, 702);
            this.dgProgressHistory.TabIndex = 4;
            this.dgProgressHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProgressHistory});
            // 
            // gvProgressHistory
            // 
            this.gvProgressHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBoxNo,
            this.colProductCode,
            this.colProductName,
            this.colPartCode,
            this.colPartNameVN,
            this.colPartNameJP,
            this.colProcessID,
            this.colProcessNameVN,
            this.colProcessNameJP,
            this.colQuantity,
            this.colNGQuantity,
            this.colUpdateTime,
            this.colDueDate,
            this.colLotNo});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDueDate;
            gridFormatRule1.Description = null;
            gridFormatRule1.Name = "ChangeCellDueDate";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "DateDiffDay(GetDate([DueDate]), Today()) >= 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvProgressHistory.FormatRules.Add(gridFormatRule1);
            this.gvProgressHistory.GridControl = this.dgProgressHistory;
            this.gvProgressHistory.Name = "gvProgressHistory";
            this.gvProgressHistory.OptionsBehavior.Editable = false;
            // 
            // colBoxNo
            // 
            this.colBoxNo.Caption = "Số Box";
            this.colBoxNo.FieldName = "BoxNo";
            this.colBoxNo.MinWidth = 25;
            this.colBoxNo.Name = "colBoxNo";
            this.colBoxNo.Visible = true;
            this.colBoxNo.VisibleIndex = 0;
            this.colBoxNo.Width = 94;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "Mã sản phẩm";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.MinWidth = 25;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 2;
            this.colProductCode.Width = 94;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Tên sản phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 94;
            // 
            // colPartCode
            // 
            this.colPartCode.Caption = "Mã linh kiện";
            this.colPartCode.FieldName = "PartCode";
            this.colPartCode.MinWidth = 25;
            this.colPartCode.Name = "colPartCode";
            this.colPartCode.Visible = true;
            this.colPartCode.VisibleIndex = 4;
            this.colPartCode.Width = 94;
            // 
            // colPartNameVN
            // 
            this.colPartNameVN.Caption = "Tên linh kiện (Việt)";
            this.colPartNameVN.FieldName = "PartNameVN";
            this.colPartNameVN.MinWidth = 25;
            this.colPartNameVN.Name = "colPartNameVN";
            this.colPartNameVN.Visible = true;
            this.colPartNameVN.VisibleIndex = 5;
            this.colPartNameVN.Width = 94;
            // 
            // colPartNameJP
            // 
            this.colPartNameJP.Caption = "Tên linh kiện (Nhật)";
            this.colPartNameJP.FieldName = "PartNameJP";
            this.colPartNameJP.MinWidth = 25;
            this.colPartNameJP.Name = "colPartNameJP";
            this.colPartNameJP.Visible = true;
            this.colPartNameJP.VisibleIndex = 6;
            this.colPartNameJP.Width = 94;
            // 
            // colProcessID
            // 
            this.colProcessID.Caption = "Mã công đoạn";
            this.colProcessID.FieldName = "ProcessID";
            this.colProcessID.MinWidth = 25;
            this.colProcessID.Name = "colProcessID";
            this.colProcessID.Visible = true;
            this.colProcessID.VisibleIndex = 7;
            this.colProcessID.Width = 94;
            // 
            // colProcessNameVN
            // 
            this.colProcessNameVN.Caption = "Tên công đoạn (Việt)";
            this.colProcessNameVN.FieldName = "ProcessNameVN";
            this.colProcessNameVN.MinWidth = 25;
            this.colProcessNameVN.Name = "colProcessNameVN";
            this.colProcessNameVN.Visible = true;
            this.colProcessNameVN.VisibleIndex = 8;
            this.colProcessNameVN.Width = 94;
            // 
            // colProcessNameJP
            // 
            this.colProcessNameJP.Caption = "Tên công đoạn (Nhật)";
            this.colProcessNameJP.FieldName = "ProcessNameJP";
            this.colProcessNameJP.MinWidth = 25;
            this.colProcessNameJP.Name = "colProcessNameJP";
            this.colProcessNameJP.Visible = true;
            this.colProcessNameJP.VisibleIndex = 9;
            this.colProcessNameJP.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng ";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 10;
            this.colQuantity.Width = 94;
            // 
            // colNGQuantity
            // 
            this.colNGQuantity.Caption = "Số lượng hao hụt ";
            this.colNGQuantity.FieldName = "NGQuantity";
            this.colNGQuantity.MinWidth = 25;
            this.colNGQuantity.Name = "colNGQuantity";
            this.colNGQuantity.Visible = true;
            this.colNGQuantity.VisibleIndex = 11;
            this.colNGQuantity.Width = 94;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Caption = "Thời gian cập nhật ";
            this.colUpdateTime.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colUpdateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUpdateTime.FieldName = "UpdateTime";
            this.colUpdateTime.MinWidth = 25;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 13;
            this.colUpdateTime.Width = 94;
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "Số Lot";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.MinWidth = 25;
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 1;
            this.colLotNo.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1790, 766);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgProgressHistory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1770, 706);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRefresh;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1770, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmProgressHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 766);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmProgressHistory";
            this.Text = "Lịch sử tiến độ";
            this.Load += new System.EventHandler(this.frmProgressHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProgressHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgressHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl dgProgressHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProgressHistory;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNGQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
    }
}