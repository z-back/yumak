
namespace yumak
{
    partial class FrmDetay
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
            this.gridDetay = new DevExpress.XtraGrid.GridControl();
            this.projeDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gViewDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYumakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYeniUrunTalep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFizibilite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProsesTasarim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIleriKalitePlanlamasiAPQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenProjeBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeLideriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.projeDetayTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeDetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetay
            // 
            this.gridDetay.DataSource = this.projeDetayBindingSource;
            this.gridDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetay.Location = new System.Drawing.Point(0, 0);
            this.gridDetay.MainView = this.gViewDetay;
            this.gridDetay.Name = "gridDetay";
            this.gridDetay.Size = new System.Drawing.Size(949, 670);
            this.gridDetay.TabIndex = 0;
            this.gridDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewDetay});
            // 
            // projeDetayBindingSource
            // 
            this.projeDetayBindingSource.DataMember = "ProjeDetay";
            this.projeDetayBindingSource.DataSource = this.yumakDataSet;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gViewDetay
            // 
            this.gViewDetay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSiraNo,
            this.colDurum,
            this.colProjeID,
            this.colStokID,
            this.colYumakNo,
            this.colAciklama,
            this.colYeniUrunTalep,
            this.colFizibilite,
            this.colProsesTasarim,
            this.colIleriKalitePlanlamasiAPQP,
            this.colProjeBaslangicTarihi,
            this.colPlanlananProjeTarihi,
            this.colGerceklesenProjeBitisTarihi,
            this.colProjeLideriID});
            this.gViewDetay.GridControl = this.gridDetay;
            this.gViewDetay.Name = "gViewDetay";
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
            // colSiraNo
            // 
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.MinWidth = 25;
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Width = 94;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.MinWidth = 25;
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 1;
            this.colDurum.Width = 94;
            // 
            // colProjeID
            // 
            this.colProjeID.FieldName = "ProjeID";
            this.colProjeID.MinWidth = 25;
            this.colProjeID.Name = "colProjeID";
            this.colProjeID.Width = 94;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.Width = 94;
            // 
            // colYumakNo
            // 
            this.colYumakNo.FieldName = "YumakNo";
            this.colYumakNo.MinWidth = 25;
            this.colYumakNo.Name = "colYumakNo";
            this.colYumakNo.Visible = true;
            this.colYumakNo.VisibleIndex = 2;
            this.colYumakNo.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 94;
            // 
            // colYeniUrunTalep
            // 
            this.colYeniUrunTalep.FieldName = "YeniUrunTalep";
            this.colYeniUrunTalep.MinWidth = 25;
            this.colYeniUrunTalep.Name = "colYeniUrunTalep";
            this.colYeniUrunTalep.Visible = true;
            this.colYeniUrunTalep.VisibleIndex = 4;
            this.colYeniUrunTalep.Width = 94;
            // 
            // colFizibilite
            // 
            this.colFizibilite.FieldName = "Fizibilite";
            this.colFizibilite.MinWidth = 25;
            this.colFizibilite.Name = "colFizibilite";
            this.colFizibilite.Visible = true;
            this.colFizibilite.VisibleIndex = 5;
            this.colFizibilite.Width = 94;
            // 
            // colProsesTasarim
            // 
            this.colProsesTasarim.FieldName = "ProsesTasarim";
            this.colProsesTasarim.MinWidth = 25;
            this.colProsesTasarim.Name = "colProsesTasarim";
            this.colProsesTasarim.Visible = true;
            this.colProsesTasarim.VisibleIndex = 6;
            this.colProsesTasarim.Width = 94;
            // 
            // colIleriKalitePlanlamasiAPQP
            // 
            this.colIleriKalitePlanlamasiAPQP.FieldName = "IleriKalitePlanlamasiAPQP";
            this.colIleriKalitePlanlamasiAPQP.MinWidth = 25;
            this.colIleriKalitePlanlamasiAPQP.Name = "colIleriKalitePlanlamasiAPQP";
            this.colIleriKalitePlanlamasiAPQP.Visible = true;
            this.colIleriKalitePlanlamasiAPQP.VisibleIndex = 7;
            this.colIleriKalitePlanlamasiAPQP.Width = 94;
            // 
            // colProjeBaslangicTarihi
            // 
            this.colProjeBaslangicTarihi.FieldName = "ProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.MinWidth = 25;
            this.colProjeBaslangicTarihi.Name = "colProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.Visible = true;
            this.colProjeBaslangicTarihi.VisibleIndex = 8;
            this.colProjeBaslangicTarihi.Width = 94;
            // 
            // colPlanlananProjeTarihi
            // 
            this.colPlanlananProjeTarihi.FieldName = "PlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.MinWidth = 25;
            this.colPlanlananProjeTarihi.Name = "colPlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.Visible = true;
            this.colPlanlananProjeTarihi.VisibleIndex = 9;
            this.colPlanlananProjeTarihi.Width = 94;
            // 
            // colGerceklesenProjeBitisTarihi
            // 
            this.colGerceklesenProjeBitisTarihi.FieldName = "GerceklesenProjeBitisTarihi";
            this.colGerceklesenProjeBitisTarihi.MinWidth = 25;
            this.colGerceklesenProjeBitisTarihi.Name = "colGerceklesenProjeBitisTarihi";
            this.colGerceklesenProjeBitisTarihi.Visible = true;
            this.colGerceklesenProjeBitisTarihi.VisibleIndex = 10;
            this.colGerceklesenProjeBitisTarihi.Width = 94;
            // 
            // colProjeLideriID
            // 
            this.colProjeLideriID.FieldName = "ProjeLideriID";
            this.colProjeLideriID.MinWidth = 25;
            this.colProjeLideriID.Name = "colProjeLideriID";
            this.colProjeLideriID.Width = 94;
            // 
            // projeDetayTableAdapter
            // 
            this.projeDetayTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 670);
            this.Controls.Add(this.gridDetay);
            this.Name = "FrmDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewDetay;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource projeDetayBindingSource;
        private YumakDataSetTableAdapters.ProjeDetayTableAdapter projeDetayTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colYumakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colYeniUrunTalep;
        private DevExpress.XtraGrid.Columns.GridColumn colFizibilite;
        private DevExpress.XtraGrid.Columns.GridColumn colProsesTasarim;
        private DevExpress.XtraGrid.Columns.GridColumn colIleriKalitePlanlamasiAPQP;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenProjeBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeLideriID;
    }
}