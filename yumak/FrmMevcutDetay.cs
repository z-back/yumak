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
    public partial class FrmMevcutDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmMevcutDetay()
        {
            InitializeComponent();
        }

        private void FrmMevcutDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yumakDataSet.SevkiyatPaketleme' table. You can move, or remove it, as needed.
            this.sevkiyatPaketlemeTableAdapter.pidbitFillBy(this.yumakDataSet.SevkiyatPaketleme, FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.Montaj' table. You can move, or remove it, as needed.
            this.montajTableAdapter.pidbitFillBy(this.yumakDataSet.Montaj, FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.UretimPlanlama' table. You can move, or remove it, as needed.
            this.uretimPlanlamaTableAdapter.pidbitFillBy(this.yumakDataSet.UretimPlanlama, FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.KaliteKontrol' table. You can move, or remove it, as needed.
            this.kaliteKontrolTableAdapter.pidbitFillBy(this.yumakDataSet.KaliteKontrol, FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.KaliphaneAparat' table. You can move, or remove it, as needed.
            this.kaliphaneAparatTableAdapter.pidbitFillBy(this.yumakDataSet.KaliphaneAparat,FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.DisHizmet' table. You can move, or remove it, as needed.
            this.disHizmetTableAdapter.pidbitFillBy(this.yumakDataSet.DisHizmet, FrmMevcut.id, false);
            // TODO: This line of code loads data into the 'yumakDataSet.ArgeTasarimR' table. You can move, or remove it, as needed.
            this.argeTasarimRTableAdapter.pidbitFillBy(this.yumakDataSet.ArgeTasarimR,FrmMevcut.id,false);
            // TODO: This line of code loads data into the 'yumakDataSet.ParcaGenelBilgiler' table. You can move, or remove it, as needed.
            this.parcaGenelBilgilerTableAdapter.pidbitFillBy(this.yumakDataSet.ParcaGenelBilgiler, FrmMevcut.id, false);

        }
    }
}