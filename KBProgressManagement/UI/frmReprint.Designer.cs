namespace KBProgressManagement.UI
{
    partial class frmReprint
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtLotNo = new DevExpress.XtraEditors.TextEdit();
            this.cboPrintName = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPartCode = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxNo = new DevExpress.XtraEditors.TextEdit();
            this.dgReprint = new DevExpress.XtraGrid.GridControl();
            this.gvReprint = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBoxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameVN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNameJP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrintBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrintName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.colDueDate.VisibleIndex = 10;
            this.colDueDate.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.txtLotNo);
            this.layoutControl1.Controls.Add(this.cboPrintName);
            this.layoutControl1.Controls.Add(this.txtPartCode);
            this.layoutControl1.Controls.Add(this.txtBoxNo);
            this.layoutControl1.Controls.Add(this.dgReprint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1775, 729);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1391, 81);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(0, 17, 0, 17);
            this.btnPrint.Size = new System.Drawing.Size(372, 65);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In lại";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1391, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 17, 0, 17);
            this.btnRefresh.Size = new System.Drawing.Size(372, 65);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(691, 41);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLotNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLotNo.Size = new System.Drawing.Size(696, 32);
            this.txtLotNo.StyleController = this.layoutControl1;
            this.txtLotNo.TabIndex = 8;
            // 
            // cboPrintName
            // 
            this.cboPrintName.Location = new System.Drawing.Point(691, 110);
            this.cboPrintName.Name = "cboPrintName";
            this.cboPrintName.Properties.Appearance.Options.UseTextOptions = true;
            this.cboPrintName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cboPrintName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrintName.Properties.PopupView = this.gridLookUpEdit1View;
            this.cboPrintName.Size = new System.Drawing.Size(696, 32);
            this.cboPrintName.StyleController = this.layoutControl1;
            this.cboPrintName.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtPartCode
            // 
            this.txtPartCode.Location = new System.Drawing.Point(12, 110);
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPartCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPartCode.Size = new System.Drawing.Size(675, 32);
            this.txtPartCode.StyleController = this.layoutControl1;
            this.txtPartCode.TabIndex = 6;
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Location = new System.Drawing.Point(12, 41);
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBoxNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBoxNo.Size = new System.Drawing.Size(675, 32);
            this.txtBoxNo.StyleController = this.layoutControl1;
            this.txtBoxNo.TabIndex = 5;
            // 
            // dgReprint
            // 
            this.dgReprint.Location = new System.Drawing.Point(12, 150);
            this.dgReprint.MainView = this.gvReprint;
            this.dgReprint.Name = "dgReprint";
            this.dgReprint.Size = new System.Drawing.Size(1751, 567);
            this.dgReprint.TabIndex = 4;
            this.dgReprint.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReprint});
            // 
            // gvReprint
            // 
            this.gvReprint.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBoxNo,
            this.colProductCode,
            this.colProductName,
            this.colPartCode,
            this.colPartNameVN,
            this.colPartNameJP,
            this.colProductLine,
            this.colLotNo,
            this.colQuantity,
            this.colDueDate,
            this.colPrintTime,
            this.colPrintBy});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDueDate;
            gridFormatRule1.Description = null;
            gridFormatRule1.Name = "FormatCellDueDate";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "DateDiffDay(GetDate([DueDate]), Today()) >= 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvReprint.FormatRules.Add(gridFormatRule1);
            this.gvReprint.GridControl = this.dgReprint;
            this.gvReprint.Name = "gvReprint";
            this.gvReprint.OptionsBehavior.Editable = false;
            this.gvReprint.OptionsSelection.MultiSelect = true;
            this.gvReprint.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colBoxNo
            // 
            this.colBoxNo.Caption = "Số Box";
            this.colBoxNo.FieldName = "BoxNo";
            this.colBoxNo.MinWidth = 25;
            this.colBoxNo.Name = "colBoxNo";
            this.colBoxNo.Visible = true;
            this.colBoxNo.VisibleIndex = 1;
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
            // colProductLine
            // 
            this.colProductLine.Caption = "Dây chuyền";
            this.colProductLine.FieldName = "ProductLine";
            this.colProductLine.MinWidth = 25;
            this.colProductLine.Name = "colProductLine";
            this.colProductLine.Visible = true;
            this.colProductLine.VisibleIndex = 7;
            this.colProductLine.Width = 94;
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "Số lot";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.MinWidth = 25;
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 8;
            this.colLotNo.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 9;
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
            this.colPrintTime.VisibleIndex = 11;
            this.colPrintTime.Width = 94;
            // 
            // colPrintBy
            // 
            this.colPrintBy.Caption = "Người in";
            this.colPrintBy.FieldName = "PrintBy";
            this.colPrintBy.MinWidth = 25;
            this.colPrintBy.Name = "colPrintBy";
            this.colPrintBy.Visible = true;
            this.colPrintBy.VisibleIndex = 12;
            this.colPrintBy.Width = 94;
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
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1775, 729);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgReprint;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1755, 571);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.txtBoxNo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(679, 69);
            this.layoutControlItem2.Text = "Số Box";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(128, 26);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.txtPartCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(679, 69);
            this.layoutControlItem3.Text = "Mã Linh Kiện";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(128, 26);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem5.Control = this.txtLotNo;
            this.layoutControlItem5.Location = new System.Drawing.Point(679, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(700, 69);
            this.layoutControlItem5.Text = "Số Lot";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(128, 26);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.cboPrintName;
            this.layoutControlItem4.Location = new System.Drawing.Point(679, 69);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(700, 69);
            this.layoutControlItem4.Text = "Chọn Máy In";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(128, 26);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnRefresh;
            this.layoutControlItem6.Location = new System.Drawing.Point(1379, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(376, 69);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPrint;
            this.layoutControlItem7.Location = new System.Drawing.Point(1379, 69);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(376, 69);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            this.layoutControlItem7.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmReprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1775, 729);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmReprint";
            this.Text = "In lại tem";
            this.Load += new System.EventHandler(this.frmReprint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrintName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.TextEdit txtLotNo;
        private DevExpress.XtraEditors.GridLookUpEdit cboPrintName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtPartCode;
        private DevExpress.XtraEditors.TextEdit txtBoxNo;
        private DevExpress.XtraGrid.GridControl dgReprint;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReprint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameVN;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNameJP;
        private DevExpress.XtraGrid.Columns.GridColumn colProductLine;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintBy;
    }
}