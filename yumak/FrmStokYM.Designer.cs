
namespace yumak
{
    partial class FrmStokYM
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
            this.gridStokYM = new DevExpress.XtraGrid.GridControl();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gridStokYMView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYumakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOEMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stokTableAdapter = new yumak.YumakDataSetTableAdapters.StokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokYM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokYMView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStokYM
            // 
            this.gridStokYM.DataSource = this.stokBindingSource;
            this.gridStokYM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStokYM.Location = new System.Drawing.Point(0, 0);
            this.gridStokYM.MainView = this.gridStokYMView;
            this.gridStokYM.Name = "gridStokYM";
            this.gridStokYM.Size = new System.Drawing.Size(951, 638);
            this.gridStokYM.TabIndex = 1;
            this.gridStokYM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokYMView});
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
            // gridStokYMView
            // 
            this.gridStokYMView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colYumakNo,
            this.colUrunAd,
            this.colResim,
            this.colOEMNo});
            this.gridStokYMView.GridControl = this.gridStokYM;
            this.gridStokYMView.Name = "gridStokYMView";
            this.gridStokYMView.OptionsBehavior.Editable = false;
            this.gridStokYMView.OptionsBehavior.ReadOnly = true;
            this.gridStokYMView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridStokYMView_RowCellClick);
            this.gridStokYMView.DoubleClick += new System.EventHandler(this.gridStokYMView_DoubleClick);
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
            // FrmStokYM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 638);
            this.Controls.Add(this.gridStokYM);
            this.Name = "FrmStokYM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStokYM";
            this.Load += new System.EventHandler(this.FrmStokYM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStokYM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokYMView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStokYM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokYMView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colYumakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colOEMNo;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private YumakDataSetTableAdapters.StokTableAdapter stokTableAdapter;
    }
}