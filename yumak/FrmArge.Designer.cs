
namespace yumak
{
    partial class FrmArge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArge));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.projeUstBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBitenP = new DevExpress.XtraBars.BarButtonItem();
            this.btnMevcutP = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeniP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnProjeOlustur = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.projeUstBilgileriTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter();
            this.projeDetayTableAdapter1 = new yumak.YumakDataSetTableAdapters.ProjeDetayTableAdapter();
            this.projeUstBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridArge = new DevExpress.XtraGrid.GridControl();
            this.projeUstBilgileriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gViewArge = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOEMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYuzde = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewArge)).BeginInit();
            this.SuspendLayout();
            // 
            // projeUstBilgileriBindingSource
            // 
            this.projeUstBilgileriBindingSource.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource.DataSource = this.yumakDataSet;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btnBitenP,
            this.btnMevcutP,
            this.btnYeniP,
            this.barButtonItem2,
            this.btnProjeOlustur});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(938, 183);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnBitenP
            // 
            this.btnBitenP.Caption = "Biten Projeler";
            this.btnBitenP.Id = 2;
            this.btnBitenP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBitenP.ImageOptions.Image")));
            this.btnBitenP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBitenP.ImageOptions.LargeImage")));
            this.btnBitenP.Name = "btnBitenP";
            this.btnBitenP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBitenP_ItemClick);
            // 
            // btnMevcutP
            // 
            this.btnMevcutP.Caption = "Mevcut Projeler";
            this.btnMevcutP.Id = 3;
            this.btnMevcutP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMevcutP.ImageOptions.Image")));
            this.btnMevcutP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMevcutP.ImageOptions.LargeImage")));
            this.btnMevcutP.Name = "btnMevcutP";
            this.btnMevcutP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMevcutP_ItemClick);
            // 
            // btnYeniP
            // 
            this.btnYeniP.Caption = "Yeni Proje Ekle";
            this.btnYeniP.Id = 4;
            this.btnYeniP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniP.ImageOptions.Image")));
            this.btnYeniP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniP.ImageOptions.LargeImage")));
            this.btnYeniP.Name = "btnYeniP";
            this.btnYeniP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniP_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnProjeOlustur
            // 
            this.btnProjeOlustur.Caption = "Proje Oluştur";
            this.btnProjeOlustur.Id = 7;
            this.btnProjeOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeOlustur.ImageOptions.Image")));
            this.btnProjeOlustur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProjeOlustur.ImageOptions.LargeImage")));
            this.btnProjeOlustur.Name = "btnProjeOlustur";
            this.btnProjeOlustur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProjeOlustur_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Arge";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBitenP);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMevcutP);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProjeOlustur);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // projeUstBilgileriTableAdapter
            // 
            this.projeUstBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // projeDetayTableAdapter1
            // 
            this.projeDetayTableAdapter1.ClearBeforeFill = true;
            // 
            // projeUstBilgileriBindingSource1
            // 
            this.projeUstBilgileriBindingSource1.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource1.DataSource = this.yumakDataSet;
            // 
            // gridArge
            // 
            this.gridArge.DataSource = this.projeUstBilgileriBindingSource2;
            this.gridArge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArge.Location = new System.Drawing.Point(0, 183);
            this.gridArge.MainView = this.gViewArge;
            this.gridArge.MenuManager = this.ribbonControl1;
            this.gridArge.Name = "gridArge";
            this.gridArge.Size = new System.Drawing.Size(938, 406);
            this.gridArge.TabIndex = 3;
            this.gridArge.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewArge});
            // 
            // projeUstBilgileriBindingSource2
            // 
            this.projeUstBilgileriBindingSource2.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource2.DataSource = this.yumakDataSet;
            // 
            // gViewArge
            // 
            this.gViewArge.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKullaniciID,
            this.colProjeBaslangicTarihi,
            this.colPlanlananProjeTarihi,
            this.colBildirimTarihi,
            this.colGerceklesenProjeTarihi,
            this.colAciklama,
            this.colDurum,
            this.colOEMNo,
            this.colYuzde});
            gridFormatRule1.Column = this.colYuzde;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleDataBar1.PredefinedName = null;
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.gViewArge.FormatRules.Add(gridFormatRule1);
            this.gViewArge.GridControl = this.gridArge;
            this.gViewArge.Name = "gViewArge";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colKullaniciID
            // 
            this.colKullaniciID.FieldName = "KullaniciID";
            this.colKullaniciID.MinWidth = 25;
            this.colKullaniciID.Name = "colKullaniciID";
            this.colKullaniciID.Visible = true;
            this.colKullaniciID.VisibleIndex = 1;
            this.colKullaniciID.Width = 94;
            // 
            // colProjeBaslangicTarihi
            // 
            this.colProjeBaslangicTarihi.FieldName = "ProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.MinWidth = 25;
            this.colProjeBaslangicTarihi.Name = "colProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.Visible = true;
            this.colProjeBaslangicTarihi.VisibleIndex = 2;
            this.colProjeBaslangicTarihi.Width = 94;
            // 
            // colPlanlananProjeTarihi
            // 
            this.colPlanlananProjeTarihi.FieldName = "PlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.MinWidth = 25;
            this.colPlanlananProjeTarihi.Name = "colPlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.Visible = true;
            this.colPlanlananProjeTarihi.VisibleIndex = 3;
            this.colPlanlananProjeTarihi.Width = 94;
            // 
            // colBildirimTarihi
            // 
            this.colBildirimTarihi.FieldName = "BildirimTarihi";
            this.colBildirimTarihi.MinWidth = 25;
            this.colBildirimTarihi.Name = "colBildirimTarihi";
            this.colBildirimTarihi.Visible = true;
            this.colBildirimTarihi.VisibleIndex = 4;
            this.colBildirimTarihi.Width = 94;
            // 
            // colGerceklesenProjeTarihi
            // 
            this.colGerceklesenProjeTarihi.FieldName = "GerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.MinWidth = 25;
            this.colGerceklesenProjeTarihi.Name = "colGerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.Visible = true;
            this.colGerceklesenProjeTarihi.VisibleIndex = 5;
            this.colGerceklesenProjeTarihi.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 94;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.MinWidth = 25;
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 7;
            this.colDurum.Width = 94;
            // 
            // colOEMNo
            // 
            this.colOEMNo.FieldName = "OEMNo";
            this.colOEMNo.MinWidth = 25;
            this.colOEMNo.Name = "colOEMNo";
            this.colOEMNo.Visible = true;
            this.colOEMNo.VisibleIndex = 8;
            this.colOEMNo.Width = 94;
            // 
            // colYuzde
            // 
            this.colYuzde.FieldName = "Yuzde";
            this.colYuzde.MinWidth = 25;
            this.colYuzde.Name = "colYuzde";
            this.colYuzde.Visible = true;
            this.colYuzde.VisibleIndex = 9;
            this.colYuzde.Width = 94;
            // 
            // FrmArge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 589);
            this.Controls.Add(this.gridArge);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmArge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmArge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewArge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBitenP;
        private DevExpress.XtraBars.BarButtonItem btnMevcutP;
        private DevExpress.XtraBars.BarButtonItem btnYeniP;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource;
        private YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter projeUstBilgileriTableAdapter;
        private YumakDataSetTableAdapters.ProjeDetayTableAdapter projeDetayTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnProjeOlustur;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource1;
        private DevExpress.XtraGrid.GridControl gridArge;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewArge;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOEMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colYuzde;
    }
}