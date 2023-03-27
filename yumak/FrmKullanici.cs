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
    public partial class FrmKullanici : DevExpress.XtraEditors.XtraForm
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }
        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.yumakDataSet.Kullanici);



        }
        public static string KullaniciID;
        private void gViewKullanici_DoubleClick(object sender, EventArgs e)
        {
            KullaniciID = gViewKullanici.GetFocusedRowCellValue("ID").ToString();
            this.Close();
        }
    }
}