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
    public partial class FrmMevcut : DevExpress.XtraEditors.XtraForm
    {
        public FrmMevcut()
        {
            InitializeComponent();
        }

        

        private void FrmMevcut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeUstBilgileri' table. You can move, or remove it, as needed.
            this.projeUstBilgileriTableAdapter.DurumDevamFillBy(this.yumakDataSet.ProjeUstBilgileri);
        }

        private void btnMevcutDetay_Click(object sender, EventArgs e)
        {

        }
        public static int id = 0;
        private void btnMevcutDetay_DoubleClick(object sender, EventArgs e)
        {
            
        int index = gViewMevcut.FocusedRowHandle;
            
            if (index >= 0)
            {
                id = Convert.ToInt32(gViewMevcut.GetRowCellValue(index, "ID").ToString());
            }
            FrmMevcutDetay frm = new FrmMevcutDetay();
            frm.Show();
        }
    }
}