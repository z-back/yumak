
namespace yumak
{
    partial class FrmBiten
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
            this.gridBiten = new DevExpress.XtraGrid.GridControl();
            this.projeUstBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gViewBiten = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colDetay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBitenDetay = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.projeUstBilgileriTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridBiten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewBiten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBitenDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBiten
            // 
            this.gridBiten.DataSource = this.projeUstBilgileriBindingSource;
            this.gridBiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBiten.Location = new System.Drawing.Point(0, 0);
            this.gridBiten.MainView = this.gViewBiten;
            this.gridBiten.Name = "gridBiten";
            this.gridBiten.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnBitenDetay});
            this.gridBiten.Size = new System.Drawing.Size(1001, 607);
            this.gridBiten.TabIndex = 0;
            this.gridBiten.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewBiten});
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
            // gViewBiten
            // 
            this.gViewBiten.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colDetay});
            this.gViewBiten.GridControl = this.gridBiten;
            this.gViewBiten.Name = "gViewBiten";
            this.gViewBiten.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gViewBiten_RowCellClick);
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
            // colDetay
            // 
            this.colDetay.Caption = "Detay";
            this.colDetay.ColumnEdit = this.btnBitenDetay;
            this.colDetay.MinWidth = 25;
            this.colDetay.Name = "colDetay";
            this.colDetay.Visible = true;
            this.colDetay.VisibleIndex = 8;
            this.colDetay.Width = 94;
            // 
            // btnBitenDetay
            // 
            this.btnBitenDetay.AutoHeight = false;
            this.btnBitenDetay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.btnBitenDetay.Name = "btnBitenDetay";
            this.btnBitenDetay.ReadOnly = true;
            this.btnBitenDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnBitenDetay.DoubleClick += new System.EventHandler(this.btnBitenDetay_DoubleClick);
            // 
            // projeUstBilgileriTableAdapter
            // 
            this.projeUstBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 607);
            this.Controls.Add(this.gridBiten);
            this.Name = "FrmBiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBiten";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBiten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewBiten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBitenDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBiten;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewBiten;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource;
        private YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter projeUstBilgileriTableAdapter;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDetay;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBitenDetay;
    }
}