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
    public partial class FrmKullaniciYM : DevExpress.XtraEditors.XtraForm
    {
        public FrmKullaniciYM()
        {
            InitializeComponent();
        }

        private void FrmKullaniciYMSec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.yumakDataSet.Kullanici);

        }
        public static string KullaniciYMID;
        private void gViewKullanici_DoubleClick(object sender, EventArgs e)
        {
            KullaniciYMID = gViewKullanici.GetFocusedRowCellValue("ID").ToString();
            this.Close();
        }
    }
}