
namespace yumak
{
    partial class FrmMevcut
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
            this.projeUstBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.projeUstBilgileriTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter();
            this.gridMevcut = new DevExpress.XtraGrid.GridControl();
            this.projeUstBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gViewMevcut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOEMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMevcutDetay = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMevcut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMevcut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMevcutDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // projeUstBilgileriBindingSource
            // 
            this.projeUstBilgileriBindingSource.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource.DataSource = this.yumakDataSetBindingSource;
            // 
            // yumakDataSetBindingSource
            // 
            this.yumakDataSetBindingSource.DataSource = this.yumakDataSet;
            this.yumakDataSetBindingSource.Position = 0;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeUstBilgileriTableAdapter
            // 
            this.projeUstBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // gridMevcut
            // 
            this.gridMevcut.DataSource = this.projeUstBilgileriBindingSource1;
            this.gridMevcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMevcut.Location = new System.Drawing.Point(0, 0);
            this.gridMevcut.MainView = this.gViewMevcut;
            this.gridMevcut.Name = "gridMevcut";
            this.gridMevcut.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnMevcutDetay});
            this.gridMevcut.Size = new System.Drawing.Size(1026, 598);
            this.gridMevcut.TabIndex = 0;
            this.gridMevcut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewMevcut});
            // 
            // projeUstBilgileriBindingSource1
            // 
            this.projeUstBilgileriBindingSource1.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource1.DataSource = this.yumakDataSet;
            // 
            // gViewMevcut
            // 
            this.gViewMevcut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokID,
            this.colKullaniciID,
            this.colProjeBaslangicTarihi,
            this.colPlanlananProjeTarihi,
            this.colBildirimTarihi,
            this.colGerceklesenProjeTarihi,
            this.colAciklama,
            this.colDurum,
            this.colOEMNo,
            this.Detay});
            this.gViewMevcut.GridControl = this.gridMevcut;
            this.gViewMevcut.Name = "gViewMevcut";
            // 
            // colID
            // 
            this.colID.Caption = "Sıra Numarası";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.Width = 94;
            // 
            // colKullaniciID
            // 
            this.colKullaniciID.FieldName = "KullaniciID";
            this.colKullaniciID.MinWidth = 25;
            this.colKullaniciID.Name = "colKullaniciID";
            this.colKullaniciID.Width = 94;
            // 
            // colProjeBaslangicTarihi
            // 
            this.colProjeBaslangicTarihi.FieldName = "ProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.MinWidth = 25;
            this.colProjeBaslangicTarihi.Name = "colProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.Visible = true;
            this.colProjeBaslangicTarihi.VisibleIndex = 1;
            this.colProjeBaslangicTarihi.Width = 94;
            // 
            // colPlanlananProjeTarihi
            // 
            this.colPlanlananProjeTarihi.FieldName = "PlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.MinWidth = 25;
            this.colPlanlananProjeTarihi.Name = "colPlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.Visible = true;
            this.colPlanlananProjeTarihi.VisibleIndex = 2;
            this.colPlanlananProjeTarihi.Width = 94;
            // 
            // colBildirimTarihi
            // 
            this.colBildirimTarihi.FieldName = "BildirimTarihi";
            this.colBildirimTarihi.MinWidth = 25;
            this.colBildirimTarihi.Name = "colBildirimTarihi";
            this.colBildirimTarihi.Visible = true;
            this.colBildirimTarihi.VisibleIndex = 3;
            this.colBildirimTarihi.Width = 94;
            // 
            // colGerceklesenProjeTarihi
            // 
            this.colGerceklesenProjeTarihi.FieldName = "GerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.MinWidth = 25;
            this.colGerceklesenProjeTarihi.Name = "colGerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.Visible = true;
            this.colGerceklesenProjeTarihi.VisibleIndex = 4;
            this.colGerceklesenProjeTarihi.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 94;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.MinWidth = 25;
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 6;
            this.colDurum.Width = 94;
            // 
            // colOEMNo
            // 
            this.colOEMNo.FieldName = "OEMNo";
            this.colOEMNo.MinWidth = 25;
            this.colOEMNo.Name = "colOEMNo";
            this.colOEMNo.Visible = true;
            this.colOEMNo.VisibleIndex = 7;
            this.colOEMNo.Width = 94;
            // 
            // Detay
            // 
            this.Detay.Caption = "Detay";
            this.Detay.ColumnEdit = this.btnMevcutDetay;
            this.Detay.MinWidth = 25;
            this.Detay.Name = "Detay";
            this.Detay.Visible = true;
            this.Detay.VisibleIndex = 8;
            this.Detay.Width = 94;
            // 
            // btnMevcutDetay
            // 
            this.btnMevcutDetay.AutoHeight = false;
            this.btnMevcutDetay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.btnMevcutDetay.Name = "btnMevcutDetay";
            this.btnMevcutDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnMevcutDetay.Click += new System.EventHandler(this.btnMevcutDetay_Click);
            this.btnMevcutDetay.DoubleClick += new System.EventHandler(this.btnMevcutDetay_DoubleClick);
            // 
            // FrmMevcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 598);
            this.Controls.Add(this.gridMevcut);
            this.Name = "FrmMevcut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMevcut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMevcut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMevcut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMevcut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMevcutDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource yumakDataSetBindingSource;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource;
        private YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter projeUstBilgileriTableAdapter;
        private DevExpress.XtraGrid.GridControl gridMevcut;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewMevcut;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOEMNo;
        private DevExpress.XtraGrid.Columns.GridColumn Detay;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnMevcutDetay;
    }
}