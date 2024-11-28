namespace KBProgressManagement.UI
{
    partial class frmPrintLabelHistory
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
            this.dgPrintLabelHistory = new DevExpress.XtraGrid.GridControl();
            this.gvPrintLabelHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBoxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrintLabelHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrintLabelHistory)).BeginInit();
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
            this.colDueDate.VisibleIndex = 6;
            this.colDueDate.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.dgPrintLabelHistory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1742, 744);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.refresh;
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1718, 36);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgPrintLabelHistory
            // 
            this.dgPrintLabelHistory.Location = new System.Drawing.Point(12, 52);
            this.dgPrintLabelHistory.MainView = this.gvPrintLabelHistory;
            this.dgPrintLabelHistory.Name = "dgPrintLabelHistory";
            this.dgPrintLabelHistory.Size = new System.Drawing.Size(1718, 680);
            this.dgPrintLabelHistory.TabIndex = 4;
            this.dgPrintLabelHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrintLabelHistory});
            // 
            // gvPrintLabelHistory
            // 
            this.gvPrintLabelHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBoxNo,
            this.colProductCode,
            this.colPartCode,
            this.colProductLine,
            this.colLotNo,
            this.colQuantity,
            this.colDueDate,
            this.colPrintTime,
            this.colPrintBy});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDueDate;
            gridFormatRule1.Description = null;
            gridFormatRule1.Name = "ChangeCellDueDate";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "DateDiffDay(GetDate([DueDate]), Today()) >= 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvPrintLabelHistory.FormatRules.Add(gridFormatRule1);
            this.gvPrintLabelHistory.GridControl = this.dgPrintLabelHistory;
            this.gvPrintLabelHistory.Name = "gvPrintLabelHistory";
            this.gvPrintLabelHistory.OptionsBehavior.Editable = false;
            // 
            // colBoxNo
            // 
            this.colBoxNo.Caption = "Số box";
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
            this.colProductCode.VisibleIndex = 1;
            this.colProductCode.Width = 94;
            // 
            // colPartCode
            // 
            this.colPartCode.Caption = "Mã linh kiện ";
            this.colPartCode.FieldName = "PartCode";
            this.colPartCode.MinWidth = 25;
            this.colPartCode.Name = "colPartCode";
            this.colPartCode.Visible = true;
            this.colPartCode.VisibleIndex = 2;
            this.colPartCode.Width = 94;
            // 
            // colProductLine
            // 
            this.colProductLine.Caption = "Dây chuyền";
            this.colProductLine.FieldName = "ProductLine";
            this.colProductLine.MinWidth = 25;
            this.colProductLine.Name = "colProductLine";
            this.colProductLine.Visible = true;
            this.colProductLine.VisibleIndex = 3;
            this.colProductLine.Width = 94;
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "Số lot";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.MinWidth = 25;
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 4;
            this.colLotNo.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 94;
            // 
            // colPrintTime
            // 
            this.colPrintTime.Caption = "Ngày in";
            this.colPrintTime.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPrintTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPrintTime.FieldName = "PrintTime";
            this.colPrintTime.MinWidth = 25;
            this.colPrintTime.Name = "colPrintTime";
            this.colPrintTime.Visible = true;
            this.colPrintTime.VisibleIndex = 7;
            this.colPrintTime.Width = 94;
            // 
            // colPrintBy
            // 
            this.colPrintBy.Caption = "Người in";
            this.colPrintBy.FieldName = "PrintBy";
            this.colPrintBy.MinWidth = 25;
            this.colPrintBy.Name = "colPrintBy";
            this.colPrintBy.Visible = true;
            this.colPrintBy.VisibleIndex = 8;
            this.colPrintBy.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1742, 744);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgPrintLabelHistory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1722, 684);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRefresh;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1722, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmPrintLabelHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 744);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPrintLabelHistory";
            this.Text = "Lịch sử in tem";
            this.Load += new System.EventHandler(this.frmPrintLabelHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrintLabelHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrintLabelHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl dgPrintLabelHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrintLabelHistory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLine;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintBy;
    }
}