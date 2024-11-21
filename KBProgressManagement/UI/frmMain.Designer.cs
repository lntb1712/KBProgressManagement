namespace KBProgressManagement.UI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtFullName = new DevExpress.XtraBars.BarStaticItem();
            this.btnUserManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnGroupManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnStageRegistration = new DevExpress.XtraBars.BarButtonItem();
            this.btnPart = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductPart = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnReprint = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintHistory = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.btnProgress = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgressHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Function = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.txtFullName);
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(87, 70, 87, 70);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtFullName,
            this.ribbon.ExpandCollapseItem,
            this.btnUserManagement,
            this.btnGroupManagement,
            this.btnStageRegistration,
            this.btnPart,
            this.btnProduct,
            this.btnProductPart,
            this.btnPrint,
            this.btnReprint,
            this.btnPrintHistory,
            this.barCheckItem1,
            this.btnProgress,
            this.btnProgressHistory,
            this.btnLogOut,
            this.barStaticItem1,
            this.barEditItem1,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 943;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Function});
            this.ribbon.Size = new System.Drawing.Size(1848, 231);
            // 
            // txtFullName
            // 
            this.txtFullName.Caption = "FullName";
            this.txtFullName.Id = 17;
            this.txtFullName.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_user_48;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUserManagement.Caption = "Quản lí người dùng";
            this.btnUserManagement.Id = 1;
            this.btnUserManagement.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_user_48;
            this.btnUserManagement.ImageOptions.LargeImageIndex = 38;
            this.btnUserManagement.LargeWidth = 100;
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUserManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserManagement_ItemClick);
            // 
            // btnGroupManagement
            // 
            this.btnGroupManagement.Caption = "Quản lí nhóm người dùng";
            this.btnGroupManagement.Id = 2;
            this.btnGroupManagement.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Account;
            this.btnGroupManagement.ImageOptions.LargeImageIndex = 38;
            this.btnGroupManagement.LargeWidth = 125;
            this.btnGroupManagement.Name = "btnGroupManagement";
            this.btnGroupManagement.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGroupManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGroupManagement_ItemClick);
            // 
            // btnStageRegistration
            // 
            this.btnStageRegistration.Caption = "Thêm công đoạn";
            this.btnStageRegistration.Id = 3;
            this.btnStageRegistration.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.engineering;
            this.btnStageRegistration.ImageOptions.LargeImageIndex = 38;
            this.btnStageRegistration.LargeWidth = 100;
            this.btnStageRegistration.Name = "btnStageRegistration";
            this.btnStageRegistration.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStageRegistration.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStageRegistration_ItemClick);
            // 
            // btnPart
            // 
            this.btnPart.Caption = "Khai báo linh kiện";
            this.btnPart.Id = 4;
            this.btnPart.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.carton;
            this.btnPart.ImageOptions.LargeImageIndex = 38;
            this.btnPart.LargeWidth = 100;
            this.btnPart.Name = "btnPart";
            this.btnPart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPart_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Khai báo sản phẩm";
            this.btnProduct.Id = 5;
            this.btnProduct.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.Product;
            this.btnProduct.ImageOptions.LargeImageIndex = 38;
            this.btnProduct.LargeWidth = 100;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnProductPart
            // 
            this.btnProductPart.Caption = "Khai báo linh kiện cho sản phẩm";
            this.btnProductPart.Id = 6;
            this.btnProductPart.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.structure;
            this.btnProductPart.ImageOptions.LargeImageIndex = 38;
            this.btnProductPart.LargeWidth = 150;
            this.btnProductPart.Name = "btnProductPart";
            this.btnProductPart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProductPart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductPart_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In tem";
            this.btnPrint.Id = 7;
            this.btnPrint.ImageOptions.Image = global::KBProgressManagement.Properties.Resources._1;
            this.btnPrint.ImageOptions.LargeImageIndex = 38;
            this.btnPrint.LargeWidth = 100;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnReprint
            // 
            this.btnReprint.Caption = "In lại tem";
            this.btnReprint.Id = 8;
            this.btnReprint.ImageOptions.Image = global::KBProgressManagement.Properties.Resources._2;
            this.btnReprint.ImageOptions.LargeImageIndex = 38;
            this.btnReprint.LargeWidth = 100;
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnReprint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReprint_ItemClick);
            // 
            // btnPrintHistory
            // 
            this.btnPrintHistory.Caption = "Lịch sử in tem";
            this.btnPrintHistory.Id = 9;
            this.btnPrintHistory.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_print_address_label_48;
            this.btnPrintHistory.ImageOptions.LargeImageIndex = 38;
            this.btnPrintHistory.LargeWidth = 100;
            this.btnPrintHistory.Name = "btnPrintHistory";
            this.btnPrintHistory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPrintHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintHistory_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 10;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // btnProgress
            // 
            this.btnProgress.Caption = "Tiến độ";
            this.btnProgress.Id = 11;
            this.btnProgress.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_line_chart_32;
            this.btnProgress.ImageOptions.LargeImageIndex = 38;
            this.btnProgress.LargeWidth = 100;
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProgress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProgress_ItemClick);
            // 
            // btnProgressHistory
            // 
            this.btnProgressHistory.Caption = "Lịch sử tiến độ";
            this.btnProgressHistory.Id = 12;
            this.btnProgressHistory.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_history_32;
            this.btnProgressHistory.ImageOptions.LargeImageIndex = 38;
            this.btnProgressHistory.LargeWidth = 100;
            this.btnProgressHistory.Name = "btnProgressHistory";
            this.btnProgressHistory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 14;
            this.btnLogOut.ImageOptions.Image = global::KBProgressManagement.Properties.Resources.icons8_log_out_32;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 15;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 16;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // Function
            // 
            this.Function.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Function.Appearance.Options.UseFont = true;
            this.Function.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.Function.Name = "Function";
            this.Function.Text = "Chức Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserManagement);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupManagement);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lí người dùng ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStageRegistration);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPart);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProductPart);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lí sản phẩm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReprint);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPrintHistory);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lí in tem";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProgress);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProgressHistory);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lí tiến độ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Cài Đặt";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmMain
            // 
            this.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 778);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.IconOptions.Image = global::KBProgressManagement.Properties.Resources.logo;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "KB PROGRESS MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Function;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUserManagement;
        private DevExpress.XtraBars.BarButtonItem btnGroupManagement;
        private DevExpress.XtraBars.BarButtonItem btnStageRegistration;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnPart;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnProductPart;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnReprint;
        private DevExpress.XtraBars.BarButtonItem btnPrintHistory;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnProgress;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnProgressHistory;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem txtFullName;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}