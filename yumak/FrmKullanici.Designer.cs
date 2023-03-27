
namespace yumak
{
    partial class FrmKullanici
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
            this.gridKullanici = new DevExpress.XtraGrid.GridControl();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gViewKullanici = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanıcıAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullaniciTableAdapter = new yumak.YumakDataSetTableAdapters.KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKullanici
            // 
            this.gridKullanici.DataSource = this.kullaniciBindingSource;
            this.gridKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKullanici.Location = new System.Drawing.Point(0, 0);
            this.gridKullanici.MainView = this.gViewKullanici;
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(951, 638);
            this.gridKullanici.TabIndex = 1;
            this.gridKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewKullanici});
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.yumakDataSet;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gViewKullanici
            // 
            this.gViewKullanici.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAd,
            this.colSoyad,
            this.colKullanıcıAD});
            this.gViewKullanici.GridControl = this.gridKullanici;
            this.gViewKullanici.Name = "gViewKullanici";
            this.gViewKullanici.OptionsBehavior.Editable = false;
            this.gViewKullanici.OptionsBehavior.ReadOnly = true;
            this.gViewKullanici.DoubleClick += new System.EventHandler(this.gViewKullanici_DoubleClick);
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
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 2;
            this.colSoyad.Width = 94;
            // 
            // colKullanıcıAD
            // 
            this.colKullanıcıAD.FieldName = "KullanıcıAD";
            this.colKullanıcıAD.MinWidth = 25;
            this.colKullanıcıAD.Name = "colKullanıcıAD";
            this.colKullanıcıAD.Visible = true;
            this.colKullanıcıAD.VisibleIndex = 3;
            this.colKullanıcıAD.Width = 94;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 638);
            this.Controls.Add(this.gridKullanici);
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKullanici";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanıcıAD;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private YumakDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
    }
}