
namespace yumak
{
    partial class FrmStok
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
            this.gridStok = new DevExpress.XtraGrid.GridControl();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gridStokView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYumakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOEMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokTableAdapter = new yumak.YumakDataSetTableAdapters.StokTableAdapter();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new yumak.YumakDataSetTableAdapters.KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStok
            // 
            this.gridStok.DataSource = this.stokBindingSource;
            this.gridStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStok.Location = new System.Drawing.Point(0, 0);
            this.gridStok.MainView = this.gridStokView;
            this.gridStok.Name = "gridStok";
            this.gridStok.Size = new System.Drawing.Size(951, 638);
            this.gridStok.TabIndex = 0;
            this.gridStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokView});
            this.gridStok.Click += new System.EventHandler(this.gridStok_Click);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "Stok";
            this.stokBindingSource.DataSource = this.yumakDataSet;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridStokView
            // 
            this.gridStokView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colYumakNo,
            this.colUrunAd,
            this.colResim,
            this.colOEMNo});
            this.gridStokView.GridControl = this.gridStok;
            this.gridStokView.Name = "gridStokView";
            this.gridStokView.OptionsBehavior.Editable = false;
            this.gridStokView.OptionsBehavior.ReadOnly = true;
            this.gridStokView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridStokView_RowCellClick);
            this.gridStokView.Click += new System.EventHandler(this.gridStokView_Click);
            this.gridStokView.DoubleClick += new System.EventHandler(this.gridStokView_DoubleClick);
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
            // colYumakNo
            // 
            this.colYumakNo.FieldName = "YumakNo";
            this.colYumakNo.MinWidth = 25;
            this.colYumakNo.Name = "colYumakNo";
            this.colYumakNo.Visible = true;
            this.colYumakNo.VisibleIndex = 1;
            this.colYumakNo.Width = 94;
            // 
            // colUrunAd
            // 
            this.colUrunAd.FieldName = "UrunAd";
            this.colUrunAd.MinWidth = 25;
            this.colUrunAd.Name = "colUrunAd";
            this.colUrunAd.Visible = true;
            this.colUrunAd.VisibleIndex = 2;
            this.colUrunAd.Width = 94;
            // 
            // colResim
            // 
            this.colResim.FieldName = "Resim";
            this.colResim.MinWidth = 25;
            this.colResim.Name = "colResim";
            this.colResim.Visible = true;
            this.colResim.VisibleIndex = 3;
            this.colResim.Width = 94;
            // 
            // colOEMNo
            // 
            this.colOEMNo.FieldName = "OEMNo";
            this.colOEMNo.MinWidth = 25;
            this.colOEMNo.Name = "colOEMNo";
            this.colOEMNo.Visible = true;
            this.colOEMNo.VisibleIndex = 4;
            this.colOEMNo.Width = 94;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.yumakDataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 638);
            this.Controls.Add(this.gridStok);
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStok_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStok_FormClosed);
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokView;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private YumakDataSetTableAdapters.StokTableAdapter stokTableAdapter;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private YumakDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colYumakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colOEMNo;
    }
}