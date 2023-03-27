using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yumak
{
    public partial class FrmArge : DevExpress.XtraEditors.XtraForm
    {
        public FrmArge()
        {
            InitializeComponent();
        }

        private void btnBitenP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBiten frm = new FrmBiten();
            frm.Show();
        }

        private void btnMevcutP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMevcut frm = new FrmMevcut();
            frm.Show();
        }

        private void btnYeniP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void FrmArge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeUstBilgileri' table. You can move, or remove it, as needed.
            this.projeDetayTableAdapter1.Fill(this.yumakDataSet.ProjeDetay);
            this.projeUstBilgileriTableAdapter.Fill(yumakDataSet.ProjeUstBilgileri);
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmDetay frm = new FrmDetay();
            frm.Show();
           
        }
       
        private void gViewArge_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //gViewArge.BeginUpdate();
            //foreach (GridColumn column in gViewArge.VisibleColumns)
            //{
            //    if (column.FieldName == "Detay")
            //        column.OptionsColumn.ReadOnly = false;
            //    else
            //        column.OptionsColumn.ReadOnly = true;
            //}
            //gViewArge.EndUpdate();

        }

       

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDetay frm = new FrmDetay();
            frm.Show();
        }

        private void gViewArge_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string durum;
            durum = gViewArge.GetRowCellValue(e.RowHandle,"Durum").ToString();
            if(durum == "Devam Ediyor")
            {
                e.Appearance.BackColor = Color.Red;
            }else if( durum == "Üretildi")
            {
                e.Appearance.BackColor = Color.Green;
            }
        }

        

        private void btnProjeOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProjeOlustur frm = new FrmProjeOlustur();
            frm.Show();
        }

        private void gViewArge_DoubleClick(object sender, EventArgs e)
        {
            
        }
        
        public static string id;
        
        private void btnArgeDetay_DoubleClick(object sender, EventArgs e)
        {
            id = gViewArge.GetFocusedRowCellValue("ID").ToString();
            FrmDetay frm = new FrmDetay();
            frm.Show();
        }

       
    }
}