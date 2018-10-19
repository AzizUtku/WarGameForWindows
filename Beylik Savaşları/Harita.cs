using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beylik_Savaşları
{
    public partial class frmHarita : Form
    {
        public Form1 frmoyuncu1;
        //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        public Bilgi abilerbilgi;
        public FormCanik frmcanik;
        public FormMentese frmmentese;
        public FormHamit frmhamit;
        public FormKaraman frmkaraman;
        public FormEsrefcs frmesref;
        public FormTrabzon frmtrabzon;
        public FormAydin frmaydin;
        public FormEretna frmeretna;
        public FormSaruhan frmsaruhan;
        public FormGermiyan frmgermiyan;
        public FormRamazan frmramazan;
        public FormDulkadir frmdulkadir;
        public FormKolemen frmkolemen;
        public FormKaresi frmkaresi;
        public FormOsmanli frmosmanli;
        public FormBizans frmbizans;
     
        public frmHarita()
        {
            InitializeComponent();
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            abilerbilgi = new Bilgi();
            abilerbilgi.harita = this;
            frmcanik = new FormCanik();
            frmcanik.harita = this;
            frmmentese = new FormMentese();
            frmmentese.harita = this;
            frmhamit = new FormHamit();
            frmhamit.harita = this;
            frmkaraman = new FormKaraman();
            frmkaraman.harita = this;
            frmesref = new FormEsrefcs();
            frmesref.harita = this;
            frmtrabzon = new FormTrabzon();
            frmtrabzon.harita = this;
            frmaydin = new FormAydin();
            frmaydin.harita = this;
            frmeretna = new FormEretna();
            frmeretna.harita = this;
            frmsaruhan = new FormSaruhan();
            frmsaruhan.harita = this;
            frmgermiyan = new FormGermiyan();
            frmgermiyan.harita = this;
            frmramazan = new FormRamazan();
            frmramazan.harita = this;
            frmdulkadir = new FormDulkadir();
            frmdulkadir.harita = this;
            frmkolemen = new FormKolemen();
            frmkolemen.harita = this;
            frmkaresi = new FormKaresi();
            frmkaresi.harita = this;
            frmosmanli = new FormOsmanli();
            frmosmanli.harita = this;
            frmbizans = new FormBizans();
            frmbizans.harita = this;

        }
        int a = 0;


        #region AskerSayısı
        //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        public double AskerSayisi(AskerTipleri secileno1)
        {
            switch (secileno1)
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                case AskerTipleri.Piyade: return double.Parse(frmoyuncu1.lbl1piyade.Text);
                case AskerTipleri.Suvari: return double.Parse(frmoyuncu1.lbl1suvari.Text);
                case AskerTipleri.Okcu: return double.Parse(frmoyuncu1.lbl1okcu.Text);
                case AskerTipleri.Sipahi: return double.Parse(frmoyuncu1.lbl1sipahi.Text);
                case AskerTipleri.Yeniceri: return double.Parse(frmoyuncu1.lbl1yeniceri.Text);
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisi2(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return double.Parse(frmoyuncu1.lbl2piyade.Text);
                case AskerTipleri.Suvari: return double.Parse(frmoyuncu1.lbl2suvari.Text);
                case AskerTipleri.Okcu: return double.Parse(frmoyuncu1.lbl2okcu.Text);
                case AskerTipleri.Sipahi: return double.Parse(frmoyuncu1.lbl2sipahi.Text);
                case AskerTipleri.Yeniceri: return double.Parse(frmoyuncu1.lbl2yeniceri.Text);
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisiahiler(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 500;
                case AskerTipleri.Okcu: return 300;
                case AskerTipleri.Sipahi: return 200;
                case AskerTipleri.Suvari: return 150;
                case AskerTipleri.Yeniceri: return 100;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisimentese(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 300;
                case AskerTipleri.Okcu: return 200;
                case AskerTipleri.Sipahi: return 300;
                case AskerTipleri.Suvari: return 200;
                case AskerTipleri.Yeniceri: return 100;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisicanik(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 300;
                case AskerTipleri.Okcu: return 300;
                case AskerTipleri.Sipahi: return 350;
                case AskerTipleri.Suvari: return 250;
                case AskerTipleri.Yeniceri: return 200;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisihamit(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 400;
                case AskerTipleri.Okcu: return 350;
                case AskerTipleri.Sipahi: return 400;
                case AskerTipleri.Suvari: return 250;
                case AskerTipleri.Yeniceri: return 150;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisikaraman(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 600;
                case AskerTipleri.Okcu: return 700;
                case AskerTipleri.Sipahi: return 500;
                case AskerTipleri.Suvari: return 350;
                case AskerTipleri.Yeniceri: return 350;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisiesref(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 600;
                case AskerTipleri.Okcu: return 700;
                case AskerTipleri.Sipahi: return 600;
                case AskerTipleri.Suvari: return 700;
                case AskerTipleri.Yeniceri: return 500;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisitrabzon(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 600;
                case AskerTipleri.Okcu: return 500;
                case AskerTipleri.Sipahi: return 600;
                case AskerTipleri.Suvari: return 600;
                case AskerTipleri.Yeniceri: return 700;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisiaydin(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 600;
                case AskerTipleri.Okcu: return 850;
                case AskerTipleri.Sipahi: return 800;
                case AskerTipleri.Suvari: return 1000;
                case AskerTipleri.Yeniceri: return 1000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisieretna(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 1000;
                case AskerTipleri.Okcu: return 1500;
                case AskerTipleri.Sipahi: return 800;
                case AskerTipleri.Suvari: return 900;
                case AskerTipleri.Yeniceri: return 800;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisisaruhan(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 1500;
                case AskerTipleri.Okcu: return 1500;
                case AskerTipleri.Sipahi: return 1500;
                case AskerTipleri.Suvari: return 1500;
                case AskerTipleri.Yeniceri: return 1000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisigermiyan(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 1500;
                case AskerTipleri.Okcu: return 1500;
                case AskerTipleri.Sipahi: return 1500;
                case AskerTipleri.Suvari: return 1500;
                case AskerTipleri.Yeniceri: return 1500;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisiramazan(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 1500;
                case AskerTipleri.Okcu: return 1500;
                case AskerTipleri.Sipahi: return 1500;
                case AskerTipleri.Suvari: return 1000;
                case AskerTipleri.Yeniceri: return 1000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisidulkadir(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 1500;
                case AskerTipleri.Okcu: return 1500;
                case AskerTipleri.Sipahi: return 1500;
                case AskerTipleri.Suvari: return 2000;
                case AskerTipleri.Yeniceri: return 1500;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisikolemen(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 5000;
                case AskerTipleri.Okcu: return 5000;
                case AskerTipleri.Sipahi: return 2500;
                case AskerTipleri.Suvari: return 2200;
                case AskerTipleri.Yeniceri: return 2000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisikaresi(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 6000;
                case AskerTipleri.Okcu: return 5500;
                case AskerTipleri.Sipahi: return 5000;
                case AskerTipleri.Suvari: return 5000;
                case AskerTipleri.Yeniceri: return 5000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisiosmanli(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 30000;
                case AskerTipleri.Okcu: return 30000;
                case AskerTipleri.Sipahi: return 30000;
                case AskerTipleri.Suvari: return 30000;
                case AskerTipleri.Yeniceri: return 25000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        public double AskerSayisibizans(AskerTipleri secileno2)
        {
            switch (secileno2)
            {
                case AskerTipleri.Piyade: return 10000;
                case AskerTipleri.Okcu: return 10000;
                case AskerTipleri.Sipahi: return 10000;
                case AskerTipleri.Suvari: return 10000;
                case AskerTipleri.Yeniceri: return 10000;
            }
            return 0; // yanlış asker tipi gelirse bir şekilde, 0 dönsün..
        }
        #endregion
        //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        SavasDuzeni oyuncu1 = new SavasDuzeni();
        SavasDuzeni oyuncu2 = new SavasDuzeni();
        SavasDuzeni ahiler = new SavasDuzeni();
        SavasDuzeni mentese = new SavasDuzeni();
        SavasDuzeni canik = new SavasDuzeni();
        SavasDuzeni hamit = new SavasDuzeni();
        SavasDuzeni esref = new SavasDuzeni();
        SavasDuzeni karaman = new SavasDuzeni();
        SavasDuzeni trabzon = new SavasDuzeni();
        SavasDuzeni aydin = new SavasDuzeni();
        SavasDuzeni eretna = new SavasDuzeni();
        SavasDuzeni saruhan = new SavasDuzeni();
        SavasDuzeni germiyan = new SavasDuzeni();
        SavasDuzeni ramazan = new SavasDuzeni();
        SavasDuzeni dulkadir = new SavasDuzeni();
        SavasDuzeni kolemen = new SavasDuzeni();
        SavasDuzeni karesi = new SavasDuzeni();
        SavasDuzeni osmanli = new SavasDuzeni();
        SavasDuzeni bizans = new SavasDuzeni();

        public void Main(string[] args)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            #region Güçler
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            gucMatrisi.Add(AskerTipleri.Piyade, new Dictionary<AskerTipleri, double>());
            gucMatrisi.Add(AskerTipleri.Okcu, new Dictionary<AskerTipleri, double>());
            gucMatrisi.Add(AskerTipleri.Sipahi, new Dictionary<AskerTipleri, double>());
            gucMatrisi.Add(AskerTipleri.Suvari, new Dictionary<AskerTipleri, double>());
            gucMatrisi.Add(AskerTipleri.Yeniceri, new Dictionary<AskerTipleri, double>());


            gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Piyade, 1);    //piyadenin piyadeye gücü aynıdır.. 1..
            gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Okcu, 20 / 25);      // buradaki 1 i senin değiştirmen lazım.
            gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Sipahi, 20/80);    // double tanımladık ki, piyade örneğin okcudan güçsüzse burada 0.5 diye tanımlayabilirsin.. 
            gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Suvari, 40/70);
            gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Yeniceri, 20/100);

            gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Piyade, 25 / 20);
            gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Okcu, 1);
            gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Sipahi, 25/40);
            gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Suvari, 25/140);
            gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Yeniceri, 50/100);

            gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Piyade, 80 / 20);
            gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Okcu, 40/25);
            gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Sipahi, 1);
            gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Suvari, 40/70);
            gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Yeniceri, 40/200);

            gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Piyade,70/40);
            gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Okcu,140/25);
            gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Sipahi, 70/40);
            gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Suvari, 1);
            gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Yeniceri, 70/100);

            gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Piyade, 100/20);
            gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Okcu, 100/50);
            gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Sipahi, 200/40);
            gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Suvari, 100/70);
            gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Yeniceri, 1);

            //bu matrisi şu şekilde kullanabilirsin : 
            // suvarinin piyade karşısındaki güç çarpanı..

            // double carpan = gucMatrisi[AskerTipleri.Suvari][AskerTipleri.Piyade];

            //şimdi kullanıcıdan aldığın datayı tutacak veri yapısına gelelim..

            #endregion
            #region SavasDuzenleri
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
            oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
            oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
            oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
            oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
            oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
            oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
            oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
            oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
            oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);



            oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
            oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
            oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
            oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
            oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
            oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
            oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
            oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
            oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
            oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);


            ahiler.OrduDuzeni[0] = (AskerTipleri)cmbahiler1.SelectedItem;
            ahiler.AskerSayilari[0] = AskerSayisiahiler((AskerTipleri)cmbahiler1.SelectedItem);
            ahiler.OrduDuzeni[1] = (AskerTipleri)cmbahiler2.SelectedItem;
            ahiler.AskerSayilari[1] = AskerSayisiahiler((AskerTipleri)cmbahiler2.SelectedItem);
            ahiler.OrduDuzeni[2] = (AskerTipleri)cmbahiler3.SelectedItem;
            ahiler.AskerSayilari[2] = AskerSayisiahiler((AskerTipleri)cmbahiler3.SelectedItem);
            ahiler.OrduDuzeni[3] = (AskerTipleri)cmbahiler4.SelectedItem;
            ahiler.AskerSayilari[3] = AskerSayisiahiler((AskerTipleri)cmbahiler4.SelectedItem);
            ahiler.OrduDuzeni[4] = (AskerTipleri)cmbahiler5.SelectedItem;
            ahiler.AskerSayilari[4] = AskerSayisiahiler((AskerTipleri)cmbahiler5.SelectedItem);


            mentese.OrduDuzeni[0] = (AskerTipleri)cmbmentese1.SelectedItem;
            mentese.AskerSayilari[0] = AskerSayisimentese((AskerTipleri)cmbmentese1.SelectedItem);
            mentese.OrduDuzeni[1] = (AskerTipleri)cmbmentese1.SelectedItem;
            mentese.AskerSayilari[1] = AskerSayisimentese((AskerTipleri)cmbmentese2.SelectedItem);
            mentese.OrduDuzeni[2] = (AskerTipleri)cmbmentese1.SelectedItem;
            mentese.AskerSayilari[2] = AskerSayisimentese((AskerTipleri)cmbmentese3.SelectedItem);
            mentese.OrduDuzeni[3] = (AskerTipleri)cmbmentese1.SelectedItem;
            mentese.AskerSayilari[3] = AskerSayisimentese((AskerTipleri)cmbmentese4.SelectedItem);
            mentese.OrduDuzeni[4] = (AskerTipleri)cmbmentese1.SelectedItem;
            mentese.AskerSayilari[4] = AskerSayisimentese((AskerTipleri)cmbmentese5.SelectedItem);


            canik.OrduDuzeni[0] = (AskerTipleri)cmbcanik1.SelectedItem;
            canik.AskerSayilari[0] = AskerSayisicanik((AskerTipleri)cmbcanik1.SelectedItem);
            canik.OrduDuzeni[1] = (AskerTipleri)cmbcanik1.SelectedItem;
            canik.AskerSayilari[1] = AskerSayisicanik((AskerTipleri)cmbcanik2.SelectedItem);
            canik.OrduDuzeni[2] = (AskerTipleri)cmbcanik1.SelectedItem;
            canik.AskerSayilari[2] = AskerSayisicanik((AskerTipleri)cmbcanik3.SelectedItem);
            canik.OrduDuzeni[3] = (AskerTipleri)cmbcanik1.SelectedItem;
            canik.AskerSayilari[3] = AskerSayisicanik((AskerTipleri)cmbcanik4.SelectedItem);
            canik.OrduDuzeni[4] = (AskerTipleri)cmbcanik1.SelectedItem;
            canik.AskerSayilari[4] = AskerSayisicanik((AskerTipleri)cmbcanik5.SelectedItem);

           
            hamit.OrduDuzeni[0] = (AskerTipleri)cmbhamit1.SelectedItem;
            hamit.AskerSayilari[0] = AskerSayisihamit((AskerTipleri)cmbhamit1.SelectedItem);
            hamit.OrduDuzeni[1] = (AskerTipleri)cmbhamit2.SelectedItem;
            hamit.AskerSayilari[1] = AskerSayisihamit((AskerTipleri)cmbhamit2.SelectedItem);
            hamit.OrduDuzeni[2] = (AskerTipleri)cmbhamit3.SelectedItem;
            hamit.AskerSayilari[2] = AskerSayisihamit((AskerTipleri)cmbhamit3.SelectedItem);
            hamit.OrduDuzeni[3] = (AskerTipleri)cmbhamit4.SelectedItem;
            hamit.AskerSayilari[3] = AskerSayisihamit((AskerTipleri)cmbhamit4.SelectedItem);
            hamit.OrduDuzeni[4] = (AskerTipleri)cmbhamit5.SelectedItem;
            hamit.AskerSayilari[4] = AskerSayisihamit((AskerTipleri)cmbhamit5.SelectedItem);
            
            karaman.OrduDuzeni[0] = (AskerTipleri)cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[0] = AskerSayisikaraman((AskerTipleri)cmbkaraman1.SelectedItem);
            karaman.OrduDuzeni[1] = (AskerTipleri)cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[1] = AskerSayisikaraman((AskerTipleri)cmbkaraman2.SelectedItem);
            karaman.OrduDuzeni[2] = (AskerTipleri)cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[2] = AskerSayisikaraman((AskerTipleri)cmbkaraman3.SelectedItem);
            karaman.OrduDuzeni[3] = (AskerTipleri)cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[3] = AskerSayisikaraman((AskerTipleri)cmbkaraman4.SelectedItem);
            karaman.OrduDuzeni[4] = (AskerTipleri)cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[4] = AskerSayisikaraman((AskerTipleri)cmbkaraman5.SelectedItem);

           
            esref.OrduDuzeni[0] = (AskerTipleri)cmbesref1.SelectedItem;
            esref.AskerSayilari[0] = AskerSayisiesref((AskerTipleri)cmbesref1.SelectedItem);
            esref.OrduDuzeni[1] = (AskerTipleri)cmbesref1.SelectedItem;
            esref.AskerSayilari[1] = AskerSayisiesref((AskerTipleri)cmbesref2.SelectedItem);
            esref.OrduDuzeni[2] = (AskerTipleri)cmbesref1.SelectedItem;
            esref.AskerSayilari[2] = AskerSayisiesref((AskerTipleri)cmbesref3.SelectedItem);
            esref.OrduDuzeni[3] = (AskerTipleri)cmbesref1.SelectedItem;
            esref.AskerSayilari[3] = AskerSayisiesref((AskerTipleri)cmbesref4.SelectedItem);
            esref.OrduDuzeni[4] = (AskerTipleri)cmbesref1.SelectedItem;
            esref.AskerSayilari[4] = AskerSayisiesref((AskerTipleri)cmbesref5.SelectedItem);
           
            trabzon.OrduDuzeni[0] = (AskerTipleri)cmbtrabzon1.SelectedItem;
            trabzon.AskerSayilari[0] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon1.SelectedItem);
            trabzon.OrduDuzeni[1] = (AskerTipleri)cmbtrabzon2.SelectedItem;
            trabzon.AskerSayilari[1] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon2.SelectedItem);
            trabzon.OrduDuzeni[2] = (AskerTipleri)cmbtrabzon3.SelectedItem;
            trabzon.AskerSayilari[2] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon3.SelectedItem);
            trabzon.OrduDuzeni[3] = (AskerTipleri)cmbtrabzon4.SelectedItem;
            trabzon.AskerSayilari[3] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon4.SelectedItem);
            trabzon.OrduDuzeni[4] = (AskerTipleri)cmbtrabzon5.SelectedItem;
            trabzon.AskerSayilari[4] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon5.SelectedItem);
            
            aydin.OrduDuzeni[0] = (AskerTipleri)cmbaydin1.SelectedItem;
            aydin.AskerSayilari[0] = AskerSayisiaydin((AskerTipleri)cmbaydin1.SelectedItem);
            aydin.OrduDuzeni[1] = (AskerTipleri)cmbaydin1.SelectedItem;
            aydin.AskerSayilari[1] = AskerSayisiaydin((AskerTipleri)cmbaydin2.SelectedItem);
            aydin.OrduDuzeni[2] = (AskerTipleri)cmbaydin1.SelectedItem;
            aydin.AskerSayilari[2] = AskerSayisiaydin((AskerTipleri)cmbaydin3.SelectedItem);
            aydin.OrduDuzeni[3] = (AskerTipleri)cmbaydin1.SelectedItem;
            aydin.AskerSayilari[3] = AskerSayisiaydin((AskerTipleri)cmbaydin4.SelectedItem);
            aydin.OrduDuzeni[4] = (AskerTipleri)cmbaydin1.SelectedItem;
            aydin.AskerSayilari[4] = AskerSayisiaydin((AskerTipleri)cmbaydin5.SelectedItem);
           
            eretna.OrduDuzeni[0] = (AskerTipleri)cmberetna1.SelectedItem;
            eretna.AskerSayilari[0] = AskerSayisieretna((AskerTipleri)cmberetna1.SelectedItem);
            eretna.OrduDuzeni[1] = (AskerTipleri)cmberetna1.SelectedItem;
            eretna.AskerSayilari[1] = AskerSayisieretna((AskerTipleri)cmberetna2.SelectedItem);
            eretna.OrduDuzeni[2] = (AskerTipleri)cmberetna1.SelectedItem;
            eretna.AskerSayilari[2] = AskerSayisieretna((AskerTipleri)cmberetna3.SelectedItem);
            eretna.OrduDuzeni[3] = (AskerTipleri)cmberetna1.SelectedItem;
            eretna.AskerSayilari[3] = AskerSayisieretna((AskerTipleri)cmberetna4.SelectedItem);
            eretna.OrduDuzeni[4] = (AskerTipleri)cmberetna1.SelectedItem;
            eretna.AskerSayilari[4] = AskerSayisieretna((AskerTipleri)cmberetna5.SelectedItem);
           
            saruhan.OrduDuzeni[0] = (AskerTipleri)cmbsaruhan1.SelectedItem;
            saruhan.AskerSayilari[0] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan1.SelectedItem);
            saruhan.OrduDuzeni[1] = (AskerTipleri)cmbsaruhan2.SelectedItem;
            saruhan.AskerSayilari[1] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan2.SelectedItem);
            saruhan.OrduDuzeni[2] = (AskerTipleri)cmbsaruhan3.SelectedItem;
            saruhan.AskerSayilari[2] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan3.SelectedItem);
            saruhan.OrduDuzeni[3] = (AskerTipleri)cmbsaruhan4.SelectedItem;
            saruhan.AskerSayilari[3] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan4.SelectedItem);
            saruhan.OrduDuzeni[4] = (AskerTipleri)cmbsaruhan5.SelectedItem;
            saruhan.AskerSayilari[4] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan5.SelectedItem);
           
            germiyan.OrduDuzeni[0] = (AskerTipleri)cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[0] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan1.SelectedItem);
            germiyan.OrduDuzeni[1] = (AskerTipleri)cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[1] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan2.SelectedItem);
            germiyan.OrduDuzeni[2] = (AskerTipleri)cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[2] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan3.SelectedItem);
            germiyan.OrduDuzeni[3] = (AskerTipleri)cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[3] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan4.SelectedItem);
            germiyan.OrduDuzeni[4] = (AskerTipleri)cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[4] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan5.SelectedItem);
           
            ramazan.OrduDuzeni[0] = (AskerTipleri)cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[0] = AskerSayisiramazan((AskerTipleri)cmbramazan1.SelectedItem);
            ramazan.OrduDuzeni[1] = (AskerTipleri)cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[1] = AskerSayisiramazan((AskerTipleri)cmbramazan2.SelectedItem);
            ramazan.OrduDuzeni[2] = (AskerTipleri)cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[2] = AskerSayisiramazan((AskerTipleri)cmbramazan3.SelectedItem);
            ramazan.OrduDuzeni[3] = (AskerTipleri)cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[3] = AskerSayisiramazan((AskerTipleri)cmbramazan4.SelectedItem);
            ramazan.OrduDuzeni[4] = (AskerTipleri)cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[4] = AskerSayisiramazan((AskerTipleri)cmbramazan5.SelectedItem);
           
            dulkadir.OrduDuzeni[0] = (AskerTipleri)cmbdulkadir1.SelectedItem;
            dulkadir.AskerSayilari[0] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir1.SelectedItem);
            dulkadir.OrduDuzeni[1] = (AskerTipleri)cmbdulkadir2.SelectedItem;
            dulkadir.AskerSayilari[1] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir2.SelectedItem);
            dulkadir.OrduDuzeni[2] = (AskerTipleri)cmbdulkadir3.SelectedItem;
            dulkadir.AskerSayilari[2] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir3.SelectedItem);
            dulkadir.OrduDuzeni[3] = (AskerTipleri)cmbdulkadir4.SelectedItem;
            dulkadir.AskerSayilari[3] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir4.SelectedItem);
            dulkadir.OrduDuzeni[4] = (AskerTipleri)cmbdulkadir5.SelectedItem;
            dulkadir.AskerSayilari[4] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir5.SelectedItem);
            
            kolemen.OrduDuzeni[0] = (AskerTipleri)cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[0] = AskerSayisikolemen((AskerTipleri)cmbkolemen1.SelectedItem);
            kolemen.OrduDuzeni[1] = (AskerTipleri)cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[1] = AskerSayisikolemen((AskerTipleri)cmbkolemen2.SelectedItem);
            kolemen.OrduDuzeni[2] = (AskerTipleri)cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[2] = AskerSayisikolemen((AskerTipleri)cmbkolemen3.SelectedItem);
            kolemen.OrduDuzeni[3] = (AskerTipleri)cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[3] = AskerSayisikolemen((AskerTipleri)cmbkolemen4.SelectedItem);
            kolemen.OrduDuzeni[4] = (AskerTipleri)cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[4] = AskerSayisikolemen((AskerTipleri)cmbkolemen5.SelectedItem);
            
            karesi.OrduDuzeni[0] = (AskerTipleri)cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[0] = AskerSayisikaresi((AskerTipleri)cmbkaresi1.SelectedItem);
            karesi.OrduDuzeni[1] = (AskerTipleri)cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[1] = AskerSayisikaresi((AskerTipleri)cmbkaresi2.SelectedItem);
            karesi.OrduDuzeni[2] = (AskerTipleri)cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[2] = AskerSayisikaresi((AskerTipleri)cmbkaresi3.SelectedItem);
            karesi.OrduDuzeni[3] = (AskerTipleri)cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[3] = AskerSayisikaresi((AskerTipleri)cmbkaresi4.SelectedItem);
            karesi.OrduDuzeni[4] = (AskerTipleri)cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[4] = AskerSayisikaresi((AskerTipleri)cmbkaresi5.SelectedItem);
            
            osmanli.OrduDuzeni[0] = (AskerTipleri)cmbosmanli1.SelectedItem;
            osmanli.AskerSayilari[0] = AskerSayisiosmanli((AskerTipleri)cmbosmanli1.SelectedItem);
            osmanli.OrduDuzeni[1] = (AskerTipleri)cmbosmanli2.SelectedItem;
            osmanli.AskerSayilari[1] = AskerSayisiosmanli((AskerTipleri)cmbosmanli2.SelectedItem);
            osmanli.OrduDuzeni[2] = (AskerTipleri)cmbosmanli3.SelectedItem;
            osmanli.AskerSayilari[2] = AskerSayisiosmanli((AskerTipleri)cmbosmanli3.SelectedItem);
            osmanli.OrduDuzeni[3] = (AskerTipleri)cmbosmanli4.SelectedItem;
            osmanli.AskerSayilari[3] = AskerSayisiosmanli((AskerTipleri)cmbosmanli4.SelectedItem);
            osmanli.OrduDuzeni[4] = (AskerTipleri)cmbosmanli5.SelectedItem;
            osmanli.AskerSayilari[4] = AskerSayisiosmanli((AskerTipleri)cmbosmanli5.SelectedItem);
          
            bizans.OrduDuzeni[0] = (AskerTipleri)cmbbizans1.SelectedItem;
            bizans.AskerSayilari[0] = AskerSayisibizans((AskerTipleri)cmbbizans1.SelectedItem);
            bizans.OrduDuzeni[1] = (AskerTipleri)cmbbizans1.SelectedItem;
            bizans.AskerSayilari[1] = AskerSayisibizans((AskerTipleri)cmbbizans2.SelectedItem);
            bizans.OrduDuzeni[2] = (AskerTipleri)cmbbizans1.SelectedItem;
            bizans.AskerSayilari[2] = AskerSayisibizans((AskerTipleri)cmbbizans3.SelectedItem);
            bizans.OrduDuzeni[3] = (AskerTipleri)cmbbizans1.SelectedItem;
            bizans.AskerSayilari[3] = AskerSayisibizans((AskerTipleri)cmbbizans4.SelectedItem);
            bizans.OrduDuzeni[4] = (AskerTipleri)cmbbizans1.SelectedItem;
            bizans.AskerSayilari[4] = AskerSayisibizans((AskerTipleri)cmbbizans5.SelectedItem);
            #endregion
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }
        int RastgeleSayi1;
        public static void Savas(SavasDuzeni o1, SavasDuzeni o2)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

            int s1 = 0, s2 = 0; 

            int tur = 0;
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

            do
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                tur++;
                MessageBox.Show(string.Format("{0}. tur oynanıyor...", tur));

                MessageBox.Show(string.Format("{0} {1} karşısında {2} {3}", o1.AskerSayilari[s1], o1.OrduDuzeni[s1].ToString(), o2.AskerSayilari[s2], o2.OrduDuzeni[s2].ToString()));

                
                double o1Guc = o1.AskerSayilari[s1] * gucMatrisi[o1.OrduDuzeni[s1]][o2.OrduDuzeni[s2]];
                double o2Guc = o2.AskerSayilari[s2] * gucMatrisi[o2.OrduDuzeni[s2]][o1.OrduDuzeni[s1]];
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..


                if (o1Guc > o2Guc)
                {
                    //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                    o2.AskerSayilari[s2] = 0;
                    o1.AskerSayilari[s1] = (o1Guc - o2Guc) / gucMatrisi[o1.OrduDuzeni[s1]][o2.OrduDuzeni[s2]];
                    //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                    
                    s2++;
                   
                 
                    MessageBox.Show("Bu turu Oyuncu1 Kazandı");

                }
                else if (o1Guc < o2Guc)
                {
                    //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                    o1.AskerSayilari[s1] = 0;
                o2.AskerSayilari[s2] = (o2Guc - o1Guc) / gucMatrisi[o2.OrduDuzeni[s2]][o1.OrduDuzeni[s1]];
                    s1++;
                    MessageBox.Show("Bu turu Oyuncu2 Kazandı");
                }
                else
                {
                    //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                    o1.AskerSayilari[s1] = 0;
                    o2.AskerSayilari[s2] = 0;
                    s1++;
                    s2++;
                    MessageBox.Show("Bu tur berabere");
                }

            } while (s1 < 5 && s2 < 5);

            if (s1 > s2)
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                MessageBox.Show("Savaşı Oyuncu 2 kazandı..");
            }
            else if (s1 < s2)
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                MessageBox.Show("Savaşı Oyuncu 1 kazandı..");
            }
            else
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                MessageBox.Show("Savaşta yenişemediler, sağ kalan yok..");
            }
        }
        public class SavasDuzeni
        {//Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            public AskerTipleri[] OrduDuzeni;
            public double[] AskerSayilari;

            public SavasDuzeni()
            {
                OrduDuzeni = new AskerTipleri[5];
                AskerSayilari = new double[5] { 0, 0, 0, 0, 0 };

            }//Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }
        protected static Dictionary<AskerTipleri, Dictionary<AskerTipleri, double>> gucMatrisi = new Dictionary<AskerTipleri, Dictionary<AskerTipleri, double>>();
        public enum AskerTipleri
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            Piyade,
            Okcu,
            Sipahi,
            Suvari,
            Yeniceri
        }
        private void button2_Click(object sender, EventArgs e)
        {

    

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            abilerbilgi.ShowDialog();
        }

        public void button18_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnAbiler_Click(object sender, EventArgs e)
        {
            


       

           


        }

        private void Harita_Load_1(object sender, EventArgs e)
        {
            /*
            btnAhilerK.Hide();
            btnAydinK.Hide();
            btnBizansK.Hide();
            btnCanikK.Hide();
            btnDulkadirK.Hide();
            btnEretnaK.Hide();
            btnEsrefK.Hide();
            btnGermiyanK.Hide();
            btnHamitK.Hide();
            btnKaramanK.Hide();
            btnKaresiK.Hide();
            btnKolemenK.Hide();
            btnMenteseK.Hide();
            btnOsmanK.Hide();
            btnRamazanK.Hide();
            btnSaruhanK.Hide();
            btnTrabzonK.Hide();
            lblAhiler.Hide();
            lblAydin.Hide();
            lblBizans.Hide();
            lblCanik.Hide();
            lblDulkadir.Hide();
            lblEretna.Hide();
            lblEsref.Hide();
            lblGermiyan.Hide();
            lblHamit.Hide();
            lblKaraman.Hide();
            lblKaresi.Hide();
            lblKolemen.Hide();
            lblMentese.Hide();
            lblOsman.Hide();
            lblRamazan.Hide();
            lblSaruhan.Hide();
            lblTrabzon.Hide();
           
            */
   /*
            if (frmoyuncu1.label9.Text == "Oyuncu1")
	           {
                 label1.Text = "Oyuncu1";
	           }

            else
               {
                label1.Text = "Oyuncu2";
               }
     */
            this.FormClosing += new FormClosingEventHandler(Harita_FormClosing);
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            #region OrduDüzenleri,Oyuncu Yerleri,Data Source

            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (a == 0)
            {
                #region Data Source
              
                
                cmbahiler1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbahiler2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbahiler3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbahiler4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbahiler5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbmentese1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbmentese2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbmentese3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbmentese4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbmentese5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbcanik1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbcanik2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbcanik3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbcanik4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbcanik5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbhamit1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbhamit2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbhamit3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbhamit4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbhamit5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbkaraman1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaraman2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaraman3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaraman4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaraman5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbesref1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbesref2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbesref3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbesref4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbesref5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbtrabzon1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbtrabzon2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbtrabzon3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbtrabzon4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbtrabzon5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbaydin1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbaydin2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbaydin3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbaydin4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbaydin5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmberetna1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmberetna2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmberetna3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmberetna4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmberetna5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbsaruhan1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbsaruhan2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbsaruhan3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbsaruhan4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbsaruhan5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbgermiyan1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbgermiyan2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbgermiyan3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbgermiyan4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbgermiyan5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbramazan1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbramazan2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbramazan3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbramazan4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbramazan5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbdulkadir1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbdulkadir2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbdulkadir3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbdulkadir4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbdulkadir5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbkolemen1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkolemen2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkolemen3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkolemen4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkolemen5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbkaresi1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaresi2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaresi3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaresi4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbkaresi5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbosmanli1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbosmanli2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbosmanli3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbosmanli4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbosmanli5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                cmbbizans1.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbbizans2.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbbizans3.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbbizans4.DataSource = Enum.GetValues(typeof(AskerTipleri));
                cmbbizans5.DataSource = Enum.GetValues(typeof(AskerTipleri));

                #endregion

                #region Güçler
                gucMatrisi.Add(AskerTipleri.Piyade, new Dictionary<AskerTipleri, double>());
                gucMatrisi.Add(AskerTipleri.Okcu, new Dictionary<AskerTipleri, double>());
                gucMatrisi.Add(AskerTipleri.Sipahi, new Dictionary<AskerTipleri, double>());
                gucMatrisi.Add(AskerTipleri.Suvari, new Dictionary<AskerTipleri, double>());
                gucMatrisi.Add(AskerTipleri.Yeniceri, new Dictionary<AskerTipleri, double>());


                gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Piyade, 20);    //piyadenin piyadeye gücü aynıdır.. 1..
                gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Okcu, 20);      // buradaki 1 i senin değiştirmen lazım.
                gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Sipahi, 40);    // double tanımladık ki, piyade örneğin okcudan güçsüzse burada 0.5 diye tanımlayabilirsin.. 
                gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Suvari, 20);
                gucMatrisi[AskerTipleri.Piyade].Add(AskerTipleri.Yeniceri, 20);

                gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Piyade, 25);
                gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Okcu, 25);
                gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Sipahi, 25);
                gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Suvari, 25);
                gucMatrisi[AskerTipleri.Okcu].Add(AskerTipleri.Yeniceri, 50);

                gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Piyade, 40);
                gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Okcu, 80);
                gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Sipahi, 40);
                gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Suvari, 40);
                gucMatrisi[AskerTipleri.Sipahi].Add(AskerTipleri.Yeniceri, 40);

                gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Piyade, 140);
                gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Okcu, 70);
                gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Sipahi, 70);
                gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Suvari, 70);
                gucMatrisi[AskerTipleri.Suvari].Add(AskerTipleri.Yeniceri, 70);

                gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Piyade, 100);
                gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Okcu, 100);
                gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Sipahi, 100);
                gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Suvari, 200);
                gucMatrisi[AskerTipleri.Yeniceri].Add(AskerTipleri.Yeniceri, 100);

                //bu matrisi şu şekilde kullanabilirsin : 
                // suvarinin piyade karşısındaki güç çarpanı..

                // double carpan = gucMatrisi[AskerTipleri.Suvari][AskerTipleri.Piyade];

                //şimdi kullanıcıdan aldığın datayı tutacak veri yapısına gelelim..

                #endregion

                #region Oyuncu Yerleri

                Random oyuncuyerleri = new Random();
                RastgeleSayi1 = oyuncuyerleri.Next(1, 3);
                if (RastgeleSayi1 == 1)
                {
                   pbAlttaki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                   lblAlttaki.Text = "Oyuncu1";
                   pbUstteki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                   lblUstteki.Text = "Oyuncu2";
                }

                else
                {
                  pbUstteki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                  lblUstteki.Text = "Oyuncu1";
                  pbAlttaki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                  lblAlttaki.Text = "Oyuncu2";
                }



                #endregion

                #region Bizans Ordu Düzeni

                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbbizans1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbbizans1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbbizans1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbbizans1.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbbizans1.SelectedIndex = 4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbbizans2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbbizans2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbbizans2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbbizans2.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbbizans2.SelectedIndex = 4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbbizans3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbbizans3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbbizans3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbbizans3.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbbizans3.SelectedIndex = 4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbbizans4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbbizans4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbbizans4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbbizans4.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbbizans4.SelectedIndex = 4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbbizans5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbbizans5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbbizans5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbbizans5.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbbizans5.SelectedIndex = 4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Osmanoğulları

                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbosmanli1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbosmanli1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbosmanli1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbosmanli1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbosmanli1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbosmanli2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbosmanli2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbosmanli2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbosmanli2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbosmanli2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbosmanli3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbosmanli3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbosmanli3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbosmanli3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbosmanli3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbosmanli4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbosmanli4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbosmanli4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbosmanli4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbosmanli4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbosmanli5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbosmanli5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbosmanli5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbosmanli5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbosmanli5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region KaresiOğulları
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbkaresi1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbkaresi1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbkaresi1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbkaresi1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbkaresi1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbkaresi2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbkaresi2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbkaresi2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbkaresi2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbkaresi2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbkaresi3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbkaresi3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbkaresi3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbkaresi3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbkaresi3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbkaresi4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbkaresi4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbkaresi4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbkaresi4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbkaresi4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbkaresi5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbkaresi5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbkaresi5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbkaresi5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbkaresi5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Germiyan
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbgermiyan1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbgermiyan1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbgermiyan1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbgermiyan1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbgermiyan1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbgermiyan2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbgermiyan2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbgermiyan2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbgermiyan2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbgermiyan2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbgermiyan3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbgermiyan3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbgermiyan3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbgermiyan3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbgermiyan3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbgermiyan4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbgermiyan4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbgermiyan4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbgermiyan4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbgermiyan4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbgermiyan5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbgermiyan5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbgermiyan5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbgermiyan5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbgermiyan5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Saruhan
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbsaruhan1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbsaruhan1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbsaruhan1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbsaruhan1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbsaruhan1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbsaruhan2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbsaruhan2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbsaruhan2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbsaruhan2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbsaruhan2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbsaruhan3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbsaruhan3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbsaruhan3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbsaruhan3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbsaruhan3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbsaruhan4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbsaruhan4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbsaruhan4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbsaruhan4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbsaruhan4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbsaruhan5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbsaruhan5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbsaruhan5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbsaruhan5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbsaruhan5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Aydın
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbaydin1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbaydin1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbaydin1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbaydin1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbaydin1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbaydin2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbaydin2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbaydin2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbaydin2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbaydin2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbaydin3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbaydin3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbaydin3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbaydin3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbaydin3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbaydin4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbaydin4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbaydin4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbaydin4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbaydin4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbaydin5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbaydin5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbaydin5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbaydin5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbaydin5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Menteşe
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbmentese1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbmentese1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbmentese1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbmentese1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbmentese1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbmentese2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbmentese2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbmentese2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbmentese2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbmentese2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbmentese3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbmentese3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbmentese3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbmentese3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbmentese3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbmentese4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbmentese4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbmentese4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbmentese4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbmentese4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbmentese5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbmentese5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbmentese5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbmentese5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbmentese5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Hamit
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbhamit1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbhamit1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbhamit1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbhamit1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbhamit1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbhamit2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbhamit2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbhamit2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbhamit2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbhamit2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbhamit3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbhamit3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbhamit3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbhamit3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbhamit3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbhamit4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbhamit4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbhamit4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbhamit4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbhamit4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbhamit5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbhamit5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbhamit5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbhamit5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbhamit5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Eşref
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbesref1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbesref1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbesref1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbesref1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbesref1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbesref2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbesref2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbesref2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbesref2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbesref2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbesref3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbesref3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbesref3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbesref3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbesref3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbesref4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbesref4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbesref4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbesref4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbesref4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbesref5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbesref5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbesref5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbesref5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbesref5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Abiler

                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            
                            cmbahiler1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbahiler1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbahiler1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbahiler1.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbahiler1.SelectedIndex = 4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbahiler2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbahiler2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbahiler2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbahiler2.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbahiler2.SelectedIndex = 4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbahiler3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbahiler3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbahiler3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbahiler3.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbahiler3.SelectedIndex = 4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbahiler4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbahiler4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbahiler4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbahiler4.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbahiler4.SelectedIndex = 4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbahiler5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbahiler5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbahiler5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbahiler5.SelectedIndex = 3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbahiler5.SelectedIndex = 4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }
                #endregion
             
                #region Karaman
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbkaraman1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbkaraman1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbkaraman1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbkaraman1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbkaraman1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbkaraman2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbkaraman2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbkaraman2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbkaraman2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbkaraman2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbkaraman3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbkaraman3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbkaraman3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbkaraman3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbkaraman3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbkaraman4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbkaraman4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbkaraman4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbkaraman4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbkaraman4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbkaraman5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbkaraman5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbkaraman5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbkaraman5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbkaraman5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Ramazan
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbramazan1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbramazan1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbramazan1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbramazan1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbramazan1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbramazan2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbramazan2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbramazan2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbramazan2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbramazan2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbramazan3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbramazan3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbramazan3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbramazan3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbramazan3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbramazan4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbramazan4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbramazan4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbramazan4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbramazan4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbramazan5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbramazan5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbramazan5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbramazan5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbramazan5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Dulkadir
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbdulkadir1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbdulkadir1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbdulkadir1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbdulkadir1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbdulkadir1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbdulkadir2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbdulkadir2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbdulkadir2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbdulkadir2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbdulkadir2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbdulkadir3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbdulkadir3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbdulkadir3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbdulkadir3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbdulkadir3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbdulkadir4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbdulkadir4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbdulkadir4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbdulkadir4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbdulkadir4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbdulkadir5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbdulkadir5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbdulkadir5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbdulkadir5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbdulkadir5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Çanik
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbcanik1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbcanik1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbcanik1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbcanik1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbcanik1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbcanik2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbcanik2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbcanik2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbcanik2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbcanik2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbcanik3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbcanik3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbcanik3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbcanik3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbcanik3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbcanik4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbcanik4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbcanik4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbcanik4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbcanik4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbcanik5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbcanik5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbcanik5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbcanik5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbcanik5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Eretna
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmberetna1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmberetna1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmberetna1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmberetna1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmberetna1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmberetna2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmberetna2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmberetna2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmberetna2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmberetna2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmberetna3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmberetna3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmberetna3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmberetna3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmberetna3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmberetna4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmberetna4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmberetna4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmberetna4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmberetna4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmberetna5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmberetna5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmberetna5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmberetna5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmberetna5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Trabzon Rum
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbtrabzon1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbtrabzon1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbtrabzon1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbtrabzon1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbtrabzon1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbtrabzon2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbtrabzon2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbtrabzon2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbtrabzon2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbtrabzon2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbtrabzon3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbtrabzon3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbtrabzon3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbtrabzon3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbtrabzon3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbtrabzon4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbtrabzon4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbtrabzon4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbtrabzon4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbtrabzon4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbtrabzon5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbtrabzon5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbtrabzon5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbtrabzon5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbtrabzon5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion

                #region Kölemen Devleti
                try
                {
                    Random yeni = new Random(); //1
                    listBox1.Items.Clear(); //2
                    int RastgeleSayi = yeni.Next(1, 6); //3
                    int[] FarkliSayilariTut = new int[5]; //4
                    FarkliSayilariTut[0] = RastgeleSayi; //5
                    for (int i = 1; i < FarkliSayilariTut.Length; i++) //6
                    {
                        RastgeleSayi = yeni.Next(1, 6); //7
                        for (int j = 0; j < i; j++) //8
                        {
                            if (FarkliSayilariTut[j] == RastgeleSayi) //9
                            {
                                i--;  //10
                                break; //11
                            }
                            else
                            {
                                FarkliSayilariTut[i] = RastgeleSayi;  //12
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        listBox1.Items.Add(FarkliSayilariTut[i].ToString()); //13

                        #region 1. Konum
                        if (FarkliSayilariTut[0] == 1)
                        {
                            cmbkolemen1.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[0] == 2)
                        {
                            cmbkolemen1.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[0] == 3)
                        {
                            cmbkolemen1.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[0] == 4)
                        {
                            cmbkolemen1.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[0] == 5)
                        {
                            cmbkolemen1.SelectedIndex =4;
                        }
                        #endregion

                        #region 2. Konum
                        if (FarkliSayilariTut[1] == 1)
                        {
                            cmbkolemen2.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[1] == 2)
                        {
                            cmbkolemen2.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[1] == 3)
                        {
                            cmbkolemen2.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[1] == 4)
                        {
                            cmbkolemen2.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[1] == 5)
                        {
                            cmbkolemen2.SelectedIndex =4;
                        }
                        #endregion

                        #region 3. Konum
                        if (FarkliSayilariTut[2] == 1)
                        {
                            cmbkolemen3.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[2] == 2)
                        {
                            cmbkolemen3.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[2] == 3)
                        {
                            cmbkolemen3.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[2] == 4)
                        {
                            cmbkolemen3.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[2] == 5)
                        {
                            cmbkolemen3.SelectedIndex =4;
                        }
                        #endregion

                        #region 4. Konum
                        if (FarkliSayilariTut[3] == 1)
                        {
                            cmbkolemen4.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[3] == 2)
                        {
                            cmbkolemen4.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[3] == 3)
                        {
                            cmbkolemen4.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[3] == 4)
                        {
                            cmbkolemen4.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[3] == 5)
                        {
                            cmbkolemen4.SelectedIndex =4;
                        }
                        #endregion

                        #region 5. Konum
                        if (FarkliSayilariTut[4] == 1)
                        {
                            cmbkolemen5.SelectedIndex = 0;
                        }

                        if (FarkliSayilariTut[4] == 2)
                        {
                            cmbkolemen5.SelectedIndex = 1;
                        }

                        if (FarkliSayilariTut[4] == 3)
                        {
                            cmbkolemen5.SelectedIndex = 2;
                        }

                        if (FarkliSayilariTut[4] == 4)
                        {
                            cmbkolemen5.SelectedIndex =3;
                        }

                        if (FarkliSayilariTut[4] == 5)
                        {
                            cmbkolemen5.SelectedIndex =4;
                        }
                        #endregion

                    }

                }
                catch (Exception)
                {

                }

                #endregion
                a = 1;
            }
            #endregion
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            #region Savaş Alanları Oyuncu1
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            btnUstteki.Visible = false;
            btnAlttaki.Visible = false;
            btnAhiler.Visible = false;
            btnOsman.Visible = false;
            btnKaraman.Visible = false;
            btnEretna.Visible = false;
            btnCanik.Visible = false;
            btnTrabzon.Visible = false;
            btnDulkadir.Visible = false;
            btnRamazan.Visible = false;
            btnKolemen.Visible = false;
            btnMentese.Visible = false;
            btnEsref.Visible = false;
            btnKaresi.Visible = false;
            btnGermiyan.Visible = false;
            btnAydin.Visible = false;
            btnBizans.Visible = false;
            btnHamit.Visible = false;
            btnSaruhan.Visible = false;

            if (label1.Text == "Oyuncu1")
            {
                #region Üstteki Oyuncu1se
                if (lblUstteki.Text=="Oyuncu1")
                {
                    btnOsman.Visible = true;
                    btnAhiler.Visible = true;
                    btnEretna.Visible = true;
                    btnCanik.Visible = true;
                    btnBizans.Visible = true;

                    if (lblAhiler.Text=="Oyuncu1")
                    {
                        btnOsman.Visible = true;
                        btnKaraman.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblMentese.Text=="Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnHamit.Visible = true;
                    }

                    if (lblCanik.Text=="Oyuncu1")
                    {
                        btnTrabzon.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblHamit.Text=="Oyuncu1")
                    {
                        btnMentese.Visible = true;
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblKaraman.Text=="Oyuncu1")
                    {
                        btnHamit.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnOsman.Visible = true;
                        btnAhiler.Visible = true;
                        btnEretna.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblEsref.Text=="Oyuncu1")
                    {
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }


                    if (lblTrabzon.Text=="Oyuncu1")
                    {
                        btnCanik.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblAydin.Text=="Oyuncu1")
                    {
                        btnGermiyan.Visible = true;
                        btnHamit.Visible = true;
                        btnSaruhan.Visible = true;
                        btnMentese.Visible = true;
                    }

                    if (lblEretna.Text=="Oyuncu1")
                    {
                        btnKaraman.Visible = true;
                        btnRamazan.Visible = true;
                        btnDulkadir.Visible = true;
                        btnTrabzon.Visible = true;
                        btnCanik.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblSaruhan.Text=="Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaresi.Visible = true;
                    }

                    if (lblGermiyan.Text=="Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnOsman.Visible = true;
                        btnSaruhan.Visible = true;
                        btnKaresi.Visible = true;
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblRamazan.Text=="Oyuncu1")
                    {
                        btnKaraman.Visible = true;
                        btnDulkadir.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblDulkadir.Text=="Oyuncu1")
                    {
                        btnRamazan.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblKolemen.Text=="Oyuncu1")
                    {
                        btnDulkadir.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblKaresi.Text=="Oyuncu1")
                    {
                        btnGermiyan.Visible = true;
                        btnSaruhan.Visible = true;
                        btnOsman.Visible = true;
                    }

                    if (lblOsman.Text=="Oyuncu1")
                    {
                        btnBizans.Visible = true;
                        btnKaresi.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaraman.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblBizans.Text=="Oyuncu1")
                    {
                        btnUstteki.Visible = true;
                        btnAlttaki.Visible = true;
                    }


                }

                #endregion
                #region Alttaki Oyuncu1se
                else
                {
                    btnMentese.Visible = true;
                    btnKaraman.Visible = true;
                    btnHamit.Visible = true;
                    btnBizans.Visible = true;
                    if (lblAhiler.Text == "Oyuncu1")
                    {
                        btnOsman.Visible = true;
                        btnKaraman.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblMentese.Text == "Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnHamit.Visible = true;
                    }

                    if (lblCanik.Text == "Oyuncu1")
                    {
                        btnTrabzon.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblHamit.Text == "Oyuncu1")
                    {
                        btnMentese.Visible = true;
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblKaraman.Text == "Oyuncu1")
                    {
                        btnHamit.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnOsman.Visible = true;
                        btnAhiler.Visible = true;
                        btnEretna.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblEsref.Text == "Oyuncu1")
                    {
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }


                    if (lblTrabzon.Text == "Oyuncu1")
                    {
                        btnCanik.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblAydin.Text == "Oyuncu1")
                    {
                        btnGermiyan.Visible = true;
                        btnHamit.Visible = true;
                        btnSaruhan.Visible = true;
                        btnMentese.Visible = true;
                    }

                    if (lblEretna.Text == "Oyuncu1")
                    {
                        btnKaraman.Visible = true;
                        btnRamazan.Visible = true;
                        btnDulkadir.Visible = true;
                        btnTrabzon.Visible = true;
                        btnCanik.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblSaruhan.Text == "Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaresi.Visible = true;
                    }

                    if (lblGermiyan.Text == "Oyuncu1")
                    {
                        btnAydin.Visible = true;
                        btnOsman.Visible = true;
                        btnSaruhan.Visible = true;
                        btnKaresi.Visible = true;
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblRamazan.Text == "Oyuncu1")
                    {
                        btnKaraman.Visible = true;
                        btnDulkadir.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblDulkadir.Text == "Oyuncu1")
                    {
                        btnRamazan.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblKolemen.Text == "Oyuncu1")
                    {
                        btnDulkadir.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblKaresi.Text == "Oyuncu1")
                    {
                        btnGermiyan.Visible = true;
                        btnSaruhan.Visible = true;
                        btnOsman.Visible = true;
                    }

                    if (lblOsman.Text == "Oyuncu1")
                    {
                        btnBizans.Visible = true;
                        btnKaresi.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaraman.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblBizans.Text == "Oyuncu1")
                    {
                        btnUstteki.Visible = true;
                        btnAlttaki.Visible = true;
                    }
                    
                }

                #endregion

            }

            #endregion
            #region Savaş Alanları Oyuncu2
            else
            {//Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                #region Üstteki Oyuncu1se
                if (lblUstteki.Text == "Oyuncu2")
                {
                    btnOsman.Visible = true;
                    btnAhiler.Visible = true;
                    btnEretna.Visible = true;
                    btnCanik.Visible = true;
                    btnBizans.Visible = true;

                    if (lblAhiler.Text == "Oyuncu2")
                    {
                        btnOsman.Visible = true;
                        btnKaraman.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblMentese.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnHamit.Visible = true;
                    }

                    if (lblCanik.Text == "Oyuncu2")
                    {
                        btnTrabzon.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblHamit.Text == "Oyuncu2")
                    {
                        btnMentese.Visible = true;
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblKaraman.Text == "Oyuncu2")
                    {
                        btnHamit.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnOsman.Visible = true;
                        btnAhiler.Visible = true;
                        btnEretna.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblEsref.Text == "Oyuncu2")
                    {
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }


                    if (lblTrabzon.Text == "Oyuncu2")
                    {
                        btnCanik.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblAydin.Text == "Oyuncu2")
                    {
                        btnGermiyan.Visible = true;
                        btnHamit.Visible = true;
                        btnSaruhan.Visible = true;
                        btnMentese.Visible = true;
                    }

                    if (lblEretna.Text == "Oyuncu2")
                    {
                        btnKaraman.Visible = true;
                        btnRamazan.Visible = true;
                        btnDulkadir.Visible = true;
                        btnTrabzon.Visible = true;
                        btnCanik.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblSaruhan.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaresi.Visible = true;
                    }

                    if (lblGermiyan.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnOsman.Visible = true;
                        btnSaruhan.Visible = true;
                        btnKaresi.Visible = true;
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblRamazan.Text == "Oyuncu2")
                    {
                        btnKaraman.Visible = true;
                        btnDulkadir.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblDulkadir.Text == "Oyuncu2")
                    {
                        btnRamazan.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblKolemen.Text == "Oyuncu2")
                    {
                        btnDulkadir.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblKaresi.Text == "Oyuncu2")
                    {
                        btnGermiyan.Visible = true;
                        btnSaruhan.Visible = true;
                        btnOsman.Visible = true;
                    }

                    if (lblOsman.Text == "Oyuncu2")
                    {
                        btnBizans.Visible = true;
                        btnKaresi.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaraman.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblBizans.Text == "Oyuncu2")
                    {
                        btnUstteki.Visible = true;
                        btnAlttaki.Visible = true;
                    }


                }

                #endregion
                #region Alttaki Oyuncu2se
                else
                {
                    btnMentese.Visible = true;
                    btnKaraman.Visible = true;
                    btnHamit.Visible = true;
                    btnBizans.Visible = true;
                    if (lblAhiler.Text == "Oyuncu2")
                    {
                        btnOsman.Visible = true;
                        btnKaraman.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblMentese.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnHamit.Visible = true;
                    }

                    if (lblCanik.Text == "Oyuncu2")
                    {
                        btnTrabzon.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblHamit.Text == "Oyuncu2")
                    {
                        btnMentese.Visible = true;
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblKaraman.Text == "Oyuncu2")
                    {
                        btnHamit.Visible = true;
                        btnGermiyan.Visible = true;
                        btnEsref.Visible = true;
                        btnOsman.Visible = true;
                        btnAhiler.Visible = true;
                        btnEretna.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblEsref.Text == "Oyuncu2")
                    {
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }


                    if (lblTrabzon.Text == "Oyuncu2")
                    {
                        btnCanik.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblAydin.Text == "Oyuncu2")
                    {
                        btnGermiyan.Visible = true;
                        btnHamit.Visible = true;
                        btnSaruhan.Visible = true;
                        btnMentese.Visible = true;
                    }

                    if (lblEretna.Text == "Oyuncu2")
                    {
                        btnKaraman.Visible = true;
                        btnRamazan.Visible = true;
                        btnDulkadir.Visible = true;
                        btnTrabzon.Visible = true;
                        btnCanik.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblSaruhan.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaresi.Visible = true;
                    }

                    if (lblGermiyan.Text == "Oyuncu2")
                    {
                        btnAydin.Visible = true;
                        btnOsman.Visible = true;
                        btnSaruhan.Visible = true;
                        btnKaresi.Visible = true;
                        btnHamit.Visible = true;
                        btnKaraman.Visible = true;
                    }

                    if (lblRamazan.Text == "Oyuncu2")
                    {
                        btnKaraman.Visible = true;
                        btnDulkadir.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblDulkadir.Text == "Oyuncu2")
                    {
                        btnRamazan.Visible = true;
                        btnKolemen.Visible = true;
                        btnEretna.Visible = true;
                    }

                    if (lblKolemen.Text == "Oyuncu2")
                    {
                        btnDulkadir.Visible = true;
                        btnRamazan.Visible = true;
                    }

                    if (lblKaresi.Text == "Oyuncu2")
                    {
                        btnGermiyan.Visible = true;
                        btnSaruhan.Visible = true;
                        btnOsman.Visible = true;
                    }

                    if (lblOsman.Text == "Oyuncu2")
                    {
                        btnBizans.Visible = true;
                        btnKaresi.Visible = true;
                        btnGermiyan.Visible = true;
                        btnKaraman.Visible = true;
                        btnAhiler.Visible = true;
                    }

                    if (lblBizans.Text == "Oyuncu2")
                    {
                        btnUstteki.Visible = true;
                        btnAlttaki.Visible = true;
                    }

                }

                #endregion

            }
            #endregion
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

        }

        void Harita_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;
        }

     

      

        private void button2_Click_2(object sender, EventArgs e)
        {
            abilerbilgi.ShowDialog();
        }

        private void btnAhilerK_Click(object sender, EventArgs e)
        {

            if (lblAhiler.Text != "Oyuncu1" && lblAhiler.Text != "Oyuncu2")
            {

                #region Oyuncu1Se


                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();
                        

                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        ahiler.OrduDuzeni[0] = (AskerTipleri)cmbahiler1.SelectedItem;
                        ahiler.AskerSayilari[0] = AskerSayisiahiler((AskerTipleri)cmbahiler1.SelectedItem);
                        ahiler.OrduDuzeni[1] = (AskerTipleri)cmbahiler2.SelectedItem;
                        ahiler.AskerSayilari[1] = AskerSayisiahiler((AskerTipleri)cmbahiler2.SelectedItem);
                        ahiler.OrduDuzeni[2] = (AskerTipleri)cmbahiler3.SelectedItem;
                        ahiler.AskerSayilari[2] = AskerSayisiahiler((AskerTipleri)cmbahiler3.SelectedItem);
                        ahiler.OrduDuzeni[3] = (AskerTipleri)cmbahiler4.SelectedItem;
                        ahiler.AskerSayilari[3] = AskerSayisiahiler((AskerTipleri)cmbahiler4.SelectedItem);
                        ahiler.OrduDuzeni[4] = (AskerTipleri)cmbahiler5.SelectedItem;
                        ahiler.AskerSayilari[4] = AskerSayisiahiler((AskerTipleri)cmbahiler5.SelectedItem);

                        Savas(oyuncu1, ahiler);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Ahiler Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbahiler1.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbahiler2.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbahiler3.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbahiler4.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbahiler5.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        abilerbilgi.lblahilersg.Text = ((double.Parse(abilerbilgi.lblahilerpiyade.Text) * 20) + (double.Parse(abilerbilgi.lblahilerokcu.Text) * 25) + (double.Parse(abilerbilgi.lblahilersipahi.Text) * 40) + (double.Parse(abilerbilgi.lblahilersuvari.Text) * 70) + (double.Parse(abilerbilgi.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (abilerbilgi.lblahilerpiyade.Text == "0" && abilerbilgi.lblahilerokcu.Text == "0" && abilerbilgi.lblahilersipahi.Text=="0" && abilerbilgi.lblahilersuvari.Text == "0" && abilerbilgi.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 50000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 50.000 Altın Ganimet Elde Ettiniz.");
                            pbAhiler.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblAhiler.Text = "Oyuncu1";
                            btnOsman.Visible = true;
                            btnKaraman.Visible = true;
                            btnEretna.Visible = true;

                        }
                    }
                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");

                }
                #endregion



                #region Oyuncu2Se
                else 
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);


                        ahiler.OrduDuzeni[0] = (AskerTipleri)cmbahiler1.SelectedItem;
                        ahiler.AskerSayilari[0] = AskerSayisiahiler((AskerTipleri)cmbahiler1.SelectedItem);
                        ahiler.OrduDuzeni[1] = (AskerTipleri)cmbahiler2.SelectedItem;
                        ahiler.AskerSayilari[1] = AskerSayisiahiler((AskerTipleri)cmbahiler2.SelectedItem);
                        ahiler.OrduDuzeni[2] = (AskerTipleri)cmbahiler3.SelectedItem;
                        ahiler.AskerSayilari[2] = AskerSayisiahiler((AskerTipleri)cmbahiler3.SelectedItem);
                        ahiler.OrduDuzeni[3] = (AskerTipleri)cmbahiler4.SelectedItem;
                        ahiler.AskerSayilari[3] = AskerSayisiahiler((AskerTipleri)cmbahiler4.SelectedItem);
                        ahiler.OrduDuzeni[4] = (AskerTipleri)cmbahiler5.SelectedItem;
                        ahiler.AskerSayilari[4] = AskerSayisiahiler((AskerTipleri)cmbahiler5.SelectedItem);

                        Savas(oyuncu2, ahiler);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Ahiler Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbahiler1.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else if (cmbahiler1.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbahiler2.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else if (cmbahiler2.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbahiler3.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else if (cmbahiler3.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbahiler4.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else if (cmbahiler4.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbahiler5.Text == "Piyade")
                        {
                            abilerbilgi.lblahilerpiyade.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Okcu")
                        {
                            abilerbilgi.lblahilerokcu.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Sipahi")
                        {
                            abilerbilgi.lblahilersipahi.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else if (cmbahiler5.Text == "Suvari")
                        {
                            abilerbilgi.lblahilersuvari.Text = ahiler.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            abilerbilgi.lblahileryeniceri.Text = ahiler.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        abilerbilgi.lblahilersg.Text = ((double.Parse(abilerbilgi.lblahilerpiyade.Text) * 20) + (double.Parse(abilerbilgi.lblahilerokcu.Text) * 25) + (double.Parse(abilerbilgi.lblahilersipahi.Text) * 40) + (double.Parse(abilerbilgi.lblahilersuvari.Text) * 70) + (double.Parse(abilerbilgi.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (abilerbilgi.lblahilerpiyade.Text == "0" && abilerbilgi.lblahilerokcu.Text == "0" && abilerbilgi.lblahilersipahi.Text == "0" && abilerbilgi.lblahilersuvari.Text == "0" && abilerbilgi.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 50000).ToString();
                            pbAhiler.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            MessageBox.Show("Tebrikler! Savaştan 50.000 Altın Ganimet Elde Ettiniz.");
                            lblAhiler.Text = "Oyuncu2";
                            btnOsman.Visible = true;
                            btnKaraman.Visible = true;
                            btnEretna.Visible = true;

                        }

                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion

            }
                else
                {
                    MessageBox.Show("Ahiler Zaten Elegeçirilmiş!");
                }

           

        }
        private void btnCanikK_Click(object sender, EventArgs e)
        {
            if (lblCanik.Text != "Oyuncu1" && lblCanik.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        canik.OrduDuzeni[0] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[0] = AskerSayisicanik((AskerTipleri)cmbcanik1.SelectedItem);
                        canik.OrduDuzeni[1] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[1] = AskerSayisicanik((AskerTipleri)cmbcanik2.SelectedItem);
                        canik.OrduDuzeni[2] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[2] = AskerSayisicanik((AskerTipleri)cmbcanik3.SelectedItem);
                        canik.OrduDuzeni[3] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[3] = AskerSayisicanik((AskerTipleri)cmbcanik4.SelectedItem);
                        canik.OrduDuzeni[4] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[4] = AskerSayisicanik((AskerTipleri)cmbcanik5.SelectedItem);

                        Savas(oyuncu1, canik);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Çanık Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbcanik1.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbcanik2.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbcanik3.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbcanik4.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbcanik5.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion

                        frmcanik.lblahilersg.Text = ((double.Parse(frmcanik.lblahilerpiyade.Text) * 20) + (double.Parse(frmcanik.lblahilerokcu.Text) * 25) + (double.Parse(frmcanik.lblahilersipahi.Text) * 40) + (double.Parse(frmcanik.lblahilersuvari.Text) * 70) + (double.Parse(frmcanik.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmcanik.lblahilerpiyade.Text == "0" && frmcanik.lblahilerokcu.Text == "0" && frmcanik.lblahilersipahi.Text == "0" && frmcanik.lblahilersuvari.Text == "0" && frmcanik.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 80000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 80.000 Altın Ganimet Elde Ettiniz.");
                            pbCanik.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblCanik.Text = "Oyuncu1";
                            btnTrabzon.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);


                        canik.OrduDuzeni[0] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[0] = AskerSayisicanik((AskerTipleri)cmbcanik1.SelectedItem);
                        canik.OrduDuzeni[1] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[1] = AskerSayisicanik((AskerTipleri)cmbcanik2.SelectedItem);
                        canik.OrduDuzeni[2] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[2] = AskerSayisicanik((AskerTipleri)cmbcanik3.SelectedItem);
                        canik.OrduDuzeni[3] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[3] = AskerSayisicanik((AskerTipleri)cmbcanik4.SelectedItem);
                        canik.OrduDuzeni[4] = (AskerTipleri)cmbcanik1.SelectedItem;
                        canik.AskerSayilari[4] = AskerSayisicanik((AskerTipleri)cmbcanik5.SelectedItem);

                        Savas(oyuncu2, canik);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Çanık Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbcanik1.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[0].ToString();
                        }

                        else if (cmbcanik1.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbcanik2.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[1].ToString();
                        }

                        else if (cmbcanik2.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbcanik3.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[2].ToString();
                        }

                        else if (cmbcanik3.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbcanik4.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[3].ToString();
                        }

                        else if (cmbcanik4.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbcanik5.Text == "Piyade")
                        {
                            frmcanik.lblahilerpiyade.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Okcu")
                        {
                            frmcanik.lblahilerokcu.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Sipahi")
                        {
                            frmcanik.lblahilersipahi.Text = canik.AskerSayilari[4].ToString();
                        }

                        else if (cmbcanik5.Text == "Suvari")
                        {
                            frmcanik.lblahilersuvari.Text = canik.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmcanik.lblahileryeniceri.Text = canik.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmcanik.lblahilersg.Text = ((double.Parse(frmcanik.lblahilerpiyade.Text) * 20) + (double.Parse(frmcanik.lblahilerokcu.Text) * 25) + (double.Parse(frmcanik.lblahilersipahi.Text) * 40) + (double.Parse(frmcanik.lblahilersuvari.Text) * 70) + (double.Parse(frmcanik.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmcanik.lblahilerpiyade.Text == "0" && frmcanik.lblahilerokcu.Text == "0" && frmcanik.lblahilersipahi.Text == "0" && frmcanik.lblahilersuvari.Text == "0" && frmcanik.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 80000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 80.000 Altın Ganimet Elde Ettiniz.");
                            pbCanik.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblCanik.Text = "Oyuncu2";
                            btnTrabzon.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Canik Zaten Elegeçirilmiş!");
            }
        }
       
        private void btnMenteseK_Click(object sender, EventArgs e)
        {
            if (lblMentese.Text != "Oyuncu1" && lblMentese.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region mentese Savaş Düzeni
                        mentese.OrduDuzeni[0] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[0] = AskerSayisimentese((AskerTipleri)cmbmentese1.SelectedItem);
                        mentese.OrduDuzeni[1] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[1] = AskerSayisimentese((AskerTipleri)cmbmentese2.SelectedItem);
                        mentese.OrduDuzeni[2] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[2] = AskerSayisimentese((AskerTipleri)cmbmentese3.SelectedItem);
                        mentese.OrduDuzeni[3] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[3] = AskerSayisimentese((AskerTipleri)cmbmentese4.SelectedItem);
                        mentese.OrduDuzeni[4] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[4] = AskerSayisimentese((AskerTipleri)cmbmentese5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, mentese);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Mentese Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbmentese1.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbmentese2.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbmentese3.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbmentese4.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbmentese5.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmmentese.lblahilersg.Text = ((double.Parse(frmmentese.lblahilerpiyade.Text) * 20) + (double.Parse(frmmentese.lblahilerokcu.Text) * 25) + (double.Parse(frmmentese.lblahilersipahi.Text) * 40) + (double.Parse(frmmentese.lblahilersuvari.Text) * 70) + (double.Parse(frmmentese.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmmentese.lblahilerpiyade.Text == "0" && frmmentese.lblahilerokcu.Text == "0" && frmmentese.lblahilersipahi.Text == "0" && frmmentese.lblahilersuvari.Text == "0" && frmmentese.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 50000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 50.000 Altın Ganimet Elde Ettiniz.");
                            pbMentese.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblMentese.Text = "Oyuncu1";
                            btnAydin.Visible = true;
                            btnHamit.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region mentese Savaş Düzeni
                        mentese.OrduDuzeni[0] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[0] = AskerSayisimentese((AskerTipleri)cmbmentese1.SelectedItem);
                        mentese.OrduDuzeni[1] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[1] = AskerSayisimentese((AskerTipleri)cmbmentese2.SelectedItem);
                        mentese.OrduDuzeni[2] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[2] = AskerSayisimentese((AskerTipleri)cmbmentese3.SelectedItem);
                        mentese.OrduDuzeni[3] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[3] = AskerSayisimentese((AskerTipleri)cmbmentese4.SelectedItem);
                        mentese.OrduDuzeni[4] = (AskerTipleri)cmbmentese1.SelectedItem;
                        mentese.AskerSayilari[4] = AskerSayisimentese((AskerTipleri)cmbmentese5.SelectedItem);
                        #endregion
                        

                        Savas(oyuncu2, mentese);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Mentese Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbmentese1.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else if (cmbmentese1.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbmentese2.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else if (cmbmentese2.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbmentese3.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else if (cmbmentese3.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbmentese4.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else if (cmbmentese4.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbmentese5.Text == "Piyade")
                        {
                            frmmentese.lblahilerpiyade.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Okcu")
                        {
                            frmmentese.lblahilerokcu.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Sipahi")
                        {
                            frmmentese.lblahilersipahi.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else if (cmbmentese5.Text == "Suvari")
                        {
                            frmmentese.lblahilersuvari.Text = mentese.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmmentese.lblahileryeniceri.Text = mentese.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmmentese.lblahilersg.Text = ((double.Parse(frmmentese.lblahilerpiyade.Text) * 20) + (double.Parse(frmmentese.lblahilerokcu.Text) * 25) + (double.Parse(frmmentese.lblahilersipahi.Text) * 40) + (double.Parse(frmmentese.lblahilersuvari.Text) * 70) + (double.Parse(frmmentese.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmmentese.lblahilerpiyade.Text == "0" && frmmentese.lblahilerokcu.Text == "0" && frmmentese.lblahilersipahi.Text == "0" && frmmentese.lblahilersuvari.Text == "0" && frmmentese.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 50000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 50.000 Altın Ganimet Elde Ettiniz.");
                            pbMentese.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblMentese.Text = "Oyuncu2";
                            btnAydin.Visible = true;
                            btnHamit.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Menteşe Zaten Elegeçirilmiş!");
            }
        }

        private void btnHamitK_Click(object sender, EventArgs e)
        {
            if (lblHamit.Text != "Oyuncu1" && lblHamit.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Hamit Savaş Düzeni
                        hamit.OrduDuzeni[0] = (AskerTipleri)cmbhamit1.SelectedItem;
                        hamit.AskerSayilari[0] = AskerSayisihamit((AskerTipleri)cmbhamit1.SelectedItem);
                        hamit.OrduDuzeni[1] = (AskerTipleri)cmbhamit2.SelectedItem;
                        hamit.AskerSayilari[1] = AskerSayisihamit((AskerTipleri)cmbhamit2.SelectedItem);
                        hamit.OrduDuzeni[2] = (AskerTipleri)cmbhamit3.SelectedItem;
                        hamit.AskerSayilari[2] = AskerSayisihamit((AskerTipleri)cmbhamit3.SelectedItem);
                        hamit.OrduDuzeni[3] = (AskerTipleri)cmbhamit4.SelectedItem;
                        hamit.AskerSayilari[3] = AskerSayisihamit((AskerTipleri)cmbhamit4.SelectedItem);
                        hamit.OrduDuzeni[4] = (AskerTipleri)cmbhamit5.SelectedItem;
                        hamit.AskerSayilari[4] = AskerSayisihamit((AskerTipleri)cmbhamit5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, hamit);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Hamit Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbhamit1.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbhamit2.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbhamit3.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbhamit4.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbhamit5.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmhamit.lblahilersg.Text = ((double.Parse(frmhamit.lblahilerpiyade.Text) * 20) + (double.Parse(frmhamit.lblahilerokcu.Text) * 25) + (double.Parse(frmhamit.lblahilersipahi.Text) * 40) + (double.Parse(frmhamit.lblahilersuvari.Text) * 70) + (double.Parse(frmhamit.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmhamit.lblahilerpiyade.Text == "0" && frmhamit.lblahilerokcu.Text == "0" && frmhamit.lblahilersipahi.Text == "0" && frmhamit.lblahilersuvari.Text == "0" && frmhamit.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 80000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 80.000 Altın Ganimet Elde Ettiniz.");
                            pbHamit.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblHamit.Text = "Oyuncu1";
                            btnMentese.Visible = true;
                            btnAydin.Visible = true;
                            btnGermiyan.Visible = true;
                            btnEsref.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Hamit Savaş Düzeni
                        hamit.OrduDuzeni[0] = (AskerTipleri)cmbhamit1.SelectedItem;
                        hamit.AskerSayilari[0] = AskerSayisihamit((AskerTipleri)cmbhamit1.SelectedItem);
                        hamit.OrduDuzeni[1] = (AskerTipleri)cmbhamit2.SelectedItem;
                        hamit.AskerSayilari[1] = AskerSayisihamit((AskerTipleri)cmbhamit2.SelectedItem);
                        hamit.OrduDuzeni[2] = (AskerTipleri)cmbhamit3.SelectedItem;
                        hamit.AskerSayilari[2] = AskerSayisihamit((AskerTipleri)cmbhamit3.SelectedItem);
                        hamit.OrduDuzeni[3] = (AskerTipleri)cmbhamit4.SelectedItem;
                        hamit.AskerSayilari[3] = AskerSayisihamit((AskerTipleri)cmbhamit4.SelectedItem);
                        hamit.OrduDuzeni[4] = (AskerTipleri)cmbhamit5.SelectedItem;
                        hamit.AskerSayilari[4] = AskerSayisihamit((AskerTipleri)cmbhamit5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, hamit);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Hamit Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbhamit1.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else if (cmbhamit1.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbhamit2.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else if (cmbhamit2.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbhamit3.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else if (cmbhamit3.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbhamit4.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else if (cmbhamit4.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbhamit5.Text == "Piyade")
                        {
                            frmhamit.lblahilerpiyade.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Okcu")
                        {
                            frmhamit.lblahilerokcu.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Sipahi")
                        {
                            frmhamit.lblahilersipahi.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else if (cmbhamit5.Text == "Suvari")
                        {
                            frmhamit.lblahilersuvari.Text = hamit.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmhamit.lblahileryeniceri.Text = hamit.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmhamit.lblahilersg.Text = ((double.Parse(frmhamit.lblahilerpiyade.Text) * 20) + (double.Parse(frmhamit.lblahilerokcu.Text) * 25) + (double.Parse(frmhamit.lblahilersipahi.Text) * 40) + (double.Parse(frmhamit.lblahilersuvari.Text) * 70) + (double.Parse(frmhamit.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmhamit.lblahilerpiyade.Text == "0" && frmhamit.lblahilerokcu.Text == "0" && frmhamit.lblahilersipahi.Text == "0" && frmhamit.lblahilersuvari.Text == "0" && frmhamit.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 80000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 80.000 Altın Ganimet Elde Ettiniz.");
                            pbHamit.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblHamit.Text = "Oyuncu2";
                            btnMentese.Visible = true;
                            btnAydin.Visible = true;
                            btnGermiyan.Visible = true;
                            btnEsref.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Hamit Zaten Elegeçirilmiş!");
            }
        }

        private void btnKaramanK_Click(object sender, EventArgs e)
        {
            if (lblKaraman.Text != "Oyuncu1" && lblKaraman.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Karaman Savaş Düzeni
                        karaman.OrduDuzeni[0] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[0] = AskerSayisikaraman((AskerTipleri)cmbkaraman1.SelectedItem);
                        karaman.OrduDuzeni[1] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[1] = AskerSayisikaraman((AskerTipleri)cmbkaraman2.SelectedItem);
                        karaman.OrduDuzeni[2] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[2] = AskerSayisikaraman((AskerTipleri)cmbkaraman3.SelectedItem);
                        karaman.OrduDuzeni[3] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[3] = AskerSayisikaraman((AskerTipleri)cmbkaraman4.SelectedItem);
                        karaman.OrduDuzeni[4] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[4] = AskerSayisikaraman((AskerTipleri)cmbkaraman5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, karaman);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Karaman Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkaraman1.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkaraman2.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkaraman3.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkaraman4.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkaraman5.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmkaraman.lblahilersg.Text = ((double.Parse(frmkaraman.lblahilerpiyade.Text) * 20) + (double.Parse(frmkaraman.lblahilerokcu.Text) * 25) + (double.Parse(frmkaraman.lblahilersipahi.Text) * 40) + (double.Parse(frmkaraman.lblahilersuvari.Text) * 70) + (double.Parse(frmkaraman.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkaraman.lblahilerpiyade.Text == "0" && frmkaraman.lblahilerokcu.Text == "0" && frmkaraman.lblahilersipahi.Text == "0" && frmkaraman.lblahilersuvari.Text == "0" && frmkaraman.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 140000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 140.000 Altın Ganimet Elde Ettiniz.");
                            pbKaraman.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblKaraman.Text = "Oyuncu1";
                            btnHamit.Visible = true;
                            btnGermiyan.Visible = true;
                            btnEsref.Visible = true;
                            btnOsman.Visible = true;
                            btnAhiler.Visible = true;
                            btnEretna.Visible = true;
                            btnRamazan.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Karaman Savaş Düzeni
                        karaman.OrduDuzeni[0] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[0] = AskerSayisikaraman((AskerTipleri)cmbkaraman1.SelectedItem);
                        karaman.OrduDuzeni[1] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[1] = AskerSayisikaraman((AskerTipleri)cmbkaraman2.SelectedItem);
                        karaman.OrduDuzeni[2] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[2] = AskerSayisikaraman((AskerTipleri)cmbkaraman3.SelectedItem);
                        karaman.OrduDuzeni[3] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[3] = AskerSayisikaraman((AskerTipleri)cmbkaraman4.SelectedItem);
                        karaman.OrduDuzeni[4] = (AskerTipleri)cmbkaraman1.SelectedItem;
                        karaman.AskerSayilari[4] = AskerSayisikaraman((AskerTipleri)cmbkaraman5.SelectedItem);
                        #endregion


                        Savas(oyuncu2,karaman);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Karaman Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkaraman1.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaraman1.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkaraman2.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaraman2.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkaraman3.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaraman3.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkaraman4.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaraman4.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkaraman5.Text == "Piyade")
                        {
                            frmkaraman.lblahilerpiyade.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Okcu")
                        {
                            frmkaraman.lblahilerokcu.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Sipahi")
                        {
                            frmkaraman.lblahilersipahi.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaraman5.Text == "Suvari")
                        {
                            frmkaraman.lblahilersuvari.Text = karaman.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkaraman.lblahileryeniceri.Text = karaman.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmkaraman.lblahilersg.Text = ((double.Parse(frmkaraman.lblahilerpiyade.Text) * 20) + (double.Parse(frmkaraman.lblahilerokcu.Text) * 25) + (double.Parse(frmkaraman.lblahilersipahi.Text) * 40) + (double.Parse(frmkaraman.lblahilersuvari.Text) * 70) + (double.Parse(frmkaraman.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkaraman.lblahilerpiyade.Text == "0" && frmkaraman.lblahilerokcu.Text == "0" && frmkaraman.lblahilersipahi.Text == "0" && frmkaraman.lblahilersuvari.Text == "0" && frmkaraman.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 140000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 140.000 Altın Ganimet Elde Ettiniz.");
                            pbKaraman.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblKaraman.Text = "Oyuncu2";
                            btnHamit.Visible = true;
                            btnGermiyan.Visible = true;
                            btnEsref.Visible = true;
                            btnOsman.Visible = true;
                            btnAhiler.Visible = true;
                            btnEretna.Visible = true;
                            btnRamazan.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Karaman Zaten Elegeçirilmiş!");
            }
        }
        
        private void btnEsrefK_Click(object sender, EventArgs e)
        {
            if (lblEsref.Text != "Oyuncu1" && lblEsref.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Eşref Savaş Düzeni
                        esref.OrduDuzeni[0] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[0] = AskerSayisiesref((AskerTipleri)cmbesref1.SelectedItem);
                        esref.OrduDuzeni[1] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[1] = AskerSayisiesref((AskerTipleri)cmbesref2.SelectedItem);
                        esref.OrduDuzeni[2] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[2] = AskerSayisiesref((AskerTipleri)cmbesref3.SelectedItem);
                        esref.OrduDuzeni[3] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[3] = AskerSayisiesref((AskerTipleri)cmbesref4.SelectedItem);
                        esref.OrduDuzeni[4] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[4] = AskerSayisiesref((AskerTipleri)cmbesref5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, esref);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Esref Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbesref1.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbesref2.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbesref3.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbesref4.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbesref5.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmesref.lblahilersg.Text = ((double.Parse(frmesref.lblahilerpiyade.Text) * 20) + (double.Parse(frmesref.lblahilerokcu.Text) * 25) + (double.Parse(frmesref.lblahilersipahi.Text) * 40) + (double.Parse(frmesref.lblahilersuvari.Text) * 70) + (double.Parse(frmesref.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();


                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmesref.lblahilerpiyade.Text == "0" && frmesref.lblahilerokcu.Text == "0" && frmesref.lblahilersipahi.Text == "0" && frmesref.lblahilersuvari.Text == "0" && frmesref.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 200000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 200.000 Altın Ganimet Elde Ettiniz.");
                            pbEsref.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblEsref.Text = "Oyuncu1";

                            btnHamit.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Eşref Savaş Düzeni
                        esref.OrduDuzeni[0] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[0] = AskerSayisiesref((AskerTipleri)cmbesref1.SelectedItem);
                        esref.OrduDuzeni[1] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[1] = AskerSayisiesref((AskerTipleri)cmbesref2.SelectedItem);
                        esref.OrduDuzeni[2] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[2] = AskerSayisiesref((AskerTipleri)cmbesref3.SelectedItem);
                        esref.OrduDuzeni[3] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[3] = AskerSayisiesref((AskerTipleri)cmbesref4.SelectedItem);
                        esref.OrduDuzeni[4] = (AskerTipleri)cmbesref1.SelectedItem;
                        esref.AskerSayilari[4] = AskerSayisiesref((AskerTipleri)cmbesref5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, esref);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Esref Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbesref1.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[0].ToString();
                        }

                        else if (cmbesref1.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbesref2.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[1].ToString();
                        }

                        else if (cmbesref2.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbesref3.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[2].ToString();
                        }

                        else if (cmbesref3.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbesref4.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[3].ToString();
                        }

                        else if (cmbesref4.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbesref5.Text == "Piyade")
                        {
                            frmesref.lblahilerpiyade.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Okcu")
                        {
                            frmesref.lblahilerokcu.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Sipahi")
                        {
                            frmesref.lblahilersipahi.Text = esref.AskerSayilari[4].ToString();
                        }

                        else if (cmbesref5.Text == "Suvari")
                        {
                            frmesref.lblahilersuvari.Text = esref.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmesref.lblahileryeniceri.Text = esref.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmesref.lblahilersg.Text = ((double.Parse(frmesref.lblahilerpiyade.Text) * 20) + (double.Parse(frmesref.lblahilerokcu.Text) * 25) + (double.Parse(frmesref.lblahilersipahi.Text) * 40) + (double.Parse(frmesref.lblahilersuvari.Text) * 70) + (double.Parse(frmesref.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmesref.lblahilerpiyade.Text == "0" && frmesref.lblahilerokcu.Text == "0" && frmesref.lblahilersipahi.Text == "0" && frmesref.lblahilersuvari.Text == "0" && frmesref.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 200000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 200.000 Altın Ganimet Elde Ettiniz.");
                            pbEsref.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblEsref.Text = "Oyuncu2";
                            btnHamit.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Eşref Zaten Elegeçirilmiş!");
            }
        }

        private void btnTrabzonK_Click(object sender, EventArgs e)
        {
            if (lblTrabzon.Text != "Oyuncu1" && lblTrabzon.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Trabzon Savaş Düzeni
                        trabzon.OrduDuzeni[0] = (AskerTipleri)cmbtrabzon1.SelectedItem;
                        trabzon.AskerSayilari[0] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon1.SelectedItem);
                        trabzon.OrduDuzeni[1] = (AskerTipleri)cmbtrabzon2.SelectedItem;
                        trabzon.AskerSayilari[1] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon2.SelectedItem);
                        trabzon.OrduDuzeni[2] = (AskerTipleri)cmbtrabzon3.SelectedItem;
                        trabzon.AskerSayilari[2] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon3.SelectedItem);
                        trabzon.OrduDuzeni[3] = (AskerTipleri)cmbtrabzon4.SelectedItem;
                        trabzon.AskerSayilari[3] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon4.SelectedItem);
                        trabzon.OrduDuzeni[4] = (AskerTipleri)cmbtrabzon5.SelectedItem;
                        trabzon.AskerSayilari[4] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, trabzon);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Trabzon Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbtrabzon1.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbtrabzon2.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbtrabzon3.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbtrabzon4.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbtrabzon5.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmtrabzon.lblahilersg.Text = ((double.Parse(frmtrabzon.lblahilerpiyade.Text) * 20) + (double.Parse(frmtrabzon.lblahilerokcu.Text) * 25) + (double.Parse(frmtrabzon.lblahilersipahi.Text) * 40) + (double.Parse(frmtrabzon.lblahilersuvari.Text) * 70) + (double.Parse(frmtrabzon.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmtrabzon.lblahilerpiyade.Text == "0" && frmtrabzon.lblahilerokcu.Text == "0" && frmtrabzon.lblahilersipahi.Text == "0" && frmtrabzon.lblahilersuvari.Text == "0" && frmtrabzon.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 210000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 210.000 Altın Ganimet Elde Ettiniz.");
                            pbTrabzon.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblTrabzon.Text = "Oyuncu1";
                            btnCanik.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Trabzon Savaş Düzeni
                        trabzon.OrduDuzeni[0] = (AskerTipleri)cmbtrabzon1.SelectedItem;
                        trabzon.AskerSayilari[0] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon1.SelectedItem);
                        trabzon.OrduDuzeni[1] = (AskerTipleri)cmbtrabzon2.SelectedItem;
                        trabzon.AskerSayilari[1] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon2.SelectedItem);
                        trabzon.OrduDuzeni[2] = (AskerTipleri)cmbtrabzon3.SelectedItem;
                        trabzon.AskerSayilari[2] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon3.SelectedItem);
                        trabzon.OrduDuzeni[3] = (AskerTipleri)cmbtrabzon4.SelectedItem;
                        trabzon.AskerSayilari[3] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon4.SelectedItem);
                        trabzon.OrduDuzeni[4] = (AskerTipleri)cmbtrabzon5.SelectedItem;
                        trabzon.AskerSayilari[4] = AskerSayisitrabzon((AskerTipleri)cmbtrabzon5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, trabzon);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Trabzon Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbtrabzon1.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else if (cmbtrabzon1.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbtrabzon2.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else if (cmbtrabzon2.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbtrabzon3.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else if (cmbtrabzon3.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbtrabzon4.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else if (cmbtrabzon4.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbtrabzon5.Text == "Piyade")
                        {
                            frmtrabzon.lblahilerpiyade.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Okcu")
                        {
                            frmtrabzon.lblahilerokcu.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Sipahi")
                        {
                            frmtrabzon.lblahilersipahi.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else if (cmbtrabzon5.Text == "Suvari")
                        {
                            frmtrabzon.lblahilersuvari.Text = trabzon.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmtrabzon.lblahileryeniceri.Text = trabzon.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmtrabzon.lblahilersg.Text = ((double.Parse(frmtrabzon.lblahilerpiyade.Text) * 20) + (double.Parse(frmtrabzon.lblahilerokcu.Text) * 25) + (double.Parse(frmtrabzon.lblahilersipahi.Text) * 40) + (double.Parse(frmtrabzon.lblahilersuvari.Text) * 70) + (double.Parse(frmtrabzon.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();


                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmtrabzon.lblahilerpiyade.Text == "0" && frmtrabzon.lblahilerokcu.Text == "0" && frmtrabzon.lblahilersipahi.Text == "0" && frmtrabzon.lblahilersuvari.Text == "0" && frmtrabzon.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 210000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 210.000 Altın Ganimet Elde Ettiniz.");
                            pbTrabzon.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblTrabzon.Text = "Oyuncu2";
                            btnCanik.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Trabzon Rum Zaten Elegeçirilmiş!");
            }
        }

        private void btnAydinK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblAydin.Text != "Oyuncu1" && lblAydin.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Aydın Savaş Düzeni
                        aydin.OrduDuzeni[0] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[0] = AskerSayisiaydin((AskerTipleri)cmbaydin1.SelectedItem);
                        aydin.OrduDuzeni[1] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[1] = AskerSayisiaydin((AskerTipleri)cmbaydin2.SelectedItem);
                        aydin.OrduDuzeni[2] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[2] = AskerSayisiaydin((AskerTipleri)cmbaydin3.SelectedItem);
                        aydin.OrduDuzeni[3] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[3] = AskerSayisiaydin((AskerTipleri)cmbaydin4.SelectedItem);
                        aydin.OrduDuzeni[4] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[4] = AskerSayisiaydin((AskerTipleri)cmbaydin5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, aydin);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Aydin Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbaydin1.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbaydin2.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbaydin3.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbaydin4.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbaydin5.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmaydin.lblahilersg.Text = ((double.Parse(frmaydin.lblahilerpiyade.Text) * 20) + (double.Parse(frmaydin.lblahilerokcu.Text) * 25) + (double.Parse(frmaydin.lblahilersipahi.Text) * 40) + (double.Parse(frmaydin.lblahilersuvari.Text) * 70) + (double.Parse(frmaydin.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmaydin.lblahilerpiyade.Text == "0" && frmaydin.lblahilerokcu.Text == "0" && frmaydin.lblahilersipahi.Text == "0" && frmaydin.lblahilersuvari.Text == "0" && frmaydin.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 300000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 300.000 Altın Ganimet Elde Ettiniz.");
                            pbAydin.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblAydin.Text = "Oyuncu1";
                            btnGermiyan.Visible = true;
                            btnHamit.Visible = true;
                            btnSaruhan.Visible = true;
                            btnMentese.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Aydın Savaş Düzeni
                        aydin.OrduDuzeni[0] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[0] = AskerSayisiaydin((AskerTipleri)cmbaydin1.SelectedItem);
                        aydin.OrduDuzeni[1] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[1] = AskerSayisiaydin((AskerTipleri)cmbaydin2.SelectedItem);
                        aydin.OrduDuzeni[2] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[2] = AskerSayisiaydin((AskerTipleri)cmbaydin3.SelectedItem);
                        aydin.OrduDuzeni[3] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[3] = AskerSayisiaydin((AskerTipleri)cmbaydin4.SelectedItem);
                        aydin.OrduDuzeni[4] = (AskerTipleri)cmbaydin1.SelectedItem;
                        aydin.AskerSayilari[4] = AskerSayisiaydin((AskerTipleri)cmbaydin5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, aydin);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Aydin Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (cmbaydin1.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else if (cmbaydin1.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbaydin2.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else if (cmbaydin2.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbaydin3.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else if (cmbaydin3.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbaydin4.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else if (cmbaydin4.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbaydin5.Text == "Piyade")
                        {
                            frmaydin.lblahilerpiyade.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Okcu")
                        {
                            frmaydin.lblahilerokcu.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Sipahi")
                        {
                            frmaydin.lblahilersipahi.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else if (cmbaydin5.Text == "Suvari")
                        {
                            frmaydin.lblahilersuvari.Text = aydin.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmaydin.lblahileryeniceri.Text = aydin.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmaydin.lblahilersg.Text = ((double.Parse(frmaydin.lblahilerpiyade.Text) * 20) + (double.Parse(frmaydin.lblahilerokcu.Text) * 25) + (double.Parse(frmaydin.lblahilersipahi.Text) * 40) + (double.Parse(frmaydin.lblahilersuvari.Text) * 70) + (double.Parse(frmaydin.lblahileryeniceri.Text) * 100)).ToString();


                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmaydin.lblahilerpiyade.Text == "0" && frmaydin.lblahilerokcu.Text == "0" && frmaydin.lblahilersipahi.Text == "0" && frmaydin.lblahilersuvari.Text == "0" && frmaydin.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 300000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 300.000 Altın Ganimet Elde Ettiniz.");
                            pbAydin.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblAydin.Text = "Oyuncu2";
                            btnGermiyan.Visible = true;
                            btnHamit.Visible = true;
                            btnSaruhan.Visible = true;
                            btnMentese.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Aydın Zaten Elegeçirilmiş!");
            }
        }

        private void btnEretnaK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblEretna.Text != "Oyuncu1" && lblEretna.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Eretna Savaş Düzeni
                        eretna.OrduDuzeni[0] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[0] = AskerSayisieretna((AskerTipleri)cmberetna1.SelectedItem);
                        eretna.OrduDuzeni[1] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[1] = AskerSayisieretna((AskerTipleri)cmberetna2.SelectedItem);
                        eretna.OrduDuzeni[2] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[2] = AskerSayisieretna((AskerTipleri)cmberetna3.SelectedItem);
                        eretna.OrduDuzeni[3] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[3] = AskerSayisieretna((AskerTipleri)cmberetna4.SelectedItem);
                        eretna.OrduDuzeni[4] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[4] = AskerSayisieretna((AskerTipleri)cmberetna5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, eretna);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Eretna Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmberetna1.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmberetna2.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmberetna3.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmberetna4.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmberetna5.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmeretna.lblahilersg.Text = ((double.Parse(frmeretna.lblahilerpiyade.Text) * 20) + (double.Parse(frmeretna.lblahilerokcu.Text) * 25) + (double.Parse(frmeretna.lblahilersipahi.Text) * 40) + (double.Parse(frmeretna.lblahilersuvari.Text) * 70) + (double.Parse(frmeretna.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmeretna.lblahilerpiyade.Text == "0" && frmeretna.lblahilerokcu.Text == "0" && frmeretna.lblahilersipahi.Text == "0" && frmeretna.lblahilersuvari.Text == "0" && frmeretna.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 300000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 300.000 Altın Ganimet Elde Ettiniz.");
                            pbEretna.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblEretna.Text = "Oyuncu1";
                            btnKaraman.Visible = true;
                            btnRamazan.Visible = true;
                            btnDulkadir.Visible = true;
                            btnTrabzon.Visible = true;
                            btnCanik.Visible = true;
                            btnAhiler.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Eretna Savaş Düzeni
                        eretna.OrduDuzeni[0] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[0] = AskerSayisieretna((AskerTipleri)cmberetna1.SelectedItem);
                        eretna.OrduDuzeni[1] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[1] = AskerSayisieretna((AskerTipleri)cmberetna2.SelectedItem);
                        eretna.OrduDuzeni[2] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[2] = AskerSayisieretna((AskerTipleri)cmberetna3.SelectedItem);
                        eretna.OrduDuzeni[3] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[3] = AskerSayisieretna((AskerTipleri)cmberetna4.SelectedItem);
                        eretna.OrduDuzeni[4] = (AskerTipleri)cmberetna1.SelectedItem;
                        eretna.AskerSayilari[4] = AskerSayisieretna((AskerTipleri)cmberetna5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, eretna);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Eretna Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmberetna1.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else if (cmberetna1.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmberetna2.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else if (cmberetna2.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmberetna3.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else if (cmberetna3.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmberetna4.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else if (cmberetna4.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmberetna5.Text == "Piyade")
                        {
                            frmeretna.lblahilerpiyade.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Okcu")
                        {
                            frmeretna.lblahilerokcu.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Sipahi")
                        {
                            frmeretna.lblahilersipahi.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else if (cmberetna5.Text == "Suvari")
                        {
                            frmeretna.lblahilersuvari.Text = eretna.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmeretna.lblahileryeniceri.Text = eretna.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmeretna.lblahilersg.Text = ((double.Parse(frmeretna.lblahilerpiyade.Text) * 20) + (double.Parse(frmeretna.lblahilerokcu.Text) * 25) + (double.Parse(frmeretna.lblahilersipahi.Text) * 40) + (double.Parse(frmeretna.lblahilersuvari.Text) * 70) + (double.Parse(frmeretna.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmeretna.lblahilerpiyade.Text == "0" && frmeretna.lblahilerokcu.Text == "0" && frmeretna.lblahilersipahi.Text == "0" && frmeretna.lblahilersuvari.Text == "0" && frmeretna.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 300000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 300.000 Altın Ganimet Elde Ettiniz.");
                            pbEretna.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblEretna.Text = "Oyuncu2";
                            btnKaraman.Visible = true;
                            btnRamazan.Visible = true;
                            btnDulkadir.Visible = true;
                            btnTrabzon.Visible = true;
                            btnCanik.Visible = true;
                            btnAhiler.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Eretna Zaten Elegeçirilmiş!");
            }
        }

        private void btnSaruhanK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblSaruhan.Text != "Oyuncu1" && lblSaruhan.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Saruhan Savaş Düzeni
                        saruhan.OrduDuzeni[0] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[0] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan1.SelectedItem);
                        saruhan.OrduDuzeni[1] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[1] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan2.SelectedItem);
                        saruhan.OrduDuzeni[2] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[2] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan3.SelectedItem);
                        saruhan.OrduDuzeni[3] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[3] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan4.SelectedItem);
                        saruhan.OrduDuzeni[4] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[4] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, saruhan);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Saruhan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbsaruhan1.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbsaruhan2.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbsaruhan3.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbsaruhan4.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbsaruhan5.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmsaruhan.lblahilersg.Text = ((double.Parse(frmsaruhan.lblahilerpiyade.Text) * 20) + (double.Parse(frmsaruhan.lblahilerokcu.Text) * 25) + (double.Parse(frmsaruhan.lblahilersipahi.Text) * 40) + (double.Parse(frmsaruhan.lblahilersuvari.Text) * 70) + (double.Parse(frmsaruhan.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmsaruhan.lblahilerpiyade.Text == "0" && frmsaruhan.lblahilerokcu.Text == "0" && frmsaruhan.lblahilersipahi.Text == "0" && frmsaruhan.lblahilersuvari.Text == "0" && frmsaruhan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 450000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 450.000 Altın Ganimet Elde Ettiniz.");
                            pbSaruhan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblSaruhan.Text = "Oyuncu1";
                            btnAydin.Visible = true;
                            btnGermiyan.Visible = true;
                            btnKaresi.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Saruhan Savaş Düzeni
                        saruhan.OrduDuzeni[0] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[0] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan1.SelectedItem);
                        saruhan.OrduDuzeni[1] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[1] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan2.SelectedItem);
                        saruhan.OrduDuzeni[2] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[2] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan3.SelectedItem);
                        saruhan.OrduDuzeni[3] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[3] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan4.SelectedItem);
                        saruhan.OrduDuzeni[4] = (AskerTipleri)cmbsaruhan1.SelectedItem;
                        saruhan.AskerSayilari[4] = AskerSayisisaruhan((AskerTipleri)cmbsaruhan5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, saruhan);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Saruhan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbsaruhan1.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else if (cmbsaruhan1.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbsaruhan2.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else if (cmbsaruhan2.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbsaruhan3.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else if (cmbsaruhan3.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbsaruhan4.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else if (cmbsaruhan4.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbsaruhan5.Text == "Piyade")
                        {
                            frmsaruhan.lblahilerpiyade.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Okcu")
                        {
                            frmsaruhan.lblahilerokcu.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Sipahi")
                        {
                            frmsaruhan.lblahilersipahi.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else if (cmbsaruhan5.Text == "Suvari")
                        {
                            frmsaruhan.lblahilersuvari.Text = saruhan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmsaruhan.lblahileryeniceri.Text = saruhan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmsaruhan.lblahilersg.Text = ((double.Parse(frmsaruhan.lblahilerpiyade.Text) * 20) + (double.Parse(frmsaruhan.lblahilerokcu.Text) * 25) + (double.Parse(frmsaruhan.lblahilersipahi.Text) * 40) + (double.Parse(frmsaruhan.lblahilersuvari.Text) * 70) + (double.Parse(frmsaruhan.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmsaruhan.lblahilerpiyade.Text == "0" && frmsaruhan.lblahilerokcu.Text == "0" && frmsaruhan.lblahilersipahi.Text == "0" && frmsaruhan.lblahilersuvari.Text == "0" && frmsaruhan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 450000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 450.000 Altın Ganimet Elde Ettiniz.");
                            pbSaruhan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblSaruhan.Text = "Oyuncu2";
                            btnAydin.Visible = true;
                            btnGermiyan.Visible = true;
                            btnKaresi.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Saruhan Zaten Elegeçirilmiş!");
            }
        }

        private void btnGermiyanK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblGermiyan.Text != "Oyuncu1" && lblGermiyan.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Germiyan Savaş Düzeni
                        germiyan.OrduDuzeni[0] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[0] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan1.SelectedItem);
                        germiyan.OrduDuzeni[1] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[1] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan2.SelectedItem);
                        germiyan.OrduDuzeni[2] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[2] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan3.SelectedItem);
                        germiyan.OrduDuzeni[3] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[3] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan4.SelectedItem);
                        germiyan.OrduDuzeni[4] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[4] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, germiyan);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Germiyan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbgermiyan1.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbgermiyan2.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbgermiyan3.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbgermiyan4.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbgermiyan5.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmgermiyan.lblahilersg.Text = ((double.Parse(frmgermiyan.lblahilerpiyade.Text) * 20) + (double.Parse(frmgermiyan.lblahilerokcu.Text) * 25) + (double.Parse(frmgermiyan.lblahilersipahi.Text) * 40) + (double.Parse(frmgermiyan.lblahilersuvari.Text) * 70) + (double.Parse(frmgermiyan.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmgermiyan.lblahilerpiyade.Text == "0" && frmgermiyan.lblahilerokcu.Text == "0" && frmgermiyan.lblahilersipahi.Text == "0" && frmgermiyan.lblahilersuvari.Text == "0" && frmgermiyan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 510000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 510.000 Altın Ganimet Elde Ettiniz.");
                            pbGermiyan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblGermiyan.Text = "Oyuncu1";
                            btnAydin.Visible = true;
                            btnOsman.Visible = true;
                            btnSaruhan.Visible = true;
                            btnKaresi.Visible = true;
                            btnHamit.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Germiyan Savaş Düzeni
                        germiyan.OrduDuzeni[0] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[0] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan1.SelectedItem);
                        germiyan.OrduDuzeni[1] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[1] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan2.SelectedItem);
                        germiyan.OrduDuzeni[2] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[2] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan3.SelectedItem);
                        germiyan.OrduDuzeni[3] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[3] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan4.SelectedItem);
                        germiyan.OrduDuzeni[4] = (AskerTipleri)cmbgermiyan1.SelectedItem;
                        germiyan.AskerSayilari[4] = AskerSayisigermiyan((AskerTipleri)cmbgermiyan5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, germiyan);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Germiyan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbgermiyan1.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else if (cmbgermiyan1.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbgermiyan2.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else if (cmbgermiyan2.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbgermiyan3.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else if (cmbgermiyan3.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbgermiyan4.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else if (cmbgermiyan4.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbgermiyan5.Text == "Piyade")
                        {
                            frmgermiyan.lblahilerpiyade.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Okcu")
                        {
                            frmgermiyan.lblahilerokcu.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Sipahi")
                        {
                            frmgermiyan.lblahilersipahi.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else if (cmbgermiyan5.Text == "Suvari")
                        {
                            frmgermiyan.lblahilersuvari.Text = germiyan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmgermiyan.lblahileryeniceri.Text = germiyan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmgermiyan.lblahilersg.Text = ((double.Parse(frmgermiyan.lblahilerpiyade.Text) * 20) + (double.Parse(frmgermiyan.lblahilerokcu.Text) * 25) + (double.Parse(frmgermiyan.lblahilersipahi.Text) * 40) + (double.Parse(frmgermiyan.lblahilersuvari.Text) * 70) + (double.Parse(frmgermiyan.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmgermiyan.lblahilerpiyade.Text == "0" && frmgermiyan.lblahilerokcu.Text == "0" && frmgermiyan.lblahilersipahi.Text == "0" && frmgermiyan.lblahilersuvari.Text == "0" && frmgermiyan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 510000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 510.000 Altın Ganimet Elde Ettiniz.");
                            pbGermiyan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblGermiyan.Text = "Oyuncu2";
                            btnAydin.Visible = true;
                            btnOsman.Visible = true;
                            btnSaruhan.Visible = true;
                            btnKaresi.Visible = true;
                            btnHamit.Visible = true;
                            btnKaraman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Germiyan Zaten Elegeçirilmiş!");
            }
        }

        private void btnRamazanK_Click(object sender, EventArgs e)
        {//Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

            if (lblRamazan.Text != "Oyuncu1" && lblRamazan.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Ramazan Savaş Düzeni
                        ramazan.OrduDuzeni[0] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[0] = AskerSayisiramazan((AskerTipleri)cmbramazan1.SelectedItem);
                        ramazan.OrduDuzeni[1] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[1] = AskerSayisiramazan((AskerTipleri)cmbramazan2.SelectedItem);
                        ramazan.OrduDuzeni[2] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[2] = AskerSayisiramazan((AskerTipleri)cmbramazan3.SelectedItem);
                        ramazan.OrduDuzeni[3] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[3] = AskerSayisiramazan((AskerTipleri)cmbramazan4.SelectedItem);
                        ramazan.OrduDuzeni[4] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[4] = AskerSayisiramazan((AskerTipleri)cmbramazan5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, ramazan);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Ramazan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbramazan1.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbramazan2.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbramazan3.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbramazan4.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbramazan5.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmramazan.lblahilersg.Text = ((double.Parse(frmramazan.lblahilerpiyade.Text) * 20) + (double.Parse(frmramazan.lblahilerokcu.Text) * 25) + (double.Parse(frmramazan.lblahilersipahi.Text) * 40) + (double.Parse(frmramazan.lblahilersuvari.Text) * 70) + (double.Parse(frmramazan.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmramazan.lblahilerpiyade.Text == "0" && frmramazan.lblahilerokcu.Text == "0" && frmramazan.lblahilersipahi.Text == "0" && frmramazan.lblahilersuvari.Text == "0" && frmramazan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 390000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 390.000 Altın Ganimet Elde Ettiniz.");
                            pbRamazan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblRamazan.Text = "Oyuncu1";
                            btnKaraman.Visible = true;
                            btnDulkadir.Visible = true;
                            btnKolemen.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Ramazan Savaş Düzeni
                        ramazan.OrduDuzeni[0] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[0] = AskerSayisiramazan((AskerTipleri)cmbramazan1.SelectedItem);
                        ramazan.OrduDuzeni[1] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[1] = AskerSayisiramazan((AskerTipleri)cmbramazan2.SelectedItem);
                        ramazan.OrduDuzeni[2] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[2] = AskerSayisiramazan((AskerTipleri)cmbramazan3.SelectedItem);
                        ramazan.OrduDuzeni[3] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[3] = AskerSayisiramazan((AskerTipleri)cmbramazan4.SelectedItem);
                        ramazan.OrduDuzeni[4] = (AskerTipleri)cmbramazan1.SelectedItem;
                        ramazan.AskerSayilari[4] = AskerSayisiramazan((AskerTipleri)cmbramazan5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, ramazan);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Ramazan Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbramazan1.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else if (cmbramazan1.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbramazan2.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else if (cmbramazan2.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbramazan3.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else if (cmbramazan3.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbramazan4.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else if (cmbramazan4.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbramazan5.Text == "Piyade")
                        {
                            frmramazan.lblahilerpiyade.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Okcu")
                        {
                            frmramazan.lblahilerokcu.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Sipahi")
                        {
                            frmramazan.lblahilersipahi.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else if (cmbramazan5.Text == "Suvari")
                        {
                            frmramazan.lblahilersuvari.Text = ramazan.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmramazan.lblahileryeniceri.Text = ramazan.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmramazan.lblahilersg.Text = ((double.Parse(frmramazan.lblahilerpiyade.Text) * 20) + (double.Parse(frmramazan.lblahilerokcu.Text) * 25) + (double.Parse(frmramazan.lblahilersipahi.Text) * 40) + (double.Parse(frmramazan.lblahilersuvari.Text) * 70) + (double.Parse(frmramazan.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmramazan.lblahilerpiyade.Text == "0" && frmramazan.lblahilerokcu.Text == "0" && frmramazan.lblahilersipahi.Text == "0" && frmramazan.lblahilersuvari.Text == "0" && frmramazan.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 390000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 390.000 Altın Ganimet Elde Ettiniz.");
                            pbRamazan.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblRamazan.Text = "Oyuncu2";
                            btnKaraman.Visible = true;
                            btnDulkadir.Visible = true;
                            btnKolemen.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Ramazan Zaten Elegeçirilmiş!");
            }
        }//Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

        private void btnDulkadirK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblDulkadir.Text != "Oyuncu1" && lblDulkadir.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Dulkadir Savaş Düzeni
                        dulkadir.OrduDuzeni[0] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[0] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir1.SelectedItem);
                        dulkadir.OrduDuzeni[1] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[1] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir2.SelectedItem);
                        dulkadir.OrduDuzeni[2] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[2] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir3.SelectedItem);
                        dulkadir.OrduDuzeni[3] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[3] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir4.SelectedItem);
                        dulkadir.OrduDuzeni[4] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[4] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, dulkadir);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Dulkadir Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbdulkadir1.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbdulkadir2.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbdulkadir3.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbdulkadir4.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbdulkadir5.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmdulkadir.lblahilersg.Text = ((double.Parse(frmdulkadir.lblahilerpiyade.Text) * 20) + (double.Parse(frmdulkadir.lblahilerokcu.Text) * 25) + (double.Parse(frmdulkadir.lblahilersipahi.Text) * 40) + (double.Parse(frmdulkadir.lblahilersuvari.Text) * 70) + (double.Parse(frmdulkadir.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmdulkadir.lblahilerpiyade.Text == "0" && frmdulkadir.lblahilerokcu.Text == "0" && frmdulkadir.lblahilersipahi.Text == "0" && frmdulkadir.lblahilersuvari.Text == "0" && frmdulkadir.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 600000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 600.000 Altın Ganimet Elde Ettiniz.");
                            pbDulkadir.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblDulkadir.Text = "Oyuncu1";
                            btnRamazan.Visible = true;
                            btnKolemen.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Dulkadir Savaş Düzeni
                        dulkadir.OrduDuzeni[0] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[0] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir1.SelectedItem);
                        dulkadir.OrduDuzeni[1] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[1] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir2.SelectedItem);
                        dulkadir.OrduDuzeni[2] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[2] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir3.SelectedItem);
                        dulkadir.OrduDuzeni[3] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[3] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir4.SelectedItem);
                        dulkadir.OrduDuzeni[4] = (AskerTipleri)cmbdulkadir1.SelectedItem;
                        dulkadir.AskerSayilari[4] = AskerSayisidulkadir((AskerTipleri)cmbdulkadir5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, dulkadir);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Dulkadir Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbdulkadir1.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else if (cmbdulkadir1.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbdulkadir2.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else if (cmbdulkadir2.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbdulkadir3.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else if (cmbdulkadir3.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbdulkadir4.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else if (cmbdulkadir4.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbdulkadir5.Text == "Piyade")
                        {
                            frmdulkadir.lblahilerpiyade.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Okcu")
                        {
                            frmdulkadir.lblahilerokcu.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Sipahi")
                        {
                            frmdulkadir.lblahilersipahi.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else if (cmbdulkadir5.Text == "Suvari")
                        {
                            frmdulkadir.lblahilersuvari.Text = dulkadir.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmdulkadir.lblahileryeniceri.Text = dulkadir.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmdulkadir.lblahilersg.Text = ((double.Parse(frmdulkadir.lblahilerpiyade.Text) * 20) + (double.Parse(frmdulkadir.lblahilerokcu.Text) * 25) + (double.Parse(frmdulkadir.lblahilersipahi.Text) * 40) + (double.Parse(frmdulkadir.lblahilersuvari.Text) * 70) + (double.Parse(frmdulkadir.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmdulkadir.lblahilerpiyade.Text == "0" && frmdulkadir.lblahilerokcu.Text == "0" && frmdulkadir.lblahilersipahi.Text == "0" && frmdulkadir.lblahilersuvari.Text == "0" && frmdulkadir.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 600000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 600.000 Altın Ganimet Elde Ettiniz.");
                            pbDulkadir.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblDulkadir.Text = "Oyuncu2";
                            btnRamazan.Visible = true;
                            btnKolemen.Visible = true;
                            btnEretna.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Dulkadir Zaten Elegeçirilmiş!");
            }
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }

        private void btnKolemenK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblKolemen.Text != "Oyuncu1" && lblKolemen.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Kolemen Savaş Düzeni
                        kolemen.OrduDuzeni[0] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[0] = AskerSayisikolemen((AskerTipleri)cmbkolemen1.SelectedItem);
                        kolemen.OrduDuzeni[1] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[1] = AskerSayisikolemen((AskerTipleri)cmbkolemen2.SelectedItem);
                        kolemen.OrduDuzeni[2] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[2] = AskerSayisikolemen((AskerTipleri)cmbkolemen3.SelectedItem);
                        kolemen.OrduDuzeni[3] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[3] = AskerSayisikolemen((AskerTipleri)cmbkolemen4.SelectedItem);
                        kolemen.OrduDuzeni[4] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[4] = AskerSayisikolemen((AskerTipleri)cmbkolemen5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, kolemen);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Kolemen Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkolemen1.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkolemen2.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkolemen3.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkolemen4.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkolemen5.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmkolemen.lblahilersg.Text = ((double.Parse(frmkolemen.lblahilerpiyade.Text) * 20) + (double.Parse(frmkolemen.lblahilerokcu.Text) * 25) + (double.Parse(frmkolemen.lblahilersipahi.Text) * 40) + (double.Parse(frmkolemen.lblahilersuvari.Text) * 70) + (double.Parse(frmkolemen.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkolemen.lblahilerpiyade.Text == "0" && frmkolemen.lblahilerokcu.Text == "0" && frmkolemen.lblahilersipahi.Text == "0" && frmkolemen.lblahilersuvari.Text == "0" && frmkolemen.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 1000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 1.000.000 Altın Ganimet Elde Ettiniz.");
                            pbKolemen.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblKolemen.Text = "Oyuncu1";
                            btnDulkadir.Visible = true;
                            btnRamazan.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Kolemen Savaş Düzeni
                        kolemen.OrduDuzeni[0] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[0] = AskerSayisikolemen((AskerTipleri)cmbkolemen1.SelectedItem);
                        kolemen.OrduDuzeni[1] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[1] = AskerSayisikolemen((AskerTipleri)cmbkolemen2.SelectedItem);
                        kolemen.OrduDuzeni[2] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[2] = AskerSayisikolemen((AskerTipleri)cmbkolemen3.SelectedItem);
                        kolemen.OrduDuzeni[3] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[3] = AskerSayisikolemen((AskerTipleri)cmbkolemen4.SelectedItem);
                        kolemen.OrduDuzeni[4] = (AskerTipleri)cmbkolemen1.SelectedItem;
                        kolemen.AskerSayilari[4] = AskerSayisikolemen((AskerTipleri)cmbkolemen5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, kolemen);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Kolemen Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkolemen1.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else if (cmbkolemen1.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkolemen2.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else if (cmbkolemen2.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkolemen3.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else if (cmbkolemen3.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkolemen4.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else if (cmbkolemen4.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkolemen5.Text == "Piyade")
                        {
                            frmkolemen.lblahilerpiyade.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Okcu")
                        {
                            frmkolemen.lblahilerokcu.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Sipahi")
                        {
                            frmkolemen.lblahilersipahi.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else if (cmbkolemen5.Text == "Suvari")
                        {
                            frmkolemen.lblahilersuvari.Text = kolemen.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkolemen.lblahileryeniceri.Text = kolemen.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmkolemen.lblahilersg.Text = ((double.Parse(frmkolemen.lblahilerpiyade.Text) * 20) + (double.Parse(frmkolemen.lblahilerokcu.Text) * 25) + (double.Parse(frmkolemen.lblahilersipahi.Text) * 40) + (double.Parse(frmkolemen.lblahilersuvari.Text) * 70) + (double.Parse(frmkolemen.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkolemen.lblahilerpiyade.Text == "0" && frmkolemen.lblahilerokcu.Text == "0" && frmkolemen.lblahilersipahi.Text == "0" && frmkolemen.lblahilersuvari.Text == "0" && frmkolemen.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 1000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 1.000.000 Altın Ganimet Elde Ettiniz.");
                            pbKolemen.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblKolemen.Text = "Oyuncu2";
                            btnDulkadir.Visible = true;
                            btnRamazan.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Kolemen Zaten Elegeçirilmiş!");
            }
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }

        private void btnKaresiK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblKaresi.Text != "Oyuncu1" && lblKaresi.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Karesi Savaş Düzeni
                        karesi.OrduDuzeni[0] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[0] = AskerSayisikaresi((AskerTipleri)cmbkaresi1.SelectedItem);
                        karesi.OrduDuzeni[1] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[1] = AskerSayisikaresi((AskerTipleri)cmbkaresi2.SelectedItem);
                        karesi.OrduDuzeni[2] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[2] = AskerSayisikaresi((AskerTipleri)cmbkaresi3.SelectedItem);
                        karesi.OrduDuzeni[3] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[3] = AskerSayisikaresi((AskerTipleri)cmbkaresi4.SelectedItem);
                        karesi.OrduDuzeni[4] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[4] = AskerSayisikaresi((AskerTipleri)cmbkaresi5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, karesi);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Karesi Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkaresi1.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkaresi2.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkaresi3.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkaresi4.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkaresi5.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmkaresi.lblahilersg.Text = ((double.Parse(frmkaresi.lblahilerpiyade.Text) * 20) + (double.Parse(frmkaresi.lblahilerokcu.Text) * 25) + (double.Parse(frmkaresi.lblahilersipahi.Text) * 40) + (double.Parse(frmkaresi.lblahilersuvari.Text) * 70) + (double.Parse(frmkaresi.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkaresi.lblahilerpiyade.Text == "0" && frmkaresi.lblahilerokcu.Text == "0" && frmkaresi.lblahilersipahi.Text == "0" && frmkaresi.lblahilersuvari.Text == "0" && frmkaresi.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 2000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 2.000.000 Altın Ganimet Elde Ettiniz.");
                            pbKaresi.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblKaresi.Text = "Oyuncu1";
                            btnGermiyan.Visible = true;
                            btnSaruhan.Visible = true;
                            btnOsman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Karesi Savaş Düzeni
                        karesi.OrduDuzeni[0] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[0] = AskerSayisikaresi((AskerTipleri)cmbkaresi1.SelectedItem);
                        karesi.OrduDuzeni[1] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[1] = AskerSayisikaresi((AskerTipleri)cmbkaresi2.SelectedItem);
                        karesi.OrduDuzeni[2] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[2] = AskerSayisikaresi((AskerTipleri)cmbkaresi3.SelectedItem);
                        karesi.OrduDuzeni[3] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[3] = AskerSayisikaresi((AskerTipleri)cmbkaresi4.SelectedItem);
                        karesi.OrduDuzeni[4] = (AskerTipleri)cmbkaresi1.SelectedItem;
                        karesi.AskerSayilari[4] = AskerSayisikaresi((AskerTipleri)cmbkaresi5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, karesi);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Karesi Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbkaresi1.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else if (cmbkaresi1.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbkaresi2.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else if (cmbkaresi2.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbkaresi3.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else if (cmbkaresi3.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbkaresi4.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else if (cmbkaresi4.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbkaresi5.Text == "Piyade")
                        {
                            frmkaresi.lblahilerpiyade.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Okcu")
                        {
                            frmkaresi.lblahilerokcu.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Sipahi")
                        {
                            frmkaresi.lblahilersipahi.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else if (cmbkaresi5.Text == "Suvari")
                        {
                            frmkaresi.lblahilersuvari.Text = karesi.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmkaresi.lblahileryeniceri.Text = karesi.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmkaresi.lblahilersg.Text = ((double.Parse(frmkaresi.lblahilerpiyade.Text) * 20) + (double.Parse(frmkaresi.lblahilerokcu.Text) * 25) + (double.Parse(frmkaresi.lblahilersipahi.Text) * 40) + (double.Parse(frmkaresi.lblahilersuvari.Text) * 70) + (double.Parse(frmkaresi.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmkaresi.lblahilerpiyade.Text == "0" && frmkaresi.lblahilerokcu.Text == "0" && frmkaresi.lblahilersipahi.Text == "0" && frmkaresi.lblahilersuvari.Text == "0" && frmkaresi.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 2000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 2.000.000 Altın Ganimet Elde Ettiniz.");
                            pbKaresi.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblKaresi.Text = "Oyuncu2";
                            btnGermiyan.Visible = true;
                            btnSaruhan.Visible = true;
                            btnOsman.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Karesi Zaten Elegeçirilmiş!");
            }
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }

        private void btnOsmanK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblOsman.Text != "Oyuncu1" && lblOsman.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Osmanli Savaş Düzeni
                        osmanli.OrduDuzeni[0] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[0] = AskerSayisiosmanli((AskerTipleri)cmbosmanli1.SelectedItem);
                        osmanli.OrduDuzeni[1] = (AskerTipleri)cmbosmanli2.SelectedItem;
                        osmanli.AskerSayilari[1] = AskerSayisiosmanli((AskerTipleri)cmbosmanli2.SelectedItem);
                        osmanli.OrduDuzeni[2] = (AskerTipleri)cmbosmanli3.SelectedItem;
                        osmanli.AskerSayilari[2] = AskerSayisiosmanli((AskerTipleri)cmbosmanli3.SelectedItem);
                        osmanli.OrduDuzeni[3] = (AskerTipleri)cmbosmanli4.SelectedItem;
                        osmanli.AskerSayilari[3] = AskerSayisiosmanli((AskerTipleri)cmbosmanli4.SelectedItem);
                        osmanli.OrduDuzeni[4] = (AskerTipleri)cmbosmanli5.SelectedItem;
                        osmanli.AskerSayilari[4] = AskerSayisiosmanli((AskerTipleri)cmbosmanli5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, osmanli);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Osman Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbosmanli1.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbosmanli2.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbosmanli3.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbosmanli4.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbosmanli5.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmosmanli.lblahilersg.Text = ((double.Parse(frmosmanli.lblahilerpiyade.Text) * 20) + (double.Parse(frmosmanli.lblahilerokcu.Text) * 25) + (double.Parse(frmosmanli.lblahilersipahi.Text) * 40) + (double.Parse(frmosmanli.lblahilersuvari.Text) * 70) + (double.Parse(frmosmanli.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmosmanli.lblahilerpiyade.Text == "0" && frmosmanli.lblahilerokcu.Text == "0" && frmosmanli.lblahilersipahi.Text == "0" && frmosmanli.lblahilersuvari.Text == "0" && frmosmanli.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 8000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 8.000.000 Altın Ganimet Elde Ettiniz.");
                            pbOsman.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblOsman.Text = "Oyuncu1";
                            btnBizans.Visible = true;
                            btnKaresi.Visible = true;
                            btnGermiyan.Visible = true;
                            btnKaraman.Visible = true;
                            btnAhiler.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Osman Savaş Düzeni
                        osmanli.OrduDuzeni[0] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[0] = AskerSayisiosmanli((AskerTipleri)cmbosmanli1.SelectedItem);
                        osmanli.OrduDuzeni[1] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[1] = AskerSayisiosmanli((AskerTipleri)cmbosmanli2.SelectedItem);
                        osmanli.OrduDuzeni[2] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[2] = AskerSayisiosmanli((AskerTipleri)cmbosmanli3.SelectedItem);
                        osmanli.OrduDuzeni[3] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[3] = AskerSayisiosmanli((AskerTipleri)cmbosmanli4.SelectedItem);
                        osmanli.OrduDuzeni[4] = (AskerTipleri)cmbosmanli1.SelectedItem;
                        osmanli.AskerSayilari[4] = AskerSayisiosmanli((AskerTipleri)cmbosmanli5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, osmanli);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Osman Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbosmanli1.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else if (cmbosmanli1.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbosmanli2.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else if (cmbosmanli2.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbosmanli3.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else if (cmbosmanli3.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbosmanli4.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else if (cmbosmanli4.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbosmanli5.Text == "Piyade")
                        {
                            frmosmanli.lblahilerpiyade.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Okcu")
                        {
                            frmosmanli.lblahilerokcu.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Sipahi")
                        {
                            frmosmanli.lblahilersipahi.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else if (cmbosmanli5.Text == "Suvari")
                        {
                            frmosmanli.lblahilersuvari.Text = osmanli.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmosmanli.lblahileryeniceri.Text = osmanli.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();
                        frmosmanli.lblahilersg.Text = ((double.Parse(frmosmanli.lblahilerpiyade.Text) * 20) + (double.Parse(frmosmanli.lblahilerokcu.Text) * 25) + (double.Parse(frmosmanli.lblahilersipahi.Text) * 40) + (double.Parse(frmosmanli.lblahilersuvari.Text) * 70) + (double.Parse(frmosmanli.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmosmanli.lblahilerpiyade.Text == "0" && frmosmanli.lblahilerokcu.Text == "0" && frmosmanli.lblahilersipahi.Text == "0" && frmosmanli.lblahilersuvari.Text == "0" && frmosmanli.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 8000000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 8.000.000 Altın Ganimet Elde Ettiniz.");
                            pbOsman.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblOsman.Text = "Oyuncu2";
                            btnBizans.Visible = true;
                            btnKaresi.Visible = true;
                            btnGermiyan.Visible = true;
                            btnKaraman.Visible = true;
                            btnAhiler.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Osmanoğulları Zaten Elegeçirilmiş!");
            }
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }

        private void btnBizansK_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            if (lblBizans.Text != "Oyuncu1" && lblBizans.Text != "Oyuncu2")
            {

                #region Oyuncu1Se
                if (label1.Text == "Oyuncu1")
                {
                    if (double.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Bizans Savaş Düzeni
                        bizans.OrduDuzeni[0] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[0] = AskerSayisibizans((AskerTipleri)cmbbizans1.SelectedItem);
                        bizans.OrduDuzeni[1] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[1] = AskerSayisibizans((AskerTipleri)cmbbizans2.SelectedItem);
                        bizans.OrduDuzeni[2] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[2] = AskerSayisibizans((AskerTipleri)cmbbizans3.SelectedItem);
                        bizans.OrduDuzeni[3] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[3] = AskerSayisibizans((AskerTipleri)cmbbizans4.SelectedItem);
                        bizans.OrduDuzeni[4] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[4] = AskerSayisibizans((AskerTipleri)cmbbizans5.SelectedItem);
                        #endregion

                        Savas(oyuncu1, bizans);
                        #region Oyuncu1 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox1.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox1.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox2.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox2.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox3.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox3.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox4.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox4.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox5.Text == "Piyade")
                        {
                            frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Okcu")
                        {
                            frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox5.Text == "Suvari")
                        {
                            frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Bizans Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbbizans1.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbbizans2.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbbizans3.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbbizans4.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbbizans5.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmoyuncu1.lbl1sg.Text = ((double.Parse(frmoyuncu1.lbl1piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl1okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl1sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl1suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl1yeniceri.Text) * 100)).ToString();
                        frmbizans.lblahilersg.Text = ((double.Parse(frmbizans.lblahilerpiyade.Text) * 20) + (double.Parse(frmbizans.lblahilerokcu.Text) * 25) + (double.Parse(frmbizans.lblahilersipahi.Text) * 40) + (double.Parse(frmbizans.lblahilersuvari.Text) * 70) + (double.Parse(frmbizans.lblahileryeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmbizans.lblahilerpiyade.Text == "0" && frmbizans.lblahilerokcu.Text == "0" && frmbizans.lblahilersipahi.Text == "0" && frmbizans.lblahilersuvari.Text == "0" && frmbizans.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl1para.Text = (double.Parse(frmoyuncu1.lbl1para.Text) + 4500000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 4.500.000 Altın Ganimet Elde Ettiniz.");
                            pbBizans.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                            lblBizans.Text = "Oyuncu1";
                            btnUstteki.Visible = true;
                            btnAlttaki.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                #endregion
                #region Oyuncu2Se
                else
                {
                    if (double.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Bizans Savaş Düzeni
                        bizans.OrduDuzeni[0] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[0] = AskerSayisibizans((AskerTipleri)cmbbizans1.SelectedItem);
                        bizans.OrduDuzeni[1] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[1] = AskerSayisibizans((AskerTipleri)cmbbizans2.SelectedItem);
                        bizans.OrduDuzeni[2] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[2] = AskerSayisibizans((AskerTipleri)cmbbizans3.SelectedItem);
                        bizans.OrduDuzeni[3] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[3] = AskerSayisibizans((AskerTipleri)cmbbizans4.SelectedItem);
                        bizans.OrduDuzeni[4] = (AskerTipleri)cmbbizans1.SelectedItem;
                        bizans.AskerSayilari[4] = AskerSayisibizans((AskerTipleri)cmbbizans5.SelectedItem);
                        #endregion


                        Savas(oyuncu2, bizans);
                        #region Oyuncu2 Asker Güncellemisi
                        #region AskerSayiları[0]
                        if (frmoyuncu1.comboBox10.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else if (frmoyuncu1.comboBox10.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (frmoyuncu1.comboBox9.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else if (frmoyuncu1.comboBox9.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (frmoyuncu1.comboBox8.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else if (frmoyuncu1.comboBox8.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (frmoyuncu1.comboBox7.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else if (frmoyuncu1.comboBox7.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (frmoyuncu1.comboBox6.Text == "Piyade")
                        {
                            frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Okcu")
                        {
                            frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                        {
                            frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else if (frmoyuncu1.comboBox6.Text == "Suvari")
                        {
                            frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        #region Bizans Asker Güncellemisi

                        #region AskerSayiları[0]
                        if (cmbbizans1.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else if (cmbbizans1.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[0].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[0].ToString();
                        }
                        #endregion
                        #region AskerSayiları[1]
                        if (cmbbizans2.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else if (cmbbizans2.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[1].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[1].ToString();
                        }
                        #endregion
                        #region AskerSayiları[2]
                        if (cmbbizans3.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else if (cmbbizans3.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[2].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[2].ToString();
                        }
                        #endregion
                        #region AskerSayiları[3]
                        if (cmbbizans4.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else if (cmbbizans4.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[3].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[3].ToString();
                        }
                        #endregion
                        #region AskerSayiları[4]
                        if (cmbbizans5.Text == "Piyade")
                        {
                            frmbizans.lblahilerpiyade.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Okcu")
                        {
                            frmbizans.lblahilerokcu.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Sipahi")
                        {
                            frmbizans.lblahilersipahi.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else if (cmbbizans5.Text == "Suvari")
                        {
                            frmbizans.lblahilersuvari.Text = bizans.AskerSayilari[4].ToString();
                        }

                        else
                        {
                            frmbizans.lblahileryeniceri.Text = bizans.AskerSayilari[4].ToString();
                        }
                        #endregion
                        #endregion
                        frmbizans.lblahilersg.Text = ((double.Parse(frmbizans.lblahilerpiyade.Text) * 20) + (double.Parse(frmbizans.lblahilerokcu.Text) * 25) + (double.Parse(frmbizans.lblahilersipahi.Text) * 40) + (double.Parse(frmbizans.lblahilersuvari.Text) * 70) + (double.Parse(frmbizans.lblahileryeniceri.Text) * 100)).ToString();
                        frmoyuncu1.lbl2sg.Text = ((double.Parse(frmoyuncu1.lbl2piyade.Text) * 20) + (double.Parse(frmoyuncu1.lbl2okcu.Text) * 25) + (double.Parse(frmoyuncu1.lbl2sipahi.Text) * 40) + (double.Parse(frmoyuncu1.lbl2suvari.Text) * 70) + (double.Parse(frmoyuncu1.lbl2yeniceri.Text) * 100)).ToString();

                        frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                        MessageBox.Show("Kervansaraylardan " + (double.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                        if (frmbizans.lblahilerpiyade.Text == "0" && frmbizans.lblahilerokcu.Text == "0" && frmbizans.lblahilersipahi.Text == "0" && frmbizans.lblahilersuvari.Text == "0" && frmbizans.lblahileryeniceri.Text == "0")
                        {
                            frmoyuncu1.lbl2para.Text = (double.Parse(frmoyuncu1.lbl2para.Text) + 4500000).ToString();
                            MessageBox.Show("Tebrikler! Savaştan 4.500.000 Altın Ganimet Elde Ettiniz.");
                            pbBizans.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                            lblBizans.Text = "Oyuncu2";
                            btnUstteki.Visible = true;
                            btnAlttaki.Visible = true;

                        }


                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                #endregion
                }
            }
            else
            {
                MessageBox.Show("Bizans Zaten Elegeçirilmiş!");
            }
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        }

        private void btnCanik_Click(object sender, EventArgs e)
        {
            frmcanik.ShowDialog();
        }

        private void btnTrabzon_Click(object sender, EventArgs e)
        {
            frmtrabzon.ShowDialog();
        }

        private void btnEretna_Click(object sender, EventArgs e)
        {
            frmeretna.ShowDialog();
        }

        private void btnDulkadir_Click(object sender, EventArgs e)
        {
            frmdulkadir.ShowDialog();
        }

        private void btnKolemen_Click(object sender, EventArgs e)
        {
            frmkolemen.ShowDialog();
        }

        private void btnRamazan_Click(object sender, EventArgs e)
        {
            frmramazan.ShowDialog();
        }

        private void btnKaraman_Click(object sender, EventArgs e)
        {
            frmkaraman.ShowDialog();
        }

        private void btnHamit_Click(object sender, EventArgs e)
        {
            frmhamit.ShowDialog();
        }

        private void btnEsref_Click(object sender, EventArgs e)
        {
            frmesref.ShowDialog();
        }

        private void btnGermiyan_Click(object sender, EventArgs e)
        {
            frmgermiyan.ShowDialog();
        }

        private void btnOsman_Click(object sender, EventArgs e)
        {
            frmosmanli.ShowDialog();
        }

        private void btnMentese_Click(object sender, EventArgs e)
        {
            frmmentese.ShowDialog();
        }

        private void btnAydin_Click(object sender, EventArgs e)
        {
            frmaydin.ShowDialog();
        }

        private void btnSaruhan_Click(object sender, EventArgs e)
        {
            frmsaruhan.ShowDialog();
        }

        private void btnKaresi_Click(object sender, EventArgs e)
        {
            frmkaresi.ShowDialog();
        }

        private void btnBizans_Click(object sender, EventArgs e)
        {
            frmbizans.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //frmoyuncu1.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (label1.Text=="Oyuncu1")
            {
                if (lblo1Hak.Text == 0.ToString())
                {
                    lblo1Hak.Text = 1.ToString();
                    lblo2Hak.Text = 0.ToString();
                    frmoyuncu1.lbl1para.Text =  (int.Parse(frmoyuncu1.lbl1para.Text)+(int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                    MessageBox.Show("Kervansaraylardan " +(int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)+" Altın Elde Ettiniz.");
                }
                else
                {
                    MessageBox.Show("Zaten Pas Geçmişsiniz veya Savaşmışsınız!");
                }

               
            }

            if (label1.Text == "Oyuncu2")
            {

                if (lblo2Hak.Text == 0.ToString())
                {
                    lblo1Hak.Text = 0.ToString();
                    lblo2Hak.Text = 1.ToString();
                    frmoyuncu1.lbl2para.Text = (int.Parse(frmoyuncu1.lbl2para.Text) + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                    MessageBox.Show("Kervansaraylardan " + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");
                }
                else
                {
                    MessageBox.Show("Zaten Pas Geçmişsiniz veya Savaşmışsınız!");
                }
                
             
            }
        }

        private void btnUstteki_Click(object sender, EventArgs e)
        {
            #region Oyuncu1Se
            if (label1.Text == "Oyuncu1")
            {

                if (lblUstteki.Text != "Oyuncu1")
                {

                    if (int.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Oyuncu2 Savaş Düzeni
                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);
                        #endregion
                        MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu2 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);
                        DialogResult sonuc;
                        sonuc = MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu2 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);

                        if (sonuc == DialogResult.Yes)
                        {
                            Savas(oyuncu1, oyuncu2);
                            #region Oyuncu1 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox1.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox2.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox3.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox4.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox5.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion
                            #region Oyuncu2 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox10.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox9.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox8.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox7.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox6.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion


                            frmoyuncu1.lbl1para.Text = (int.Parse(frmoyuncu1.lbl1para.Text) + (int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                            MessageBox.Show("Kervansaraylardan " + (int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                            if (frmoyuncu1.lbl2piyade.Text == "0" && frmoyuncu1.lbl2okcu.Text == "0" && frmoyuncu1.lbl2sipahi.Text == "0" && frmoyuncu1.lbl2suvari.Text == "0" && frmoyuncu1.lbl2yeniceri.Text == "0")
                            {

                                frmoyuncu1.lbl1para.Text = ((int.Parse(frmoyuncu1.lbl1para.Text)) + (int.Parse(frmoyuncu1.lbl2para.Text))).ToString();
                                MessageBox.Show("Tebrikler! Savaştan" + frmoyuncu1.lbl2para.Text + "Altın Ganimet Elde Ettiniz.");
                                frmoyuncu1.lbl2kervansaray.Text = "0";
                                frmoyuncu1.lbl2para.Text = "0";
                                pbUstteki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                                lblUstteki.Text = "Oyuncu1";
                                MessageBox.Show("Oyunu Oyuncu1 Kazandı Tebrikler...");

                            }
                        }

                        else
                        {

                        }

                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                else MessageBox.Show("Kendinize Saldıramazsınız!");
            }
            #endregion
            #region Oyuncu2Se
            else
            {
                if (lblUstteki.Text != "Oyuncu2")
                {

                    if (int.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Oyuncu1 Savaş Düzeni
                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);
                        #endregion

                        MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu1 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);
                        DialogResult sonuc;
                        sonuc = MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu1 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);

                        if (sonuc == DialogResult.Yes)
                        {
                            Savas(oyuncu2, oyuncu1);
                            #region Oyuncu2 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox10.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox9.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox8.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox7.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox6.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion
                            #region Oyuncu1 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox1.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox2.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox3.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox4.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox5.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion


                            frmoyuncu1.lbl2para.Text = (int.Parse(frmoyuncu1.lbl2para.Text) + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                            MessageBox.Show("Kervansaraylardan " + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                            if (frmoyuncu1.lbl1piyade.Text == "0" && frmoyuncu1.lbl1okcu.Text == "0" && frmoyuncu1.lbl1sipahi.Text == "0" && frmoyuncu1.lbl1suvari.Text == "0" && frmoyuncu1.lbl1yeniceri.Text == "0")
                            {

                                frmoyuncu1.lbl2para.Text = ((int.Parse(frmoyuncu1.lbl2para.Text) + int.Parse(frmoyuncu1.lbl1para.Text))).ToString();

                                MessageBox.Show("Tebrikler! Savaştan " + frmoyuncu1.lbl1para.Text + "Altın Ganimet Elde Ettiniz.");
                                frmoyuncu1.lbl1kervansaray.Text = "0";
                                frmoyuncu1.lbl1para.Text = "0";
                                pbUstteki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                                lblUstteki.Text = "Oyuncu2";
                                MessageBox.Show("Oyunu Oyuncu2 Kazandı Tebrikler...");

                            }

                        }
                        else
                        {

                        }
                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");

                }

                else MessageBox.Show("Kendinize saldıramazsınız!");



            #endregion
            }
        }

        private void btnAlttaki_Click(object sender, EventArgs e)
        {
            #region Oyuncu1Se
            if (label1.Text == "Oyuncu1")
            {

                if (lblAlttaki.Text != "Oyuncu1")
                {

                    if (int.Parse(lblo1Hak.Text) == 0)
                    {
                        lblo1Hak.Text = 1.ToString();
                        lblo2Hak.Text = 0.ToString();


                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);


                        #region Oyuncu2 Savaş Düzeni
                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);
                        #endregion
                        MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu2 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);
                        DialogResult sonuc;
                        sonuc = MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu2 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);

                        if (sonuc == DialogResult.Yes)
                        {
                            Savas(oyuncu1, oyuncu2);
                            #region Oyuncu1 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox1.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox2.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox3.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox4.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox5.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion
                            #region Oyuncu2 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox10.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox9.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox8.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox7.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox6.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion


                            frmoyuncu1.lbl1para.Text = (int.Parse(frmoyuncu1.lbl1para.Text) + (int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000)).ToString();
                            MessageBox.Show("Kervansaraylardan " + (int.Parse(frmoyuncu1.lbl1kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                            if (frmoyuncu1.lbl2piyade.Text == "0" && frmoyuncu1.lbl2okcu.Text == "0" && frmoyuncu1.lbl2sipahi.Text == "0" && frmoyuncu1.lbl2suvari.Text == "0" && frmoyuncu1.lbl2yeniceri.Text == "0")
                            {

                                frmoyuncu1.lbl1para.Text = ((int.Parse(frmoyuncu1.lbl1para.Text)) + (int.Parse(frmoyuncu1.lbl2para.Text))).ToString();
                                MessageBox.Show("Tebrikler! Savaştan" + frmoyuncu1.lbl2para.Text + "Altın Ganimet Elde Ettiniz.");
                                frmoyuncu1.lbl2kervansaray.Text = "0";
                                frmoyuncu1.lbl2para.Text = "0";
                                pbAlttaki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_1;
                                lblAlttaki.Text = "Oyuncu1";
                                MessageBox.Show("Oyunu Oyuncu1 Kazandı Tebrikler...");

                            }
                        }

                        else
                        {

                        }

                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");
                }
                else MessageBox.Show("Kendinize Saldıramazsınız!");
            }
            #endregion
            #region Oyuncu2Se
            else
            {
                if (lblAlttaki.Text != "Oyuncu2")
                {

                    if (int.Parse(lblo2Hak.Text) == 0)
                    {
                        lblo2Hak.Text = 1.ToString();
                        lblo1Hak.Text = 0.ToString();

                        oyuncu2.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox10.SelectedItem;
                        oyuncu2.AskerSayilari[0] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox10.SelectedItem);
                        oyuncu2.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox9.SelectedItem;
                        oyuncu2.AskerSayilari[1] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox9.SelectedItem);
                        oyuncu2.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox8.SelectedItem;
                        oyuncu2.AskerSayilari[2] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox8.SelectedItem);
                        oyuncu2.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox7.SelectedItem;
                        oyuncu2.AskerSayilari[3] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox7.SelectedItem);
                        oyuncu2.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox6.SelectedItem;
                        oyuncu2.AskerSayilari[4] = AskerSayisi2((AskerTipleri)frmoyuncu1.comboBox6.SelectedItem);

                        #region Oyuncu1 Savaş Düzeni
                        oyuncu1.OrduDuzeni[0] = (AskerTipleri)frmoyuncu1.comboBox1.SelectedItem;
                        oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox1.SelectedItem);
                        oyuncu1.OrduDuzeni[1] = (AskerTipleri)frmoyuncu1.comboBox2.SelectedItem;
                        oyuncu1.AskerSayilari[1] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox2.SelectedItem);
                        oyuncu1.OrduDuzeni[2] = (AskerTipleri)frmoyuncu1.comboBox3.SelectedItem;
                        oyuncu1.AskerSayilari[2] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox3.SelectedItem);
                        oyuncu1.OrduDuzeni[3] = (AskerTipleri)frmoyuncu1.comboBox4.SelectedItem;
                        oyuncu1.AskerSayilari[3] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox4.SelectedItem);
                        oyuncu1.OrduDuzeni[4] = (AskerTipleri)frmoyuncu1.comboBox5.SelectedItem;
                        oyuncu1.AskerSayilari[4] = AskerSayisi((AskerTipleri)frmoyuncu1.comboBox5.SelectedItem);
                        #endregion

                        MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu1 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);
                        DialogResult sonuc;
                        sonuc = MessageBox.Show("Savaşmak İstiyor Musunuz?", "Oyuncu1 'nin askerini görmeden direk savaşılacak. Savaşmak istiyor musunuz?", MessageBoxButtons.YesNo);

                        if (sonuc == DialogResult.Yes)
                        {
                            Savas(oyuncu2, oyuncu1);
                            #region Oyuncu2 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox10.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox10.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox9.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox9.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox8.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox8.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox7.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox7.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox6.Text == "Piyade")
                            {
                                frmoyuncu1.lbl2piyade.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Okcu")
                            {
                                frmoyuncu1.lbl2okcu.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl2sipahi.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox6.Text == "Suvari")
                            {
                                frmoyuncu1.lbl2suvari.Text = oyuncu2.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl2yeniceri.Text = oyuncu2.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion
                            #region Oyuncu1 Asker Güncellemisi
                            #region AskerSayiları[0]
                            if (frmoyuncu1.comboBox1.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else if (frmoyuncu1.comboBox1.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[0].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[0].ToString();
                            }
                            #endregion
                            #region AskerSayiları[1]
                            if (frmoyuncu1.comboBox2.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else if (frmoyuncu1.comboBox2.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[1].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[1].ToString();
                            }
                            #endregion
                            #region AskerSayiları[2]
                            if (frmoyuncu1.comboBox3.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else if (frmoyuncu1.comboBox3.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[2].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[2].ToString();
                            }
                            #endregion
                            #region AskerSayiları[3]
                            if (frmoyuncu1.comboBox4.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else if (frmoyuncu1.comboBox4.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[3].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[3].ToString();
                            }
                            #endregion
                            #region AskerSayiları[4]
                            if (frmoyuncu1.comboBox5.Text == "Piyade")
                            {
                                frmoyuncu1.lbl1piyade.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Okcu")
                            {
                                frmoyuncu1.lbl1okcu.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Sipahi")
                            {
                                frmoyuncu1.lbl1sipahi.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else if (frmoyuncu1.comboBox5.Text == "Suvari")
                            {
                                frmoyuncu1.lbl1suvari.Text = oyuncu1.AskerSayilari[4].ToString();
                            }

                            else
                            {
                                frmoyuncu1.lbl1yeniceri.Text = oyuncu1.AskerSayilari[4].ToString();
                            }
                            #endregion
                            #endregion


                            frmoyuncu1.lbl2para.Text = (int.Parse(frmoyuncu1.lbl2para.Text) + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000)).ToString();
                            MessageBox.Show("Kervansaraylardan " + (int.Parse(frmoyuncu1.lbl2kervansaray.Text) * 2000) + " Altın Elde Ettiniz.");

                            if (frmoyuncu1.lbl1piyade.Text == "0" && frmoyuncu1.lbl1okcu.Text == "0" && frmoyuncu1.lbl1sipahi.Text == "0" && frmoyuncu1.lbl1suvari.Text == "0" && frmoyuncu1.lbl1yeniceri.Text == "0")
                            {

                                frmoyuncu1.lbl2para.Text = ((int.Parse(frmoyuncu1.lbl2para.Text) + int.Parse(frmoyuncu1.lbl1para.Text))).ToString();

                                MessageBox.Show("Tebrikler! Savaştan " + frmoyuncu1.lbl1para.Text + "Altın Ganimet Elde Ettiniz.");
                                frmoyuncu1.lbl1kervansaray.Text = "0";
                                frmoyuncu1.lbl1para.Text = "0";
                                pbAlttaki.BackgroundImage = Beylik_Savaşları.Properties.Resources.Oyuncu_2;
                                lblAlttaki.Text = "Oyuncu2";
                                MessageBox.Show("Oyunu Oyuncu2 Kazandı Tebrikler...");

                            }

                        }
                        else
                        {

                        }
                    }

                    else MessageBox.Show("Her el 1 kere savaşabilirsiniz. Lütfen diğer oyuncununda savaşmasını bekleyin.");

                }

                else MessageBox.Show("Kendinize saldıramazsınız!");



            #endregion
            }
        }

     






    }
}
