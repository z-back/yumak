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
    public partial class FrmBitenDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmBitenDetay()
        {
            InitializeComponent();
        }

        private void FrmBitenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.SevkiyatPaketleme' table. You can move, or remove it, as needed.
            this.sevkiyatPaketlemeTableAdapter.pidbitFillBy(this.yumakDataSet.SevkiyatPaketleme, FrmBiten.id,true);
            // TODO: This line of code loads data into the 'yumakDataSet1.Montaj' table. You can move, or remove it, as needed.
            this.montajTableAdapter.pidbitFillBy(this.yumakDataSet1.Montaj, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet1.UretimPlanlama' table. You can move, or remove it, as needed.
            this.uretimPlanlamaTableAdapter.pidbitFillBy(this.yumakDataSet1.UretimPlanlama, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet1.KaliteKontrol' table. You can move, or remove it, as needed.
            this.kaliteKontrolTableAdapter.pidbitFillBy(this.yumakDataSet1.KaliteKontrol, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet1.KaliphaneAparat' table. You can move, or remove it, as needed.
            this.kaliphaneAparatTableAdapter.pidbitFillBy(this.yumakDataSet1.KaliphaneAparat, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet.DisHizmet' table. You can move, or remove it, as needed.
            this.disHizmetTableAdapter.pidbitFillBy(this.yumakDataSet.DisHizmet, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet.ArgeTasarimR' table. You can move, or remove it, as needed.
            this.argeTasarimRTableAdapter.pidbitFillBy(this.yumakDataSet.ArgeTasarimR, FrmBiten.id, true);
            // TODO: This line of code loads data into the 'yumakDataSet.ParcaGenelBilgiler' table. You can move, or remove it, as needed.
            this.parcaGenelBilgilerTableAdapter.pidbitFillBy(this.yumakDataSet.ParcaGenelBilgiler, FrmBiten.id,true);

        }

        
    }
}