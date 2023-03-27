
namespace yumak
{
    partial class FrmProjeOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridProjeOlustur = new DevExpress.XtraGrid.GridControl();
            this.vKullaniciProjeUstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yumakDataSet = new yumak.YumakDataSet();
            this.gViewProjeOlustur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenProjeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOEMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanıcıAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.projeUstBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeUstBilgileriTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter();
            this.vKullaniciProjeUstTableAdapter = new yumak.YumakDataSetTableAdapters.vKullaniciProjeUstTableAdapter();
            this.projeDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDetayTableAdapter = new yumak.YumakDataSetTableAdapters.ProjeDetayTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProjeOlusturOemNo = new DevExpress.XtraEditors.TextEdit();
            this.txtProjeOlusturAciklama = new DevExpress.XtraEditors.TextEdit();
            this.dateProjeOlusturBildirim = new DevExpress.XtraEditors.DateEdit();
            this.dateProjeOlusturPlanlanan = new DevExpress.XtraEditors.DateEdit();
            this.sBtnProjeOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnProjeOlusturKullaniciSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtProjeOlusturKullaniciID = new DevExpress.XtraEditors.TextEdit();
            this.txtProjeOlusturStokID = new DevExpress.XtraEditors.TextEdit();
            this.sBtnProjeOlusturStokSec = new DevExpress.XtraEditors.SimpleButton();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.ParcaGenel = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridParcaGenel = new DevExpress.XtraGrid.GridControl();
            this.parcaGenelBilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewParcaGenel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalzeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHamMalzemeUretimYontemi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSertlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsilIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKaplama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedarikciBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.rBtnParcaGenelTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnParcaGenelTamamlandi = new System.Windows.Forms.RadioButton();
            this.labelControl56 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelID = new DevExpress.XtraEditors.TextEdit();
            this.txtParcaGenelProjeID = new DevExpress.XtraEditors.TextEdit();
            this.sBtnParcaGenelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtParcaGenelProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelMalzeme = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelHamMalzeme = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelSertlik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelIsilIslem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtPArcaGenelKaplama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaGenelTedarikciBilg = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.ArgeTasarim = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridArgeTasarim = new DevExpress.XtraGrid.GridControl();
            this.argeTasarimRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewArgeTasarim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananKatiModelCizimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenKatiModelCizimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananTeknikResimCizimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenTeknikResimCizimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResimOnayTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonelRecete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAkisSemasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.rBtnArgeTasarimTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnArgeTasarimTamamlandi = new System.Windows.Forms.RadioButton();
            this.dEditArgeTasarimRecete = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimOperasyonelRecete = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimResimOnay = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimGTeknikMCizimi = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimPTeknikMCizimi = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimGKatiMCizimi = new DevExpress.XtraEditors.DateEdit();
            this.dEditArgeTasarimPKatiMCizimi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnArgeTasarimKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtArgeTasarimID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtArgeTasarimProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtArgeTasarimProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtArgeTasarimAkisSemasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.DisHizmet = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridDisHizmet = new DevExpress.XtraGrid.GridControl();
            this.disHizmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewDisHizmet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResimIletimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatinAlmaTerminTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatinAlmaNumuneGelisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumuneOnayTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.rBtnDisHizmetTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnDisHizmetTamamlandi = new System.Windows.Forms.RadioButton();
            this.dEditDisHizmetNumuneOnayTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditDisHizmetSatinAlmaTerminTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditDisHizmetResimIletimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnDisHizmetKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtDisHizmetID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.txtDisHizmetProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.txtDisHizmetProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl46 = new DevExpress.XtraEditors.LabelControl();
            this.Kaliphane = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridKalipHaneAparat = new DevExpress.XtraGrid.GridControl();
            this.kaliphaneAparatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewKalipHaneAparat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIhtiyacDuyulanKalipAdedi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalipTerminTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalipGerceklesenNumuneTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKaliteNumuneOnayTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIhtiyacDuyulanAparatAdedi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAparatTerminTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAparatGerceklesenTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.txtKalipHaneIhtıyacKalipAdedi = new DevExpress.XtraEditors.TextEdit();
            this.rBtnKalipHaneTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnKalipHaneTamamlandi = new System.Windows.Forms.RadioButton();
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditKalipHaneAparatTerminTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditKalipHaneKaliteNumuneOnayTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditKalipHaneKalipTerminTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl47 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.txtKalipHaneID = new DevExpress.XtraEditors.TextEdit();
            this.txtKalipHaneProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl49 = new DevExpress.XtraEditors.LabelControl();
            this.txtKalipHaneProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl50 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnKalipHaneAparatKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl51 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl52 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl53 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl54 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl55 = new DevExpress.XtraEditors.LabelControl();
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl57 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl58 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl59 = new DevExpress.XtraEditors.LabelControl();
            this.KaliteKontrol = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridKaliteKontrol = new DevExpress.XtraGrid.GridControl();
            this.kaliteKontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewKaliteKontrol = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelOlcmeEkipmaniIhtiyaci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelOlcmeEkipmanlariSiparisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelOlcmeTakimlarTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı = new DevExpress.XtraEditors.CheckEdit();
            this.rBtnKaliteKontrolTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnKaliteKontrolTamamlandi = new System.Windows.Forms.RadioButton();
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl60 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnKaliteKontrolKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtKaliteKontrolID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl61 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl62 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl63 = new DevExpress.XtraEditors.LabelControl();
            this.txtKaliteKontrolProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl64 = new DevExpress.XtraEditors.LabelControl();
            this.txtKaliteKontrolProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl65 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl66 = new DevExpress.XtraEditors.LabelControl();
            this.UretimPlanlama = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridUretimPlanlama = new DevExpress.XtraGrid.GridControl();
            this.uretimPlanlamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewUretimPlanlama = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIhtiyacDuyulanOzelTakim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelTakimlarSiparisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelTakimlarTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenemeUretimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKaliteNumuneOnayTarihi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.rBtnUretimPlanlamaTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnUretimPlanlamaTamamlandi = new System.Windows.Forms.RadioButton();
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditUretimPlanlamaDenemeUretimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl67 = new DevExpress.XtraEditors.LabelControl();
            this.btnUretimPlanlamaKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtUretimPlanlamaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl68 = new DevExpress.XtraEditors.LabelControl();
            this.txtUretimPlanlamaProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl69 = new DevExpress.XtraEditors.LabelControl();
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl70 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl71 = new DevExpress.XtraEditors.LabelControl();
            this.txtUretimPlanlamaProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl72 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl73 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl74 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl75 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl76 = new DevExpress.XtraEditors.LabelControl();
            this.Montaj = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridMontaj = new DevExpress.XtraGrid.GridControl();
            this.montajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewMontaj = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlkNumune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPilotMontaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.rBtnMontajTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnMontajTamamlandi = new System.Windows.Forms.RadioButton();
            this.labelControl77 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnMontajKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontajID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl78 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontajProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl79 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontajIlkNumune = new DevExpress.XtraEditors.TextEdit();
            this.txtMontajPilotMontaj = new DevExpress.XtraEditors.TextEdit();
            this.labelControl80 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontajProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl81 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl82 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl83 = new DevExpress.XtraEditors.LabelControl();
            this.SevkiyatPaketleme = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridSevkiyatPaketleme = new DevExpress.XtraGrid.GridControl();
            this.sevkiyatPaketlemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gViewSevkiyatPaketleme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeID7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeDetayID7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYeniAmbalajIhtiyaci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamamlanmaDurumu6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci = new DevExpress.XtraEditors.CheckEdit();
            this.rBtnSevkiyatPaketlemeTamamlanmadi = new System.Windows.Forms.RadioButton();
            this.rBtnSevkiyatPaketlemeTamamlandi = new System.Windows.Forms.RadioButton();
            this.labelControl86 = new DevExpress.XtraEditors.LabelControl();
            this.btnSevkiyatPaketleme = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl87 = new DevExpress.XtraEditors.LabelControl();
            this.txtSevkiyatPaketlemeID = new DevExpress.XtraEditors.TextEdit();
            this.txtSevkiyatPaketlemeProjeDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl89 = new DevExpress.XtraEditors.LabelControl();
            this.txtSevkiyatPaketlemeProjeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl90 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl91 = new DevExpress.XtraEditors.LabelControl();
            this.parcaGenelBilgilerTableAdapter = new yumak.YumakDataSetTableAdapters.ParcaGenelBilgilerTableAdapter();
            this.argeTasarimRTableAdapter = new yumak.YumakDataSetTableAdapters.ArgeTasarimRTableAdapter();
            this.disHizmetTableAdapter = new yumak.YumakDataSetTableAdapters.DisHizmetTableAdapter();
            this.kaliphaneAparatTableAdapter = new yumak.YumakDataSetTableAdapters.KaliphaneAparatTableAdapter();
            this.kaliteKontrolTableAdapter = new yumak.YumakDataSetTableAdapters.KaliteKontrolTableAdapter();
            this.uretimPlanlamaTableAdapter = new yumak.YumakDataSetTableAdapters.UretimPlanlamaTableAdapter();
            this.montajTableAdapter = new yumak.YumakDataSetTableAdapters.MontajTableAdapter();
            this.sevkiyatPaketlemeTableAdapter = new yumak.YumakDataSetTableAdapters.SevkiyatPaketlemeTableAdapter();
            this.tabPane2 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridProjeOlusturDetay = new DevExpress.XtraGrid.GridControl();
            this.gViewProjeDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYumakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYeniUrunTalep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFizibilite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProsesTasarim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIleriKalitePlanlamasiAPQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeBaslangicTarihi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananProjeTarihi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerceklesenProjeBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeUstID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParcaGenelBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArgeTasarimBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisHizmetBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKaliphaneBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKaliteKontrolBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretimPlanlamaBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontajBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkiyatBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl85 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnKullaniciYMSec = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl84 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciYMID = new DevExpress.XtraEditors.TextEdit();
            this.sBtnStokYMSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokYMID = new DevExpress.XtraEditors.TextEdit();
            this.sBtnKalemOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.checkSevkiyatPaketleme = new DevExpress.XtraEditors.CheckEdit();
            this.txtProjeOlusturProsesTasarim = new DevExpress.XtraEditors.TextEdit();
            this.checkMontaj = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.checkUretimPlanlama = new DevExpress.XtraEditors.CheckEdit();
            this.txtProjeOlusturIleriKP = new DevExpress.XtraEditors.TextEdit();
            this.checkKaliteKontrol = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.checkKaliphane = new DevExpress.XtraEditors.CheckEdit();
            this.txtProjeOlusturFizibilite = new DevExpress.XtraEditors.TextEdit();
            this.checkDisHizmet = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.checkArgeTasarim = new DevExpress.XtraEditors.CheckEdit();
            this.txtProjeOlusturYeniUrun = new DevExpress.XtraEditors.TextEdit();
            this.checkParcaGenel = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtProjeOlusturAciklamaDetay = new DevExpress.XtraEditors.TextEdit();
            this.txtProjeOlusturYumakNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtProjeOlusturSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjeOlustur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKullaniciProjeUstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProjeOlustur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturOemNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturBildirim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturBildirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturPlanlanan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturPlanlanan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturKullaniciID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturStokID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.ParcaGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcaGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcaGenelBilgilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewParcaGenel)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelMalzeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelHamMalzeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelSertlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelIsilIslem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPArcaGenelKaplama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelTedarikciBilg.Properties)).BeginInit();
            this.ArgeTasarim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArgeTasarim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.argeTasarimRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewArgeTasarim)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimRecete.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimRecete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimOperasyonelRecete.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimOperasyonelRecete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimResimOnay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimResimOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGTeknikMCizimi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGTeknikMCizimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPTeknikMCizimi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPTeknikMCizimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGKatiMCizimi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGKatiMCizimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPKatiMCizimi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPKatiMCizimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimAkisSemasi.Properties)).BeginInit();
            this.DisHizmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisHizmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disHizmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDisHizmet)).BeginInit();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetNumuneOnayTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetNumuneOnayTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaTerminTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaTerminTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetResimIletimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetResimIletimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetProjeDetayID.Properties)).BeginInit();
            this.Kaliphane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKalipHaneAparat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliphaneAparatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKalipHaneAparat)).BeginInit();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneIhtıyacKalipAdedi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatTerminTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatTerminTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipTerminTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipTerminTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Properties)).BeginInit();
            this.KaliteKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKaliteKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliteKontrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKaliteKontrol)).BeginInit();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolProjeDetayID.Properties)).BeginInit();
            this.UretimPlanlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUretimPlanlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimPlanlamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewUretimPlanlama)).BeginInit();
            this.sidePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaDenemeUretimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaDenemeUretimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaProjeID.Properties)).BeginInit();
            this.Montaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMontaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMontaj)).BeginInit();
            this.sidePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajIlkNumune.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajPilotMontaj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajProjeID.Properties)).BeginInit();
            this.SevkiyatPaketleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSevkiyatPaketleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkiyatPaketlemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewSevkiyatPaketleme)).BeginInit();
            this.sidePanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeProjeDetayID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeProjeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).BeginInit();
            this.tabPane2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjeOlusturDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProjeDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciYMID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokYMID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSevkiyatPaketleme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturProsesTasarim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMontaj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUretimPlanlama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturIleriKP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliteKontrol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliphane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturFizibilite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisHizmet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkArgeTasarim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturYeniUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkParcaGenel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturAciklamaDetay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturYumakNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturSiraNo.Properties)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProjeOlustur
            // 
            this.gridProjeOlustur.DataSource = this.vKullaniciProjeUstBindingSource;
            this.gridProjeOlustur.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridProjeOlustur.Location = new System.Drawing.Point(0, 163);
            this.gridProjeOlustur.MainView = this.gViewProjeOlustur;
            this.gridProjeOlustur.Name = "gridProjeOlustur";
            this.gridProjeOlustur.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridProjeOlustur.Size = new System.Drawing.Size(1204, 227);
            this.gridProjeOlustur.TabIndex = 0;
            this.gridProjeOlustur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewProjeOlustur});
            // 
            // vKullaniciProjeUstBindingSource
            // 
            this.vKullaniciProjeUstBindingSource.DataMember = "vKullaniciProjeUst";
            this.vKullaniciProjeUstBindingSource.DataSource = this.yumakDataSet;
            // 
            // yumakDataSet
            // 
            this.yumakDataSet.DataSetName = "YumakDataSet";
            this.yumakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gViewProjeOlustur
            // 
            this.gViewProjeOlustur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokID,
            this.colKullaniciID,
            this.colProjeBaslangicTarihi,
            this.colPlanlananProjeTarihi,
            this.colBildirimTarihi,
            this.colGerceklesenProjeTarihi,
            this.colAciklama,
            this.colDurum,
            this.colOEMNo,
            this.colkID,
            this.colAd,
            this.colSoyad,
            this.colKullanıcıAD});
            this.gViewProjeOlustur.GridControl = this.gridProjeOlustur;
            this.gViewProjeOlustur.Name = "gViewProjeOlustur";
            this.gViewProjeOlustur.NewItemRowText = "Yeni Kayıt Ekle";
            this.gViewProjeOlustur.OptionsBehavior.Editable = false;
            this.gViewProjeOlustur.OptionsBehavior.ReadOnly = true;
            this.gViewProjeOlustur.DoubleClick += new System.EventHandler(this.gViewProjeOlustur_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.Width = 94;
            // 
            // colKullaniciID
            // 
            this.colKullaniciID.FieldName = "KullaniciID";
            this.colKullaniciID.MinWidth = 25;
            this.colKullaniciID.Name = "colKullaniciID";
            this.colKullaniciID.Width = 94;
            // 
            // colProjeBaslangicTarihi
            // 
            this.colProjeBaslangicTarihi.FieldName = "ProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.MinWidth = 25;
            this.colProjeBaslangicTarihi.Name = "colProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi.Visible = true;
            this.colProjeBaslangicTarihi.VisibleIndex = 0;
            this.colProjeBaslangicTarihi.Width = 94;
            // 
            // colPlanlananProjeTarihi
            // 
            this.colPlanlananProjeTarihi.FieldName = "PlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.MinWidth = 25;
            this.colPlanlananProjeTarihi.Name = "colPlanlananProjeTarihi";
            this.colPlanlananProjeTarihi.Visible = true;
            this.colPlanlananProjeTarihi.VisibleIndex = 1;
            this.colPlanlananProjeTarihi.Width = 94;
            // 
            // colBildirimTarihi
            // 
            this.colBildirimTarihi.FieldName = "BildirimTarihi";
            this.colBildirimTarihi.MinWidth = 25;
            this.colBildirimTarihi.Name = "colBildirimTarihi";
            this.colBildirimTarihi.Visible = true;
            this.colBildirimTarihi.VisibleIndex = 2;
            this.colBildirimTarihi.Width = 94;
            // 
            // colGerceklesenProjeTarihi
            // 
            this.colGerceklesenProjeTarihi.FieldName = "GerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.MinWidth = 25;
            this.colGerceklesenProjeTarihi.Name = "colGerceklesenProjeTarihi";
            this.colGerceklesenProjeTarihi.Visible = true;
            this.colGerceklesenProjeTarihi.VisibleIndex = 3;
            this.colGerceklesenProjeTarihi.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 94;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.MinWidth = 25;
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 5;
            this.colDurum.Width = 94;
            // 
            // colOEMNo
            // 
            this.colOEMNo.FieldName = "OEMNo";
            this.colOEMNo.MinWidth = 25;
            this.colOEMNo.Name = "colOEMNo";
            this.colOEMNo.Visible = true;
            this.colOEMNo.VisibleIndex = 6;
            this.colOEMNo.Width = 94;
            // 
            // colkID
            // 
            this.colkID.FieldName = "kID";
            this.colkID.MinWidth = 25;
            this.colkID.Name = "colkID";
            this.colkID.Width = 94;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 7;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 8;
            this.colSoyad.Width = 94;
            // 
            // colKullanıcıAD
            // 
            this.colKullanıcıAD.FieldName = "KullanıcıAD";
            this.colKullanıcıAD.MinWidth = 25;
            this.colKullanıcıAD.Name = "colKullanıcıAD";
            this.colKullanıcıAD.Visible = true;
            this.colKullanıcıAD.VisibleIndex = 9;
            this.colKullanıcıAD.Width = 94;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // projeUstBilgileriBindingSource
            // 
            this.projeUstBilgileriBindingSource.DataMember = "ProjeUstBilgileri";
            this.projeUstBilgileriBindingSource.DataSource = this.yumakDataSet;
            // 
            // projeUstBilgileriTableAdapter
            // 
            this.projeUstBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // vKullaniciProjeUstTableAdapter
            // 
            this.vKullaniciProjeUstTableAdapter.ClearBeforeFill = true;
            // 
            // projeDetayBindingSource
            // 
            this.projeDetayBindingSource.DataMember = "ProjeDetay";
            this.projeDetayBindingSource.DataSource = this.yumakDataSet;
            // 
            // projeDetayTableAdapter
            // 
            this.projeDetayTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureEdit1);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtProjeOlusturOemNo);
            this.groupControl2.Controls.Add(this.txtProjeOlusturAciklama);
            this.groupControl2.Controls.Add(this.dateProjeOlusturBildirim);
            this.groupControl2.Controls.Add(this.dateProjeOlusturPlanlanan);
            this.groupControl2.Controls.Add(this.sBtnProjeOlustur);
            this.groupControl2.Controls.Add(this.sBtnProjeOlusturKullaniciSec);
            this.groupControl2.Controls.Add(this.txtProjeOlusturKullaniciID);
            this.groupControl2.Controls.Add(this.txtProjeOlusturStokID);
            this.groupControl2.Controls.Add(this.sBtnProjeOlusturStokSec);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1204, 163);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Yeni Proje Ekle";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(646, 33);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(216, 118);
            this.pictureEdit1.TabIndex = 17;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(596, 38);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(40, 16);
            this.labelControl14.TabIndex = 16;
            this.labelControl14.Text = "Resim:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(397, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 16);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "OEM No";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(391, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 16);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Açıklama";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(363, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 16);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Bildirim Tarihi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(316, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Planlanan Proje Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Kullanıcı ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(175, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Stok ID";
            // 
            // txtProjeOlusturOemNo
            // 
            this.txtProjeOlusturOemNo.Location = new System.Drawing.Point(448, 121);
            this.txtProjeOlusturOemNo.Name = "txtProjeOlusturOemNo";
            this.txtProjeOlusturOemNo.Size = new System.Drawing.Size(125, 22);
            this.txtProjeOlusturOemNo.TabIndex = 8;
            // 
            // txtProjeOlusturAciklama
            // 
            this.txtProjeOlusturAciklama.Location = new System.Drawing.Point(448, 93);
            this.txtProjeOlusturAciklama.Name = "txtProjeOlusturAciklama";
            this.txtProjeOlusturAciklama.Size = new System.Drawing.Size(125, 22);
            this.txtProjeOlusturAciklama.TabIndex = 7;
            // 
            // dateProjeOlusturBildirim
            // 
            this.dateProjeOlusturBildirim.EditValue = null;
            this.dateProjeOlusturBildirim.Location = new System.Drawing.Point(448, 65);
            this.dateProjeOlusturBildirim.Name = "dateProjeOlusturBildirim";
            this.dateProjeOlusturBildirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateProjeOlusturBildirim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateProjeOlusturBildirim.Size = new System.Drawing.Size(125, 22);
            this.dateProjeOlusturBildirim.TabIndex = 6;
            // 
            // dateProjeOlusturPlanlanan
            // 
            this.dateProjeOlusturPlanlanan.EditValue = null;
            this.dateProjeOlusturPlanlanan.Location = new System.Drawing.Point(448, 37);
            this.dateProjeOlusturPlanlanan.Name = "dateProjeOlusturPlanlanan";
            this.dateProjeOlusturPlanlanan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateProjeOlusturPlanlanan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateProjeOlusturPlanlanan.Size = new System.Drawing.Size(125, 22);
            this.dateProjeOlusturPlanlanan.TabIndex = 5;
            // 
            // sBtnProjeOlustur
            // 
            this.sBtnProjeOlustur.Location = new System.Drawing.Point(885, 102);
            this.sBtnProjeOlustur.Name = "sBtnProjeOlustur";
            this.sBtnProjeOlustur.Size = new System.Drawing.Size(313, 49);
            this.sBtnProjeOlustur.TabIndex = 4;
            this.sBtnProjeOlustur.Text = "Proje Oluştur";
            this.sBtnProjeOlustur.Click += new System.EventHandler(this.sBtnProjeOlustur_Click);
            // 
            // sBtnProjeOlusturKullaniciSec
            // 
            this.sBtnProjeOlusturKullaniciSec.Location = new System.Drawing.Point(24, 78);
            this.sBtnProjeOlusturKullaniciSec.Name = "sBtnProjeOlusturKullaniciSec";
            this.sBtnProjeOlusturKullaniciSec.Size = new System.Drawing.Size(133, 47);
            this.sBtnProjeOlusturKullaniciSec.TabIndex = 3;
            this.sBtnProjeOlusturKullaniciSec.Text = "Kullanici Seç";
            this.sBtnProjeOlusturKullaniciSec.Click += new System.EventHandler(this.sBtnProjeOlusturKullaniciSec_Click);
            // 
            // txtProjeOlusturKullaniciID
            // 
            this.txtProjeOlusturKullaniciID.Location = new System.Drawing.Point(103, 47);
            this.txtProjeOlusturKullaniciID.Name = "txtProjeOlusturKullaniciID";
            this.txtProjeOlusturKullaniciID.Properties.ReadOnly = true;
            this.txtProjeOlusturKullaniciID.Size = new System.Drawing.Size(51, 22);
            this.txtProjeOlusturKullaniciID.TabIndex = 2;
            // 
            // txtProjeOlusturStokID
            // 
            this.txtProjeOlusturStokID.Location = new System.Drawing.Point(235, 47);
            this.txtProjeOlusturStokID.Name = "txtProjeOlusturStokID";
            this.txtProjeOlusturStokID.Properties.ReadOnly = true;
            this.txtProjeOlusturStokID.Size = new System.Drawing.Size(51, 22);
            this.txtProjeOlusturStokID.TabIndex = 1;
            // 
            // sBtnProjeOlusturStokSec
            // 
            this.sBtnProjeOlusturStokSec.Location = new System.Drawing.Point(163, 78);
            this.sBtnProjeOlusturStokSec.Name = "sBtnProjeOlusturStokSec";
            this.sBtnProjeOlusturStokSec.Size = new System.Drawing.Size(133, 47);
            this.sBtnProjeOlusturStokSec.TabIndex = 0;
            this.sBtnProjeOlusturStokSec.Text = "Stok Seç";
            this.sBtnProjeOlusturStokSec.Click += new System.EventHandler(this.sBtnProjeOlusturStokSec_Click);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.ParcaGenel);
            this.tabPane1.Controls.Add(this.ArgeTasarim);
            this.tabPane1.Controls.Add(this.DisHizmet);
            this.tabPane1.Controls.Add(this.Kaliphane);
            this.tabPane1.Controls.Add(this.KaliteKontrol);
            this.tabPane1.Controls.Add(this.UretimPlanlama);
            this.tabPane1.Controls.Add(this.Montaj);
            this.tabPane1.Controls.Add(this.SevkiyatPaketleme);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.ParcaGenel,
            this.ArgeTasarim,
            this.DisHizmet,
            this.Kaliphane,
            this.KaliteKontrol,
            this.UretimPlanlama,
            this.Montaj,
            this.SevkiyatPaketleme});
            this.tabPane1.RegularSize = new System.Drawing.Size(1204, 901);
            this.tabPane1.SelectedPage = this.ParcaGenel;
            this.tabPane1.Size = new System.Drawing.Size(1204, 901);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "ParçaGenel";
            // 
            // ParcaGenel
            // 
            this.ParcaGenel.Caption = "Parça Genel";
            this.ParcaGenel.Controls.Add(this.gridParcaGenel);
            this.ParcaGenel.Controls.Add(this.sidePanel1);
            this.ParcaGenel.Name = "ParcaGenel";
            this.ParcaGenel.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridParcaGenel
            // 
            this.gridParcaGenel.DataSource = this.parcaGenelBilgilerBindingSource;
            this.gridParcaGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParcaGenel.Location = new System.Drawing.Point(0, 201);
            this.gridParcaGenel.MainView = this.gViewParcaGenel;
            this.gridParcaGenel.Name = "gridParcaGenel";
            this.gridParcaGenel.Size = new System.Drawing.Size(1204, 664);
            this.gridParcaGenel.TabIndex = 25;
            this.gridParcaGenel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewParcaGenel});
            // 
            // parcaGenelBilgilerBindingSource
            // 
            this.parcaGenelBilgilerBindingSource.DataMember = "ParcaGenelBilgiler";
            this.parcaGenelBilgilerBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewParcaGenel
            // 
            this.gViewParcaGenel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colProjeID,
            this.colProjeDetayID,
            this.colMalzeme,
            this.colHamMalzemeUretimYontemi,
            this.colSertlik,
            this.colIsilIslem,
            this.colKaplama,
            this.colTedarikciBilgisi,
            this.gridColumn2});
            this.gViewParcaGenel.GridControl = this.gridParcaGenel;
            this.gViewParcaGenel.Name = "gViewParcaGenel";
            this.gViewParcaGenel.OptionsBehavior.Editable = false;
            this.gViewParcaGenel.OptionsBehavior.ReadOnly = true;
            this.gViewParcaGenel.DoubleClick += new System.EventHandler(this.gViewParcaGenel_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // colProjeID
            // 
            this.colProjeID.FieldName = "ProjeID";
            this.colProjeID.MinWidth = 25;
            this.colProjeID.Name = "colProjeID";
            this.colProjeID.Width = 94;
            // 
            // colProjeDetayID
            // 
            this.colProjeDetayID.FieldName = "ProjeDetayID";
            this.colProjeDetayID.MinWidth = 25;
            this.colProjeDetayID.Name = "colProjeDetayID";
            this.colProjeDetayID.Width = 94;
            // 
            // colMalzeme
            // 
            this.colMalzeme.FieldName = "Malzeme";
            this.colMalzeme.MinWidth = 25;
            this.colMalzeme.Name = "colMalzeme";
            this.colMalzeme.Visible = true;
            this.colMalzeme.VisibleIndex = 1;
            this.colMalzeme.Width = 94;
            // 
            // colHamMalzemeUretimYontemi
            // 
            this.colHamMalzemeUretimYontemi.FieldName = "HamMalzemeUretimYontemi";
            this.colHamMalzemeUretimYontemi.MinWidth = 25;
            this.colHamMalzemeUretimYontemi.Name = "colHamMalzemeUretimYontemi";
            this.colHamMalzemeUretimYontemi.Visible = true;
            this.colHamMalzemeUretimYontemi.VisibleIndex = 2;
            this.colHamMalzemeUretimYontemi.Width = 94;
            // 
            // colSertlik
            // 
            this.colSertlik.FieldName = "Sertlik";
            this.colSertlik.MinWidth = 25;
            this.colSertlik.Name = "colSertlik";
            this.colSertlik.Visible = true;
            this.colSertlik.VisibleIndex = 3;
            this.colSertlik.Width = 94;
            // 
            // colIsilIslem
            // 
            this.colIsilIslem.FieldName = "IsilIslem";
            this.colIsilIslem.MinWidth = 25;
            this.colIsilIslem.Name = "colIsilIslem";
            this.colIsilIslem.Visible = true;
            this.colIsilIslem.VisibleIndex = 4;
            this.colIsilIslem.Width = 94;
            // 
            // colKaplama
            // 
            this.colKaplama.FieldName = "Kaplama";
            this.colKaplama.MinWidth = 25;
            this.colKaplama.Name = "colKaplama";
            this.colKaplama.Visible = true;
            this.colKaplama.VisibleIndex = 5;
            this.colKaplama.Width = 94;
            // 
            // colTedarikciBilgisi
            // 
            this.colTedarikciBilgisi.FieldName = "TedarikciBilgisi";
            this.colTedarikciBilgisi.MinWidth = 25;
            this.colTedarikciBilgisi.Name = "colTedarikciBilgisi";
            this.colTedarikciBilgisi.Visible = true;
            this.colTedarikciBilgisi.VisibleIndex = 6;
            this.colTedarikciBilgisi.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tamamlanma Durumu";
            this.gridColumn2.FieldName = "TamamlanmaDurumu";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 94;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.rBtnParcaGenelTamamlanmadi);
            this.sidePanel1.Controls.Add(this.rBtnParcaGenelTamamlandi);
            this.sidePanel1.Controls.Add(this.labelControl56);
            this.sidePanel1.Controls.Add(this.labelControl15);
            this.sidePanel1.Controls.Add(this.txtParcaGenelID);
            this.sidePanel1.Controls.Add(this.txtParcaGenelProjeID);
            this.sidePanel1.Controls.Add(this.sBtnParcaGenelKaydet);
            this.sidePanel1.Controls.Add(this.txtParcaGenelProjeDetayID);
            this.sidePanel1.Controls.Add(this.labelControl16);
            this.sidePanel1.Controls.Add(this.txtParcaGenelMalzeme);
            this.sidePanel1.Controls.Add(this.labelControl17);
            this.sidePanel1.Controls.Add(this.txtParcaGenelHamMalzeme);
            this.sidePanel1.Controls.Add(this.labelControl18);
            this.sidePanel1.Controls.Add(this.txtParcaGenelSertlik);
            this.sidePanel1.Controls.Add(this.labelControl19);
            this.sidePanel1.Controls.Add(this.txtParcaGenelIsilIslem);
            this.sidePanel1.Controls.Add(this.labelControl20);
            this.sidePanel1.Controls.Add(this.txtPArcaGenelKaplama);
            this.sidePanel1.Controls.Add(this.labelControl21);
            this.sidePanel1.Controls.Add(this.txtParcaGenelTedarikciBilg);
            this.sidePanel1.Controls.Add(this.labelControl22);
            this.sidePanel1.Controls.Add(this.labelControl23);
            this.sidePanel1.Controls.Add(this.labelControl24);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1204, 201);
            this.sidePanel1.TabIndex = 26;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // rBtnParcaGenelTamamlanmadi
            // 
            this.rBtnParcaGenelTamamlanmadi.AutoSize = true;
            this.rBtnParcaGenelTamamlanmadi.Checked = true;
            this.rBtnParcaGenelTamamlanmadi.Location = new System.Drawing.Point(774, 112);
            this.rBtnParcaGenelTamamlanmadi.Name = "rBtnParcaGenelTamamlanmadi";
            this.rBtnParcaGenelTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnParcaGenelTamamlanmadi.TabIndex = 75;
            this.rBtnParcaGenelTamamlanmadi.TabStop = true;
            this.rBtnParcaGenelTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnParcaGenelTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnParcaGenelTamamlandi
            // 
            this.rBtnParcaGenelTamamlandi.AutoSize = true;
            this.rBtnParcaGenelTamamlandi.Location = new System.Drawing.Point(654, 113);
            this.rBtnParcaGenelTamamlandi.Name = "rBtnParcaGenelTamamlandi";
            this.rBtnParcaGenelTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnParcaGenelTamamlandi.TabIndex = 74;
            this.rBtnParcaGenelTamamlandi.Text = "Tamamlandı";
            this.rBtnParcaGenelTamamlandi.UseVisualStyleBackColor = true;
            // 
            // labelControl56
            // 
            this.labelControl56.Location = new System.Drawing.Point(509, 115);
            this.labelControl56.Name = "labelControl56";
            this.labelControl56.Size = new System.Drawing.Size(124, 16);
            this.labelControl56.TabIndex = 73;
            this.labelControl56.Text = "TamamlanmaDurumu";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(12, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(19, 16);
            this.labelControl15.TabIndex = 72;
            this.labelControl15.Text = "1/8";
            // 
            // txtParcaGenelID
            // 
            this.txtParcaGenelID.Location = new System.Drawing.Point(1099, 6);
            this.txtParcaGenelID.Name = "txtParcaGenelID";
            this.txtParcaGenelID.Size = new System.Drawing.Size(28, 22);
            this.txtParcaGenelID.TabIndex = 0;
            this.txtParcaGenelID.Visible = false;
            // 
            // txtParcaGenelProjeID
            // 
            this.txtParcaGenelProjeID.Location = new System.Drawing.Point(194, 20);
            this.txtParcaGenelProjeID.Name = "txtParcaGenelProjeID";
            this.txtParcaGenelProjeID.Properties.ReadOnly = true;
            this.txtParcaGenelProjeID.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelProjeID.TabIndex = 1;
            // 
            // sBtnParcaGenelKaydet
            // 
            this.sBtnParcaGenelKaydet.Location = new System.Drawing.Point(640, 139);
            this.sBtnParcaGenelKaydet.Name = "sBtnParcaGenelKaydet";
            this.sBtnParcaGenelKaydet.Size = new System.Drawing.Size(255, 44);
            this.sBtnParcaGenelKaydet.TabIndex = 20;
            this.sBtnParcaGenelKaydet.Text = "Parça Genel Kaydet";
            this.sBtnParcaGenelKaydet.Click += new System.EventHandler(this.sBtnParcaGenelKaydet_Click);
            // 
            // txtParcaGenelProjeDetayID
            // 
            this.txtParcaGenelProjeDetayID.Location = new System.Drawing.Point(194, 48);
            this.txtParcaGenelProjeDetayID.Name = "txtParcaGenelProjeDetayID";
            this.txtParcaGenelProjeDetayID.Properties.ReadOnly = true;
            this.txtParcaGenelProjeDetayID.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelProjeDetayID.TabIndex = 2;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(119, 23);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(42, 16);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "ProjeID";
            // 
            // txtParcaGenelMalzeme
            // 
            this.txtParcaGenelMalzeme.Location = new System.Drawing.Point(194, 76);
            this.txtParcaGenelMalzeme.Name = "txtParcaGenelMalzeme";
            this.txtParcaGenelMalzeme.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelMalzeme.TabIndex = 3;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(534, 82);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(88, 16);
            this.labelControl17.TabIndex = 18;
            this.labelControl17.Text = "Tedarikçi Bilgisi";
            // 
            // txtParcaGenelHamMalzeme
            // 
            this.txtParcaGenelHamMalzeme.Location = new System.Drawing.Point(194, 105);
            this.txtParcaGenelHamMalzeme.Name = "txtParcaGenelHamMalzeme";
            this.txtParcaGenelHamMalzeme.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelHamMalzeme.TabIndex = 4;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(573, 54);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(49, 16);
            this.labelControl18.TabIndex = 16;
            this.labelControl18.Text = "Kaplama";
            // 
            // txtParcaGenelSertlik
            // 
            this.txtParcaGenelSertlik.Location = new System.Drawing.Point(194, 133);
            this.txtParcaGenelSertlik.Name = "txtParcaGenelSertlik";
            this.txtParcaGenelSertlik.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelSertlik.TabIndex = 5;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(575, 26);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(47, 16);
            this.labelControl19.TabIndex = 15;
            this.labelControl19.Text = "IsılIslem";
            // 
            // txtParcaGenelIsilIslem
            // 
            this.txtParcaGenelIsilIslem.Location = new System.Drawing.Point(640, 23);
            this.txtParcaGenelIsilIslem.Name = "txtParcaGenelIsilIslem";
            this.txtParcaGenelIsilIslem.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelIsilIslem.TabIndex = 6;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(139, 136);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(37, 16);
            this.labelControl20.TabIndex = 14;
            this.labelControl20.Text = "Sertlik";
            // 
            // txtPArcaGenelKaplama
            // 
            this.txtPArcaGenelKaplama.Location = new System.Drawing.Point(640, 51);
            this.txtPArcaGenelKaplama.Name = "txtPArcaGenelKaplama";
            this.txtPArcaGenelKaplama.Size = new System.Drawing.Size(255, 22);
            this.txtPArcaGenelKaplama.TabIndex = 7;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(15, 108);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(161, 16);
            this.labelControl21.TabIndex = 13;
            this.labelControl21.Text = "HamMalzemeUretimYontemi";
            // 
            // txtParcaGenelTedarikciBilg
            // 
            this.txtParcaGenelTedarikciBilg.Location = new System.Drawing.Point(640, 79);
            this.txtParcaGenelTedarikciBilg.Name = "txtParcaGenelTedarikciBilg";
            this.txtParcaGenelTedarikciBilg.Size = new System.Drawing.Size(255, 22);
            this.txtParcaGenelTedarikciBilg.TabIndex = 8;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(105, 79);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(51, 16);
            this.labelControl22.TabIndex = 12;
            this.labelControl22.Text = "Malzeme";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(1049, 9);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(12, 16);
            this.labelControl23.TabIndex = 9;
            this.labelControl23.Text = "ID";
            this.labelControl23.Visible = false;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(82, 51);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(74, 16);
            this.labelControl24.TabIndex = 11;
            this.labelControl24.Text = "ProjeDetayID";
            // 
            // ArgeTasarim
            // 
            this.ArgeTasarim.Caption = "Arge Tasarım";
            this.ArgeTasarim.Controls.Add(this.gridArgeTasarim);
            this.ArgeTasarim.Controls.Add(this.sidePanel2);
            this.ArgeTasarim.Name = "ArgeTasarim";
            this.ArgeTasarim.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridArgeTasarim
            // 
            this.gridArgeTasarim.DataSource = this.argeTasarimRBindingSource;
            this.gridArgeTasarim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArgeTasarim.Location = new System.Drawing.Point(0, 227);
            this.gridArgeTasarim.MainView = this.gViewArgeTasarim;
            this.gridArgeTasarim.Name = "gridArgeTasarim";
            this.gridArgeTasarim.Size = new System.Drawing.Size(1204, 638);
            this.gridArgeTasarim.TabIndex = 49;
            this.gridArgeTasarim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewArgeTasarim});
            // 
            // argeTasarimRBindingSource
            // 
            this.argeTasarimRBindingSource.DataMember = "ArgeTasarimR";
            this.argeTasarimRBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewArgeTasarim
            // 
            this.gViewArgeTasarim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colProjeID1,
            this.colProjeDetayID1,
            this.colPlanlananKatiModelCizimi,
            this.colGerceklesenKatiModelCizimi,
            this.colPlanlananTeknikResimCizimi,
            this.colGerceklesenTeknikResimCizimi,
            this.colResimOnayTarihi,
            this.colRecete,
            this.colOperasyonelRecete,
            this.colAkisSemasi,
            this.colTamamlanmaDurumu});
            this.gViewArgeTasarim.GridControl = this.gridArgeTasarim;
            this.gViewArgeTasarim.Name = "gViewArgeTasarim";
            this.gViewArgeTasarim.OptionsBehavior.Editable = false;
            this.gViewArgeTasarim.OptionsBehavior.ReadOnly = true;
            this.gViewArgeTasarim.DoubleClick += new System.EventHandler(this.gViewArgeTasarim_DoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sıra Numarası";
            this.gridColumn3.FieldName = "ID";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 94;
            // 
            // colProjeID1
            // 
            this.colProjeID1.FieldName = "ProjeID";
            this.colProjeID1.MinWidth = 25;
            this.colProjeID1.Name = "colProjeID1";
            this.colProjeID1.Width = 94;
            // 
            // colProjeDetayID1
            // 
            this.colProjeDetayID1.FieldName = "ProjeDetayID";
            this.colProjeDetayID1.MinWidth = 25;
            this.colProjeDetayID1.Name = "colProjeDetayID1";
            this.colProjeDetayID1.Width = 94;
            // 
            // colPlanlananKatiModelCizimi
            // 
            this.colPlanlananKatiModelCizimi.FieldName = "PlanlananKatiModelCizimi";
            this.colPlanlananKatiModelCizimi.MinWidth = 25;
            this.colPlanlananKatiModelCizimi.Name = "colPlanlananKatiModelCizimi";
            this.colPlanlananKatiModelCizimi.Visible = true;
            this.colPlanlananKatiModelCizimi.VisibleIndex = 1;
            this.colPlanlananKatiModelCizimi.Width = 94;
            // 
            // colGerceklesenKatiModelCizimi
            // 
            this.colGerceklesenKatiModelCizimi.FieldName = "GerceklesenKatiModelCizimi";
            this.colGerceklesenKatiModelCizimi.MinWidth = 25;
            this.colGerceklesenKatiModelCizimi.Name = "colGerceklesenKatiModelCizimi";
            this.colGerceklesenKatiModelCizimi.Visible = true;
            this.colGerceklesenKatiModelCizimi.VisibleIndex = 2;
            this.colGerceklesenKatiModelCizimi.Width = 94;
            // 
            // colPlanlananTeknikResimCizimi
            // 
            this.colPlanlananTeknikResimCizimi.FieldName = "PlanlananTeknikResimCizimi";
            this.colPlanlananTeknikResimCizimi.MinWidth = 25;
            this.colPlanlananTeknikResimCizimi.Name = "colPlanlananTeknikResimCizimi";
            this.colPlanlananTeknikResimCizimi.Visible = true;
            this.colPlanlananTeknikResimCizimi.VisibleIndex = 3;
            this.colPlanlananTeknikResimCizimi.Width = 94;
            // 
            // colGerceklesenTeknikResimCizimi
            // 
            this.colGerceklesenTeknikResimCizimi.FieldName = "GerceklesenTeknikResimCizimi";
            this.colGerceklesenTeknikResimCizimi.MinWidth = 25;
            this.colGerceklesenTeknikResimCizimi.Name = "colGerceklesenTeknikResimCizimi";
            this.colGerceklesenTeknikResimCizimi.Visible = true;
            this.colGerceklesenTeknikResimCizimi.VisibleIndex = 4;
            this.colGerceklesenTeknikResimCizimi.Width = 94;
            // 
            // colResimOnayTarihi
            // 
            this.colResimOnayTarihi.FieldName = "ResimOnayTarihi";
            this.colResimOnayTarihi.MinWidth = 25;
            this.colResimOnayTarihi.Name = "colResimOnayTarihi";
            this.colResimOnayTarihi.Visible = true;
            this.colResimOnayTarihi.VisibleIndex = 5;
            this.colResimOnayTarihi.Width = 94;
            // 
            // colRecete
            // 
            this.colRecete.FieldName = "Recete";
            this.colRecete.MinWidth = 25;
            this.colRecete.Name = "colRecete";
            this.colRecete.Visible = true;
            this.colRecete.VisibleIndex = 6;
            this.colRecete.Width = 94;
            // 
            // colOperasyonelRecete
            // 
            this.colOperasyonelRecete.FieldName = "OperasyonelRecete";
            this.colOperasyonelRecete.MinWidth = 25;
            this.colOperasyonelRecete.Name = "colOperasyonelRecete";
            this.colOperasyonelRecete.Visible = true;
            this.colOperasyonelRecete.VisibleIndex = 7;
            this.colOperasyonelRecete.Width = 94;
            // 
            // colAkisSemasi
            // 
            this.colAkisSemasi.FieldName = "AkisSemasi";
            this.colAkisSemasi.MinWidth = 25;
            this.colAkisSemasi.Name = "colAkisSemasi";
            this.colAkisSemasi.Visible = true;
            this.colAkisSemasi.VisibleIndex = 8;
            this.colAkisSemasi.Width = 94;
            // 
            // colTamamlanmaDurumu
            // 
            this.colTamamlanmaDurumu.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu.MinWidth = 25;
            this.colTamamlanmaDurumu.Name = "colTamamlanmaDurumu";
            this.colTamamlanmaDurumu.Visible = true;
            this.colTamamlanmaDurumu.VisibleIndex = 9;
            this.colTamamlanmaDurumu.Width = 94;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.rBtnArgeTasarimTamamlanmadi);
            this.sidePanel2.Controls.Add(this.rBtnArgeTasarimTamamlandi);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimRecete);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimOperasyonelRecete);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimResimOnay);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimGTeknikMCizimi);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimPTeknikMCizimi);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimGKatiMCizimi);
            this.sidePanel2.Controls.Add(this.dEditArgeTasarimPKatiMCizimi);
            this.sidePanel2.Controls.Add(this.labelControl25);
            this.sidePanel2.Controls.Add(this.sBtnArgeTasarimKaydet);
            this.sidePanel2.Controls.Add(this.txtArgeTasarimID);
            this.sidePanel2.Controls.Add(this.labelControl26);
            this.sidePanel2.Controls.Add(this.txtArgeTasarimProjeID);
            this.sidePanel2.Controls.Add(this.labelControl27);
            this.sidePanel2.Controls.Add(this.txtArgeTasarimProjeDetayID);
            this.sidePanel2.Controls.Add(this.labelControl28);
            this.sidePanel2.Controls.Add(this.txtArgeTasarimAkisSemasi);
            this.sidePanel2.Controls.Add(this.labelControl29);
            this.sidePanel2.Controls.Add(this.labelControl30);
            this.sidePanel2.Controls.Add(this.labelControl31);
            this.sidePanel2.Controls.Add(this.labelControl32);
            this.sidePanel2.Controls.Add(this.labelControl33);
            this.sidePanel2.Controls.Add(this.labelControl34);
            this.sidePanel2.Controls.Add(this.labelControl35);
            this.sidePanel2.Controls.Add(this.labelControl36);
            this.sidePanel2.Controls.Add(this.labelControl37);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1204, 227);
            this.sidePanel2.TabIndex = 50;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // rBtnArgeTasarimTamamlanmadi
            // 
            this.rBtnArgeTasarimTamamlanmadi.AutoSize = true;
            this.rBtnArgeTasarimTamamlanmadi.Checked = true;
            this.rBtnArgeTasarimTamamlanmadi.Location = new System.Drawing.Point(773, 138);
            this.rBtnArgeTasarimTamamlanmadi.Name = "rBtnArgeTasarimTamamlanmadi";
            this.rBtnArgeTasarimTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnArgeTasarimTamamlanmadi.TabIndex = 55;
            this.rBtnArgeTasarimTamamlanmadi.TabStop = true;
            this.rBtnArgeTasarimTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnArgeTasarimTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnArgeTasarimTamamlandi
            // 
            this.rBtnArgeTasarimTamamlandi.AutoSize = true;
            this.rBtnArgeTasarimTamamlandi.Location = new System.Drawing.Point(653, 139);
            this.rBtnArgeTasarimTamamlandi.Name = "rBtnArgeTasarimTamamlandi";
            this.rBtnArgeTasarimTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnArgeTasarimTamamlandi.TabIndex = 54;
            this.rBtnArgeTasarimTamamlandi.Text = "Tamamlandı";
            this.rBtnArgeTasarimTamamlandi.UseVisualStyleBackColor = true;
            // 
            // dEditArgeTasarimRecete
            // 
            this.dEditArgeTasarimRecete.EditValue = null;
            this.dEditArgeTasarimRecete.Location = new System.Drawing.Point(653, 54);
            this.dEditArgeTasarimRecete.Name = "dEditArgeTasarimRecete";
            this.dEditArgeTasarimRecete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimRecete.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimRecete.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimRecete.TabIndex = 53;
            // 
            // dEditArgeTasarimOperasyonelRecete
            // 
            this.dEditArgeTasarimOperasyonelRecete.EditValue = null;
            this.dEditArgeTasarimOperasyonelRecete.Location = new System.Drawing.Point(653, 82);
            this.dEditArgeTasarimOperasyonelRecete.Name = "dEditArgeTasarimOperasyonelRecete";
            this.dEditArgeTasarimOperasyonelRecete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimOperasyonelRecete.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimOperasyonelRecete.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimOperasyonelRecete.TabIndex = 52;
            // 
            // dEditArgeTasarimResimOnay
            // 
            this.dEditArgeTasarimResimOnay.EditValue = null;
            this.dEditArgeTasarimResimOnay.Location = new System.Drawing.Point(653, 26);
            this.dEditArgeTasarimResimOnay.Name = "dEditArgeTasarimResimOnay";
            this.dEditArgeTasarimResimOnay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimResimOnay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimResimOnay.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimResimOnay.TabIndex = 51;
            // 
            // dEditArgeTasarimGTeknikMCizimi
            // 
            this.dEditArgeTasarimGTeknikMCizimi.EditValue = null;
            this.dEditArgeTasarimGTeknikMCizimi.Location = new System.Drawing.Point(208, 166);
            this.dEditArgeTasarimGTeknikMCizimi.Name = "dEditArgeTasarimGTeknikMCizimi";
            this.dEditArgeTasarimGTeknikMCizimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimGTeknikMCizimi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimGTeknikMCizimi.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimGTeknikMCizimi.TabIndex = 50;
            // 
            // dEditArgeTasarimPTeknikMCizimi
            // 
            this.dEditArgeTasarimPTeknikMCizimi.EditValue = null;
            this.dEditArgeTasarimPTeknikMCizimi.Location = new System.Drawing.Point(208, 138);
            this.dEditArgeTasarimPTeknikMCizimi.Name = "dEditArgeTasarimPTeknikMCizimi";
            this.dEditArgeTasarimPTeknikMCizimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimPTeknikMCizimi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimPTeknikMCizimi.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimPTeknikMCizimi.TabIndex = 49;
            // 
            // dEditArgeTasarimGKatiMCizimi
            // 
            this.dEditArgeTasarimGKatiMCizimi.EditValue = null;
            this.dEditArgeTasarimGKatiMCizimi.Location = new System.Drawing.Point(208, 110);
            this.dEditArgeTasarimGKatiMCizimi.Name = "dEditArgeTasarimGKatiMCizimi";
            this.dEditArgeTasarimGKatiMCizimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimGKatiMCizimi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimGKatiMCizimi.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimGKatiMCizimi.TabIndex = 48;
            // 
            // dEditArgeTasarimPKatiMCizimi
            // 
            this.dEditArgeTasarimPKatiMCizimi.EditValue = null;
            this.dEditArgeTasarimPKatiMCizimi.Location = new System.Drawing.Point(208, 82);
            this.dEditArgeTasarimPKatiMCizimi.Name = "dEditArgeTasarimPKatiMCizimi";
            this.dEditArgeTasarimPKatiMCizimi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimPKatiMCizimi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditArgeTasarimPKatiMCizimi.Size = new System.Drawing.Size(255, 22);
            this.dEditArgeTasarimPKatiMCizimi.TabIndex = 47;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(12, 12);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(19, 16);
            this.labelControl25.TabIndex = 45;
            this.labelControl25.Text = "2/8";
            // 
            // sBtnArgeTasarimKaydet
            // 
            this.sBtnArgeTasarimKaydet.Location = new System.Drawing.Point(653, 166);
            this.sBtnArgeTasarimKaydet.Name = "sBtnArgeTasarimKaydet";
            this.sBtnArgeTasarimKaydet.Size = new System.Drawing.Size(255, 44);
            this.sBtnArgeTasarimKaydet.TabIndex = 44;
            this.sBtnArgeTasarimKaydet.Text = "Arge Tasarım Kaydet";
            this.sBtnArgeTasarimKaydet.Click += new System.EventHandler(this.sBtnArgeTasarimKaydet_Click);
            // 
            // txtArgeTasarimID
            // 
            this.txtArgeTasarimID.Location = new System.Drawing.Point(1095, 9);
            this.txtArgeTasarimID.Name = "txtArgeTasarimID";
            this.txtArgeTasarimID.Size = new System.Drawing.Size(32, 22);
            this.txtArgeTasarimID.TabIndex = 20;
            this.txtArgeTasarimID.Visible = false;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(508, 141);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(124, 16);
            this.labelControl26.TabIndex = 43;
            this.labelControl26.Text = "TamamlanmaDurumu";
            // 
            // txtArgeTasarimProjeID
            // 
            this.txtArgeTasarimProjeID.Location = new System.Drawing.Point(208, 26);
            this.txtArgeTasarimProjeID.Name = "txtArgeTasarimProjeID";
            this.txtArgeTasarimProjeID.Properties.ReadOnly = true;
            this.txtArgeTasarimProjeID.Size = new System.Drawing.Size(255, 22);
            this.txtArgeTasarimProjeID.TabIndex = 21;
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(567, 113);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(65, 16);
            this.labelControl27.TabIndex = 42;
            this.labelControl27.Text = "AkısSemasi";
            // 
            // txtArgeTasarimProjeDetayID
            // 
            this.txtArgeTasarimProjeDetayID.Location = new System.Drawing.Point(208, 54);
            this.txtArgeTasarimProjeDetayID.Name = "txtArgeTasarimProjeDetayID";
            this.txtArgeTasarimProjeDetayID.Properties.ReadOnly = true;
            this.txtArgeTasarimProjeDetayID.Size = new System.Drawing.Size(255, 22);
            this.txtArgeTasarimProjeDetayID.TabIndex = 22;
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(522, 85);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(110, 16);
            this.labelControl28.TabIndex = 41;
            this.labelControl28.Text = "OperasyonelRecete";
            // 
            // txtArgeTasarimAkisSemasi
            // 
            this.txtArgeTasarimAkisSemasi.Location = new System.Drawing.Point(653, 110);
            this.txtArgeTasarimAkisSemasi.Name = "txtArgeTasarimAkisSemasi";
            this.txtArgeTasarimAkisSemasi.Size = new System.Drawing.Size(255, 22);
            this.txtArgeTasarimAkisSemasi.TabIndex = 39;
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(1062, 12);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(12, 16);
            this.labelControl29.TabIndex = 29;
            this.labelControl29.Text = "ID";
            this.labelControl29.Visible = false;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(593, 57);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(39, 16);
            this.labelControl30.TabIndex = 36;
            this.labelControl30.Text = "Reçete";
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(145, 29);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(42, 16);
            this.labelControl31.TabIndex = 37;
            this.labelControl31.Text = "ProjeID";
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(535, 29);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(97, 16);
            this.labelControl32.TabIndex = 35;
            this.labelControl32.Text = "ResimOnayTarihi";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(113, 57);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(74, 16);
            this.labelControl33.TabIndex = 30;
            this.labelControl33.Text = "ProjeDetayID";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(12, 166);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(175, 16);
            this.labelControl34.TabIndex = 34;
            this.labelControl34.Text = "GerceklesenTeknikResimCizimi";
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(43, 85);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(144, 16);
            this.labelControl35.TabIndex = 31;
            this.labelControl35.Text = "PlanlananKatıModelCizimi";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(29, 113);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(158, 16);
            this.labelControl36.TabIndex = 32;
            this.labelControl36.Text = "GerceklesenKatıModelCizimi";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(26, 141);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(161, 16);
            this.labelControl37.TabIndex = 33;
            this.labelControl37.Text = "PlanlananTeknikResimCizimi";
            // 
            // DisHizmet
            // 
            this.DisHizmet.Caption = "Dış Hizmet";
            this.DisHizmet.Controls.Add(this.gridDisHizmet);
            this.DisHizmet.Controls.Add(this.sidePanel3);
            this.DisHizmet.Name = "DisHizmet";
            this.DisHizmet.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridDisHizmet
            // 
            this.gridDisHizmet.DataSource = this.disHizmetBindingSource;
            this.gridDisHizmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDisHizmet.Location = new System.Drawing.Point(0, 173);
            this.gridDisHizmet.MainView = this.gViewDisHizmet;
            this.gridDisHizmet.Name = "gridDisHizmet";
            this.gridDisHizmet.Size = new System.Drawing.Size(1204, 692);
            this.gridDisHizmet.TabIndex = 75;
            this.gridDisHizmet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewDisHizmet});
            // 
            // disHizmetBindingSource
            // 
            this.disHizmetBindingSource.DataMember = "DisHizmet";
            this.disHizmetBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewDisHizmet
            // 
            this.gViewDisHizmet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID2,
            this.colProjeID2,
            this.colProjeDetayID2,
            this.colResimIletimTarihi,
            this.colSatinAlmaTerminTarihi,
            this.colSatinAlmaNumuneGelisTarihi,
            this.colNumuneOnayTarihi,
            this.colTamamlanmaDurumu1});
            this.gViewDisHizmet.GridControl = this.gridDisHizmet;
            this.gViewDisHizmet.Name = "gViewDisHizmet";
            this.gViewDisHizmet.OptionsBehavior.Editable = false;
            this.gViewDisHizmet.OptionsBehavior.ReadOnly = true;
            this.gViewDisHizmet.DoubleClick += new System.EventHandler(this.gViewDisHizmet_DoubleClick);
            // 
            // colID2
            // 
            this.colID2.Caption = "Sıra Numarası";
            this.colID2.FieldName = "ID";
            this.colID2.MinWidth = 25;
            this.colID2.Name = "colID2";
            this.colID2.Visible = true;
            this.colID2.VisibleIndex = 0;
            this.colID2.Width = 94;
            // 
            // colProjeID2
            // 
            this.colProjeID2.FieldName = "ProjeID";
            this.colProjeID2.MinWidth = 25;
            this.colProjeID2.Name = "colProjeID2";
            this.colProjeID2.Width = 94;
            // 
            // colProjeDetayID2
            // 
            this.colProjeDetayID2.FieldName = "ProjeDetayID";
            this.colProjeDetayID2.MinWidth = 25;
            this.colProjeDetayID2.Name = "colProjeDetayID2";
            this.colProjeDetayID2.Width = 94;
            // 
            // colResimIletimTarihi
            // 
            this.colResimIletimTarihi.FieldName = "ResimIletimTarihi";
            this.colResimIletimTarihi.MinWidth = 25;
            this.colResimIletimTarihi.Name = "colResimIletimTarihi";
            this.colResimIletimTarihi.Visible = true;
            this.colResimIletimTarihi.VisibleIndex = 1;
            this.colResimIletimTarihi.Width = 94;
            // 
            // colSatinAlmaTerminTarihi
            // 
            this.colSatinAlmaTerminTarihi.FieldName = "SatinAlmaTerminTarihi";
            this.colSatinAlmaTerminTarihi.MinWidth = 25;
            this.colSatinAlmaTerminTarihi.Name = "colSatinAlmaTerminTarihi";
            this.colSatinAlmaTerminTarihi.Visible = true;
            this.colSatinAlmaTerminTarihi.VisibleIndex = 2;
            this.colSatinAlmaTerminTarihi.Width = 94;
            // 
            // colSatinAlmaNumuneGelisTarihi
            // 
            this.colSatinAlmaNumuneGelisTarihi.FieldName = "SatinAlmaNumuneGelisTarihi";
            this.colSatinAlmaNumuneGelisTarihi.MinWidth = 25;
            this.colSatinAlmaNumuneGelisTarihi.Name = "colSatinAlmaNumuneGelisTarihi";
            this.colSatinAlmaNumuneGelisTarihi.Visible = true;
            this.colSatinAlmaNumuneGelisTarihi.VisibleIndex = 3;
            this.colSatinAlmaNumuneGelisTarihi.Width = 94;
            // 
            // colNumuneOnayTarihi
            // 
            this.colNumuneOnayTarihi.FieldName = "NumuneOnayTarihi";
            this.colNumuneOnayTarihi.MinWidth = 25;
            this.colNumuneOnayTarihi.Name = "colNumuneOnayTarihi";
            this.colNumuneOnayTarihi.Visible = true;
            this.colNumuneOnayTarihi.VisibleIndex = 4;
            this.colNumuneOnayTarihi.Width = 94;
            // 
            // colTamamlanmaDurumu1
            // 
            this.colTamamlanmaDurumu1.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu1.MinWidth = 25;
            this.colTamamlanmaDurumu1.Name = "colTamamlanmaDurumu1";
            this.colTamamlanmaDurumu1.Visible = true;
            this.colTamamlanmaDurumu1.VisibleIndex = 5;
            this.colTamamlanmaDurumu1.Width = 94;
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.rBtnDisHizmetTamamlanmadi);
            this.sidePanel3.Controls.Add(this.rBtnDisHizmetTamamlandi);
            this.sidePanel3.Controls.Add(this.dEditDisHizmetNumuneOnayTarihi);
            this.sidePanel3.Controls.Add(this.dEditDisHizmetSatinAlmaNumuneGelisTarihi);
            this.sidePanel3.Controls.Add(this.dEditDisHizmetSatinAlmaTerminTarihi);
            this.sidePanel3.Controls.Add(this.dEditDisHizmetResimIletimTarihi);
            this.sidePanel3.Controls.Add(this.labelControl38);
            this.sidePanel3.Controls.Add(this.sBtnDisHizmetKaydet);
            this.sidePanel3.Controls.Add(this.txtDisHizmetID);
            this.sidePanel3.Controls.Add(this.labelControl39);
            this.sidePanel3.Controls.Add(this.labelControl40);
            this.sidePanel3.Controls.Add(this.labelControl41);
            this.sidePanel3.Controls.Add(this.txtDisHizmetProjeID);
            this.sidePanel3.Controls.Add(this.labelControl42);
            this.sidePanel3.Controls.Add(this.txtDisHizmetProjeDetayID);
            this.sidePanel3.Controls.Add(this.labelControl43);
            this.sidePanel3.Controls.Add(this.labelControl44);
            this.sidePanel3.Controls.Add(this.labelControl45);
            this.sidePanel3.Controls.Add(this.labelControl46);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel3.Location = new System.Drawing.Point(0, 0);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1204, 173);
            this.sidePanel3.TabIndex = 76;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // rBtnDisHizmetTamamlanmadi
            // 
            this.rBtnDisHizmetTamamlanmadi.AutoSize = true;
            this.rBtnDisHizmetTamamlanmadi.Checked = true;
            this.rBtnDisHizmetTamamlanmadi.Location = new System.Drawing.Point(807, 82);
            this.rBtnDisHizmetTamamlanmadi.Name = "rBtnDisHizmetTamamlanmadi";
            this.rBtnDisHizmetTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnDisHizmetTamamlanmadi.TabIndex = 77;
            this.rBtnDisHizmetTamamlanmadi.TabStop = true;
            this.rBtnDisHizmetTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnDisHizmetTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnDisHizmetTamamlandi
            // 
            this.rBtnDisHizmetTamamlandi.AutoSize = true;
            this.rBtnDisHizmetTamamlandi.Location = new System.Drawing.Point(673, 83);
            this.rBtnDisHizmetTamamlandi.Name = "rBtnDisHizmetTamamlandi";
            this.rBtnDisHizmetTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnDisHizmetTamamlandi.TabIndex = 76;
            this.rBtnDisHizmetTamamlandi.Text = "Tamamlandı";
            this.rBtnDisHizmetTamamlandi.UseVisualStyleBackColor = true;
            // 
            // dEditDisHizmetNumuneOnayTarihi
            // 
            this.dEditDisHizmetNumuneOnayTarihi.EditValue = null;
            this.dEditDisHizmetNumuneOnayTarihi.Location = new System.Drawing.Point(673, 53);
            this.dEditDisHizmetNumuneOnayTarihi.Name = "dEditDisHizmetNumuneOnayTarihi";
            this.dEditDisHizmetNumuneOnayTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetNumuneOnayTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetNumuneOnayTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditDisHizmetNumuneOnayTarihi.TabIndex = 75;
            // 
            // dEditDisHizmetSatinAlmaNumuneGelisTarihi
            // 
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.EditValue = null;
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Location = new System.Drawing.Point(673, 25);
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Name = "dEditDisHizmetSatinAlmaNumuneGelisTarihi";
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.TabIndex = 74;
            // 
            // dEditDisHizmetSatinAlmaTerminTarihi
            // 
            this.dEditDisHizmetSatinAlmaTerminTarihi.EditValue = null;
            this.dEditDisHizmetSatinAlmaTerminTarihi.Location = new System.Drawing.Point(205, 109);
            this.dEditDisHizmetSatinAlmaTerminTarihi.Name = "dEditDisHizmetSatinAlmaTerminTarihi";
            this.dEditDisHizmetSatinAlmaTerminTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetSatinAlmaTerminTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetSatinAlmaTerminTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditDisHizmetSatinAlmaTerminTarihi.TabIndex = 73;
            // 
            // dEditDisHizmetResimIletimTarihi
            // 
            this.dEditDisHizmetResimIletimTarihi.EditValue = null;
            this.dEditDisHizmetResimIletimTarihi.Location = new System.Drawing.Point(205, 81);
            this.dEditDisHizmetResimIletimTarihi.Name = "dEditDisHizmetResimIletimTarihi";
            this.dEditDisHizmetResimIletimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetResimIletimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditDisHizmetResimIletimTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditDisHizmetResimIletimTarihi.TabIndex = 72;
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(12, 12);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(19, 16);
            this.labelControl38.TabIndex = 71;
            this.labelControl38.Text = "3/8";
            // 
            // sBtnDisHizmetKaydet
            // 
            this.sBtnDisHizmetKaydet.Location = new System.Drawing.Point(673, 109);
            this.sBtnDisHizmetKaydet.Name = "sBtnDisHizmetKaydet";
            this.sBtnDisHizmetKaydet.Size = new System.Drawing.Size(255, 44);
            this.sBtnDisHizmetKaydet.TabIndex = 70;
            this.sBtnDisHizmetKaydet.Text = "Dış Hizmet Kaydet";
            this.sBtnDisHizmetKaydet.Click += new System.EventHandler(this.sBtnDisHizmetKaydet_Click);
            // 
            // txtDisHizmetID
            // 
            this.txtDisHizmetID.Location = new System.Drawing.Point(1098, 9);
            this.txtDisHizmetID.Name = "txtDisHizmetID";
            this.txtDisHizmetID.Size = new System.Drawing.Size(29, 22);
            this.txtDisHizmetID.TabIndex = 46;
            this.txtDisHizmetID.Visible = false;
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(528, 84);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(124, 16);
            this.labelControl39.TabIndex = 61;
            this.labelControl39.Text = "TamamlanmaDurumu";
            // 
            // labelControl40
            // 
            this.labelControl40.Location = new System.Drawing.Point(142, 28);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(42, 16);
            this.labelControl40.TabIndex = 63;
            this.labelControl40.Text = "ProjeID";
            // 
            // labelControl41
            // 
            this.labelControl41.Location = new System.Drawing.Point(543, 56);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(109, 16);
            this.labelControl41.TabIndex = 60;
            this.labelControl41.Text = "NumuneOnayTarihi";
            // 
            // txtDisHizmetProjeID
            // 
            this.txtDisHizmetProjeID.Location = new System.Drawing.Point(205, 25);
            this.txtDisHizmetProjeID.Name = "txtDisHizmetProjeID";
            this.txtDisHizmetProjeID.Properties.ReadOnly = true;
            this.txtDisHizmetProjeID.Size = new System.Drawing.Size(255, 22);
            this.txtDisHizmetProjeID.TabIndex = 47;
            // 
            // labelControl42
            // 
            this.labelControl42.Location = new System.Drawing.Point(487, 28);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(165, 16);
            this.labelControl42.TabIndex = 59;
            this.labelControl42.Text = "SatınAlmaNumuneGelisTarihi";
            // 
            // txtDisHizmetProjeDetayID
            // 
            this.txtDisHizmetProjeDetayID.Location = new System.Drawing.Point(205, 53);
            this.txtDisHizmetProjeDetayID.Name = "txtDisHizmetProjeDetayID";
            this.txtDisHizmetProjeDetayID.Properties.ReadOnly = true;
            this.txtDisHizmetProjeDetayID.Size = new System.Drawing.Size(255, 22);
            this.txtDisHizmetProjeDetayID.TabIndex = 48;
            // 
            // labelControl43
            // 
            this.labelControl43.Location = new System.Drawing.Point(52, 112);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(132, 16);
            this.labelControl43.TabIndex = 58;
            this.labelControl43.Text = "SatınAlmaTerminTarihi";
            // 
            // labelControl44
            // 
            this.labelControl44.Location = new System.Drawing.Point(1065, 12);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(12, 16);
            this.labelControl44.TabIndex = 55;
            this.labelControl44.Text = "ID";
            this.labelControl44.Visible = false;
            // 
            // labelControl45
            // 
            this.labelControl45.Location = new System.Drawing.Point(84, 84);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(100, 16);
            this.labelControl45.TabIndex = 57;
            this.labelControl45.Text = "ResimIletimTarihi";
            // 
            // labelControl46
            // 
            this.labelControl46.Location = new System.Drawing.Point(110, 56);
            this.labelControl46.Name = "labelControl46";
            this.labelControl46.Size = new System.Drawing.Size(74, 16);
            this.labelControl46.TabIndex = 56;
            this.labelControl46.Text = "ProjeDetayID";
            // 
            // Kaliphane
            // 
            this.Kaliphane.Caption = "Kalıphane";
            this.Kaliphane.Controls.Add(this.gridKalipHaneAparat);
            this.Kaliphane.Controls.Add(this.sidePanel4);
            this.Kaliphane.Name = "Kaliphane";
            this.Kaliphane.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridKalipHaneAparat
            // 
            this.gridKalipHaneAparat.DataSource = this.kaliphaneAparatBindingSource;
            this.gridKalipHaneAparat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKalipHaneAparat.Location = new System.Drawing.Point(0, 218);
            this.gridKalipHaneAparat.MainView = this.gViewKalipHaneAparat;
            this.gridKalipHaneAparat.Name = "gridKalipHaneAparat";
            this.gridKalipHaneAparat.Size = new System.Drawing.Size(1204, 647);
            this.gridKalipHaneAparat.TabIndex = 99;
            this.gridKalipHaneAparat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewKalipHaneAparat});
            // 
            // kaliphaneAparatBindingSource
            // 
            this.kaliphaneAparatBindingSource.DataMember = "KaliphaneAparat";
            this.kaliphaneAparatBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewKalipHaneAparat
            // 
            this.gViewKalipHaneAparat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID3,
            this.colProjeID3,
            this.colProjeDetayID3,
            this.colIhtiyacDuyulanKalipAdedi,
            this.colKalipTerminTarihi,
            this.colKalipGerceklesenNumuneTarihi,
            this.colKaliteNumuneOnayTarihi,
            this.colIhtiyacDuyulanAparatAdedi,
            this.colAparatTerminTarihi,
            this.colAparatGerceklesenTeslimTarihi,
            this.colTamamlanmaDurumu2});
            this.gViewKalipHaneAparat.GridControl = this.gridKalipHaneAparat;
            this.gViewKalipHaneAparat.Name = "gViewKalipHaneAparat";
            this.gViewKalipHaneAparat.OptionsBehavior.Editable = false;
            this.gViewKalipHaneAparat.OptionsBehavior.ReadOnly = true;
            this.gViewKalipHaneAparat.DoubleClick += new System.EventHandler(this.gViewKalipHaneAparat_DoubleClick);
            // 
            // colID3
            // 
            this.colID3.Caption = "Sıra Numarası";
            this.colID3.FieldName = "ID";
            this.colID3.MinWidth = 25;
            this.colID3.Name = "colID3";
            this.colID3.Visible = true;
            this.colID3.VisibleIndex = 0;
            this.colID3.Width = 94;
            // 
            // colProjeID3
            // 
            this.colProjeID3.FieldName = "ProjeID";
            this.colProjeID3.MinWidth = 25;
            this.colProjeID3.Name = "colProjeID3";
            this.colProjeID3.Width = 94;
            // 
            // colProjeDetayID3
            // 
            this.colProjeDetayID3.FieldName = "ProjeDetayID";
            this.colProjeDetayID3.MinWidth = 25;
            this.colProjeDetayID3.Name = "colProjeDetayID3";
            this.colProjeDetayID3.Width = 94;
            // 
            // colIhtiyacDuyulanKalipAdedi
            // 
            this.colIhtiyacDuyulanKalipAdedi.FieldName = "IhtiyacDuyulanKalipAdedi";
            this.colIhtiyacDuyulanKalipAdedi.MinWidth = 25;
            this.colIhtiyacDuyulanKalipAdedi.Name = "colIhtiyacDuyulanKalipAdedi";
            this.colIhtiyacDuyulanKalipAdedi.Visible = true;
            this.colIhtiyacDuyulanKalipAdedi.VisibleIndex = 1;
            this.colIhtiyacDuyulanKalipAdedi.Width = 94;
            // 
            // colKalipTerminTarihi
            // 
            this.colKalipTerminTarihi.FieldName = "KalipTerminTarihi";
            this.colKalipTerminTarihi.MinWidth = 25;
            this.colKalipTerminTarihi.Name = "colKalipTerminTarihi";
            this.colKalipTerminTarihi.Visible = true;
            this.colKalipTerminTarihi.VisibleIndex = 2;
            this.colKalipTerminTarihi.Width = 94;
            // 
            // colKalipGerceklesenNumuneTarihi
            // 
            this.colKalipGerceklesenNumuneTarihi.FieldName = "KalipGerceklesenNumuneTarihi";
            this.colKalipGerceklesenNumuneTarihi.MinWidth = 25;
            this.colKalipGerceklesenNumuneTarihi.Name = "colKalipGerceklesenNumuneTarihi";
            this.colKalipGerceklesenNumuneTarihi.Visible = true;
            this.colKalipGerceklesenNumuneTarihi.VisibleIndex = 3;
            this.colKalipGerceklesenNumuneTarihi.Width = 94;
            // 
            // colKaliteNumuneOnayTarihi
            // 
            this.colKaliteNumuneOnayTarihi.FieldName = "KaliteNumuneOnayTarihi";
            this.colKaliteNumuneOnayTarihi.MinWidth = 25;
            this.colKaliteNumuneOnayTarihi.Name = "colKaliteNumuneOnayTarihi";
            this.colKaliteNumuneOnayTarihi.Visible = true;
            this.colKaliteNumuneOnayTarihi.VisibleIndex = 4;
            this.colKaliteNumuneOnayTarihi.Width = 94;
            // 
            // colIhtiyacDuyulanAparatAdedi
            // 
            this.colIhtiyacDuyulanAparatAdedi.FieldName = "IhtiyacDuyulanAparatAdedi";
            this.colIhtiyacDuyulanAparatAdedi.MinWidth = 25;
            this.colIhtiyacDuyulanAparatAdedi.Name = "colIhtiyacDuyulanAparatAdedi";
            this.colIhtiyacDuyulanAparatAdedi.Visible = true;
            this.colIhtiyacDuyulanAparatAdedi.VisibleIndex = 5;
            this.colIhtiyacDuyulanAparatAdedi.Width = 94;
            // 
            // colAparatTerminTarihi
            // 
            this.colAparatTerminTarihi.FieldName = "AparatTerminTarihi";
            this.colAparatTerminTarihi.MinWidth = 25;
            this.colAparatTerminTarihi.Name = "colAparatTerminTarihi";
            this.colAparatTerminTarihi.Visible = true;
            this.colAparatTerminTarihi.VisibleIndex = 6;
            this.colAparatTerminTarihi.Width = 94;
            // 
            // colAparatGerceklesenTeslimTarihi
            // 
            this.colAparatGerceklesenTeslimTarihi.FieldName = "AparatGerceklesenTeslimTarihi";
            this.colAparatGerceklesenTeslimTarihi.MinWidth = 25;
            this.colAparatGerceklesenTeslimTarihi.Name = "colAparatGerceklesenTeslimTarihi";
            this.colAparatGerceklesenTeslimTarihi.Visible = true;
            this.colAparatGerceklesenTeslimTarihi.VisibleIndex = 7;
            this.colAparatGerceklesenTeslimTarihi.Width = 94;
            // 
            // colTamamlanmaDurumu2
            // 
            this.colTamamlanmaDurumu2.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu2.MinWidth = 25;
            this.colTamamlanmaDurumu2.Name = "colTamamlanmaDurumu2";
            this.colTamamlanmaDurumu2.Visible = true;
            this.colTamamlanmaDurumu2.VisibleIndex = 8;
            this.colTamamlanmaDurumu2.Width = 94;
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.txtKalipHaneIhtıyacKalipAdedi);
            this.sidePanel4.Controls.Add(this.rBtnKalipHaneTamamlanmadi);
            this.sidePanel4.Controls.Add(this.rBtnKalipHaneTamamlandi);
            this.sidePanel4.Controls.Add(this.dEditKalipHaneAparatGerceklesenTeslimTarihi);
            this.sidePanel4.Controls.Add(this.dEditKalipHaneAparatTerminTarihi);
            this.sidePanel4.Controls.Add(this.dEditKalipHaneKaliteNumuneOnayTarihi);
            this.sidePanel4.Controls.Add(this.dEditKalipHaneKalipGerceklesenNumuneTarihi);
            this.sidePanel4.Controls.Add(this.dEditKalipHaneKalipTerminTarihi);
            this.sidePanel4.Controls.Add(this.labelControl47);
            this.sidePanel4.Controls.Add(this.labelControl48);
            this.sidePanel4.Controls.Add(this.txtKalipHaneID);
            this.sidePanel4.Controls.Add(this.txtKalipHaneProjeID);
            this.sidePanel4.Controls.Add(this.labelControl49);
            this.sidePanel4.Controls.Add(this.txtKalipHaneProjeDetayID);
            this.sidePanel4.Controls.Add(this.labelControl50);
            this.sidePanel4.Controls.Add(this.sBtnKalipHaneAparatKaydet);
            this.sidePanel4.Controls.Add(this.labelControl51);
            this.sidePanel4.Controls.Add(this.labelControl52);
            this.sidePanel4.Controls.Add(this.labelControl53);
            this.sidePanel4.Controls.Add(this.labelControl54);
            this.sidePanel4.Controls.Add(this.labelControl55);
            this.sidePanel4.Controls.Add(this.txtKalipHaneIhtiyacDuyulanAparatAdedi);
            this.sidePanel4.Controls.Add(this.labelControl57);
            this.sidePanel4.Controls.Add(this.labelControl58);
            this.sidePanel4.Controls.Add(this.labelControl59);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel4.Location = new System.Drawing.Point(0, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1204, 218);
            this.sidePanel4.TabIndex = 100;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // txtKalipHaneIhtıyacKalipAdedi
            // 
            this.txtKalipHaneIhtıyacKalipAdedi.Location = new System.Drawing.Point(231, 78);
            this.txtKalipHaneIhtıyacKalipAdedi.Name = "txtKalipHaneIhtıyacKalipAdedi";
            this.txtKalipHaneIhtıyacKalipAdedi.Properties.Mask.EditMask = "d";
            this.txtKalipHaneIhtıyacKalipAdedi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKalipHaneIhtıyacKalipAdedi.Size = new System.Drawing.Size(258, 22);
            this.txtKalipHaneIhtıyacKalipAdedi.TabIndex = 104;
            // 
            // rBtnKalipHaneTamamlanmadi
            // 
            this.rBtnKalipHaneTamamlanmadi.AutoSize = true;
            this.rBtnKalipHaneTamamlanmadi.Checked = true;
            this.rBtnKalipHaneTamamlanmadi.Location = new System.Drawing.Point(857, 107);
            this.rBtnKalipHaneTamamlanmadi.Name = "rBtnKalipHaneTamamlanmadi";
            this.rBtnKalipHaneTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnKalipHaneTamamlanmadi.TabIndex = 103;
            this.rBtnKalipHaneTamamlanmadi.TabStop = true;
            this.rBtnKalipHaneTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnKalipHaneTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnKalipHaneTamamlandi
            // 
            this.rBtnKalipHaneTamamlandi.AutoSize = true;
            this.rBtnKalipHaneTamamlandi.Location = new System.Drawing.Point(723, 108);
            this.rBtnKalipHaneTamamlandi.Name = "rBtnKalipHaneTamamlandi";
            this.rBtnKalipHaneTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnKalipHaneTamamlandi.TabIndex = 102;
            this.rBtnKalipHaneTamamlandi.Text = "Tamamlandı";
            this.rBtnKalipHaneTamamlandi.UseVisualStyleBackColor = true;
            // 
            // dEditKalipHaneAparatGerceklesenTeslimTarihi
            // 
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.EditValue = null;
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Location = new System.Drawing.Point(723, 78);
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Name = "dEditKalipHaneAparatGerceklesenTeslimTarihi";
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Size = new System.Drawing.Size(258, 22);
            this.dEditKalipHaneAparatGerceklesenTeslimTarihi.TabIndex = 101;
            // 
            // dEditKalipHaneAparatTerminTarihi
            // 
            this.dEditKalipHaneAparatTerminTarihi.EditValue = null;
            this.dEditKalipHaneAparatTerminTarihi.Location = new System.Drawing.Point(723, 50);
            this.dEditKalipHaneAparatTerminTarihi.Name = "dEditKalipHaneAparatTerminTarihi";
            this.dEditKalipHaneAparatTerminTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneAparatTerminTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneAparatTerminTarihi.Size = new System.Drawing.Size(258, 22);
            this.dEditKalipHaneAparatTerminTarihi.TabIndex = 100;
            // 
            // dEditKalipHaneKaliteNumuneOnayTarihi
            // 
            this.dEditKalipHaneKaliteNumuneOnayTarihi.EditValue = null;
            this.dEditKalipHaneKaliteNumuneOnayTarihi.Location = new System.Drawing.Point(228, 167);
            this.dEditKalipHaneKaliteNumuneOnayTarihi.Name = "dEditKalipHaneKaliteNumuneOnayTarihi";
            this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKaliteNumuneOnayTarihi.Size = new System.Drawing.Size(258, 22);
            this.dEditKalipHaneKaliteNumuneOnayTarihi.TabIndex = 99;
            // 
            // dEditKalipHaneKalipGerceklesenNumuneTarihi
            // 
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.EditValue = null;
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Location = new System.Drawing.Point(231, 134);
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Name = "dEditKalipHaneKalipGerceklesenNumuneTarihi";
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditKalipHaneKalipGerceklesenNumuneTarihi.TabIndex = 98;
            // 
            // dEditKalipHaneKalipTerminTarihi
            // 
            this.dEditKalipHaneKalipTerminTarihi.EditValue = null;
            this.dEditKalipHaneKalipTerminTarihi.Location = new System.Drawing.Point(231, 106);
            this.dEditKalipHaneKalipTerminTarihi.Name = "dEditKalipHaneKalipTerminTarihi";
            this.dEditKalipHaneKalipTerminTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKalipTerminTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKalipHaneKalipTerminTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditKalipHaneKalipTerminTarihi.TabIndex = 97;
            // 
            // labelControl47
            // 
            this.labelControl47.Location = new System.Drawing.Point(12, 12);
            this.labelControl47.Name = "labelControl47";
            this.labelControl47.Size = new System.Drawing.Size(19, 16);
            this.labelControl47.TabIndex = 89;
            this.labelControl47.Text = "4/8";
            // 
            // labelControl48
            // 
            this.labelControl48.Location = new System.Drawing.Point(580, 109);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(124, 16);
            this.labelControl48.TabIndex = 95;
            this.labelControl48.Text = "TamamlanmaDurumu";
            // 
            // txtKalipHaneID
            // 
            this.txtKalipHaneID.Location = new System.Drawing.Point(1095, 9);
            this.txtKalipHaneID.Name = "txtKalipHaneID";
            this.txtKalipHaneID.Size = new System.Drawing.Size(32, 22);
            this.txtKalipHaneID.TabIndex = 72;
            this.txtKalipHaneID.Visible = false;
            // 
            // txtKalipHaneProjeID
            // 
            this.txtKalipHaneProjeID.Location = new System.Drawing.Point(231, 22);
            this.txtKalipHaneProjeID.Name = "txtKalipHaneProjeID";
            this.txtKalipHaneProjeID.Properties.ReadOnly = true;
            this.txtKalipHaneProjeID.Size = new System.Drawing.Size(255, 22);
            this.txtKalipHaneProjeID.TabIndex = 73;
            // 
            // labelControl49
            // 
            this.labelControl49.Location = new System.Drawing.Point(527, 81);
            this.labelControl49.Name = "labelControl49";
            this.labelControl49.Size = new System.Drawing.Size(178, 16);
            this.labelControl49.TabIndex = 93;
            this.labelControl49.Text = "AparatGerceklesenTeslimTarihi";
            // 
            // txtKalipHaneProjeDetayID
            // 
            this.txtKalipHaneProjeDetayID.Location = new System.Drawing.Point(231, 50);
            this.txtKalipHaneProjeDetayID.Name = "txtKalipHaneProjeDetayID";
            this.txtKalipHaneProjeDetayID.Properties.ReadOnly = true;
            this.txtKalipHaneProjeDetayID.Size = new System.Drawing.Size(255, 22);
            this.txtKalipHaneProjeDetayID.TabIndex = 74;
            // 
            // labelControl50
            // 
            this.labelControl50.Location = new System.Drawing.Point(593, 53);
            this.labelControl50.Name = "labelControl50";
            this.labelControl50.Size = new System.Drawing.Size(112, 16);
            this.labelControl50.TabIndex = 91;
            this.labelControl50.Text = "AparatTerminTarihi";
            // 
            // sBtnKalipHaneAparatKaydet
            // 
            this.sBtnKalipHaneAparatKaydet.Location = new System.Drawing.Point(723, 134);
            this.sBtnKalipHaneAparatKaydet.Name = "sBtnKalipHaneAparatKaydet";
            this.sBtnKalipHaneAparatKaydet.Size = new System.Drawing.Size(258, 44);
            this.sBtnKalipHaneAparatKaydet.TabIndex = 88;
            this.sBtnKalipHaneAparatKaydet.Text = "KalıpHaneAparat Kaydet";
            this.sBtnKalipHaneAparatKaydet.Click += new System.EventHandler(this.sBtnKalipHaneAparatKaydet_Click);
            // 
            // labelControl51
            // 
            this.labelControl51.Location = new System.Drawing.Point(1062, 12);
            this.labelControl51.Name = "labelControl51";
            this.labelControl51.Size = new System.Drawing.Size(12, 16);
            this.labelControl51.TabIndex = 80;
            this.labelControl51.Text = "ID";
            this.labelControl51.Visible = false;
            // 
            // labelControl52
            // 
            this.labelControl52.Location = new System.Drawing.Point(553, 25);
            this.labelControl52.Name = "labelControl52";
            this.labelControl52.Size = new System.Drawing.Size(152, 16);
            this.labelControl52.TabIndex = 86;
            this.labelControl52.Text = "IhtiyacDuyulanAparatAdedi";
            // 
            // labelControl53
            // 
            this.labelControl53.Location = new System.Drawing.Point(168, 25);
            this.labelControl53.Name = "labelControl53";
            this.labelControl53.Size = new System.Drawing.Size(42, 16);
            this.labelControl53.TabIndex = 87;
            this.labelControl53.Text = "ProjeID";
            // 
            // labelControl54
            // 
            this.labelControl54.Location = new System.Drawing.Point(70, 170);
            this.labelControl54.Name = "labelControl54";
            this.labelControl54.Size = new System.Drawing.Size(140, 16);
            this.labelControl54.TabIndex = 85;
            this.labelControl54.Text = "KaliteNumuneOnayTarihi";
            // 
            // labelControl55
            // 
            this.labelControl55.Location = new System.Drawing.Point(136, 53);
            this.labelControl55.Name = "labelControl55";
            this.labelControl55.Size = new System.Drawing.Size(74, 16);
            this.labelControl55.TabIndex = 81;
            this.labelControl55.Text = "ProjeDetayID";
            // 
            // txtKalipHaneIhtiyacDuyulanAparatAdedi
            // 
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Location = new System.Drawing.Point(723, 22);
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Name = "txtKalipHaneIhtiyacDuyulanAparatAdedi";
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Properties.Mask.EditMask = "d";
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Size = new System.Drawing.Size(258, 22);
            this.txtKalipHaneIhtiyacDuyulanAparatAdedi.TabIndex = 79;
            // 
            // labelControl57
            // 
            this.labelControl57.Location = new System.Drawing.Point(69, 81);
            this.labelControl57.Name = "labelControl57";
            this.labelControl57.Size = new System.Drawing.Size(141, 16);
            this.labelControl57.TabIndex = 82;
            this.labelControl57.Text = "IhtiyacDuyulanKalipAdedi";
            // 
            // labelControl58
            // 
            this.labelControl58.Location = new System.Drawing.Point(109, 109);
            this.labelControl58.Name = "labelControl58";
            this.labelControl58.Size = new System.Drawing.Size(101, 16);
            this.labelControl58.TabIndex = 83;
            this.labelControl58.Text = "KalipTerminTarihi";
            // 
            // labelControl59
            // 
            this.labelControl59.Location = new System.Drawing.Point(34, 137);
            this.labelControl59.Name = "labelControl59";
            this.labelControl59.Size = new System.Drawing.Size(176, 16);
            this.labelControl59.TabIndex = 84;
            this.labelControl59.Text = "KalipGerceklesenNumuneTarihi";
            // 
            // KaliteKontrol
            // 
            this.KaliteKontrol.Caption = "Kalite Kontrol";
            this.KaliteKontrol.Controls.Add(this.gridKaliteKontrol);
            this.KaliteKontrol.Controls.Add(this.sidePanel5);
            this.KaliteKontrol.Name = "KaliteKontrol";
            this.KaliteKontrol.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridKaliteKontrol
            // 
            this.gridKaliteKontrol.DataSource = this.kaliteKontrolBindingSource;
            this.gridKaliteKontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKaliteKontrol.Location = new System.Drawing.Point(0, 182);
            this.gridKaliteKontrol.MainView = this.gViewKaliteKontrol;
            this.gridKaliteKontrol.Name = "gridKaliteKontrol";
            this.gridKaliteKontrol.Size = new System.Drawing.Size(1204, 683);
            this.gridKaliteKontrol.TabIndex = 116;
            this.gridKaliteKontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewKaliteKontrol});
            // 
            // kaliteKontrolBindingSource
            // 
            this.kaliteKontrolBindingSource.DataMember = "KaliteKontrol";
            this.kaliteKontrolBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewKaliteKontrol
            // 
            this.gViewKaliteKontrol.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID4,
            this.colProjeID4,
            this.colProjeDetayID4,
            this.colOzelOlcmeEkipmaniIhtiyaci,
            this.colOzelOlcmeEkipmanlariSiparisTarihi,
            this.colOzelOlcmeTakimlarTeslimTarihi,
            this.colTamamlanmaDurumu3});
            this.gViewKaliteKontrol.GridControl = this.gridKaliteKontrol;
            this.gViewKaliteKontrol.Name = "gViewKaliteKontrol";
            this.gViewKaliteKontrol.OptionsBehavior.Editable = false;
            this.gViewKaliteKontrol.OptionsBehavior.ReadOnly = true;
            this.gViewKaliteKontrol.DoubleClick += new System.EventHandler(this.gViewKaliteKontrol_DoubleClick);
            // 
            // colID4
            // 
            this.colID4.Caption = "Sıra Numarası";
            this.colID4.FieldName = "ID";
            this.colID4.MinWidth = 25;
            this.colID4.Name = "colID4";
            this.colID4.Visible = true;
            this.colID4.VisibleIndex = 0;
            this.colID4.Width = 94;
            // 
            // colProjeID4
            // 
            this.colProjeID4.FieldName = "ProjeID";
            this.colProjeID4.MinWidth = 25;
            this.colProjeID4.Name = "colProjeID4";
            this.colProjeID4.Width = 94;
            // 
            // colProjeDetayID4
            // 
            this.colProjeDetayID4.FieldName = "ProjeDetayID";
            this.colProjeDetayID4.MinWidth = 25;
            this.colProjeDetayID4.Name = "colProjeDetayID4";
            this.colProjeDetayID4.Width = 94;
            // 
            // colOzelOlcmeEkipmaniIhtiyaci
            // 
            this.colOzelOlcmeEkipmaniIhtiyaci.FieldName = "OzelOlcmeEkipmaniIhtiyaci";
            this.colOzelOlcmeEkipmaniIhtiyaci.MinWidth = 25;
            this.colOzelOlcmeEkipmaniIhtiyaci.Name = "colOzelOlcmeEkipmaniIhtiyaci";
            this.colOzelOlcmeEkipmaniIhtiyaci.Visible = true;
            this.colOzelOlcmeEkipmaniIhtiyaci.VisibleIndex = 1;
            this.colOzelOlcmeEkipmaniIhtiyaci.Width = 94;
            // 
            // colOzelOlcmeEkipmanlariSiparisTarihi
            // 
            this.colOzelOlcmeEkipmanlariSiparisTarihi.FieldName = "OzelOlcmeEkipmanlariSiparisTarihi";
            this.colOzelOlcmeEkipmanlariSiparisTarihi.MinWidth = 25;
            this.colOzelOlcmeEkipmanlariSiparisTarihi.Name = "colOzelOlcmeEkipmanlariSiparisTarihi";
            this.colOzelOlcmeEkipmanlariSiparisTarihi.Visible = true;
            this.colOzelOlcmeEkipmanlariSiparisTarihi.VisibleIndex = 2;
            this.colOzelOlcmeEkipmanlariSiparisTarihi.Width = 94;
            // 
            // colOzelOlcmeTakimlarTeslimTarihi
            // 
            this.colOzelOlcmeTakimlarTeslimTarihi.FieldName = "OzelOlcmeTakimlarTeslimTarihi";
            this.colOzelOlcmeTakimlarTeslimTarihi.MinWidth = 25;
            this.colOzelOlcmeTakimlarTeslimTarihi.Name = "colOzelOlcmeTakimlarTeslimTarihi";
            this.colOzelOlcmeTakimlarTeslimTarihi.Visible = true;
            this.colOzelOlcmeTakimlarTeslimTarihi.VisibleIndex = 3;
            this.colOzelOlcmeTakimlarTeslimTarihi.Width = 94;
            // 
            // colTamamlanmaDurumu3
            // 
            this.colTamamlanmaDurumu3.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu3.MinWidth = 25;
            this.colTamamlanmaDurumu3.Name = "colTamamlanmaDurumu3";
            this.colTamamlanmaDurumu3.Visible = true;
            this.colTamamlanmaDurumu3.VisibleIndex = 4;
            this.colTamamlanmaDurumu3.Width = 94;
            // 
            // sidePanel5
            // 
            this.sidePanel5.Controls.Add(this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı);
            this.sidePanel5.Controls.Add(this.rBtnKaliteKontrolTamamlanmadi);
            this.sidePanel5.Controls.Add(this.rBtnKaliteKontrolTamamlandi);
            this.sidePanel5.Controls.Add(this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi);
            this.sidePanel5.Controls.Add(this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi);
            this.sidePanel5.Controls.Add(this.labelControl60);
            this.sidePanel5.Controls.Add(this.sBtnKaliteKontrolKaydet);
            this.sidePanel5.Controls.Add(this.txtKaliteKontrolID);
            this.sidePanel5.Controls.Add(this.labelControl61);
            this.sidePanel5.Controls.Add(this.labelControl62);
            this.sidePanel5.Controls.Add(this.labelControl63);
            this.sidePanel5.Controls.Add(this.txtKaliteKontrolProjeID);
            this.sidePanel5.Controls.Add(this.labelControl64);
            this.sidePanel5.Controls.Add(this.txtKaliteKontrolProjeDetayID);
            this.sidePanel5.Controls.Add(this.labelControl65);
            this.sidePanel5.Controls.Add(this.labelControl66);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel5.Location = new System.Drawing.Point(0, 0);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1204, 182);
            this.sidePanel5.TabIndex = 98;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı
            // 
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Location = new System.Drawing.Point(17, 88);
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Name = "checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı";
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Properties.Caption = "Özel Ölçme Ekipman İhtiyacı";
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Size = new System.Drawing.Size(196, 24);
            this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.TabIndex = 136;
            // 
            // rBtnKaliteKontrolTamamlanmadi
            // 
            this.rBtnKaliteKontrolTamamlanmadi.AutoSize = true;
            this.rBtnKaliteKontrolTamamlanmadi.Checked = true;
            this.rBtnKaliteKontrolTamamlanmadi.Location = new System.Drawing.Point(830, 89);
            this.rBtnKaliteKontrolTamamlanmadi.Name = "rBtnKaliteKontrolTamamlanmadi";
            this.rBtnKaliteKontrolTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnKaliteKontrolTamamlanmadi.TabIndex = 133;
            this.rBtnKaliteKontrolTamamlanmadi.TabStop = true;
            this.rBtnKaliteKontrolTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnKaliteKontrolTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnKaliteKontrolTamamlandi
            // 
            this.rBtnKaliteKontrolTamamlandi.AutoSize = true;
            this.rBtnKaliteKontrolTamamlandi.Location = new System.Drawing.Point(696, 90);
            this.rBtnKaliteKontrolTamamlandi.Name = "rBtnKaliteKontrolTamamlandi";
            this.rBtnKaliteKontrolTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnKaliteKontrolTamamlandi.TabIndex = 132;
            this.rBtnKaliteKontrolTamamlandi.Text = "Tamamlandı";
            this.rBtnKaliteKontrolTamamlandi.UseVisualStyleBackColor = true;
            // 
            // dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi
            // 
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.EditValue = null;
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Location = new System.Drawing.Point(696, 60);
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Name = "dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi";
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.TabIndex = 131;
            // 
            // dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi
            // 
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.EditValue = null;
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Location = new System.Drawing.Point(696, 32);
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Name = "dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi";
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.TabIndex = 130;
            // 
            // labelControl60
            // 
            this.labelControl60.Location = new System.Drawing.Point(12, 14);
            this.labelControl60.Name = "labelControl60";
            this.labelControl60.Size = new System.Drawing.Size(19, 16);
            this.labelControl60.TabIndex = 129;
            this.labelControl60.Text = "5/8";
            // 
            // sBtnKaliteKontrolKaydet
            // 
            this.sBtnKaliteKontrolKaydet.Location = new System.Drawing.Point(696, 116);
            this.sBtnKaliteKontrolKaydet.Name = "sBtnKaliteKontrolKaydet";
            this.sBtnKaliteKontrolKaydet.Size = new System.Drawing.Size(255, 44);
            this.sBtnKaliteKontrolKaydet.TabIndex = 128;
            this.sBtnKaliteKontrolKaydet.Text = "KaliteKontrol Kaydet";
            this.sBtnKaliteKontrolKaydet.Click += new System.EventHandler(this.sBtnKaliteKontrolKaydet_Click);
            // 
            // txtKaliteKontrolID
            // 
            this.txtKaliteKontrolID.Location = new System.Drawing.Point(1069, 11);
            this.txtKaliteKontrolID.Name = "txtKaliteKontrolID";
            this.txtKaliteKontrolID.Size = new System.Drawing.Size(58, 22);
            this.txtKaliteKontrolID.TabIndex = 114;
            this.txtKaliteKontrolID.Visible = false;
            // 
            // labelControl61
            // 
            this.labelControl61.Location = new System.Drawing.Point(551, 91);
            this.labelControl61.Name = "labelControl61";
            this.labelControl61.Size = new System.Drawing.Size(124, 16);
            this.labelControl61.TabIndex = 126;
            this.labelControl61.Text = "TamamlanmaDurumu";
            // 
            // labelControl62
            // 
            this.labelControl62.Location = new System.Drawing.Point(128, 35);
            this.labelControl62.Name = "labelControl62";
            this.labelControl62.Size = new System.Drawing.Size(42, 16);
            this.labelControl62.TabIndex = 127;
            this.labelControl62.Text = "ProjeID";
            // 
            // labelControl63
            // 
            this.labelControl63.Location = new System.Drawing.Point(493, 63);
            this.labelControl63.Name = "labelControl63";
            this.labelControl63.Size = new System.Drawing.Size(182, 16);
            this.labelControl63.TabIndex = 125;
            this.labelControl63.Text = "ÖzelÖlcmeTakimlarTeslimTarihi";
            // 
            // txtKaliteKontrolProjeID
            // 
            this.txtKaliteKontrolProjeID.Location = new System.Drawing.Point(191, 32);
            this.txtKaliteKontrolProjeID.Name = "txtKaliteKontrolProjeID";
            this.txtKaliteKontrolProjeID.Properties.ReadOnly = true;
            this.txtKaliteKontrolProjeID.Size = new System.Drawing.Size(255, 22);
            this.txtKaliteKontrolProjeID.TabIndex = 115;
            // 
            // labelControl64
            // 
            this.labelControl64.Location = new System.Drawing.Point(476, 35);
            this.labelControl64.Name = "labelControl64";
            this.labelControl64.Size = new System.Drawing.Size(199, 16);
            this.labelControl64.TabIndex = 124;
            this.labelControl64.Text = "ÖzelÖlçmeEkipmanlarıSiparisTarihi";
            // 
            // txtKaliteKontrolProjeDetayID
            // 
            this.txtKaliteKontrolProjeDetayID.Location = new System.Drawing.Point(191, 60);
            this.txtKaliteKontrolProjeDetayID.Name = "txtKaliteKontrolProjeDetayID";
            this.txtKaliteKontrolProjeDetayID.Properties.ReadOnly = true;
            this.txtKaliteKontrolProjeDetayID.Size = new System.Drawing.Size(255, 22);
            this.txtKaliteKontrolProjeDetayID.TabIndex = 116;
            // 
            // labelControl65
            // 
            this.labelControl65.Location = new System.Drawing.Point(1036, 14);
            this.labelControl65.Name = "labelControl65";
            this.labelControl65.Size = new System.Drawing.Size(12, 16);
            this.labelControl65.TabIndex = 121;
            this.labelControl65.Text = "ID";
            this.labelControl65.Visible = false;
            // 
            // labelControl66
            // 
            this.labelControl66.Location = new System.Drawing.Point(96, 63);
            this.labelControl66.Name = "labelControl66";
            this.labelControl66.Size = new System.Drawing.Size(74, 16);
            this.labelControl66.TabIndex = 122;
            this.labelControl66.Text = "ProjeDetayID";
            // 
            // UretimPlanlama
            // 
            this.UretimPlanlama.Caption = "Uretim Planlama";
            this.UretimPlanlama.Controls.Add(this.gridUretimPlanlama);
            this.UretimPlanlama.Controls.Add(this.sidePanel6);
            this.UretimPlanlama.Name = "UretimPlanlama";
            this.UretimPlanlama.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridUretimPlanlama
            // 
            this.gridUretimPlanlama.DataSource = this.uretimPlanlamaBindingSource;
            this.gridUretimPlanlama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUretimPlanlama.Location = new System.Drawing.Point(0, 151);
            this.gridUretimPlanlama.MainView = this.gViewUretimPlanlama;
            this.gridUretimPlanlama.Name = "gridUretimPlanlama";
            this.gridUretimPlanlama.Size = new System.Drawing.Size(1204, 714);
            this.gridUretimPlanlama.TabIndex = 99;
            this.gridUretimPlanlama.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewUretimPlanlama});
            // 
            // uretimPlanlamaBindingSource
            // 
            this.uretimPlanlamaBindingSource.DataMember = "UretimPlanlama";
            this.uretimPlanlamaBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewUretimPlanlama
            // 
            this.gViewUretimPlanlama.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID5,
            this.colProjeID5,
            this.colProjeDetayID5,
            this.colIhtiyacDuyulanOzelTakim,
            this.colOzelTakimlarSiparisTarihi,
            this.colOzelTakimlarTeslimTarihi,
            this.colDenemeUretimTarihi,
            this.colKaliteNumuneOnayTarihi1,
            this.colTamamlanmaDurumu4});
            this.gViewUretimPlanlama.GridControl = this.gridUretimPlanlama;
            this.gViewUretimPlanlama.Name = "gViewUretimPlanlama";
            this.gViewUretimPlanlama.OptionsBehavior.Editable = false;
            this.gViewUretimPlanlama.OptionsBehavior.ReadOnly = true;
            this.gViewUretimPlanlama.DoubleClick += new System.EventHandler(this.gViewUretimPlanlama_DoubleClick);
            // 
            // colID5
            // 
            this.colID5.Caption = "Sıra Numarası";
            this.colID5.FieldName = "ID";
            this.colID5.MinWidth = 25;
            this.colID5.Name = "colID5";
            this.colID5.Visible = true;
            this.colID5.VisibleIndex = 0;
            this.colID5.Width = 94;
            // 
            // colProjeID5
            // 
            this.colProjeID5.FieldName = "ProjeID";
            this.colProjeID5.MinWidth = 25;
            this.colProjeID5.Name = "colProjeID5";
            this.colProjeID5.Width = 94;
            // 
            // colProjeDetayID5
            // 
            this.colProjeDetayID5.FieldName = "ProjeDetayID";
            this.colProjeDetayID5.MinWidth = 25;
            this.colProjeDetayID5.Name = "colProjeDetayID5";
            this.colProjeDetayID5.Width = 94;
            // 
            // colIhtiyacDuyulanOzelTakim
            // 
            this.colIhtiyacDuyulanOzelTakim.FieldName = "IhtiyacDuyulanOzelTakim";
            this.colIhtiyacDuyulanOzelTakim.MinWidth = 25;
            this.colIhtiyacDuyulanOzelTakim.Name = "colIhtiyacDuyulanOzelTakim";
            this.colIhtiyacDuyulanOzelTakim.Visible = true;
            this.colIhtiyacDuyulanOzelTakim.VisibleIndex = 1;
            this.colIhtiyacDuyulanOzelTakim.Width = 94;
            // 
            // colOzelTakimlarSiparisTarihi
            // 
            this.colOzelTakimlarSiparisTarihi.FieldName = "OzelTakimlarSiparisTarihi";
            this.colOzelTakimlarSiparisTarihi.MinWidth = 25;
            this.colOzelTakimlarSiparisTarihi.Name = "colOzelTakimlarSiparisTarihi";
            this.colOzelTakimlarSiparisTarihi.Visible = true;
            this.colOzelTakimlarSiparisTarihi.VisibleIndex = 2;
            this.colOzelTakimlarSiparisTarihi.Width = 94;
            // 
            // colOzelTakimlarTeslimTarihi
            // 
            this.colOzelTakimlarTeslimTarihi.FieldName = "OzelTakimlarTeslimTarihi";
            this.colOzelTakimlarTeslimTarihi.MinWidth = 25;
            this.colOzelTakimlarTeslimTarihi.Name = "colOzelTakimlarTeslimTarihi";
            this.colOzelTakimlarTeslimTarihi.Visible = true;
            this.colOzelTakimlarTeslimTarihi.VisibleIndex = 3;
            this.colOzelTakimlarTeslimTarihi.Width = 94;
            // 
            // colDenemeUretimTarihi
            // 
            this.colDenemeUretimTarihi.FieldName = "DenemeUretimTarihi";
            this.colDenemeUretimTarihi.MinWidth = 25;
            this.colDenemeUretimTarihi.Name = "colDenemeUretimTarihi";
            this.colDenemeUretimTarihi.Visible = true;
            this.colDenemeUretimTarihi.VisibleIndex = 4;
            this.colDenemeUretimTarihi.Width = 94;
            // 
            // colKaliteNumuneOnayTarihi1
            // 
            this.colKaliteNumuneOnayTarihi1.FieldName = "KaliteNumuneOnayTarihi";
            this.colKaliteNumuneOnayTarihi1.MinWidth = 25;
            this.colKaliteNumuneOnayTarihi1.Name = "colKaliteNumuneOnayTarihi1";
            this.colKaliteNumuneOnayTarihi1.Visible = true;
            this.colKaliteNumuneOnayTarihi1.VisibleIndex = 5;
            this.colKaliteNumuneOnayTarihi1.Width = 94;
            // 
            // colTamamlanmaDurumu4
            // 
            this.colTamamlanmaDurumu4.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu4.MinWidth = 25;
            this.colTamamlanmaDurumu4.Name = "colTamamlanmaDurumu4";
            this.colTamamlanmaDurumu4.Visible = true;
            this.colTamamlanmaDurumu4.VisibleIndex = 6;
            this.colTamamlanmaDurumu4.Width = 94;
            // 
            // sidePanel6
            // 
            this.sidePanel6.Controls.Add(this.rBtnUretimPlanlamaTamamlanmadi);
            this.sidePanel6.Controls.Add(this.rBtnUretimPlanlamaTamamlandi);
            this.sidePanel6.Controls.Add(this.dEditUretimPlanlamaKaliteNumuneOnayTarihi);
            this.sidePanel6.Controls.Add(this.dEditUretimPlanlamaDenemeUretimTarihi);
            this.sidePanel6.Controls.Add(this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi);
            this.sidePanel6.Controls.Add(this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi);
            this.sidePanel6.Controls.Add(this.labelControl67);
            this.sidePanel6.Controls.Add(this.btnUretimPlanlamaKaydet);
            this.sidePanel6.Controls.Add(this.txtUretimPlanlamaID);
            this.sidePanel6.Controls.Add(this.labelControl68);
            this.sidePanel6.Controls.Add(this.txtUretimPlanlamaProjeDetayID);
            this.sidePanel6.Controls.Add(this.labelControl69);
            this.sidePanel6.Controls.Add(this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim);
            this.sidePanel6.Controls.Add(this.labelControl70);
            this.sidePanel6.Controls.Add(this.labelControl71);
            this.sidePanel6.Controls.Add(this.txtUretimPlanlamaProjeID);
            this.sidePanel6.Controls.Add(this.labelControl72);
            this.sidePanel6.Controls.Add(this.labelControl73);
            this.sidePanel6.Controls.Add(this.labelControl74);
            this.sidePanel6.Controls.Add(this.labelControl75);
            this.sidePanel6.Controls.Add(this.labelControl76);
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel6.Location = new System.Drawing.Point(0, 0);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(1204, 151);
            this.sidePanel6.TabIndex = 98;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // rBtnUretimPlanlamaTamamlanmadi
            // 
            this.rBtnUretimPlanlamaTamamlanmadi.AutoSize = true;
            this.rBtnUretimPlanlamaTamamlanmadi.Checked = true;
            this.rBtnUretimPlanlamaTamamlanmadi.Location = new System.Drawing.Point(785, 101);
            this.rBtnUretimPlanlamaTamamlanmadi.Name = "rBtnUretimPlanlamaTamamlanmadi";
            this.rBtnUretimPlanlamaTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnUretimPlanlamaTamamlanmadi.TabIndex = 135;
            this.rBtnUretimPlanlamaTamamlanmadi.TabStop = true;
            this.rBtnUretimPlanlamaTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnUretimPlanlamaTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnUretimPlanlamaTamamlandi
            // 
            this.rBtnUretimPlanlamaTamamlandi.AutoSize = true;
            this.rBtnUretimPlanlamaTamamlandi.Location = new System.Drawing.Point(651, 102);
            this.rBtnUretimPlanlamaTamamlandi.Name = "rBtnUretimPlanlamaTamamlandi";
            this.rBtnUretimPlanlamaTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnUretimPlanlamaTamamlandi.TabIndex = 134;
            this.rBtnUretimPlanlamaTamamlandi.Text = "Tamamlandı";
            this.rBtnUretimPlanlamaTamamlandi.UseVisualStyleBackColor = true;
            // 
            // dEditUretimPlanlamaKaliteNumuneOnayTarihi
            // 
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.EditValue = null;
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Location = new System.Drawing.Point(651, 68);
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Name = "dEditUretimPlanlamaKaliteNumuneOnayTarihi";
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.TabIndex = 90;
            // 
            // dEditUretimPlanlamaDenemeUretimTarihi
            // 
            this.dEditUretimPlanlamaDenemeUretimTarihi.EditValue = null;
            this.dEditUretimPlanlamaDenemeUretimTarihi.Location = new System.Drawing.Point(651, 42);
            this.dEditUretimPlanlamaDenemeUretimTarihi.Name = "dEditUretimPlanlamaDenemeUretimTarihi";
            this.dEditUretimPlanlamaDenemeUretimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaDenemeUretimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaDenemeUretimTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditUretimPlanlamaDenemeUretimTarihi.TabIndex = 89;
            // 
            // dEditUretimPlanlamaOzelTakimlarTeslimTarihi
            // 
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.EditValue = null;
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Location = new System.Drawing.Point(651, 14);
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Name = "dEditUretimPlanlamaOzelTakimlarTeslimTarihi";
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Size = new System.Drawing.Size(255, 22);
            this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.TabIndex = 88;
            // 
            // dEditUretimPlanlamaOzelTakimlarSiparisTarihi
            // 
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.EditValue = null;
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Location = new System.Drawing.Point(198, 107);
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Name = "dEditUretimPlanlamaOzelTakimlarSiparisTarihi";
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Size = new System.Drawing.Size(236, 22);
            this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.TabIndex = 87;
            // 
            // labelControl67
            // 
            this.labelControl67.Location = new System.Drawing.Point(30, 14);
            this.labelControl67.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl67.Name = "labelControl67";
            this.labelControl67.Size = new System.Drawing.Size(19, 16);
            this.labelControl67.TabIndex = 86;
            this.labelControl67.Text = "6/8";
            // 
            // btnUretimPlanlamaKaydet
            // 
            this.btnUretimPlanlamaKaydet.Location = new System.Drawing.Point(937, 81);
            this.btnUretimPlanlamaKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUretimPlanlamaKaydet.Name = "btnUretimPlanlamaKaydet";
            this.btnUretimPlanlamaKaydet.Size = new System.Drawing.Size(255, 53);
            this.btnUretimPlanlamaKaydet.TabIndex = 85;
            this.btnUretimPlanlamaKaydet.Text = "Uretim Planlama Kaydet";
            this.btnUretimPlanlamaKaydet.Click += new System.EventHandler(this.btnUretimPlanlamaKaydet_Click);
            // 
            // txtUretimPlanlamaID
            // 
            this.txtUretimPlanlamaID.Location = new System.Drawing.Point(1091, 11);
            this.txtUretimPlanlamaID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUretimPlanlamaID.Name = "txtUretimPlanlamaID";
            this.txtUretimPlanlamaID.Size = new System.Drawing.Size(37, 22);
            this.txtUretimPlanlamaID.TabIndex = 73;
            this.txtUretimPlanlamaID.Visible = false;
            // 
            // labelControl68
            // 
            this.labelControl68.Location = new System.Drawing.Point(508, 103);
            this.labelControl68.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl68.Name = "labelControl68";
            this.labelControl68.Size = new System.Drawing.Size(124, 16);
            this.labelControl68.TabIndex = 76;
            this.labelControl68.Text = "TamamlanmaDurumu";
            // 
            // txtUretimPlanlamaProjeDetayID
            // 
            this.txtUretimPlanlamaProjeDetayID.Location = new System.Drawing.Point(198, 46);
            this.txtUretimPlanlamaProjeDetayID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUretimPlanlamaProjeDetayID.Name = "txtUretimPlanlamaProjeDetayID";
            this.txtUretimPlanlamaProjeDetayID.Properties.ReadOnly = true;
            this.txtUretimPlanlamaProjeDetayID.Size = new System.Drawing.Size(236, 22);
            this.txtUretimPlanlamaProjeDetayID.TabIndex = 72;
            // 
            // labelControl69
            // 
            this.labelControl69.Location = new System.Drawing.Point(487, 71);
            this.labelControl69.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl69.Name = "labelControl69";
            this.labelControl69.Size = new System.Drawing.Size(140, 16);
            this.labelControl69.TabIndex = 77;
            this.labelControl69.Text = "KaliteNumuneOnayTarihi";
            // 
            // txtUretimPlanlamaIhtiyacDuyulanOzelTakim
            // 
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Location = new System.Drawing.Point(198, 78);
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Name = "txtUretimPlanlamaIhtiyacDuyulanOzelTakim";
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Size = new System.Drawing.Size(236, 22);
            this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.TabIndex = 74;
            // 
            // labelControl70
            // 
            this.labelControl70.Location = new System.Drawing.Point(511, 45);
            this.labelControl70.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl70.Name = "labelControl70";
            this.labelControl70.Size = new System.Drawing.Size(118, 16);
            this.labelControl70.TabIndex = 78;
            this.labelControl70.Text = "DenemeUretimTarihi";
            // 
            // labelControl71
            // 
            this.labelControl71.Location = new System.Drawing.Point(489, 17);
            this.labelControl71.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl71.Name = "labelControl71";
            this.labelControl71.Size = new System.Drawing.Size(146, 16);
            this.labelControl71.TabIndex = 79;
            this.labelControl71.Text = "OzelTakimlarTeslimTarihi";
            // 
            // txtUretimPlanlamaProjeID
            // 
            this.txtUretimPlanlamaProjeID.Location = new System.Drawing.Point(198, 14);
            this.txtUretimPlanlamaProjeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUretimPlanlamaProjeID.Name = "txtUretimPlanlamaProjeID";
            this.txtUretimPlanlamaProjeID.Properties.ReadOnly = true;
            this.txtUretimPlanlamaProjeID.Size = new System.Drawing.Size(236, 22);
            this.txtUretimPlanlamaProjeID.TabIndex = 75;
            // 
            // labelControl72
            // 
            this.labelControl72.Location = new System.Drawing.Point(32, 113);
            this.labelControl72.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl72.Name = "labelControl72";
            this.labelControl72.Size = new System.Drawing.Size(147, 16);
            this.labelControl72.TabIndex = 80;
            this.labelControl72.Text = "OzelTakimlarSiparisTarihi";
            // 
            // labelControl73
            // 
            this.labelControl73.Location = new System.Drawing.Point(1048, 14);
            this.labelControl73.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl73.Name = "labelControl73";
            this.labelControl73.Size = new System.Drawing.Size(12, 16);
            this.labelControl73.TabIndex = 81;
            this.labelControl73.Text = "ID";
            this.labelControl73.Visible = false;
            // 
            // labelControl74
            // 
            this.labelControl74.Location = new System.Drawing.Point(92, 49);
            this.labelControl74.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl74.Name = "labelControl74";
            this.labelControl74.Size = new System.Drawing.Size(74, 16);
            this.labelControl74.TabIndex = 84;
            this.labelControl74.Text = "ProjeDetayID";
            // 
            // labelControl75
            // 
            this.labelControl75.Location = new System.Drawing.Point(126, 17);
            this.labelControl75.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl75.Name = "labelControl75";
            this.labelControl75.Size = new System.Drawing.Size(42, 16);
            this.labelControl75.TabIndex = 83;
            this.labelControl75.Text = "ProjeID";
            // 
            // labelControl76
            // 
            this.labelControl76.Location = new System.Drawing.Point(28, 81);
            this.labelControl76.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl76.Name = "labelControl76";
            this.labelControl76.Size = new System.Drawing.Size(142, 16);
            this.labelControl76.TabIndex = 82;
            this.labelControl76.Text = "IhtiyacDuyulanOzelTakim";
            // 
            // Montaj
            // 
            this.Montaj.Caption = "Montaj";
            this.Montaj.Controls.Add(this.gridMontaj);
            this.Montaj.Controls.Add(this.sidePanel7);
            this.Montaj.Name = "Montaj";
            this.Montaj.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridMontaj
            // 
            this.gridMontaj.DataSource = this.montajBindingSource;
            this.gridMontaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMontaj.Location = new System.Drawing.Point(0, 166);
            this.gridMontaj.MainView = this.gViewMontaj;
            this.gridMontaj.Name = "gridMontaj";
            this.gridMontaj.Size = new System.Drawing.Size(1204, 699);
            this.gridMontaj.TabIndex = 99;
            this.gridMontaj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewMontaj});
            // 
            // montajBindingSource
            // 
            this.montajBindingSource.DataMember = "Montaj";
            this.montajBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewMontaj
            // 
            this.gViewMontaj.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID6,
            this.colProjeID6,
            this.colProjeDetayID6,
            this.colIlkNumune,
            this.colPilotMontaj,
            this.colTamamlanmaDurumu5});
            this.gViewMontaj.GridControl = this.gridMontaj;
            this.gViewMontaj.Name = "gViewMontaj";
            this.gViewMontaj.OptionsBehavior.Editable = false;
            this.gViewMontaj.OptionsBehavior.ReadOnly = true;
            this.gViewMontaj.DoubleClick += new System.EventHandler(this.gViewMontaj_DoubleClick);
            // 
            // colID6
            // 
            this.colID6.Caption = "Sıra Numarası";
            this.colID6.FieldName = "ID";
            this.colID6.MinWidth = 25;
            this.colID6.Name = "colID6";
            this.colID6.Visible = true;
            this.colID6.VisibleIndex = 0;
            this.colID6.Width = 94;
            // 
            // colProjeID6
            // 
            this.colProjeID6.FieldName = "ProjeID";
            this.colProjeID6.MinWidth = 25;
            this.colProjeID6.Name = "colProjeID6";
            this.colProjeID6.Width = 94;
            // 
            // colProjeDetayID6
            // 
            this.colProjeDetayID6.FieldName = "ProjeDetayID";
            this.colProjeDetayID6.MinWidth = 25;
            this.colProjeDetayID6.Name = "colProjeDetayID6";
            this.colProjeDetayID6.Width = 94;
            // 
            // colIlkNumune
            // 
            this.colIlkNumune.FieldName = "IlkNumune";
            this.colIlkNumune.MinWidth = 25;
            this.colIlkNumune.Name = "colIlkNumune";
            this.colIlkNumune.Visible = true;
            this.colIlkNumune.VisibleIndex = 1;
            this.colIlkNumune.Width = 94;
            // 
            // colPilotMontaj
            // 
            this.colPilotMontaj.FieldName = "PilotMontaj";
            this.colPilotMontaj.MinWidth = 25;
            this.colPilotMontaj.Name = "colPilotMontaj";
            this.colPilotMontaj.Visible = true;
            this.colPilotMontaj.VisibleIndex = 2;
            this.colPilotMontaj.Width = 94;
            // 
            // colTamamlanmaDurumu5
            // 
            this.colTamamlanmaDurumu5.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu5.MinWidth = 25;
            this.colTamamlanmaDurumu5.Name = "colTamamlanmaDurumu5";
            this.colTamamlanmaDurumu5.Visible = true;
            this.colTamamlanmaDurumu5.VisibleIndex = 3;
            this.colTamamlanmaDurumu5.Width = 94;
            // 
            // sidePanel7
            // 
            this.sidePanel7.Controls.Add(this.rBtnMontajTamamlanmadi);
            this.sidePanel7.Controls.Add(this.rBtnMontajTamamlandi);
            this.sidePanel7.Controls.Add(this.labelControl77);
            this.sidePanel7.Controls.Add(this.sBtnMontajKaydet);
            this.sidePanel7.Controls.Add(this.txtMontajID);
            this.sidePanel7.Controls.Add(this.labelControl78);
            this.sidePanel7.Controls.Add(this.txtMontajProjeDetayID);
            this.sidePanel7.Controls.Add(this.labelControl79);
            this.sidePanel7.Controls.Add(this.txtMontajIlkNumune);
            this.sidePanel7.Controls.Add(this.txtMontajPilotMontaj);
            this.sidePanel7.Controls.Add(this.labelControl80);
            this.sidePanel7.Controls.Add(this.txtMontajProjeID);
            this.sidePanel7.Controls.Add(this.labelControl81);
            this.sidePanel7.Controls.Add(this.labelControl82);
            this.sidePanel7.Controls.Add(this.labelControl83);
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel7.Location = new System.Drawing.Point(0, 0);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(1204, 166);
            this.sidePanel7.TabIndex = 98;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // rBtnMontajTamamlanmadi
            // 
            this.rBtnMontajTamamlanmadi.AutoSize = true;
            this.rBtnMontajTamamlanmadi.Checked = true;
            this.rBtnMontajTamamlanmadi.Location = new System.Drawing.Point(702, 27);
            this.rBtnMontajTamamlanmadi.Name = "rBtnMontajTamamlanmadi";
            this.rBtnMontajTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnMontajTamamlanmadi.TabIndex = 137;
            this.rBtnMontajTamamlanmadi.TabStop = true;
            this.rBtnMontajTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnMontajTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnMontajTamamlandi
            // 
            this.rBtnMontajTamamlandi.AutoSize = true;
            this.rBtnMontajTamamlandi.Location = new System.Drawing.Point(570, 28);
            this.rBtnMontajTamamlandi.Name = "rBtnMontajTamamlandi";
            this.rBtnMontajTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnMontajTamamlandi.TabIndex = 136;
            this.rBtnMontajTamamlandi.Text = "Tamamlandı";
            this.rBtnMontajTamamlandi.UseVisualStyleBackColor = true;
            // 
            // labelControl77
            // 
            this.labelControl77.Location = new System.Drawing.Point(15, 9);
            this.labelControl77.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl77.Name = "labelControl77";
            this.labelControl77.Size = new System.Drawing.Size(19, 16);
            this.labelControl77.TabIndex = 73;
            this.labelControl77.Text = "7/8";
            // 
            // sBtnMontajKaydet
            // 
            this.sBtnMontajKaydet.Location = new System.Drawing.Point(568, 72);
            this.sBtnMontajKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnMontajKaydet.Name = "sBtnMontajKaydet";
            this.sBtnMontajKaydet.Size = new System.Drawing.Size(255, 53);
            this.sBtnMontajKaydet.TabIndex = 72;
            this.sBtnMontajKaydet.Text = "Montaj Kaydet";
            this.sBtnMontajKaydet.Click += new System.EventHandler(this.sBtnMontajKaydet_Click);
            // 
            // txtMontajID
            // 
            this.txtMontajID.Location = new System.Drawing.Point(1093, 6);
            this.txtMontajID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontajID.Name = "txtMontajID";
            this.txtMontajID.Size = new System.Drawing.Size(34, 22);
            this.txtMontajID.TabIndex = 64;
            this.txtMontajID.Visible = false;
            // 
            // labelControl78
            // 
            this.labelControl78.Location = new System.Drawing.Point(438, 29);
            this.labelControl78.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl78.Name = "labelControl78";
            this.labelControl78.Size = new System.Drawing.Size(124, 16);
            this.labelControl78.TabIndex = 67;
            this.labelControl78.Text = "TamamlanmaDurumu";
            // 
            // txtMontajProjeDetayID
            // 
            this.txtMontajProjeDetayID.Location = new System.Drawing.Point(122, 56);
            this.txtMontajProjeDetayID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontajProjeDetayID.Name = "txtMontajProjeDetayID";
            this.txtMontajProjeDetayID.Properties.ReadOnly = true;
            this.txtMontajProjeDetayID.Size = new System.Drawing.Size(236, 22);
            this.txtMontajProjeDetayID.TabIndex = 63;
            // 
            // labelControl79
            // 
            this.labelControl79.Location = new System.Drawing.Point(53, 121);
            this.labelControl79.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl79.Name = "labelControl79";
            this.labelControl79.Size = new System.Drawing.Size(63, 16);
            this.labelControl79.TabIndex = 68;
            this.labelControl79.Text = "PilotMontaj";
            // 
            // txtMontajIlkNumune
            // 
            this.txtMontajIlkNumune.Location = new System.Drawing.Point(122, 88);
            this.txtMontajIlkNumune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontajIlkNumune.Name = "txtMontajIlkNumune";
            this.txtMontajIlkNumune.Size = new System.Drawing.Size(236, 22);
            this.txtMontajIlkNumune.TabIndex = 62;
            // 
            // txtMontajPilotMontaj
            // 
            this.txtMontajPilotMontaj.Location = new System.Drawing.Point(122, 118);
            this.txtMontajPilotMontaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontajPilotMontaj.Name = "txtMontajPilotMontaj";
            this.txtMontajPilotMontaj.Size = new System.Drawing.Size(236, 22);
            this.txtMontajPilotMontaj.TabIndex = 61;
            // 
            // labelControl80
            // 
            this.labelControl80.Location = new System.Drawing.Point(42, 59);
            this.labelControl80.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl80.Name = "labelControl80";
            this.labelControl80.Size = new System.Drawing.Size(74, 16);
            this.labelControl80.TabIndex = 69;
            this.labelControl80.Text = "ProjeDetayID";
            // 
            // txtMontajProjeID
            // 
            this.txtMontajProjeID.Location = new System.Drawing.Point(122, 24);
            this.txtMontajProjeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontajProjeID.Name = "txtMontajProjeID";
            this.txtMontajProjeID.Properties.ReadOnly = true;
            this.txtMontajProjeID.Size = new System.Drawing.Size(236, 22);
            this.txtMontajProjeID.TabIndex = 65;
            // 
            // labelControl81
            // 
            this.labelControl81.Location = new System.Drawing.Point(56, 91);
            this.labelControl81.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl81.Name = "labelControl81";
            this.labelControl81.Size = new System.Drawing.Size(60, 16);
            this.labelControl81.TabIndex = 70;
            this.labelControl81.Text = "IlkNumune";
            // 
            // labelControl82
            // 
            this.labelControl82.Location = new System.Drawing.Point(1060, 9);
            this.labelControl82.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl82.Name = "labelControl82";
            this.labelControl82.Size = new System.Drawing.Size(12, 16);
            this.labelControl82.TabIndex = 66;
            this.labelControl82.Text = "ID";
            this.labelControl82.Visible = false;
            // 
            // labelControl83
            // 
            this.labelControl83.Location = new System.Drawing.Point(74, 27);
            this.labelControl83.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl83.Name = "labelControl83";
            this.labelControl83.Size = new System.Drawing.Size(42, 16);
            this.labelControl83.TabIndex = 71;
            this.labelControl83.Text = "ProjeID";
            // 
            // SevkiyatPaketleme
            // 
            this.SevkiyatPaketleme.Caption = "Sevkiyat Paketleme";
            this.SevkiyatPaketleme.Controls.Add(this.gridSevkiyatPaketleme);
            this.SevkiyatPaketleme.Controls.Add(this.sidePanel8);
            this.SevkiyatPaketleme.Name = "SevkiyatPaketleme";
            this.SevkiyatPaketleme.Size = new System.Drawing.Size(1204, 865);
            // 
            // gridSevkiyatPaketleme
            // 
            this.gridSevkiyatPaketleme.DataSource = this.sevkiyatPaketlemeBindingSource;
            this.gridSevkiyatPaketleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSevkiyatPaketleme.Location = new System.Drawing.Point(0, 118);
            this.gridSevkiyatPaketleme.MainView = this.gViewSevkiyatPaketleme;
            this.gridSevkiyatPaketleme.Name = "gridSevkiyatPaketleme";
            this.gridSevkiyatPaketleme.Size = new System.Drawing.Size(1204, 747);
            this.gridSevkiyatPaketleme.TabIndex = 60;
            this.gridSevkiyatPaketleme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewSevkiyatPaketleme});
            // 
            // sevkiyatPaketlemeBindingSource
            // 
            this.sevkiyatPaketlemeBindingSource.DataMember = "SevkiyatPaketleme";
            this.sevkiyatPaketlemeBindingSource.DataSource = this.yumakDataSet;
            // 
            // gViewSevkiyatPaketleme
            // 
            this.gViewSevkiyatPaketleme.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID7,
            this.colProjeID7,
            this.colProjeDetayID7,
            this.colYeniAmbalajIhtiyaci,
            this.colTamamlanmaDurumu6});
            this.gViewSevkiyatPaketleme.GridControl = this.gridSevkiyatPaketleme;
            this.gViewSevkiyatPaketleme.Name = "gViewSevkiyatPaketleme";
            this.gViewSevkiyatPaketleme.OptionsBehavior.Editable = false;
            this.gViewSevkiyatPaketleme.OptionsBehavior.ReadOnly = true;
            this.gViewSevkiyatPaketleme.DoubleClick += new System.EventHandler(this.gViewSevkiyatPaketleme_DoubleClick);
            // 
            // colID7
            // 
            this.colID7.Caption = "Sıra Numarası";
            this.colID7.FieldName = "ID";
            this.colID7.MinWidth = 25;
            this.colID7.Name = "colID7";
            this.colID7.Visible = true;
            this.colID7.VisibleIndex = 0;
            this.colID7.Width = 94;
            // 
            // colProjeID7
            // 
            this.colProjeID7.FieldName = "ProjeID";
            this.colProjeID7.MinWidth = 25;
            this.colProjeID7.Name = "colProjeID7";
            this.colProjeID7.Width = 94;
            // 
            // colProjeDetayID7
            // 
            this.colProjeDetayID7.FieldName = "ProjeDetayID";
            this.colProjeDetayID7.MinWidth = 25;
            this.colProjeDetayID7.Name = "colProjeDetayID7";
            this.colProjeDetayID7.Width = 94;
            // 
            // colYeniAmbalajIhtiyaci
            // 
            this.colYeniAmbalajIhtiyaci.FieldName = "YeniAmbalajIhtiyaci";
            this.colYeniAmbalajIhtiyaci.MinWidth = 25;
            this.colYeniAmbalajIhtiyaci.Name = "colYeniAmbalajIhtiyaci";
            this.colYeniAmbalajIhtiyaci.Visible = true;
            this.colYeniAmbalajIhtiyaci.VisibleIndex = 1;
            this.colYeniAmbalajIhtiyaci.Width = 94;
            // 
            // colTamamlanmaDurumu6
            // 
            this.colTamamlanmaDurumu6.FieldName = "TamamlanmaDurumu";
            this.colTamamlanmaDurumu6.MinWidth = 25;
            this.colTamamlanmaDurumu6.Name = "colTamamlanmaDurumu6";
            this.colTamamlanmaDurumu6.Visible = true;
            this.colTamamlanmaDurumu6.VisibleIndex = 2;
            this.colTamamlanmaDurumu6.Width = 94;
            // 
            // sidePanel8
            // 
            this.sidePanel8.Controls.Add(this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci);
            this.sidePanel8.Controls.Add(this.rBtnSevkiyatPaketlemeTamamlanmadi);
            this.sidePanel8.Controls.Add(this.rBtnSevkiyatPaketlemeTamamlandi);
            this.sidePanel8.Controls.Add(this.labelControl86);
            this.sidePanel8.Controls.Add(this.btnSevkiyatPaketleme);
            this.sidePanel8.Controls.Add(this.labelControl87);
            this.sidePanel8.Controls.Add(this.txtSevkiyatPaketlemeID);
            this.sidePanel8.Controls.Add(this.txtSevkiyatPaketlemeProjeDetayID);
            this.sidePanel8.Controls.Add(this.labelControl89);
            this.sidePanel8.Controls.Add(this.txtSevkiyatPaketlemeProjeID);
            this.sidePanel8.Controls.Add(this.labelControl90);
            this.sidePanel8.Controls.Add(this.labelControl91);
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel8.Location = new System.Drawing.Point(0, 0);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(1204, 118);
            this.sidePanel8.TabIndex = 59;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // checkSevkiyatPaketlemeYeniAmbalajIhtiyaci
            // 
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Location = new System.Drawing.Point(372, 30);
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Name = "checkSevkiyatPaketlemeYeniAmbalajIhtiyaci";
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Properties.Caption = "Yeni Ambalaj Ihtiyacı";
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Size = new System.Drawing.Size(151, 24);
            this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.TabIndex = 140;
            // 
            // rBtnSevkiyatPaketlemeTamamlanmadi
            // 
            this.rBtnSevkiyatPaketlemeTamamlanmadi.AutoSize = true;
            this.rBtnSevkiyatPaketlemeTamamlanmadi.Checked = true;
            this.rBtnSevkiyatPaketlemeTamamlanmadi.Location = new System.Drawing.Point(634, 64);
            this.rBtnSevkiyatPaketlemeTamamlanmadi.Name = "rBtnSevkiyatPaketlemeTamamlanmadi";
            this.rBtnSevkiyatPaketlemeTamamlanmadi.Size = new System.Drawing.Size(121, 21);
            this.rBtnSevkiyatPaketlemeTamamlanmadi.TabIndex = 139;
            this.rBtnSevkiyatPaketlemeTamamlanmadi.TabStop = true;
            this.rBtnSevkiyatPaketlemeTamamlanmadi.Text = "Tamamlanmadı";
            this.rBtnSevkiyatPaketlemeTamamlanmadi.UseVisualStyleBackColor = true;
            // 
            // rBtnSevkiyatPaketlemeTamamlandi
            // 
            this.rBtnSevkiyatPaketlemeTamamlandi.AutoSize = true;
            this.rBtnSevkiyatPaketlemeTamamlandi.Location = new System.Drawing.Point(502, 65);
            this.rBtnSevkiyatPaketlemeTamamlandi.Name = "rBtnSevkiyatPaketlemeTamamlandi";
            this.rBtnSevkiyatPaketlemeTamamlandi.Size = new System.Drawing.Size(102, 21);
            this.rBtnSevkiyatPaketlemeTamamlandi.TabIndex = 138;
            this.rBtnSevkiyatPaketlemeTamamlandi.Text = "Tamamlandı";
            this.rBtnSevkiyatPaketlemeTamamlandi.UseVisualStyleBackColor = true;
            // 
            // labelControl86
            // 
            this.labelControl86.Location = new System.Drawing.Point(12, 13);
            this.labelControl86.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl86.Name = "labelControl86";
            this.labelControl86.Size = new System.Drawing.Size(19, 16);
            this.labelControl86.TabIndex = 56;
            this.labelControl86.Text = "8/8";
            // 
            // btnSevkiyatPaketleme
            // 
            this.btnSevkiyatPaketleme.Location = new System.Drawing.Point(810, 37);
            this.btnSevkiyatPaketleme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSevkiyatPaketleme.Name = "btnSevkiyatPaketleme";
            this.btnSevkiyatPaketleme.Size = new System.Drawing.Size(253, 53);
            this.btnSevkiyatPaketleme.TabIndex = 55;
            this.btnSevkiyatPaketleme.Text = "Sevkiyat Paketleme Kaydet";
            this.btnSevkiyatPaketleme.Click += new System.EventHandler(this.btnSevkiyatPaketleme_Click);
            // 
            // labelControl87
            // 
            this.labelControl87.Location = new System.Drawing.Point(372, 66);
            this.labelControl87.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl87.Name = "labelControl87";
            this.labelControl87.Size = new System.Drawing.Size(124, 16);
            this.labelControl87.TabIndex = 52;
            this.labelControl87.Text = "TamamlanmaDurumu";
            // 
            // txtSevkiyatPaketlemeID
            // 
            this.txtSevkiyatPaketlemeID.Location = new System.Drawing.Point(1103, 7);
            this.txtSevkiyatPaketlemeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSevkiyatPaketlemeID.Name = "txtSevkiyatPaketlemeID";
            this.txtSevkiyatPaketlemeID.Size = new System.Drawing.Size(24, 22);
            this.txtSevkiyatPaketlemeID.TabIndex = 45;
            this.txtSevkiyatPaketlemeID.Visible = false;
            // 
            // txtSevkiyatPaketlemeProjeDetayID
            // 
            this.txtSevkiyatPaketlemeProjeDetayID.Location = new System.Drawing.Point(105, 63);
            this.txtSevkiyatPaketlemeProjeDetayID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSevkiyatPaketlemeProjeDetayID.Name = "txtSevkiyatPaketlemeProjeDetayID";
            this.txtSevkiyatPaketlemeProjeDetayID.Properties.ReadOnly = true;
            this.txtSevkiyatPaketlemeProjeDetayID.Size = new System.Drawing.Size(236, 22);
            this.txtSevkiyatPaketlemeProjeDetayID.TabIndex = 48;
            // 
            // labelControl89
            // 
            this.labelControl89.Location = new System.Drawing.Point(20, 69);
            this.labelControl89.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl89.Name = "labelControl89";
            this.labelControl89.Size = new System.Drawing.Size(74, 16);
            this.labelControl89.TabIndex = 53;
            this.labelControl89.Text = "ProjeDetayID";
            // 
            // txtSevkiyatPaketlemeProjeID
            // 
            this.txtSevkiyatPaketlemeProjeID.Location = new System.Drawing.Point(105, 31);
            this.txtSevkiyatPaketlemeProjeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSevkiyatPaketlemeProjeID.Name = "txtSevkiyatPaketlemeProjeID";
            this.txtSevkiyatPaketlemeProjeID.Properties.ReadOnly = true;
            this.txtSevkiyatPaketlemeProjeID.Size = new System.Drawing.Size(236, 22);
            this.txtSevkiyatPaketlemeProjeID.TabIndex = 49;
            // 
            // labelControl90
            // 
            this.labelControl90.Location = new System.Drawing.Point(1080, 13);
            this.labelControl90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl90.Name = "labelControl90";
            this.labelControl90.Size = new System.Drawing.Size(12, 16);
            this.labelControl90.TabIndex = 50;
            this.labelControl90.Text = "ID";
            this.labelControl90.Visible = false;
            // 
            // labelControl91
            // 
            this.labelControl91.Location = new System.Drawing.Point(52, 37);
            this.labelControl91.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl91.Name = "labelControl91";
            this.labelControl91.Size = new System.Drawing.Size(42, 16);
            this.labelControl91.TabIndex = 51;
            this.labelControl91.Text = "ProjeID";
            // 
            // parcaGenelBilgilerTableAdapter
            // 
            this.parcaGenelBilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // argeTasarimRTableAdapter
            // 
            this.argeTasarimRTableAdapter.ClearBeforeFill = true;
            // 
            // disHizmetTableAdapter
            // 
            this.disHizmetTableAdapter.ClearBeforeFill = true;
            // 
            // kaliphaneAparatTableAdapter
            // 
            this.kaliphaneAparatTableAdapter.ClearBeforeFill = true;
            // 
            // kaliteKontrolTableAdapter
            // 
            this.kaliteKontrolTableAdapter.ClearBeforeFill = true;
            // 
            // uretimPlanlamaTableAdapter
            // 
            this.uretimPlanlamaTableAdapter.ClearBeforeFill = true;
            // 
            // montajTableAdapter
            // 
            this.montajTableAdapter.ClearBeforeFill = true;
            // 
            // sevkiyatPaketlemeTableAdapter
            // 
            this.sevkiyatPaketlemeTableAdapter.ClearBeforeFill = true;
            // 
            // tabPane2
            // 
            this.tabPane2.Controls.Add(this.tabNavigationPage1);
            this.tabPane2.Controls.Add(this.tabNavigationPage3);
            this.tabPane2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane2.Location = new System.Drawing.Point(0, 0);
            this.tabPane2.Name = "tabPane2";
            this.tabPane2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage3});
            this.tabPane2.RegularSize = new System.Drawing.Size(1204, 937);
            this.tabPane2.SelectedPage = this.tabNavigationPage1;
            this.tabPane2.Size = new System.Drawing.Size(1204, 937);
            this.tabPane2.TabIndex = 6;
            this.tabPane2.Text = "tabPane2";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Yeni Proje Ekle";
            this.tabNavigationPage1.Controls.Add(this.gridProjeOlusturDetay);
            this.tabNavigationPage1.Controls.Add(this.groupControl1);
            this.tabNavigationPage1.Controls.Add(this.gridProjeOlustur);
            this.tabNavigationPage1.Controls.Add(this.groupControl2);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1204, 901);
            // 
            // gridProjeOlusturDetay
            // 
            this.gridProjeOlusturDetay.DataSource = this.projeDetayBindingSource;
            this.gridProjeOlusturDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProjeOlusturDetay.Location = new System.Drawing.Point(0, 594);
            this.gridProjeOlusturDetay.MainView = this.gViewProjeDetay;
            this.gridProjeOlusturDetay.Name = "gridProjeOlusturDetay";
            this.gridProjeOlusturDetay.Size = new System.Drawing.Size(1204, 307);
            this.gridProjeOlusturDetay.TabIndex = 6;
            this.gridProjeOlusturDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gViewProjeDetay});
            // 
            // gViewProjeDetay
            // 
            this.gViewProjeDetay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colSiraNo,
            this.colDurum1,
            this.colYumakNo,
            this.colAciklama1,
            this.colYeniUrunTalep,
            this.colFizibilite,
            this.colProsesTasarim,
            this.colIleriKalitePlanlamasiAPQP,
            this.colProjeBaslangicTarihi1,
            this.colPlanlananProjeTarihi1,
            this.colGerceklesenProjeBitisTarihi,
            this.colKullaniciID1,
            this.colProjeUstID,
            this.colStokID1,
            this.colParcaGenelBilgisi,
            this.colArgeTasarimBilgisi,
            this.colDisHizmetBilgisi,
            this.colKaliphaneBilgisi,
            this.colKaliteKontrolBilgisi,
            this.colUretimPlanlamaBilgisi,
            this.colMontajBilgisi,
            this.colSevkiyatBilgisi});
            this.gViewProjeDetay.GridControl = this.gridProjeOlusturDetay;
            this.gViewProjeDetay.Name = "gViewProjeDetay";
            this.gViewProjeDetay.NewItemRowText = "Yeni Kayıt Ekle";
            this.gViewProjeDetay.OptionsBehavior.Editable = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.MinWidth = 25;
            this.colID1.Name = "colID1";
            this.colID1.Width = 94;
            // 
            // colSiraNo
            // 
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.MinWidth = 25;
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 0;
            this.colSiraNo.Width = 94;
            // 
            // colDurum1
            // 
            this.colDurum1.FieldName = "Durum";
            this.colDurum1.MinWidth = 25;
            this.colDurum1.Name = "colDurum1";
            this.colDurum1.Visible = true;
            this.colDurum1.VisibleIndex = 1;
            this.colDurum1.Width = 94;
            // 
            // colYumakNo
            // 
            this.colYumakNo.FieldName = "YumakNo";
            this.colYumakNo.MinWidth = 25;
            this.colYumakNo.Name = "colYumakNo";
            this.colYumakNo.Visible = true;
            this.colYumakNo.VisibleIndex = 2;
            this.colYumakNo.Width = 94;
            // 
            // colAciklama1
            // 
            this.colAciklama1.FieldName = "Aciklama";
            this.colAciklama1.MinWidth = 25;
            this.colAciklama1.Name = "colAciklama1";
            this.colAciklama1.Visible = true;
            this.colAciklama1.VisibleIndex = 3;
            this.colAciklama1.Width = 94;
            // 
            // colYeniUrunTalep
            // 
            this.colYeniUrunTalep.FieldName = "YeniUrunTalep";
            this.colYeniUrunTalep.MinWidth = 25;
            this.colYeniUrunTalep.Name = "colYeniUrunTalep";
            this.colYeniUrunTalep.Visible = true;
            this.colYeniUrunTalep.VisibleIndex = 4;
            this.colYeniUrunTalep.Width = 94;
            // 
            // colFizibilite
            // 
            this.colFizibilite.FieldName = "Fizibilite";
            this.colFizibilite.MinWidth = 25;
            this.colFizibilite.Name = "colFizibilite";
            this.colFizibilite.Visible = true;
            this.colFizibilite.VisibleIndex = 5;
            this.colFizibilite.Width = 94;
            // 
            // colProsesTasarim
            // 
            this.colProsesTasarim.FieldName = "ProsesTasarim";
            this.colProsesTasarim.MinWidth = 25;
            this.colProsesTasarim.Name = "colProsesTasarim";
            this.colProsesTasarim.Visible = true;
            this.colProsesTasarim.VisibleIndex = 6;
            this.colProsesTasarim.Width = 94;
            // 
            // colIleriKalitePlanlamasiAPQP
            // 
            this.colIleriKalitePlanlamasiAPQP.FieldName = "IleriKalitePlanlamasiAPQP";
            this.colIleriKalitePlanlamasiAPQP.MinWidth = 25;
            this.colIleriKalitePlanlamasiAPQP.Name = "colIleriKalitePlanlamasiAPQP";
            this.colIleriKalitePlanlamasiAPQP.Visible = true;
            this.colIleriKalitePlanlamasiAPQP.VisibleIndex = 7;
            this.colIleriKalitePlanlamasiAPQP.Width = 94;
            // 
            // colProjeBaslangicTarihi1
            // 
            this.colProjeBaslangicTarihi1.FieldName = "ProjeBaslangicTarihi";
            this.colProjeBaslangicTarihi1.MinWidth = 25;
            this.colProjeBaslangicTarihi1.Name = "colProjeBaslangicTarihi1";
            this.colProjeBaslangicTarihi1.Width = 94;
            // 
            // colPlanlananProjeTarihi1
            // 
            this.colPlanlananProjeTarihi1.FieldName = "PlanlananProjeTarihi";
            this.colPlanlananProjeTarihi1.MinWidth = 25;
            this.colPlanlananProjeTarihi1.Name = "colPlanlananProjeTarihi1";
            this.colPlanlananProjeTarihi1.Width = 94;
            // 
            // colGerceklesenProjeBitisTarihi
            // 
            this.colGerceklesenProjeBitisTarihi.FieldName = "GerceklesenProjeBitisTarihi";
            this.colGerceklesenProjeBitisTarihi.MinWidth = 25;
            this.colGerceklesenProjeBitisTarihi.Name = "colGerceklesenProjeBitisTarihi";
            this.colGerceklesenProjeBitisTarihi.Width = 94;
            // 
            // colKullaniciID1
            // 
            this.colKullaniciID1.FieldName = "KullaniciID";
            this.colKullaniciID1.MinWidth = 25;
            this.colKullaniciID1.Name = "colKullaniciID1";
            this.colKullaniciID1.Width = 94;
            // 
            // colProjeUstID
            // 
            this.colProjeUstID.FieldName = "ProjeUstID";
            this.colProjeUstID.MinWidth = 25;
            this.colProjeUstID.Name = "colProjeUstID";
            this.colProjeUstID.Width = 94;
            // 
            // colStokID1
            // 
            this.colStokID1.FieldName = "StokID";
            this.colStokID1.MinWidth = 25;
            this.colStokID1.Name = "colStokID1";
            this.colStokID1.Visible = true;
            this.colStokID1.VisibleIndex = 8;
            this.colStokID1.Width = 94;
            // 
            // colParcaGenelBilgisi
            // 
            this.colParcaGenelBilgisi.FieldName = "ParcaGenelBilgisi";
            this.colParcaGenelBilgisi.MinWidth = 25;
            this.colParcaGenelBilgisi.Name = "colParcaGenelBilgisi";
            this.colParcaGenelBilgisi.Visible = true;
            this.colParcaGenelBilgisi.VisibleIndex = 9;
            this.colParcaGenelBilgisi.Width = 94;
            // 
            // colArgeTasarimBilgisi
            // 
            this.colArgeTasarimBilgisi.FieldName = "ArgeTasarimBilgisi";
            this.colArgeTasarimBilgisi.MinWidth = 25;
            this.colArgeTasarimBilgisi.Name = "colArgeTasarimBilgisi";
            this.colArgeTasarimBilgisi.Visible = true;
            this.colArgeTasarimBilgisi.VisibleIndex = 10;
            this.colArgeTasarimBilgisi.Width = 94;
            // 
            // colDisHizmetBilgisi
            // 
            this.colDisHizmetBilgisi.FieldName = "DisHizmetBilgisi";
            this.colDisHizmetBilgisi.MinWidth = 25;
            this.colDisHizmetBilgisi.Name = "colDisHizmetBilgisi";
            this.colDisHizmetBilgisi.Visible = true;
            this.colDisHizmetBilgisi.VisibleIndex = 11;
            this.colDisHizmetBilgisi.Width = 94;
            // 
            // colKaliphaneBilgisi
            // 
            this.colKaliphaneBilgisi.FieldName = "KaliphaneBilgisi";
            this.colKaliphaneBilgisi.MinWidth = 25;
            this.colKaliphaneBilgisi.Name = "colKaliphaneBilgisi";
            this.colKaliphaneBilgisi.Visible = true;
            this.colKaliphaneBilgisi.VisibleIndex = 12;
            this.colKaliphaneBilgisi.Width = 94;
            // 
            // colKaliteKontrolBilgisi
            // 
            this.colKaliteKontrolBilgisi.FieldName = "KaliteKontrolBilgisi";
            this.colKaliteKontrolBilgisi.MinWidth = 25;
            this.colKaliteKontrolBilgisi.Name = "colKaliteKontrolBilgisi";
            this.colKaliteKontrolBilgisi.Visible = true;
            this.colKaliteKontrolBilgisi.VisibleIndex = 13;
            this.colKaliteKontrolBilgisi.Width = 94;
            // 
            // colUretimPlanlamaBilgisi
            // 
            this.colUretimPlanlamaBilgisi.FieldName = "UretimPlanlamaBilgisi";
            this.colUretimPlanlamaBilgisi.MinWidth = 25;
            this.colUretimPlanlamaBilgisi.Name = "colUretimPlanlamaBilgisi";
            this.colUretimPlanlamaBilgisi.Visible = true;
            this.colUretimPlanlamaBilgisi.VisibleIndex = 14;
            this.colUretimPlanlamaBilgisi.Width = 94;
            // 
            // colMontajBilgisi
            // 
            this.colMontajBilgisi.FieldName = "MontajBilgisi";
            this.colMontajBilgisi.MinWidth = 25;
            this.colMontajBilgisi.Name = "colMontajBilgisi";
            this.colMontajBilgisi.Visible = true;
            this.colMontajBilgisi.VisibleIndex = 15;
            this.colMontajBilgisi.Width = 94;
            // 
            // colSevkiyatBilgisi
            // 
            this.colSevkiyatBilgisi.FieldName = "SevkiyatBilgisi";
            this.colSevkiyatBilgisi.MinWidth = 25;
            this.colSevkiyatBilgisi.Name = "colSevkiyatBilgisi";
            this.colSevkiyatBilgisi.Visible = true;
            this.colSevkiyatBilgisi.VisibleIndex = 16;
            this.colSevkiyatBilgisi.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl85);
            this.groupControl1.Controls.Add(this.sBtnKullaniciYMSec);
            this.groupControl1.Controls.Add(this.labelControl84);
            this.groupControl1.Controls.Add(this.txtKullaniciYMID);
            this.groupControl1.Controls.Add(this.sBtnStokYMSec);
            this.groupControl1.Controls.Add(this.txtStokYMID);
            this.groupControl1.Controls.Add(this.sBtnKalemOlustur);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.checkSevkiyatPaketleme);
            this.groupControl1.Controls.Add(this.txtProjeOlusturProsesTasarim);
            this.groupControl1.Controls.Add(this.checkMontaj);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.checkUretimPlanlama);
            this.groupControl1.Controls.Add(this.txtProjeOlusturIleriKP);
            this.groupControl1.Controls.Add(this.checkKaliteKontrol);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.checkKaliphane);
            this.groupControl1.Controls.Add(this.txtProjeOlusturFizibilite);
            this.groupControl1.Controls.Add(this.checkDisHizmet);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.checkArgeTasarim);
            this.groupControl1.Controls.Add(this.txtProjeOlusturYeniUrun);
            this.groupControl1.Controls.Add(this.checkParcaGenel);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtProjeOlusturAciklamaDetay);
            this.groupControl1.Controls.Add(this.txtProjeOlusturYumakNo);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtProjeOlusturSiraNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 390);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1204, 204);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Seçili Proje için Yarı Mamül Ekle";
            // 
            // labelControl85
            // 
            this.labelControl85.Location = new System.Drawing.Point(14, 43);
            this.labelControl85.Name = "labelControl85";
            this.labelControl85.Size = new System.Drawing.Size(62, 16);
            this.labelControl85.TabIndex = 20;
            this.labelControl85.Text = "Kullanıcı ID";
            // 
            // sBtnKullaniciYMSec
            // 
            this.sBtnKullaniciYMSec.Location = new System.Drawing.Point(14, 77);
            this.sBtnKullaniciYMSec.Name = "sBtnKullaniciYMSec";
            this.sBtnKullaniciYMSec.Size = new System.Drawing.Size(133, 47);
            this.sBtnKullaniciYMSec.TabIndex = 19;
            this.sBtnKullaniciYMSec.Text = "Kullanici Seç";
            this.sBtnKullaniciYMSec.Click += new System.EventHandler(this.sBtnKullaniciYMSec_Click);
            // 
            // labelControl84
            // 
            this.labelControl84.Location = new System.Drawing.Point(175, 43);
            this.labelControl84.Name = "labelControl84";
            this.labelControl84.Size = new System.Drawing.Size(41, 16);
            this.labelControl84.TabIndex = 19;
            this.labelControl84.Text = "Stok ID";
            // 
            // txtKullaniciYMID
            // 
            this.txtKullaniciYMID.Location = new System.Drawing.Point(95, 40);
            this.txtKullaniciYMID.Name = "txtKullaniciYMID";
            this.txtKullaniciYMID.Properties.ReadOnly = true;
            this.txtKullaniciYMID.Size = new System.Drawing.Size(51, 22);
            this.txtKullaniciYMID.TabIndex = 18;
            // 
            // sBtnStokYMSec
            // 
            this.sBtnStokYMSec.Location = new System.Drawing.Point(163, 77);
            this.sBtnStokYMSec.Name = "sBtnStokYMSec";
            this.sBtnStokYMSec.Size = new System.Drawing.Size(133, 47);
            this.sBtnStokYMSec.TabIndex = 18;
            this.sBtnStokYMSec.Text = "Stok Seç";
            this.sBtnStokYMSec.Click += new System.EventHandler(this.sBtnStokYMSec_Click);
            // 
            // txtStokYMID
            // 
            this.txtStokYMID.Location = new System.Drawing.Point(222, 40);
            this.txtStokYMID.Name = "txtStokYMID";
            this.txtStokYMID.Properties.ReadOnly = true;
            this.txtStokYMID.Size = new System.Drawing.Size(51, 22);
            this.txtStokYMID.TabIndex = 18;
            // 
            // sBtnKalemOlustur
            // 
            this.sBtnKalemOlustur.Location = new System.Drawing.Point(879, 142);
            this.sBtnKalemOlustur.Name = "sBtnKalemOlustur";
            this.sBtnKalemOlustur.Size = new System.Drawing.Size(313, 49);
            this.sBtnKalemOlustur.TabIndex = 2;
            this.sBtnKalemOlustur.Text = "Kalem Oluştur";
            this.sBtnKalemOlustur.Click += new System.EventHandler(this.sBtnKalemOlustur_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(592, 62);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(89, 16);
            this.labelControl13.TabIndex = 25;
            this.labelControl13.Text = "Proses Tasarım";
            // 
            // checkSevkiyatPaketleme
            // 
            this.checkSevkiyatPaketleme.Location = new System.Drawing.Point(733, 155);
            this.checkSevkiyatPaketleme.Name = "checkSevkiyatPaketleme";
            this.checkSevkiyatPaketleme.Properties.Caption = "SevkiyatPaketleme";
            this.checkSevkiyatPaketleme.Size = new System.Drawing.Size(138, 24);
            this.checkSevkiyatPaketleme.TabIndex = 7;
            // 
            // txtProjeOlusturProsesTasarim
            // 
            this.txtProjeOlusturProsesTasarim.Location = new System.Drawing.Point(695, 59);
            this.txtProjeOlusturProsesTasarim.Name = "txtProjeOlusturProsesTasarim";
            this.txtProjeOlusturProsesTasarim.Size = new System.Drawing.Size(106, 22);
            this.txtProjeOlusturProsesTasarim.TabIndex = 24;
            // 
            // checkMontaj
            // 
            this.checkMontaj.Location = new System.Drawing.Point(648, 155);
            this.checkMontaj.Name = "checkMontaj";
            this.checkMontaj.Properties.Caption = "Montaj";
            this.checkMontaj.Size = new System.Drawing.Size(79, 24);
            this.checkMontaj.TabIndex = 6;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(559, 93);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(122, 16);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "İleri Kalite Planlaması";
            // 
            // checkUretimPlanlama
            // 
            this.checkUretimPlanlama.Location = new System.Drawing.Point(515, 155);
            this.checkUretimPlanlama.Name = "checkUretimPlanlama";
            this.checkUretimPlanlama.Properties.Caption = "UretimPlanlama";
            this.checkUretimPlanlama.Size = new System.Drawing.Size(127, 24);
            this.checkUretimPlanlama.TabIndex = 5;
            // 
            // txtProjeOlusturIleriKP
            // 
            this.txtProjeOlusturIleriKP.Location = new System.Drawing.Point(695, 87);
            this.txtProjeOlusturIleriKP.Name = "txtProjeOlusturIleriKP";
            this.txtProjeOlusturIleriKP.Size = new System.Drawing.Size(106, 22);
            this.txtProjeOlusturIleriKP.TabIndex = 22;
            // 
            // checkKaliteKontrol
            // 
            this.checkKaliteKontrol.Location = new System.Drawing.Point(406, 155);
            this.checkKaliteKontrol.Name = "checkKaliteKontrol";
            this.checkKaliteKontrol.Properties.Caption = "KaliteKontrol";
            this.checkKaliteKontrol.Size = new System.Drawing.Size(103, 24);
            this.checkKaliteKontrol.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(635, 34);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 16);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Fizibilite";
            // 
            // checkKaliphane
            // 
            this.checkKaliphane.Location = new System.Drawing.Point(315, 155);
            this.checkKaliphane.Name = "checkKaliphane";
            this.checkKaliphane.Properties.Caption = "Kaliphane";
            this.checkKaliphane.Size = new System.Drawing.Size(85, 24);
            this.checkKaliphane.TabIndex = 3;
            // 
            // txtProjeOlusturFizibilite
            // 
            this.txtProjeOlusturFizibilite.Location = new System.Drawing.Point(695, 31);
            this.txtProjeOlusturFizibilite.Name = "txtProjeOlusturFizibilite";
            this.txtProjeOlusturFizibilite.Size = new System.Drawing.Size(106, 22);
            this.txtProjeOlusturFizibilite.TabIndex = 20;
            // 
            // checkDisHizmet
            // 
            this.checkDisHizmet.Location = new System.Drawing.Point(222, 155);
            this.checkDisHizmet.Name = "checkDisHizmet";
            this.checkDisHizmet.Properties.Caption = "DisHizmet";
            this.checkDisHizmet.Size = new System.Drawing.Size(87, 24);
            this.checkDisHizmet.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(317, 90);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 16);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Yeni Ürün Talep";
            // 
            // checkArgeTasarim
            // 
            this.checkArgeTasarim.Location = new System.Drawing.Point(115, 155);
            this.checkArgeTasarim.Name = "checkArgeTasarim";
            this.checkArgeTasarim.Properties.Caption = "ArgeTasarim";
            this.checkArgeTasarim.Size = new System.Drawing.Size(107, 24);
            this.checkArgeTasarim.TabIndex = 1;
            // 
            // txtProjeOlusturYeniUrun
            // 
            this.txtProjeOlusturYeniUrun.Location = new System.Drawing.Point(422, 87);
            this.txtProjeOlusturYeniUrun.Name = "txtProjeOlusturYeniUrun";
            this.txtProjeOlusturYeniUrun.Size = new System.Drawing.Size(110, 22);
            this.txtProjeOlusturYeniUrun.TabIndex = 18;
            // 
            // checkParcaGenel
            // 
            this.checkParcaGenel.Location = new System.Drawing.Point(15, 155);
            this.checkParcaGenel.Name = "checkParcaGenel";
            this.checkParcaGenel.Properties.Caption = "ParcaGenel";
            this.checkParcaGenel.Size = new System.Drawing.Size(94, 24);
            this.checkParcaGenel.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(822, 33);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 16);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Açıklama";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(351, 62);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Yumak No";
            // 
            // txtProjeOlusturAciklamaDetay
            // 
            this.txtProjeOlusturAciklamaDetay.Location = new System.Drawing.Point(879, 30);
            this.txtProjeOlusturAciklamaDetay.Name = "txtProjeOlusturAciklamaDetay";
            this.txtProjeOlusturAciklamaDetay.Properties.AutoHeight = false;
            this.txtProjeOlusturAciklamaDetay.Size = new System.Drawing.Size(313, 90);
            this.txtProjeOlusturAciklamaDetay.TabIndex = 15;
            // 
            // txtProjeOlusturYumakNo
            // 
            this.txtProjeOlusturYumakNo.Location = new System.Drawing.Point(422, 59);
            this.txtProjeOlusturYumakNo.Name = "txtProjeOlusturYumakNo";
            this.txtProjeOlusturYumakNo.Size = new System.Drawing.Size(110, 22);
            this.txtProjeOlusturYumakNo.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(366, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Sıra No";
            // 
            // txtProjeOlusturSiraNo
            // 
            this.txtProjeOlusturSiraNo.Location = new System.Drawing.Point(422, 31);
            this.txtProjeOlusturSiraNo.Name = "txtProjeOlusturSiraNo";
            this.txtProjeOlusturSiraNo.Size = new System.Drawing.Size(110, 22);
            this.txtProjeOlusturSiraNo.TabIndex = 0;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = " Süreç Güncelle";
            this.tabNavigationPage3.Controls.Add(this.tabPane1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1204, 901);
            // 
            // FrmProjeOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 937);
            this.Controls.Add(this.tabPane2);
            this.Name = "FrmProjeOlustur";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmProjeOlustur_Activated);
            this.Load += new System.EventHandler(this.FrmProjeOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjeOlustur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKullaniciProjeUstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yumakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProjeOlustur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeUstBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturOemNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturBildirim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturBildirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturPlanlanan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProjeOlusturPlanlanan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturKullaniciID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturStokID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ParcaGenel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridParcaGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcaGenelBilgilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewParcaGenel)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelMalzeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelHamMalzeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelSertlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelIsilIslem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPArcaGenelKaplama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaGenelTedarikciBilg.Properties)).EndInit();
            this.ArgeTasarim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArgeTasarim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.argeTasarimRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewArgeTasarim)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimRecete.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimRecete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimOperasyonelRecete.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimOperasyonelRecete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimResimOnay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimResimOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGTeknikMCizimi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGTeknikMCizimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPTeknikMCizimi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPTeknikMCizimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGKatiMCizimi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimGKatiMCizimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPKatiMCizimi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditArgeTasarimPKatiMCizimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArgeTasarimAkisSemasi.Properties)).EndInit();
            this.DisHizmet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisHizmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disHizmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewDisHizmet)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetNumuneOnayTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetNumuneOnayTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaNumuneGelisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaTerminTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetSatinAlmaTerminTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetResimIletimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditDisHizmetResimIletimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisHizmetProjeDetayID.Properties)).EndInit();
            this.Kaliphane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKalipHaneAparat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliphaneAparatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKalipHaneAparat)).EndInit();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneIhtıyacKalipAdedi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatGerceklesenTeslimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatTerminTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneAparatTerminTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKaliteNumuneOnayTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipGerceklesenNumuneTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipTerminTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKalipHaneKalipTerminTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalipHaneIhtiyacDuyulanAparatAdedi.Properties)).EndInit();
            this.KaliteKontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKaliteKontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliteKontrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewKaliteKontrol)).EndInit();
            this.sidePanel5.ResumeLayout(false);
            this.sidePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaliteKontrolProjeDetayID.Properties)).EndInit();
            this.UretimPlanlama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUretimPlanlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uretimPlanlamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewUretimPlanlama)).EndInit();
            this.sidePanel6.ResumeLayout(false);
            this.sidePanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaKaliteNumuneOnayTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaDenemeUretimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaDenemeUretimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarTeslimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEditUretimPlanlamaOzelTakimlarSiparisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaIhtiyacDuyulanOzelTakim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUretimPlanlamaProjeID.Properties)).EndInit();
            this.Montaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMontaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMontaj)).EndInit();
            this.sidePanel7.ResumeLayout(false);
            this.sidePanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajIlkNumune.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajPilotMontaj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontajProjeID.Properties)).EndInit();
            this.SevkiyatPaketleme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSevkiyatPaketleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkiyatPaketlemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewSevkiyatPaketleme)).EndInit();
            this.sidePanel8.ResumeLayout(false);
            this.sidePanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSevkiyatPaketlemeYeniAmbalajIhtiyaci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeProjeDetayID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSevkiyatPaketlemeProjeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane2)).EndInit();
            this.tabPane2.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjeOlusturDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gViewProjeDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciYMID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokYMID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSevkiyatPaketleme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturProsesTasarim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMontaj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUretimPlanlama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturIleriKP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliteKontrol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKaliphane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturFizibilite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisHizmet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkArgeTasarim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturYeniUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkParcaGenel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturAciklamaDetay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturYumakNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeOlusturSiraNo.Properties)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProjeOlustur;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewProjeOlustur;
        private YumakDataSet yumakDataSet;
        private System.Windows.Forms.BindingSource projeUstBilgileriBindingSource;
        private YumakDataSetTableAdapters.ProjeUstBilgileriTableAdapter projeUstBilgileriTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource vKullaniciProjeUstBindingSource;
        private YumakDataSetTableAdapters.vKullaniciProjeUstTableAdapter vKullaniciProjeUstTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenProjeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOEMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colkID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanıcıAD;
        private System.Windows.Forms.BindingSource projeDetayBindingSource;
        private YumakDataSetTableAdapters.ProjeDetayTableAdapter projeDetayTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton sBtnProjeOlusturStokSec;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturOemNo;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturAciklama;
        private DevExpress.XtraEditors.DateEdit dateProjeOlusturBildirim;
        private DevExpress.XtraEditors.DateEdit dateProjeOlusturPlanlanan;
        private DevExpress.XtraEditors.SimpleButton sBtnProjeOlustur;
        private DevExpress.XtraEditors.SimpleButton sBtnProjeOlusturKullaniciSec;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturKullaniciID;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturStokID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage ParcaGenel;
        private DevExpress.XtraGrid.GridControl gridParcaGenel;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewParcaGenel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID;
        private DevExpress.XtraGrid.Columns.GridColumn colMalzeme;
        private DevExpress.XtraGrid.Columns.GridColumn colHamMalzemeUretimYontemi;
        private DevExpress.XtraGrid.Columns.GridColumn colSertlik;
        private DevExpress.XtraGrid.Columns.GridColumn colIsilIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKaplama;
        private DevExpress.XtraGrid.Columns.GridColumn colTedarikciBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage ArgeTasarim;
        private DevExpress.XtraGrid.GridControl gridArgeTasarim;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewArgeTasarim;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananKatiModelCizimi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenKatiModelCizimi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananTeknikResimCizimi;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenTeknikResimCizimi;
        private DevExpress.XtraGrid.Columns.GridColumn colResimOnayTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colRecete;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonelRecete;
        private DevExpress.XtraGrid.Columns.GridColumn colAkisSemasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu;
        private DevExpress.XtraBars.Navigation.TabNavigationPage DisHizmet;
        private DevExpress.XtraGrid.GridControl gridDisHizmet;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewDisHizmet;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID2;
        private DevExpress.XtraGrid.Columns.GridColumn colResimIletimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSatinAlmaTerminTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSatinAlmaNumuneGelisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colNumuneOnayTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Kaliphane;
        private DevExpress.XtraGrid.GridControl gridKalipHaneAparat;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewKalipHaneAparat;
        private DevExpress.XtraGrid.Columns.GridColumn colID3;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID3;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID3;
        private DevExpress.XtraGrid.Columns.GridColumn colIhtiyacDuyulanKalipAdedi;
        private DevExpress.XtraGrid.Columns.GridColumn colKalipTerminTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKalipGerceklesenNumuneTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKaliteNumuneOnayTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIhtiyacDuyulanAparatAdedi;
        private DevExpress.XtraGrid.Columns.GridColumn colAparatTerminTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAparatGerceklesenTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage KaliteKontrol;
        private DevExpress.XtraGrid.GridControl gridKaliteKontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewKaliteKontrol;
        private DevExpress.XtraGrid.Columns.GridColumn colID4;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID4;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID4;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelOlcmeEkipmaniIhtiyaci;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelOlcmeEkipmanlariSiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelOlcmeTakimlarTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu3;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.CheckEdit checkKaliteKontrolOzelOlcmeEkipmanIhtiyacı;
        private System.Windows.Forms.RadioButton rBtnKaliteKontrolTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnKaliteKontrolTamamlandi;
        private DevExpress.XtraEditors.DateEdit dEditKaliteKontrolOzelOlcmeTakimlarTeslimTarihi;
        private DevExpress.XtraEditors.DateEdit dEditKaliteKontrolOzelOlcmeEkipmanlariSiparisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl60;
        private DevExpress.XtraEditors.SimpleButton sBtnKaliteKontrolKaydet;
        private DevExpress.XtraEditors.TextEdit txtKaliteKontrolID;
        private DevExpress.XtraEditors.LabelControl labelControl61;
        private DevExpress.XtraEditors.LabelControl labelControl62;
        private DevExpress.XtraEditors.LabelControl labelControl63;
        private DevExpress.XtraEditors.TextEdit txtKaliteKontrolProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl64;
        private DevExpress.XtraEditors.TextEdit txtKaliteKontrolProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl65;
        private DevExpress.XtraEditors.LabelControl labelControl66;
        private DevExpress.XtraBars.Navigation.TabNavigationPage UretimPlanlama;
        private DevExpress.XtraGrid.GridControl gridUretimPlanlama;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewUretimPlanlama;
        private DevExpress.XtraGrid.Columns.GridColumn colID5;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID5;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID5;
        private DevExpress.XtraGrid.Columns.GridColumn colIhtiyacDuyulanOzelTakim;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelTakimlarSiparisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelTakimlarTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDenemeUretimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKaliteNumuneOnayTarihi1;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu4;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private System.Windows.Forms.RadioButton rBtnUretimPlanlamaTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnUretimPlanlamaTamamlandi;
        private DevExpress.XtraEditors.DateEdit dEditUretimPlanlamaKaliteNumuneOnayTarihi;
        private DevExpress.XtraEditors.DateEdit dEditUretimPlanlamaDenemeUretimTarihi;
        private DevExpress.XtraEditors.DateEdit dEditUretimPlanlamaOzelTakimlarTeslimTarihi;
        private DevExpress.XtraEditors.DateEdit dEditUretimPlanlamaOzelTakimlarSiparisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl67;
        private DevExpress.XtraEditors.SimpleButton btnUretimPlanlamaKaydet;
        private DevExpress.XtraEditors.TextEdit txtUretimPlanlamaID;
        private DevExpress.XtraEditors.LabelControl labelControl68;
        private DevExpress.XtraEditors.TextEdit txtUretimPlanlamaProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl69;
        private DevExpress.XtraEditors.TextEdit txtUretimPlanlamaIhtiyacDuyulanOzelTakim;
        private DevExpress.XtraEditors.LabelControl labelControl70;
        private DevExpress.XtraEditors.LabelControl labelControl71;
        private DevExpress.XtraEditors.TextEdit txtUretimPlanlamaProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl72;
        private DevExpress.XtraEditors.LabelControl labelControl73;
        private DevExpress.XtraEditors.LabelControl labelControl74;
        private DevExpress.XtraEditors.LabelControl labelControl75;
        private DevExpress.XtraEditors.LabelControl labelControl76;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Montaj;
        private DevExpress.XtraGrid.GridControl gridMontaj;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewMontaj;
        private DevExpress.XtraGrid.Columns.GridColumn colID6;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID6;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID6;
        private DevExpress.XtraGrid.Columns.GridColumn colIlkNumune;
        private DevExpress.XtraGrid.Columns.GridColumn colPilotMontaj;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu5;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private System.Windows.Forms.RadioButton rBtnMontajTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnMontajTamamlandi;
        private DevExpress.XtraEditors.LabelControl labelControl77;
        private DevExpress.XtraEditors.SimpleButton sBtnMontajKaydet;
        private DevExpress.XtraEditors.TextEdit txtMontajID;
        private DevExpress.XtraEditors.LabelControl labelControl78;
        private DevExpress.XtraEditors.TextEdit txtMontajProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl79;
        private DevExpress.XtraEditors.TextEdit txtMontajIlkNumune;
        private DevExpress.XtraEditors.TextEdit txtMontajPilotMontaj;
        private DevExpress.XtraEditors.LabelControl labelControl80;
        private DevExpress.XtraEditors.TextEdit txtMontajProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl81;
        private DevExpress.XtraEditors.LabelControl labelControl82;
        private DevExpress.XtraEditors.LabelControl labelControl83;
        private DevExpress.XtraBars.Navigation.TabNavigationPage SevkiyatPaketleme;
        private DevExpress.XtraGrid.GridControl gridSevkiyatPaketleme;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewSevkiyatPaketleme;
        private DevExpress.XtraGrid.Columns.GridColumn colID7;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeID7;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeDetayID7;
        private DevExpress.XtraGrid.Columns.GridColumn colYeniAmbalajIhtiyaci;
        private DevExpress.XtraGrid.Columns.GridColumn colTamamlanmaDurumu6;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.CheckEdit checkSevkiyatPaketlemeYeniAmbalajIhtiyaci;
        private System.Windows.Forms.RadioButton rBtnSevkiyatPaketlemeTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnSevkiyatPaketlemeTamamlandi;
        private DevExpress.XtraEditors.LabelControl labelControl86;
        private DevExpress.XtraEditors.SimpleButton btnSevkiyatPaketleme;
        private DevExpress.XtraEditors.LabelControl labelControl87;
        private DevExpress.XtraEditors.TextEdit txtSevkiyatPaketlemeID;
        private DevExpress.XtraEditors.TextEdit txtSevkiyatPaketlemeProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl89;
        private DevExpress.XtraEditors.TextEdit txtSevkiyatPaketlemeProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl90;
        private DevExpress.XtraEditors.LabelControl labelControl91;
        private System.Windows.Forms.BindingSource parcaGenelBilgilerBindingSource;
        private YumakDataSetTableAdapters.ParcaGenelBilgilerTableAdapter parcaGenelBilgilerTableAdapter;
        private System.Windows.Forms.BindingSource argeTasarimRBindingSource;
        private YumakDataSetTableAdapters.ArgeTasarimRTableAdapter argeTasarimRTableAdapter;
        private System.Windows.Forms.BindingSource disHizmetBindingSource;
        private YumakDataSetTableAdapters.DisHizmetTableAdapter disHizmetTableAdapter;
        private System.Windows.Forms.BindingSource kaliphaneAparatBindingSource;
        private YumakDataSetTableAdapters.KaliphaneAparatTableAdapter kaliphaneAparatTableAdapter;
        private System.Windows.Forms.BindingSource kaliteKontrolBindingSource;
        private YumakDataSetTableAdapters.KaliteKontrolTableAdapter kaliteKontrolTableAdapter;
        private System.Windows.Forms.BindingSource uretimPlanlamaBindingSource;
        private YumakDataSetTableAdapters.UretimPlanlamaTableAdapter uretimPlanlamaTableAdapter;
        private System.Windows.Forms.BindingSource montajBindingSource;
        private YumakDataSetTableAdapters.MontajTableAdapter montajTableAdapter;
        private System.Windows.Forms.BindingSource sevkiyatPaketlemeBindingSource;
        private YumakDataSetTableAdapters.SevkiyatPaketlemeTableAdapter sevkiyatPaketlemeTableAdapter;
        private DevExpress.XtraBars.Navigation.TabPane tabPane2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraGrid.GridControl gridProjeOlusturDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gViewProjeDetay;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum1;
        private DevExpress.XtraGrid.Columns.GridColumn colYumakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama1;
        private DevExpress.XtraGrid.Columns.GridColumn colYeniUrunTalep;
        private DevExpress.XtraGrid.Columns.GridColumn colFizibilite;
        private DevExpress.XtraGrid.Columns.GridColumn colProsesTasarim;
        private DevExpress.XtraGrid.Columns.GridColumn colIleriKalitePlanlamasiAPQP;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeBaslangicTarihi1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananProjeTarihi1;
        private DevExpress.XtraGrid.Columns.GridColumn colGerceklesenProjeBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeUstID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID1;
        private DevExpress.XtraGrid.Columns.GridColumn colParcaGenelBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colArgeTasarimBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colDisHizmetBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colKaliphaneBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colKaliteKontrolBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colUretimPlanlamaBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colMontajBilgisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkiyatBilgisi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl85;
        private DevExpress.XtraEditors.SimpleButton sBtnKullaniciYMSec;
        private DevExpress.XtraEditors.LabelControl labelControl84;
        private DevExpress.XtraEditors.TextEdit txtKullaniciYMID;
        private DevExpress.XtraEditors.SimpleButton sBtnStokYMSec;
        private DevExpress.XtraEditors.TextEdit txtStokYMID;
        private DevExpress.XtraEditors.SimpleButton sBtnKalemOlustur;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.CheckEdit checkSevkiyatPaketleme;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturProsesTasarim;
        private DevExpress.XtraEditors.CheckEdit checkMontaj;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.CheckEdit checkUretimPlanlama;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturIleriKP;
        private DevExpress.XtraEditors.CheckEdit checkKaliteKontrol;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit checkKaliphane;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturFizibilite;
        private DevExpress.XtraEditors.CheckEdit checkDisHizmet;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit checkArgeTasarim;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturYeniUrun;
        private DevExpress.XtraEditors.CheckEdit checkParcaGenel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturAciklamaDetay;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturYumakNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtProjeOlusturSiraNo;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.RadioButton rBtnParcaGenelTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnParcaGenelTamamlandi;
        private DevExpress.XtraEditors.LabelControl labelControl56;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelID;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelProjeID;
        private DevExpress.XtraEditors.SimpleButton sBtnParcaGenelKaydet;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelMalzeme;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelHamMalzeme;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelSertlik;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelIsilIslem;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtPArcaGenelKaplama;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtParcaGenelTedarikciBilg;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.RadioButton rBtnArgeTasarimTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnArgeTasarimTamamlandi;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimRecete;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimOperasyonelRecete;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimResimOnay;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimGTeknikMCizimi;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimPTeknikMCizimi;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimGKatiMCizimi;
        private DevExpress.XtraEditors.DateEdit dEditArgeTasarimPKatiMCizimi;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.SimpleButton sBtnArgeTasarimKaydet;
        private DevExpress.XtraEditors.TextEdit txtArgeTasarimID;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtArgeTasarimProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtArgeTasarimProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtArgeTasarimAkisSemasi;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private System.Windows.Forms.RadioButton rBtnDisHizmetTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnDisHizmetTamamlandi;
        private DevExpress.XtraEditors.DateEdit dEditDisHizmetNumuneOnayTarihi;
        private DevExpress.XtraEditors.DateEdit dEditDisHizmetSatinAlmaNumuneGelisTarihi;
        private DevExpress.XtraEditors.DateEdit dEditDisHizmetSatinAlmaTerminTarihi;
        private DevExpress.XtraEditors.DateEdit dEditDisHizmetResimIletimTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.SimpleButton sBtnDisHizmetKaydet;
        private DevExpress.XtraEditors.TextEdit txtDisHizmetID;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.TextEdit txtDisHizmetProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.TextEdit txtDisHizmetProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.LabelControl labelControl46;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.TextEdit txtKalipHaneIhtıyacKalipAdedi;
        private System.Windows.Forms.RadioButton rBtnKalipHaneTamamlanmadi;
        private System.Windows.Forms.RadioButton rBtnKalipHaneTamamlandi;
        private DevExpress.XtraEditors.DateEdit dEditKalipHaneAparatGerceklesenTeslimTarihi;
        private DevExpress.XtraEditors.DateEdit dEditKalipHaneAparatTerminTarihi;
        private DevExpress.XtraEditors.DateEdit dEditKalipHaneKaliteNumuneOnayTarihi;
        private DevExpress.XtraEditors.DateEdit dEditKalipHaneKalipGerceklesenNumuneTarihi;
        private DevExpress.XtraEditors.DateEdit dEditKalipHaneKalipTerminTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl47;
        private DevExpress.XtraEditors.LabelControl labelControl48;
        private DevExpress.XtraEditors.TextEdit txtKalipHaneID;
        private DevExpress.XtraEditors.TextEdit txtKalipHaneProjeID;
        private DevExpress.XtraEditors.LabelControl labelControl49;
        private DevExpress.XtraEditors.TextEdit txtKalipHaneProjeDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl50;
        private DevExpress.XtraEditors.SimpleButton sBtnKalipHaneAparatKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl51;
        private DevExpress.XtraEditors.LabelControl labelControl52;
        private DevExpress.XtraEditors.LabelControl labelControl53;
        private DevExpress.XtraEditors.LabelControl labelControl54;
        private DevExpress.XtraEditors.LabelControl labelControl55;
        private DevExpress.XtraEditors.TextEdit txtKalipHaneIhtiyacDuyulanAparatAdedi;
        private DevExpress.XtraEditors.LabelControl labelControl57;
        private DevExpress.XtraEditors.LabelControl labelControl58;
        private DevExpress.XtraEditors.LabelControl labelControl59;
    }
}