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
    public partial class FrmBiten : DevExpress.XtraEditors.XtraForm
    {
        public FrmBiten()
        {
            InitializeComponent();
        }

        private void FrmBiten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeUstBilgileri' table. You can move, or remove it, as needed.
            this.projeUstBilgileriTableAdapter.DurumUretildiFillBy(this.yumakDataSet.ProjeUstBilgileri);

        }


        public static int id = 0;
        
        private void btnBitenDetay_DoubleClick(object sender, EventArgs e)
        {
            int index = gViewBiten.FocusedRowHandle;
            
            if (index >= 0)
            {
                id = Convert.ToInt32(gViewBiten.GetRowCellValue(index, "ID").ToString());
            }
            FrmBitenDetay frm = new FrmBitenDetay();
            frm.Show();
        }


        private void gViewBiten_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }
    }
}