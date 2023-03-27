using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yumak
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.yumakDataSet.Kullanici);
            // TODO: This line of code loads data into the 'yumakDataSet.Stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.yumakDataSet.Stok);

        }
        public static string StokID;
        private void gridStokView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            StokID = gridStokView.GetFocusedRowCellValue("ID").ToString();

        }

        

        private void FrmStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FrmStok_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void gridStok_Click(object sender, EventArgs e)
        {

        }

        private void gridStokView_Click(object sender, EventArgs e)
        {
           
        }

        private void gridStokView_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}