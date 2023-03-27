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
    public partial class FrmDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetay()
        {
            InitializeComponent();
        }

        private void FrmDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeDetay' table. You can move, or remove it, as needed.
            this.projeDetayTableAdapter.ProjeIDFillBy(this.yumakDataSet.ProjeDetay, int.Parse(FrmArge.id));

        }
    }
}