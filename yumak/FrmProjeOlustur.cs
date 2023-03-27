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
    public partial class FrmProjeOlustur : DevExpress.XtraEditors.XtraForm
    {
        public FrmProjeOlustur()
        {
            InitializeComponent();
        }

        private void FrmProjeOlustur_Load(object sender, EventArgs e)
        {

        }
        private void FrmProjeOlustur_Activated(object sender, EventArgs e)
        {

            TabloDoldur();
            txtProjeOlusturStokID.Text = FrmStok.StokID;
            txtProjeOlusturKullaniciID.Text = FrmKullanici.KullaniciID;
            txtStokYMID.Text = FrmStokYM.StokYMID;
            txtKullaniciYMID.Text = FrmKullaniciYM.KullaniciYMID;


            StokSecDoldur();
        }

        YumakEntities db = new YumakEntities();
        public int id = 0;

        public int ProjeUstID;
        public int StokID;
        public int StokYMID;
        public int KullaniciID;
        public int KullaniciYMID;

        public DateTime ProjeBaslangicTarihi;
        public DateTime PlanlananProjeTarihi;
        public DateTime BildirimTarihi;
        public DateTime GerceklesenProjeTarihi;


        public void TabloDoldur()
        {
            // TODO: This line of code loads data into the 'yumakDataSet.SevkiyatPaketleme' table. You can move, or remove it, as needed.
            this.sevkiyatPaketlemeTableAdapter.Fill(this.yumakDataSet.SevkiyatPaketleme);
            // TODO: This line of code loads data into the 'yumakDataSet.Montaj' table. You can move, or remove it, as needed.
            this.montajTableAdapter.Fill(this.yumakDataSet.Montaj);
            // TODO: This line of code loads data into the 'yumakDataSet.UretimPlanlama' table. You can move, or remove it, as needed.
            this.uretimPlanlamaTableAdapter.Fill(this.yumakDataSet.UretimPlanlama);
            // TODO: This line of code loads data into the 'yumakDataSet.KaliteKontrol' table. You can move, or remove it, as needed.
            this.kaliteKontrolTableAdapter.Fill(this.yumakDataSet.KaliteKontrol);
            // TODO: This line of code loads data into the 'yumakDataSet.KaliphaneAparat' table. You can move, or remove it, as needed.
            this.kaliphaneAparatTableAdapter.Fill(this.yumakDataSet.KaliphaneAparat);
            // TODO: This line of code loads data into the 'yumakDataSet.DisHizmet' table. You can move, or remove it, as needed.
            this.disHizmetTableAdapter.Fill(this.yumakDataSet.DisHizmet);
            // TODO: This line of code loads data into the 'yumakDataSet.ArgeTasarimR' table. You can move, or remove it, as needed.
            this.argeTasarimRTableAdapter.Fill(this.yumakDataSet.ArgeTasarimR);
            // TODO: This line of code loads data into the 'yumakDataSet.ParcaGenelBilgiler' table. You can move, or remove it, as needed.
            this.parcaGenelBilgilerTableAdapter.Fill(this.yumakDataSet.ParcaGenelBilgiler);
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeDetay' table. You can move, or remove it, as needed.
            this.projeDetayTableAdapter.ProjeIDFillBy(this.yumakDataSet.ProjeDetay, id);
            // TODO: This line of code loads data into the 'yumakDataSet.vKullaniciProjeUst' table. You can move, or remove it, as needed.
            this.vKullaniciProjeUstTableAdapter.Fill(this.yumakDataSet.vKullaniciProjeUst);
            // TODO: This line of code loads data into the 'yumakDataSet.ProjeUstBilgileri' table. You can move, or remove it, as needed.
            this.projeUstBilgileriTableAdapter.Fill(this.yumakDataSet.ProjeUstBilgileri);
        }
        private void sBtnParcaGenelKaydet_Click(object sender, EventArgs e)
        {
            if (txtParcaGenelProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtParcaGenelID.Text);
                var query = from x in db.ParcaGenelBilgilers
                            where x.ID == ID
                            select x;

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.Malzeme = txtParcaGenelMalzeme.Text;
                        item.HamMalzemeUretimYontemi = txtParcaGenelHamMalzeme.Text;
                        item.Sertlik = txtParcaGenelSertlik.Text;
                        item.IsilIslem = txtParcaGenelIsilIslem.Text;
                        item.Kaplama = txtPArcaGenelKaplama.Text;
                        item.TedarikciBilgisi = txtParcaGenelTedarikciBilg.Text;
                        if (rBtnParcaGenelTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;

                            YumakEntities dbdeneme = new YumakEntities();
                            int ProjeID = int.Parse(txtParcaGenelProjeID.Text);
                            int ProjeDetayID = int.Parse(txtParcaGenelProjeDetayID.Text);

                            var query2 = from x in dbdeneme.ProjeDetays
                                         where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                                         select x;

                            if (query2.Any())
                            {

                                foreach (var x in query2)
                                {
                                    decimal? hesapla = x.Yuzde + (100 / x.Sayac);
                                    x.Yuzde = hesapla;


                                }
                            }
                            dbdeneme.SaveChanges();

                        }
                        else if (rBtnParcaGenelTamamlanmadi.Checked == true)
                        {

                            item.TamamlanmaDurumu = false;

                            //if (query2.Any())
                            //{


                            //    foreach (var x in query2)
                            //    {

                            //        x.Yuzde = x.Yuzde - (100 / x.Sayac);

                            //    }
                            //}
                            //dbdeneme.SaveChanges();

                        }



                    }
                    db.SaveChanges();

                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");



            }
            ClearAll(sidePanel1);
            this.parcaGenelBilgilerTableAdapter.Fill(this.yumakDataSet.ParcaGenelBilgiler);


        }

        //Sidepanel içerisindeki textbox'ları temizler. Parametre olarak side panel ismini veya groupcontrol ismini verebilirsin.
        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
            }
            rBtnParcaGenelTamamlanmadi.Checked = true;
            rBtnArgeTasarimTamamlanmadi.Checked = true;
            rBtnDisHizmetTamamlanmadi.Checked = true;
            rBtnKalipHaneTamamlanmadi.Checked = true;
            rBtnKaliteKontrolTamamlanmadi.Checked = true;
            rBtnUretimPlanlamaTamamlanmadi.Checked = true;
            rBtnMontajTamamlanmadi.Checked = true;
            rBtnSevkiyatPaketlemeTamamlanmadi.Checked = true;



        }
        public void StokSecDoldur()
        {
            if (txtProjeOlusturStokID.Text == "")
            {

            }
            else
            {
                StokID = int.Parse(txtProjeOlusturStokID.Text);
                Byte[] image;
                var query = from x in db.Stoks where x.ID == StokID select x;
                if (query.Any())
                {
                    try
                    {
                        txtProjeOlusturStokID.Text = query.FirstOrDefault().ID.ToString();
                        txtProjeOlusturOemNo.Text = query.FirstOrDefault().OEMNo;


                        image = Encoding.ASCII.GetBytes(query.FirstOrDefault().Resim.ToString());

                        if (!DBNull.Value.Equals(query.FirstOrDefault().Resim.ToString()))
                        {
                            var DATA = (Byte[])(query.FirstOrDefault().Resim);
                            var StokStream = new MemoryStream(DATA);
                            pictureEdit1.Image = Image.FromStream(StokStream);
                        }
                        else
                        {
                            pictureEdit1.Image = null;
                        }

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);

                    }



                }
            }
        }


        int pdid = 0;
        private void sBtnKalemOlustur_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (id == 0)
            {
                XtraMessageBox.Show("Lütfen tablodan bir seçim yapınız.. Seçim yapmak için satırın üzerine çift tıklayınız..", "Uyarı");
            }
            else if (txtProjeOlusturSiraNo.Text == "" ||
                txtProjeOlusturYumakNo.Text == "" ||
                txtProjeOlusturAciklamaDetay.Text == "" ||
                txtProjeOlusturYeniUrun.Text == "" ||
                txtProjeOlusturFizibilite.Text == "" ||
                txtProjeOlusturProsesTasarim.Text == "" ||
                txtProjeOlusturIleriKP.Text == ""
               )
            {
                XtraMessageBox.Show("Lütfen gerekli alanları doldurunuz.. ", "Uyarı");

            }
            else if (checkParcaGenel.Checked == false && checkArgeTasarim.Checked == false && checkDisHizmet.Checked == false &&
                checkKaliphane.Checked == false && checkKaliteKontrol.Checked == false &&
                checkUretimPlanlama.Checked == false && checkMontaj.Checked == false && checkSevkiyatPaketleme.Checked == false)
            {

                XtraMessageBox.Show("En az bir adet süreç seçimi yapmalısınız.. ", "Uyarı");

            }

            else
            {
                var query = from x in db.vKullaniciProjeUsts where x.ID == id select x;
                if (query.Any())
                {
                    try
                    {
                        ProjeUstID = int.Parse(query.FirstOrDefault().ID.ToString());
                        StokYMID = int.Parse(query.FirstOrDefault().StokID.ToString());
                        KullaniciYMID = int.Parse(query.FirstOrDefault().KullaniciID.ToString());

                        ProjeBaslangicTarihi = DateTime.Parse(query.FirstOrDefault().ProjeBaslangicTarihi.ToString());
                        PlanlananProjeTarihi = DateTime.Parse(query.FirstOrDefault().PlanlananProjeTarihi.ToString());


                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);

                    }
                }
                YumakEntities dbProjeDetay = new YumakEntities();
                ProjeDetay projeDetay = new ProjeDetay();
                projeDetay.ProjeUstID = ProjeUstID;
                projeDetay.StokID = StokYMID;
                projeDetay.KullaniciID = KullaniciYMID;
                projeDetay.SiraNo = double.Parse(txtProjeOlusturSiraNo.Text);
                projeDetay.YumakNo = txtProjeOlusturYumakNo.Text;
                projeDetay.Aciklama = txtProjeOlusturAciklamaDetay.Text;
                projeDetay.YeniUrunTalep = txtProjeOlusturYeniUrun.Text;
                projeDetay.Fizibilite = txtProjeOlusturFizibilite.Text;
                projeDetay.ProsesTasarim = txtProjeOlusturProsesTasarim.Text;
                projeDetay.IleriKalitePlanlamasiAPQP = txtProjeOlusturIleriKP.Text;
                projeDetay.ProjeBaslangicTarihi = ProjeBaslangicTarihi;
                projeDetay.PlanlananProjeTarihi = PlanlananProjeTarihi;
                projeDetay.Durum = "Devam Ediyor";
                projeDetay.ParcaGenelBilgisi = checkParcaGenel.Checked;
                projeDetay.ArgeTasarimBilgisi = checkArgeTasarim.Checked;
                projeDetay.DisHizmetBilgisi = checkDisHizmet.Checked;
                projeDetay.KaliphaneBilgisi = checkKaliphane.Checked;
                projeDetay.KaliteKontrolBilgisi = checkKaliteKontrol.Checked;
                projeDetay.UretimPlanlamaBilgisi = checkUretimPlanlama.Checked;
                projeDetay.MontajBilgisi = checkMontaj.Checked;
                projeDetay.SevkiyatBilgisi = checkSevkiyatPaketleme.Checked;
                projeDetay.Yuzde = 0;
                var query2 = db.ProjeDetays
                    .OrderByDescending(u => u.ID)
                    .FirstOrDefault();
                pdid = query2.ID;

                #region ifblokları
                if (checkParcaGenel.Checked == true)
                {

                    ParcaGenelBilgiler pgb = new ParcaGenelBilgiler();
                    pgb.ProjeID = ProjeUstID;
                    pgb.ProjeDetayID = query2.ID + 1;
                    pgb.TamamlanmaDurumu = false;

                    db.ParcaGenelBilgilers.Add(pgb);
                    db.SaveChanges();
                    counter++;
                }
                if (checkArgeTasarim.Checked == true)
                {
                    ArgeTasarimR ag = new ArgeTasarimR();
                    ag.ProjeID = ProjeUstID;
                    ag.ProjeDetayID = query2.ID + 1;
                    ag.TamamlanmaDurumu = false;

                    db.ArgeTasarimRs.Add(ag);
                    db.SaveChanges();
                    counter++;

                }
                if (checkDisHizmet.Checked == true)
                {
                    DisHizmet dh = new DisHizmet();
                    dh.ProjeID = ProjeUstID;
                    dh.ProjeDetayID = query2.ID + 1;
                    dh.TamamlanmaDurumu = false;

                    db.DisHizmets.Add(dh);
                    db.SaveChanges();
                    counter++;

                }
                if (checkKaliphane.Checked == true)
                {
                    KaliphaneAparat ka = new KaliphaneAparat();
                    ka.ProjeID = ProjeUstID;
                    ka.ProjeDetayID = query2.ID + 1;
                    ka.TamamlanmaDurumu = false;

                    db.KaliphaneAparats.Add(ka);
                    db.SaveChanges();
                    counter++;

                }
                if (checkKaliteKontrol.Checked == true)
                {

                    KaliteKontrol kk = new KaliteKontrol();
                    kk.ProjeID = ProjeUstID;
                    kk.ProjeDetayID = query2.ID + 1;
                    kk.TamamlanmaDurumu = false;
                    kk.OzelOlcmeEkipmaniIhtiyaci = false;

                    db.KaliteKontrols.Add(kk);
                    db.SaveChanges();
                    counter++;

                }
                if (checkUretimPlanlama.Checked == true)
                {
                    UretimPlanlama up = new UretimPlanlama();
                    up.ProjeID = ProjeUstID + 1;
                    up.ProjeDetayID = query2.ID;
                    up.TamamlanmaDurumu = false;


                    db.UretimPlanlamas.Add(up);
                    db.SaveChanges();
                    counter++;

                }
                if (checkMontaj.Checked == true)
                {
                    Montaj m = new Montaj();
                    m.ProjeID = ProjeUstID + 1;
                    m.ProjeDetayID = query2.ID;
                    m.TamamlanmaDurumu = false;

                    db.Montajs.Add(m);
                    db.SaveChanges();
                    counter++;

                }
                if (checkSevkiyatPaketleme.Checked == true)
                {
                    SevkiyatPaketleme sp = new SevkiyatPaketleme();
                    sp.ProjeID = ProjeUstID + 1;
                    sp.ProjeDetayID = pdid;
                    sp.TamamlanmaDurumu = false;
                    sp.YeniAmbalajIhtiyaci = false;

                    db.SevkiyatPaketlemes.Add(sp);
                    db.SaveChanges();
                    counter++;

                }
                projeDetay.Sayac = counter;
                dbProjeDetay.ProjeDetays.Add(projeDetay);
                dbProjeDetay.SaveChanges();

                XtraMessageBox.Show("Ekleme işlemi başarılı.. ", "Uyarı");
                ClearAll(groupControl1);
                checkParcaGenel.Checked = false;
                checkArgeTasarim.Checked = false;
                checkDisHizmet.Checked = false;
                checkKaliphane.Checked = false;
                checkKaliteKontrol.Checked = false;
                checkUretimPlanlama.Checked = false;
                checkMontaj.Checked = false;
                checkSevkiyatPaketleme.Checked = false;

                #endregion


            }



            this.projeDetayTableAdapter.ProjeIDFillBy(this.yumakDataSet.ProjeDetay, id);



        }

        private void gViewProjeOlustur_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(gViewProjeOlustur.GetFocusedRowCellValue("ID").ToString());
            this.projeDetayTableAdapter.ProjeIDFillBy(this.yumakDataSet.ProjeDetay, id);

        }

        private void sBtnProjeOlusturStokSec_Click(object sender, EventArgs e)
        {
            FrmStok frm = new FrmStok();
            frm.Show();


        }

        private void sBtnProjeOlusturKullaniciSec_Click(object sender, EventArgs e)
        {
            FrmKullanici frm = new FrmKullanici();
            frm.Show();

        }

        private void sBtnProjeOlustur_Click(object sender, EventArgs e)
        {
            if (txtProjeOlusturStokID.Text == "")
            {
                XtraMessageBox.Show("Lütfen bir stok seçiniz.. ", "Uyarı");

            }
            else if (txtProjeOlusturKullaniciID.Text == "")
            {
                XtraMessageBox.Show("Lütfen bir kullanıcı seçiniz.. ", "Uyarı");
            }
            else if (dateProjeOlusturPlanlanan.Text == "" || dateProjeOlusturBildirim.Text == "" || txtProjeOlusturAciklama.Text == "" || txtProjeOlusturOemNo.Text == "")
            {
                XtraMessageBox.Show("Lütfen gerekli alanları doldurunuz.. ", "Uyarı");
            }
            else
            {

                ProjeUstBilgileri projeUstBilgileri = new ProjeUstBilgileri();
                projeUstBilgileri.StokID = int.Parse(txtProjeOlusturStokID.Text);
                projeUstBilgileri.KullaniciID = int.Parse(txtProjeOlusturKullaniciID.Text);
                projeUstBilgileri.ProjeBaslangicTarihi = DateTime.Now;
                projeUstBilgileri.PlanlananProjeTarihi = DateTime.Parse(dateProjeOlusturPlanlanan.Text);
                projeUstBilgileri.BildirimTarihi = DateTime.Parse(dateProjeOlusturBildirim.Text);
                projeUstBilgileri.Aciklama = txtProjeOlusturAciklama.Text;
                projeUstBilgileri.Durum = "Devam Ediyor";
                projeUstBilgileri.OEMNo = txtProjeOlusturOemNo.Text;

                db.ProjeUstBilgileris.Add(projeUstBilgileri);
                db.SaveChanges();
                XtraMessageBox.Show("Ekleme işlemi başarılı.. ", "Uyarı");

            }

            ClearAll(groupControl2);

            pictureEdit1.Image = null;
            txtProjeOlusturKullaniciID.Text = "";
            txtProjeOlusturStokID.Text = "";
            txtProjeOlusturOemNo.Text = "";
            this.vKullaniciProjeUstTableAdapter.Fill(this.yumakDataSet.vKullaniciProjeUst);

        }

        private void sBtnStokYMSec_Click(object sender, EventArgs e)
        {
            FrmStokYM frm = new FrmStokYM();
            frm.Show();
        }

        private void sBtnKullaniciYMSec_Click(object sender, EventArgs e)
        {
            FrmKullaniciYM frm = new FrmKullaniciYM();
            frm.Show();
        }

        int seciliProjeDetayID;
        private void gViewProjeDetay_DoubleClick(object sender, EventArgs e)
        {
            seciliProjeDetayID = int.Parse(gViewProjeDetay.GetFocusedRowCellValue("ID").ToString());

            var query2 = from x in db.ProjeDetays where x.ID == seciliProjeDetayID select x;

            int pid = int.Parse(query2.FirstOrDefault().ProjeUstID.ToString());
            this.parcaGenelBilgilerTableAdapter.pidpdidFillBy(this.yumakDataSet.ParcaGenelBilgiler, pid, seciliProjeDetayID);
            this.sevkiyatPaketlemeTableAdapter.pidpdidFillBy(this.yumakDataSet.SevkiyatPaketleme, pid, seciliProjeDetayID);
            this.montajTableAdapter.pidpdidFillBy(this.yumakDataSet.Montaj, pid, seciliProjeDetayID);
            this.uretimPlanlamaTableAdapter.pidpdidFillBy(this.yumakDataSet.UretimPlanlama, pid, seciliProjeDetayID);
            this.kaliteKontrolTableAdapter.pidpdidFillBy(this.yumakDataSet.KaliteKontrol, pid, seciliProjeDetayID);
            this.kaliphaneAparatTableAdapter.pidpdidFillBy(this.yumakDataSet.KaliphaneAparat, pid, seciliProjeDetayID);
            this.disHizmetTableAdapter.pidpdidFillBy(this.yumakDataSet.DisHizmet, pid, seciliProjeDetayID);
            this.argeTasarimRTableAdapter.pidpdidFillBy(this.yumakDataSet.ArgeTasarimR, pid, seciliProjeDetayID);
        }
        private void gViewParcaGenel_DoubleClick(object sender, EventArgs e)
        {
            int Tpg = int.Parse(gViewParcaGenel.GetFocusedRowCellValue("ID").ToString());

            var query = from x in db.ParcaGenelBilgilers where x.ID == Tpg select x;
            if (query.Any())
            {
                foreach (var item in query)
                {
                    if (item.Malzeme == null) { item.Malzeme = ""; }
                    if (item.HamMalzemeUretimYontemi == null) { item.HamMalzemeUretimYontemi = ""; }
                    if (item.Sertlik == null) { item.Sertlik = ""; }
                    if (item.IsilIslem == null) { item.IsilIslem = ""; }
                    if (item.Kaplama == null) { item.Kaplama = ""; }
                    if (item.TedarikciBilgisi == null) { item.TedarikciBilgisi = ""; }
                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtParcaGenelID.Text = query.FirstOrDefault().ID.ToString();
                txtParcaGenelProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtParcaGenelProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                txtParcaGenelMalzeme.Text = query.FirstOrDefault().Malzeme.ToString();
                txtParcaGenelHamMalzeme.Text = query.FirstOrDefault().HamMalzemeUretimYontemi.ToString();
                txtParcaGenelSertlik.Text = query.FirstOrDefault().Sertlik.ToString();
                txtParcaGenelIsilIslem.Text = query.FirstOrDefault().IsilIslem.ToString();
                txtPArcaGenelKaplama.Text = query.FirstOrDefault().Kaplama.ToString();
                txtParcaGenelTedarikciBilg.Text = query.FirstOrDefault().TedarikciBilgisi.ToString();
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnParcaGenelTamamlandi.Checked = true;
                }

                else
                {
                    rBtnParcaGenelTamamlanmadi.Checked = true;
                }


            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }


        }
        private void gViewArgeTasarim_DoubleClick(object sender, EventArgs e)
        {
            int Tagr = int.Parse(gViewArgeTasarim.GetFocusedRowCellValue("ID").ToString());

            var query = from x in db.ArgeTasarimRs where x.ID == Tagr select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.PlanlananKatiModelCizimi == null) { item.PlanlananKatiModelCizimi = DateTime.MinValue; }
                    if (item.GerceklesenKatiModelCizimi == null) { item.GerceklesenKatiModelCizimi = DateTime.MinValue; }
                    if (item.PlanlananTeknikResimCizimi == null) { item.PlanlananTeknikResimCizimi = DateTime.MinValue; }
                    if (item.GerceklesenTeknikResimCizimi == null) { item.GerceklesenTeknikResimCizimi = DateTime.MinValue; }
                    if (item.ResimOnayTarihi == null) { item.ResimOnayTarihi = DateTime.MinValue; }
                    if (item.Recete == null) { item.Recete = DateTime.MinValue; }
                    if (item.OperasyonelRecete == null) { item.OperasyonelRecete = DateTime.MinValue; }

                    if (item.AkisSemasi == null) { item.AkisSemasi = ""; }
                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtArgeTasarimID.Text = query.FirstOrDefault().ID.ToString();
                txtArgeTasarimProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtArgeTasarimProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                dEditArgeTasarimPKatiMCizimi.Text = query.FirstOrDefault().PlanlananKatiModelCizimi.ToString();
                dEditArgeTasarimGKatiMCizimi.Text = query.FirstOrDefault().GerceklesenKatiModelCizimi.ToString();
                dEditArgeTasarimPTeknikMCizimi.Text = query.FirstOrDefault().PlanlananTeknikResimCizimi.ToString();
                dEditArgeTasarimGTeknikMCizimi.Text = query.FirstOrDefault().GerceklesenTeknikResimCizimi.ToString();
                dEditArgeTasarimResimOnay.Text = query.FirstOrDefault().ResimOnayTarihi.ToString();
                dEditArgeTasarimRecete.Text = query.FirstOrDefault().Recete.ToString();
                dEditArgeTasarimOperasyonelRecete.Text = query.FirstOrDefault().OperasyonelRecete.ToString();
                txtArgeTasarimAkisSemasi.Text = query.FirstOrDefault().AkisSemasi.ToString();

                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnArgeTasarimTamamlandi.Checked = true;
                }

                else
                {
                    rBtnArgeTasarimTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }
        private void gViewDisHizmet_DoubleClick(object sender, EventArgs e)
        {
            int Tdh = int.Parse(gViewDisHizmet.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.DisHizmets where x.ID == Tdh select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.ResimIletimTarihi == null) { item.ResimIletimTarihi = DateTime.MinValue; }
                    if (item.SatinAlmaTerminTarihi == null) { item.SatinAlmaTerminTarihi = DateTime.MinValue; }
                    if (item.SatinAlmaNumuneGelisTarihi == null) { item.SatinAlmaNumuneGelisTarihi = DateTime.MinValue; }
                    if (item.NumuneOnayTarihi == null) { item.NumuneOnayTarihi = DateTime.MinValue; }
                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtDisHizmetID.Text = query.FirstOrDefault().ID.ToString();
                txtDisHizmetProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtDisHizmetProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                dEditDisHizmetResimIletimTarihi.Text = query.FirstOrDefault().ResimIletimTarihi.ToString();
                dEditDisHizmetSatinAlmaTerminTarihi.Text = query.FirstOrDefault().SatinAlmaTerminTarihi.ToString();
                dEditDisHizmetSatinAlmaNumuneGelisTarihi.Text = query.FirstOrDefault().SatinAlmaNumuneGelisTarihi.ToString();
                dEditDisHizmetNumuneOnayTarihi.Text = query.FirstOrDefault().NumuneOnayTarihi.ToString();


                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnDisHizmetTamamlandi.Checked = true;
                }

                else
                {
                    rBtnDisHizmetTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }
        private void gViewKalipHaneAparat_DoubleClick(object sender, EventArgs e)
        {
            int Tka = int.Parse(gViewKalipHaneAparat.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.KaliphaneAparats where x.ID == Tka select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.IhtiyacDuyulanKalipAdedi == null) { item.IhtiyacDuyulanKalipAdedi = 0; }
                    if (item.KalipTerminTarihi == null) { item.KalipTerminTarihi = DateTime.MinValue; }
                    if (item.KalipGerceklesenNumuneTarihi == null) { item.KalipGerceklesenNumuneTarihi = DateTime.MinValue; }
                    if (item.KaliteNumuneOnayTarihi == null) { item.KaliteNumuneOnayTarihi = DateTime.MinValue; }

                    if (item.IhtiyacDuyulanAparatAdedi == null) { item.IhtiyacDuyulanAparatAdedi = 0; }
                    if (item.AparatTerminTarihi == null) { item.AparatTerminTarihi = DateTime.MinValue; }
                    if (item.AparatGerceklesenTeslimTarihi == null) { item.AparatGerceklesenTeslimTarihi = DateTime.MinValue; }


                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtKalipHaneID.Text = query.FirstOrDefault().ID.ToString();
                txtKalipHaneProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtKalipHaneProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                txtKalipHaneProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtKalipHaneProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();
                txtKalipHaneIhtıyacKalipAdedi.Text = query.FirstOrDefault().IhtiyacDuyulanKalipAdedi.ToString();
                dEditKalipHaneKalipTerminTarihi.Text = query.FirstOrDefault().KalipTerminTarihi.ToString();
                dEditKalipHaneKalipGerceklesenNumuneTarihi.Text = query.FirstOrDefault().KalipGerceklesenNumuneTarihi.ToString();
                dEditKalipHaneKaliteNumuneOnayTarihi.Text = query.FirstOrDefault().KaliteNumuneOnayTarihi.ToString();
                txtKalipHaneIhtiyacDuyulanAparatAdedi.Text = query.FirstOrDefault().IhtiyacDuyulanAparatAdedi.ToString();
                dEditKalipHaneAparatTerminTarihi.Text = query.FirstOrDefault().AparatTerminTarihi.ToString();
                dEditKalipHaneAparatGerceklesenTeslimTarihi.Text = query.FirstOrDefault().AparatGerceklesenTeslimTarihi.ToString();
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnKalipHaneTamamlandi.Checked = true;
                }

                else
                {
                    rBtnKalipHaneTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }

        private void gViewKaliteKontrol_DoubleClick(object sender, EventArgs e)
        {
            int Tkk = int.Parse(gViewKaliteKontrol.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.KaliteKontrols where x.ID == Tkk select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.OzelOlcmeEkipmanlariSiparisTarihi == null) { item.OzelOlcmeEkipmanlariSiparisTarihi = DateTime.MinValue; }
                    if (item.OzelOlcmeTakimlarTeslimTarihi == null) { item.OzelOlcmeTakimlarTeslimTarihi = DateTime.MinValue; }
                    if (item.OzelOlcmeEkipmaniIhtiyaci == null) { item.OzelOlcmeEkipmaniIhtiyaci = false; }
                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtKaliteKontrolID.Text = query.FirstOrDefault().ID.ToString();
                txtKaliteKontrolProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtKaliteKontrolProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Text = query.FirstOrDefault().OzelOlcmeEkipmanlariSiparisTarihi.ToString();
                dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Text = query.FirstOrDefault().OzelOlcmeTakimlarTeslimTarihi.ToString();
                if (bool.Parse(query.FirstOrDefault().OzelOlcmeEkipmaniIhtiyaci.ToString()) == true)
                {
                    checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Checked = true;
                }
                else
                {
                    checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Checked = false;
                }
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnKaliteKontrolTamamlandi.Checked = true;
                }

                else
                {
                    rBtnKaliteKontrolTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }
        private void gViewUretimPlanlama_DoubleClick(object sender, EventArgs e)
        {
            int Tup = int.Parse(gViewUretimPlanlama.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.UretimPlanlamas where x.ID == Tup select x;
            if (query.Any())
            {

                foreach (var item in query)
                {

                    if (item.IhtiyacDuyulanOzelTakim == null) { item.IhtiyacDuyulanOzelTakim = ""; }
                    if (item.OzelTakimlarSiparisTarihi == null) { item.OzelTakimlarSiparisTarihi = DateTime.MinValue; }
                    if (item.OzelTakimlarTeslimTarihi == null) { item.OzelTakimlarTeslimTarihi = DateTime.MinValue; }
                    if (item.DenemeUretimTarihi == null) { item.DenemeUretimTarihi = DateTime.MinValue; }

                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtUretimPlanlamaID.Text = query.FirstOrDefault().ID.ToString();
                txtUretimPlanlamaProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtUretimPlanlamaProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Text = query.FirstOrDefault().IhtiyacDuyulanOzelTakim.ToString();
                dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Text = query.FirstOrDefault().OzelTakimlarSiparisTarihi.ToString();

                dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Text = query.FirstOrDefault().OzelTakimlarTeslimTarihi.ToString();
                dEditUretimPlanlamaDenemeUretimTarihi.Text = query.FirstOrDefault().DenemeUretimTarihi.ToString();
                dEditUretimPlanlamaKaliteNumuneOnayTarihi.Text = query.FirstOrDefault().KaliteNumuneOnayTarihi.ToString();
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnUretimPlanlamaTamamlandi.Checked = true;
                }

                else
                {
                    rBtnUretimPlanlamaTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }
        private void gViewMontaj_DoubleClick(object sender, EventArgs e)
        {
            int Tm = int.Parse(gViewMontaj.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.Montajs where x.ID == Tm select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.IlkNumune == null) { item.IlkNumune = ""; }
                    if (item.PilotMontaj == null) { item.PilotMontaj = ""; }

                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }

                }

                txtMontajID.Text = query.FirstOrDefault().ID.ToString();
                txtMontajProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtMontajProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                txtMontajIlkNumune.Text = query.FirstOrDefault().IlkNumune.ToString();
                txtMontajPilotMontaj.Text = query.FirstOrDefault().PilotMontaj.ToString();
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnMontajTamamlandi.Checked = true;
                }

                else
                {
                    rBtnMontajTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }
        private void gViewSevkiyatPaketleme_DoubleClick(object sender, EventArgs e)
        {
            int Tsp = int.Parse(gViewSevkiyatPaketleme.GetFocusedRowCellValue("ID").ToString());
            var query = from x in db.SevkiyatPaketlemes where x.ID == Tsp select x;
            if (query.Any())
            {

                foreach (var item in query)
                {
                    if (item.YeniAmbalajIhtiyaci == null) { item.YeniAmbalajIhtiyaci = false; }
                    if (item.TamamlanmaDurumu == null) { item.TamamlanmaDurumu = false; }


                }

                txtSevkiyatPaketlemeID.Text = query.FirstOrDefault().ID.ToString();
                txtSevkiyatPaketlemeProjeID.Text = query.FirstOrDefault().ProjeID.ToString();
                txtSevkiyatPaketlemeProjeDetayID.Text = query.FirstOrDefault().ProjeDetayID.ToString();

                if (bool.Parse(query.FirstOrDefault().YeniAmbalajIhtiyaci.ToString()) == true)
                {
                    checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Checked = true;
                }
                else
                {
                    checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Checked = false;
                }
                if (bool.Parse(query.FirstOrDefault().TamamlanmaDurumu.ToString()) == true)
                {
                    rBtnSevkiyatPaketlemeTamamlandi.Checked = true;
                }

                else
                {
                    rBtnSevkiyatPaketlemeTamamlanmadi.Checked = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Bir şeyler ters gitti", "Uyarı");
            }
        }

        private void sBtnArgeTasarimKaydet_Click(object sender, EventArgs e)
        {
            if (txtArgeTasarimProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtArgeTasarimID.Text);

                var query = from x in db.ArgeTasarimRs
                            where x.ID == ID
                            select x;

                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtArgeTasarimProjeID.Text);
                int ProjeDetayID = int.Parse(txtArgeTasarimProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.PlanlananKatiModelCizimi = DateTime.Parse(dEditArgeTasarimPKatiMCizimi.Text);
                        item.GerceklesenKatiModelCizimi = DateTime.Parse(dEditArgeTasarimGKatiMCizimi.Text);
                        item.PlanlananTeknikResimCizimi = DateTime.Parse(dEditArgeTasarimPTeknikMCizimi.Text);
                        item.GerceklesenTeknikResimCizimi = DateTime.Parse(dEditArgeTasarimGTeknikMCizimi.Text);
                        item.ResimOnayTarihi = DateTime.Parse(dEditArgeTasarimResimOnay.Text);
                        item.Recete = DateTime.Parse(dEditArgeTasarimRecete.Text);
                        item.OperasyonelRecete = DateTime.Parse(dEditArgeTasarimOperasyonelRecete.Text);
                        item.AkisSemasi = txtArgeTasarimAkisSemasi.Text;
                        if (rBtnArgeTasarimTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();

                        }
                        else if (rBtnArgeTasarimTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;

                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }

                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");
            }
            ClearAll(sidePanel2);
            this.argeTasarimRTableAdapter.Fill(this.yumakDataSet.ArgeTasarimR);


        }

        private void sBtnDisHizmetKaydet_Click(object sender, EventArgs e)
        {
            if (txtDisHizmetProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtDisHizmetID.Text);
                var query = from x in db.DisHizmets
                            where x.ID == ID
                            select x;

                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtDisHizmetProjeID.Text);
                int ProjeDetayID = int.Parse(txtDisHizmetProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;
                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.ResimIletimTarihi = DateTime.Parse(dEditDisHizmetResimIletimTarihi.Text);
                        item.SatinAlmaTerminTarihi = DateTime.Parse(dEditDisHizmetSatinAlmaTerminTarihi.Text);
                        item.SatinAlmaNumuneGelisTarihi = DateTime.Parse(dEditDisHizmetSatinAlmaNumuneGelisTarihi.Text);
                        item.NumuneOnayTarihi = DateTime.Parse(dEditDisHizmetNumuneOnayTarihi.Text);
                        if (rBtnDisHizmetTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                        else if (rBtnDisHizmetTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;

                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }

                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");
            }
            ClearAll(sidePanel3);
            this.disHizmetTableAdapter.Fill(this.yumakDataSet.DisHizmet);

        }

        private void sBtnKalipHaneAparatKaydet_Click(object sender, EventArgs e)
        {
            if (txtKalipHaneProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtKalipHaneID.Text);
                var query = from x in db.KaliphaneAparats
                            where x.ID == ID
                            select x;
                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtKalipHaneProjeID.Text);
                int ProjeDetayID = int.Parse(txtKalipHaneProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.IhtiyacDuyulanKalipAdedi = int.Parse(txtKalipHaneIhtıyacKalipAdedi.Text);
                        item.KalipTerminTarihi = DateTime.Parse(dEditKalipHaneKalipTerminTarihi.Text);
                        item.KalipGerceklesenNumuneTarihi = DateTime.Parse(dEditKalipHaneKalipGerceklesenNumuneTarihi.Text);
                        item.KaliteNumuneOnayTarihi = DateTime.Parse(dEditKalipHaneKaliteNumuneOnayTarihi.Text);
                        item.IhtiyacDuyulanAparatAdedi = int.Parse(txtKalipHaneIhtiyacDuyulanAparatAdedi.Text);
                        item.AparatTerminTarihi = DateTime.Parse(dEditKalipHaneAparatTerminTarihi.Text);
                        item.AparatGerceklesenTeslimTarihi = DateTime.Parse(dEditKalipHaneAparatGerceklesenTeslimTarihi.Text);

                        if (rBtnKalipHaneTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                        else if (rBtnKalipHaneTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;
                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");

            }

            ClearAll(sidePanel4);
            this.kaliphaneAparatTableAdapter.Fill(this.yumakDataSet.KaliphaneAparat);
        }

        private void sBtnKaliteKontrolKaydet_Click(object sender, EventArgs e)
        {
            if (txtKaliteKontrolProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtKaliteKontrolID.Text);
                var query = from x in db.KaliteKontrols
                            where x.ID == ID
                            select x;
                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtKaliteKontrolProjeID.Text);
                int ProjeDetayID = int.Parse(txtKaliteKontrolProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;
                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.OzelOlcmeEkipmanlariSiparisTarihi = DateTime.Parse(dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Text);
                        item.OzelOlcmeTakimlarTeslimTarihi = DateTime.Parse(dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Text);
                        if (checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Checked == true)
                        {
                            item.OzelOlcmeEkipmaniIhtiyaci = true;
                        }
                        else
                        {
                            item.OzelOlcmeEkipmaniIhtiyaci = false;
                        }
                        if (rBtnKaliteKontrolTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }

                        else if (rBtnKaliteKontrolTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;

                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");

            }

            ClearAll(sidePanel5);
            checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Checked = false;
            this.kaliteKontrolTableAdapter.Fill(this.yumakDataSet.KaliteKontrol);
        }

        private void btnUretimPlanlamaKaydet_Click(object sender, EventArgs e)
        {
            if (txtUretimPlanlamaProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtUretimPlanlamaID.Text);
                var query = from x in db.UretimPlanlamas
                            where x.ID == ID
                            select x;

                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtUretimPlanlamaProjeID.Text);
                int ProjeDetayID = int.Parse(txtUretimPlanlamaProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.IhtiyacDuyulanOzelTakim = txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Text;
                        item.OzelTakimlarSiparisTarihi = DateTime.Parse(dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Text);
                        item.OzelTakimlarTeslimTarihi = DateTime.Parse(dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Text);
                        item.DenemeUretimTarihi = DateTime.Parse(dEditUretimPlanlamaDenemeUretimTarihi.Text);
                        item.KaliteNumuneOnayTarihi = DateTime.Parse(dEditUretimPlanlamaKaliteNumuneOnayTarihi.Text);
                        if (rBtnUretimPlanlamaTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                        else if (rBtnUretimPlanlamaTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - 100 / x.Sayac;

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");

            }

            ClearAll(sidePanel6);
            this.uretimPlanlamaTableAdapter.Fill(this.yumakDataSet.UretimPlanlama);
        }

        private void sBtnMontajKaydet_Click(object sender, EventArgs e)
        {
            if (txtMontajProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtMontajID.Text);
                var query = from x in db.Montajs
                            where x.ID == ID
                            select x;
                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtMontajProjeID.Text);
                int ProjeDetayID = int.Parse(txtMontajProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        item.IlkNumune = txtMontajIlkNumune.Text;
                        item.PilotMontaj = txtMontajPilotMontaj.Text;
                        if (rBtnMontajTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                        else if (rBtnMontajTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;
                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");

            }

            ClearAll(sidePanel7);
            this.montajTableAdapter.Fill(this.yumakDataSet.Montaj);

        }

        private void btnSevkiyatPaketleme_Click(object sender, EventArgs e)
        {
            if (txtSevkiyatPaketlemeProjeID.Text == "")
            {
                XtraMessageBox.Show("Lütfen güncelleme işlemi için bir kayıt seçiniz..");
            }
            else
            {
                int ID = int.Parse(txtSevkiyatPaketlemeID.Text);
                var query = from x in db.SevkiyatPaketlemes
                            where x.ID == ID
                            select x;
                YumakEntities dbdeneme = new YumakEntities();
                int ProjeID = int.Parse(txtSevkiyatPaketlemeProjeID.Text);
                int ProjeDetayID = int.Parse(txtSevkiyatPaketlemeProjeDetayID.Text);

                var query2 = from x in dbdeneme.ProjeDetays
                             where x.ProjeUstID == ProjeID & x.ID == ProjeDetayID
                             select x;
                if (query.Any())
                {
                    foreach (var item in query)
                    {

                        if (checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Checked == true)
                        {
                            item.YeniAmbalajIhtiyaci = true;
                        }
                        if (checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Checked == false)
                        {
                            item.YeniAmbalajIhtiyaci = false;
                        }
                        if (rBtnSevkiyatPaketlemeTamamlandi.Checked == true)
                        {
                            item.TamamlanmaDurumu = true;


                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde + (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }
                        else if (rBtnSevkiyatPaketlemeTamamlanmadi.Checked == true)
                        {
                            item.TamamlanmaDurumu = false;

                            if (query2.Any())
                            {


                                foreach (var x in query2)
                                {

                                    x.Yuzde = x.Yuzde - (100 / x.Sayac);

                                }
                            }
                            dbdeneme.SaveChanges();
                        }

                    }
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Bilgiler Güncellendi", "Uyarı");

            }

            ClearAll(sidePanel8);
            this.sevkiyatPaketlemeTableAdapter.Fill(this.yumakDataSet.SevkiyatPaketleme);
        }


    }
}