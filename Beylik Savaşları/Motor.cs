using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beylik_Savaşları
{
 
    class Motor
    {
        public frmHarita hrt;
        public Form1 frmoyuncu1;
       
       
        protected static Dictionary<AskerTipleri, Dictionary<AskerTipleri, double>> gucMatrisi = new Dictionary<AskerTipleri, Dictionary<AskerTipleri, double>>();


       
        public double AskerSayisi(AskerTipleri secileno1)
        {
            switch (secileno1)
            {
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
                case AskerTipleri.Okcu: return   300;
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

        int x, x2,x3,x4,x5,y,y2,y3,y4,y5;
        public void Main(string[] args)
        {
           
            // işte senin elle belirlemen gereken (kafanda zaten oluşturduğun) tablo aşağıda..
            // bu tabloyu bir kere oluşturduğunda kodunda döngüleri kullanarak güzelce savaştırabilirsin askerleri..
            // tabi kullanıcının verdiği bilgileri de güzelce tanımlayacaksın, örneğini aşağıda vereceğim..
            // aşağıdaki şunun gücü şu kadardır kısımlarını sen doğru değerlerle doldurursun. 
            // ben hepsinin birbirine karşı aynı güçte olduğunu varsaydım..

            // bu tablonun tutarlı doldurulması çook çok önemli.. yani Okcu-Piyade 2 ise, Piyade-Okcu 0.5 olmalı.. doğal olarak ;
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


            // sen şimdi buraları comboboxlardan sırasıyla dolduracaksın.. 
            // (combobox lara bu asker tipleri enum unu bind edebilirsin..)
            // örneğin : 
     //comboBox1.DataSource = Enum.GetValues(typeof(AskerTipleri));
            // okurken de değeri :
            // AskerTipleri secilen = (AskerTipleri)comboBox1.SelectedItem;
            // yani aşağıdaki kod şöyle birşey olacak sende.. : 
            /*
             oyuncu1.OrduDuzeni[0] = (AskerTipleri)comboBox1.SelectedItem;
            oyuncu1.AskerSayilari[0] = int.Parse(txtYukardaNeSecildiyseO.Text); 
             
             */
            // burada anladıysan, asker sayılarını kolay doldurmak için, ordu düzeniyle asker sayılarını aynı mantıkta al.. 
            // ya da bir fonksiyon yaz, ne seçildiyse gitsin onun textini getirsin.. aşağıdakine benzer..

             
          
             
             
            
           

            // kullanırken de 
            // oyuncu1.AskerSayilari[0] = AskerSayisi((AskerTipleri)comboBox1.SelectedItem);
            // şeklinde kullan..

            #region SavasDuzenleri
            SavasDuzeni oyuncu1 = new SavasDuzeni();
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
            
            
            SavasDuzeni oyuncu2 = new SavasDuzeni();
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

            SavasDuzeni ahiler = new SavasDuzeni();
            ahiler.OrduDuzeni[0] = (AskerTipleri)hrt.cmbahiler1.SelectedItem;
            ahiler.AskerSayilari[0] = AskerSayisiahiler((AskerTipleri)hrt.cmbahiler1.SelectedItem);
            ahiler.OrduDuzeni[1] = (AskerTipleri)hrt.cmbahiler2.SelectedItem;
            ahiler.AskerSayilari[1] = AskerSayisiahiler((AskerTipleri)hrt.cmbahiler2.SelectedItem);
            ahiler.OrduDuzeni[2] = (AskerTipleri)hrt.cmbahiler3.SelectedItem;
            ahiler.AskerSayilari[2] = AskerSayisiahiler((AskerTipleri)hrt.cmbahiler3.SelectedItem);
            ahiler.OrduDuzeni[3] = (AskerTipleri)hrt.cmbahiler4.SelectedItem;
            ahiler.AskerSayilari[3] = AskerSayisiahiler((AskerTipleri)hrt.cmbahiler4.SelectedItem);
            ahiler.OrduDuzeni[4] = (AskerTipleri)hrt.cmbahiler5.SelectedItem;
            ahiler.AskerSayilari[4] = AskerSayisiahiler((AskerTipleri)hrt.cmbahiler5.SelectedItem);

            SavasDuzeni mentese = new SavasDuzeni();
            mentese.OrduDuzeni[0] = (AskerTipleri)hrt.cmbmentese1.SelectedItem;
            mentese.AskerSayilari[0] = AskerSayisimentese((AskerTipleri)hrt.cmbmentese1.SelectedItem);
            mentese.OrduDuzeni[1] = (AskerTipleri)hrt.cmbmentese1.SelectedItem;
            mentese.AskerSayilari[1] = AskerSayisimentese((AskerTipleri)hrt.cmbmentese2.SelectedItem);
            mentese.OrduDuzeni[2] = (AskerTipleri)hrt.cmbmentese1.SelectedItem;
            mentese.AskerSayilari[2] = AskerSayisimentese((AskerTipleri)hrt.cmbmentese3.SelectedItem);
            mentese.OrduDuzeni[3] = (AskerTipleri)hrt.cmbmentese1.SelectedItem;
            mentese.AskerSayilari[3] = AskerSayisimentese((AskerTipleri)hrt.cmbmentese4.SelectedItem);
            mentese.OrduDuzeni[4] = (AskerTipleri)hrt.cmbmentese1.SelectedItem;
            mentese.AskerSayilari[4] = AskerSayisimentese((AskerTipleri)hrt.cmbmentese5.SelectedItem);

            SavasDuzeni canik = new SavasDuzeni();
            canik.OrduDuzeni[0] = (AskerTipleri)hrt.cmbcanik1.SelectedItem;
            canik.AskerSayilari[0] = AskerSayisicanik((AskerTipleri)hrt.cmbcanik1.SelectedItem);
            canik.OrduDuzeni[1] = (AskerTipleri)hrt.cmbcanik1.SelectedItem;
            canik.AskerSayilari[1] = AskerSayisicanik((AskerTipleri)hrt.cmbcanik2.SelectedItem);
            canik.OrduDuzeni[2] = (AskerTipleri)hrt.cmbcanik1.SelectedItem;
            canik.AskerSayilari[2] = AskerSayisicanik((AskerTipleri)hrt.cmbcanik3.SelectedItem);
            canik.OrduDuzeni[3] = (AskerTipleri)hrt.cmbcanik1.SelectedItem;
            canik.AskerSayilari[3] = AskerSayisicanik((AskerTipleri)hrt.cmbcanik4.SelectedItem);
            canik.OrduDuzeni[4] = (AskerTipleri)hrt.cmbcanik1.SelectedItem;
            canik.AskerSayilari[4] = AskerSayisicanik((AskerTipleri)hrt.cmbcanik5.SelectedItem);

            SavasDuzeni hamit = new SavasDuzeni();
            hamit.OrduDuzeni[0] = (AskerTipleri)hrt.cmbhamit1.SelectedItem;
            hamit.AskerSayilari[0] = AskerSayisihamit((AskerTipleri)hrt.cmbhamit1.SelectedItem);
            hamit.OrduDuzeni[1] = (AskerTipleri)hrt.cmbhamit2.SelectedItem;
            hamit.AskerSayilari[1] = AskerSayisihamit((AskerTipleri)hrt.cmbhamit2.SelectedItem);
            hamit.OrduDuzeni[2] = (AskerTipleri)hrt.cmbhamit3.SelectedItem;
            hamit.AskerSayilari[2] = AskerSayisihamit((AskerTipleri)hrt.cmbhamit3.SelectedItem);
            hamit.OrduDuzeni[3] = (AskerTipleri)hrt.cmbhamit4.SelectedItem;
            hamit.AskerSayilari[3] = AskerSayisihamit((AskerTipleri)hrt.cmbhamit4.SelectedItem);
            hamit.OrduDuzeni[4] = (AskerTipleri)hrt.cmbhamit5.SelectedItem;
            hamit.AskerSayilari[4] = AskerSayisihamit((AskerTipleri)hrt.cmbhamit5.SelectedItem);

            SavasDuzeni karaman = new SavasDuzeni();
            karaman.OrduDuzeni[0] = (AskerTipleri)hrt.cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[0] = AskerSayisikaraman((AskerTipleri)hrt.cmbkaraman1.SelectedItem);
            karaman.OrduDuzeni[1] = (AskerTipleri)hrt.cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[1] = AskerSayisikaraman((AskerTipleri)hrt.cmbkaraman2.SelectedItem);
            karaman.OrduDuzeni[2] = (AskerTipleri)hrt.cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[2] = AskerSayisikaraman((AskerTipleri)hrt.cmbkaraman3.SelectedItem);
            karaman.OrduDuzeni[3] = (AskerTipleri)hrt.cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[3] = AskerSayisikaraman((AskerTipleri)hrt.cmbkaraman4.SelectedItem);
            karaman.OrduDuzeni[4] = (AskerTipleri)hrt.cmbkaraman1.SelectedItem;
            karaman.AskerSayilari[4] = AskerSayisikaraman((AskerTipleri)hrt.cmbkaraman5.SelectedItem);

            SavasDuzeni esref = new SavasDuzeni();
            esref.OrduDuzeni[0] = (AskerTipleri)hrt.cmbesref1.SelectedItem;
            esref.AskerSayilari[0] = AskerSayisiesref((AskerTipleri)hrt.cmbesref1.SelectedItem);
            esref.OrduDuzeni[1] = (AskerTipleri)hrt.cmbesref1.SelectedItem;
            esref.AskerSayilari[1] = AskerSayisiesref((AskerTipleri)hrt.cmbesref2.SelectedItem);
            esref.OrduDuzeni[2] = (AskerTipleri)hrt.cmbesref1.SelectedItem;
            esref.AskerSayilari[2] = AskerSayisiesref((AskerTipleri)hrt.cmbesref3.SelectedItem);
            esref.OrduDuzeni[3] = (AskerTipleri)hrt.cmbesref1.SelectedItem;
            esref.AskerSayilari[3] = AskerSayisiesref((AskerTipleri)hrt.cmbesref4.SelectedItem);
            esref.OrduDuzeni[4] = (AskerTipleri)hrt.cmbesref1.SelectedItem;
            esref.AskerSayilari[4] = AskerSayisiesref((AskerTipleri)hrt.cmbesref5.SelectedItem);

            SavasDuzeni trabzon = new SavasDuzeni();
            trabzon.OrduDuzeni[0] = (AskerTipleri)hrt.cmbtrabzon1.SelectedItem;
            trabzon.AskerSayilari[0] = AskerSayisitrabzon((AskerTipleri)hrt.cmbtrabzon1.SelectedItem);
            trabzon.OrduDuzeni[1] = (AskerTipleri)hrt.cmbtrabzon2.SelectedItem;
            trabzon.AskerSayilari[1] = AskerSayisitrabzon((AskerTipleri)hrt.cmbtrabzon2.SelectedItem);
            trabzon.OrduDuzeni[2] = (AskerTipleri)hrt.cmbtrabzon3.SelectedItem;
            trabzon.AskerSayilari[2] = AskerSayisitrabzon((AskerTipleri)hrt.cmbtrabzon3.SelectedItem);
            trabzon.OrduDuzeni[3] = (AskerTipleri)hrt.cmbtrabzon4.SelectedItem;
            trabzon.AskerSayilari[3] = AskerSayisitrabzon((AskerTipleri)hrt.cmbtrabzon4.SelectedItem);
            trabzon.OrduDuzeni[4] = (AskerTipleri)hrt.cmbtrabzon5.SelectedItem;
            trabzon.AskerSayilari[4] = AskerSayisitrabzon((AskerTipleri)hrt.cmbtrabzon5.SelectedItem);

            SavasDuzeni aydin = new SavasDuzeni();
            aydin.OrduDuzeni[0] = (AskerTipleri)hrt.cmbaydin1.SelectedItem;
            aydin.AskerSayilari[0] = AskerSayisiaydin((AskerTipleri)hrt.cmbaydin1.SelectedItem);
            aydin.OrduDuzeni[1] = (AskerTipleri)hrt.cmbaydin1.SelectedItem;
            aydin.AskerSayilari[1] = AskerSayisiaydin((AskerTipleri)hrt.cmbaydin2.SelectedItem);
            aydin.OrduDuzeni[2] = (AskerTipleri)hrt.cmbaydin1.SelectedItem;
            aydin.AskerSayilari[2] = AskerSayisiaydin((AskerTipleri)hrt.cmbaydin3.SelectedItem);
            aydin.OrduDuzeni[3] = (AskerTipleri)hrt.cmbaydin1.SelectedItem;
            aydin.AskerSayilari[3] = AskerSayisiaydin((AskerTipleri)hrt.cmbaydin4.SelectedItem);
            aydin.OrduDuzeni[4] = (AskerTipleri)hrt.cmbaydin1.SelectedItem;
            aydin.AskerSayilari[4] = AskerSayisiaydin((AskerTipleri)hrt.cmbaydin5.SelectedItem);

            SavasDuzeni eretna = new SavasDuzeni();
            eretna.OrduDuzeni[0] = (AskerTipleri)hrt.cmberetna1.SelectedItem;
            eretna.AskerSayilari[0] = AskerSayisieretna((AskerTipleri)hrt.cmberetna1.SelectedItem);
            eretna.OrduDuzeni[1] = (AskerTipleri)hrt.cmberetna1.SelectedItem;
            eretna.AskerSayilari[1] = AskerSayisieretna((AskerTipleri)hrt.cmberetna2.SelectedItem);
            eretna.OrduDuzeni[2] = (AskerTipleri)hrt.cmberetna1.SelectedItem;
            eretna.AskerSayilari[2] = AskerSayisieretna((AskerTipleri)hrt.cmberetna3.SelectedItem);
            eretna.OrduDuzeni[3] = (AskerTipleri)hrt.cmberetna1.SelectedItem;
            eretna.AskerSayilari[3] = AskerSayisieretna((AskerTipleri)hrt.cmberetna4.SelectedItem);
            eretna.OrduDuzeni[4] = (AskerTipleri)hrt.cmberetna1.SelectedItem;
            eretna.AskerSayilari[4] = AskerSayisieretna((AskerTipleri)hrt.cmberetna5.SelectedItem);

            SavasDuzeni saruhan = new SavasDuzeni();
            saruhan.OrduDuzeni[0] = (AskerTipleri)hrt.cmbsaruhan1.SelectedItem;
            saruhan.AskerSayilari[0] = AskerSayisisaruhan((AskerTipleri)hrt.cmbsaruhan1.SelectedItem);
            saruhan.OrduDuzeni[1] = (AskerTipleri)hrt.cmbsaruhan2.SelectedItem;
            saruhan.AskerSayilari[1] = AskerSayisisaruhan((AskerTipleri)hrt.cmbsaruhan2.SelectedItem);
            saruhan.OrduDuzeni[2] = (AskerTipleri)hrt.cmbsaruhan3.SelectedItem;
            saruhan.AskerSayilari[2] = AskerSayisisaruhan((AskerTipleri)hrt.cmbsaruhan3.SelectedItem);
            saruhan.OrduDuzeni[3] = (AskerTipleri)hrt.cmbsaruhan4.SelectedItem;
            saruhan.AskerSayilari[3] = AskerSayisisaruhan((AskerTipleri)hrt.cmbsaruhan4.SelectedItem);
            saruhan.OrduDuzeni[4] = (AskerTipleri)hrt.cmbsaruhan5.SelectedItem;
            saruhan.AskerSayilari[4] = AskerSayisisaruhan((AskerTipleri)hrt.cmbsaruhan5.SelectedItem);

            SavasDuzeni germiyan = new SavasDuzeni();
            germiyan.OrduDuzeni[0] = (AskerTipleri)hrt.cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[0] = AskerSayisigermiyan((AskerTipleri)hrt.cmbgermiyan1.SelectedItem);
            germiyan.OrduDuzeni[1] = (AskerTipleri)hrt.cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[1] = AskerSayisigermiyan((AskerTipleri)hrt.cmbgermiyan2.SelectedItem);
            germiyan.OrduDuzeni[2] = (AskerTipleri)hrt.cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[2] = AskerSayisigermiyan((AskerTipleri)hrt.cmbgermiyan3.SelectedItem);
            germiyan.OrduDuzeni[3] = (AskerTipleri)hrt.cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[3] = AskerSayisigermiyan((AskerTipleri)hrt.cmbgermiyan4.SelectedItem);
            germiyan.OrduDuzeni[4] = (AskerTipleri)hrt.cmbgermiyan1.SelectedItem;
            germiyan.AskerSayilari[4] = AskerSayisigermiyan((AskerTipleri)hrt.cmbgermiyan5.SelectedItem);

            SavasDuzeni ramazan = new SavasDuzeni();
            ramazan.OrduDuzeni[0] = (AskerTipleri)hrt.cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[0] = AskerSayisiramazan((AskerTipleri)hrt.cmbramazan1.SelectedItem);
            ramazan.OrduDuzeni[1] = (AskerTipleri)hrt.cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[1] = AskerSayisiramazan((AskerTipleri)hrt.cmbramazan2.SelectedItem);
            ramazan.OrduDuzeni[2] = (AskerTipleri)hrt.cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[2] = AskerSayisiramazan((AskerTipleri)hrt.cmbramazan3.SelectedItem);
            ramazan.OrduDuzeni[3] = (AskerTipleri)hrt.cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[3] = AskerSayisiramazan((AskerTipleri)hrt.cmbramazan4.SelectedItem);
            ramazan.OrduDuzeni[4] = (AskerTipleri)hrt.cmbramazan1.SelectedItem;
            ramazan.AskerSayilari[4] = AskerSayisiramazan((AskerTipleri)hrt.cmbramazan5.SelectedItem);

            SavasDuzeni dulkadir = new SavasDuzeni();
            dulkadir.OrduDuzeni[0] = (AskerTipleri)hrt.cmbdulkadir1.SelectedItem;
            dulkadir.AskerSayilari[0] = AskerSayisidulkadir((AskerTipleri)hrt.cmbdulkadir1.SelectedItem);
            dulkadir.OrduDuzeni[1] = (AskerTipleri)hrt.cmbdulkadir2.SelectedItem;
            dulkadir.AskerSayilari[1] = AskerSayisidulkadir((AskerTipleri)hrt.cmbdulkadir2.SelectedItem);
            dulkadir.OrduDuzeni[2] = (AskerTipleri)hrt.cmbdulkadir3.SelectedItem;
            dulkadir.AskerSayilari[2] = AskerSayisidulkadir((AskerTipleri)hrt.cmbdulkadir3.SelectedItem);
            dulkadir.OrduDuzeni[3] = (AskerTipleri)hrt.cmbdulkadir4.SelectedItem;
            dulkadir.AskerSayilari[3] = AskerSayisidulkadir((AskerTipleri)hrt.cmbdulkadir4.SelectedItem);
            dulkadir.OrduDuzeni[4] = (AskerTipleri)hrt.cmbdulkadir5.SelectedItem;
            dulkadir.AskerSayilari[4] = AskerSayisidulkadir((AskerTipleri)hrt.cmbdulkadir5.SelectedItem);

            SavasDuzeni kolemen = new SavasDuzeni();
            kolemen.OrduDuzeni[0] = (AskerTipleri)hrt.cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[0] = AskerSayisikolemen((AskerTipleri)hrt.cmbkolemen1.SelectedItem);
            kolemen.OrduDuzeni[1] = (AskerTipleri)hrt.cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[1] = AskerSayisikolemen((AskerTipleri)hrt.cmbkolemen2.SelectedItem);
            kolemen.OrduDuzeni[2] = (AskerTipleri)hrt.cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[2] = AskerSayisikolemen((AskerTipleri)hrt.cmbkolemen3.SelectedItem);
            kolemen.OrduDuzeni[3] = (AskerTipleri)hrt.cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[3] = AskerSayisikolemen((AskerTipleri)hrt.cmbkolemen4.SelectedItem);
            kolemen.OrduDuzeni[4] = (AskerTipleri)hrt.cmbkolemen1.SelectedItem;
            kolemen.AskerSayilari[4] = AskerSayisikolemen((AskerTipleri)hrt.cmbkolemen5.SelectedItem);

            SavasDuzeni karesi = new SavasDuzeni();
            karesi.OrduDuzeni[0] = (AskerTipleri)hrt.cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[0] = AskerSayisikaresi((AskerTipleri)hrt.cmbkaresi1.SelectedItem);
            karesi.OrduDuzeni[1] = (AskerTipleri)hrt.cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[1] = AskerSayisikaresi((AskerTipleri)hrt.cmbkaresi2.SelectedItem);
            karesi.OrduDuzeni[2] = (AskerTipleri)hrt.cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[2] = AskerSayisikaresi((AskerTipleri)hrt.cmbkaresi3.SelectedItem);
            karesi.OrduDuzeni[3] = (AskerTipleri)hrt.cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[3] = AskerSayisikaresi((AskerTipleri)hrt.cmbkaresi4.SelectedItem);
            karesi.OrduDuzeni[4] = (AskerTipleri)hrt.cmbkaresi1.SelectedItem;
            karesi.AskerSayilari[4] = AskerSayisikaresi((AskerTipleri)hrt.cmbkaresi5.SelectedItem);

            SavasDuzeni osmanli = new SavasDuzeni();
            osmanli.OrduDuzeni[0] = (AskerTipleri)hrt.cmbosmanli1.SelectedItem;
            osmanli.AskerSayilari[0] = AskerSayisiosmanli((AskerTipleri)hrt.cmbosmanli1.SelectedItem);
            osmanli.OrduDuzeni[1] = (AskerTipleri)hrt.cmbosmanli2.SelectedItem;
            osmanli.AskerSayilari[1] = AskerSayisiosmanli((AskerTipleri)hrt.cmbosmanli2.SelectedItem);
            osmanli.OrduDuzeni[2] = (AskerTipleri)hrt.cmbosmanli3.SelectedItem;
            osmanli.AskerSayilari[2] = AskerSayisiosmanli((AskerTipleri)hrt.cmbosmanli3.SelectedItem);
            osmanli.OrduDuzeni[3] = (AskerTipleri)hrt.cmbosmanli4.SelectedItem;
            osmanli.AskerSayilari[3] = AskerSayisiosmanli((AskerTipleri)hrt.cmbosmanli4.SelectedItem);
            osmanli.OrduDuzeni[4] = (AskerTipleri)hrt.cmbosmanli5.SelectedItem;
            osmanli.AskerSayilari[4] = AskerSayisiosmanli((AskerTipleri)hrt.cmbosmanli5.SelectedItem);

            SavasDuzeni bizans = new SavasDuzeni();
            bizans.OrduDuzeni[0] = (AskerTipleri)hrt.cmbbizans1.SelectedItem;
            bizans.AskerSayilari[0] = AskerSayisibizans((AskerTipleri)hrt.cmbbizans1.SelectedItem);
            bizans.OrduDuzeni[1] = (AskerTipleri)hrt.cmbbizans1.SelectedItem;
            bizans.AskerSayilari[1] = AskerSayisibizans((AskerTipleri)hrt.cmbbizans2.SelectedItem);
            bizans.OrduDuzeni[2] = (AskerTipleri)hrt.cmbbizans1.SelectedItem;
            bizans.AskerSayilari[2] = AskerSayisibizans((AskerTipleri)hrt.cmbbizans3.SelectedItem);
            bizans.OrduDuzeni[3] = (AskerTipleri)hrt.cmbbizans1.SelectedItem;
            bizans.AskerSayilari[3] = AskerSayisibizans((AskerTipleri)hrt.cmbbizans4.SelectedItem);
            bizans.OrduDuzeni[4] = (AskerTipleri)hrt.cmbbizans1.SelectedItem;
            bizans.AskerSayilari[4] = AskerSayisibizans((AskerTipleri)hrt.cmbbizans5.SelectedItem);
            #endregion


            // artık sıra savaşmaya geldi... savaş metodunun açıklaması metodun içinde...
            Console.ReadKey();


        }



    public static void Savas(SavasDuzeni o1, SavasDuzeni o2)
        {
            // bu metodda direk her seviyeyi sırayla karşılaştıramazsın. çünkü bir seviyede asker kaldığı sürece
            // diğer seviyeye geçmiyor oyun mantığı..  o yüzden her bir oyuncu için sıradaki seviyeyi ayrı indexlerde tutacağız
            // for ile değil, while ile döneceğiz, ta ki oyunculardan birinin askeri bitene kadar... 

            int s1 = 0, s2 = 0; // ordu düzen seviyeleri..

            int tur = 0; // oyun mantığında etkisi yok, sadece kaç tur oyun oynanmış görmek için tutuyoruz..


            do
            {
                tur++;
                Console.WriteLine(string.Format("{0}. tur oynanıyor...", tur));

                Console.WriteLine(string.Format("{0} {1} karşısında {2} {3}", o1.AskerSayilari[s1], o1.OrduDuzeni[s1].ToString(), o2.AskerSayilari[s2], o2.OrduDuzeni[s2].ToString()));

                // kim yenecek kim yenilecek bu adımda hesaplayalım..
                double o1Guc = o1.AskerSayilari[s1] * gucMatrisi[o1.OrduDuzeni[s1]][o2.OrduDuzeni[s2]];
                double o2Guc = o2.AskerSayilari[s2] * gucMatrisi[o2.OrduDuzeni[s2]][o1.OrduDuzeni[s1]];
                // o2gucu sadece 2. oyuncu yenilince, eksiltme işlemi için kullanacağız.... 


                if (o1Guc > o2.AskerSayilari[s2])
                {
                    // turu oyuncu 1 kazandı..
                    // 2. oyuncunun bu seviyesinde asker kalmadı..
                    // 1. oyuncudan da gücüne göre belirli sayıda asker eksilteceğiz..
                    o2.AskerSayilari[s2] = 0;
                    s2++;// ikinci oyuncuyu bir sonraki seviyeye taşıdık..
                    o1.AskerSayilari[s1] -= o2Guc;
                    Console.WriteLine("Bu turu Oyuncu1 Kazandı");

                }
                else if (o1Guc < o2.AskerSayilari[s2])
                {
                    // turu oyuncu 2 kazandı..
                    // 1. oyuncunun bu seviyesinde asker kalmadı..
                    // 2. oyuncudan da gücüne göre belirli sayıda asker eksilteceğiz..
                    o1.AskerSayilari[s1] = 0;
                    s1++;// birinci oyuncuyu bir sonraki seviyeye taşıdık..
                    o2.AskerSayilari[s2] -= o1Guc;
                    Console.WriteLine("Bu turu Oyuncu2 Kazandı");
                }
                else
                {
                    //berabere..
                    // iki tarafın da bu seviyede askeri kalmadı... iki oyuncuyu da bir sonraki seviyeye taşıdık..
                    o1.AskerSayilari[s1] = 0;
                    o2.AskerSayilari[s2] = 0;
                    s1++;
                    s2++;
                    Console.WriteLine("Bu tur berabere");
                }

            } while (s1 < 5 && s2 < 5);

            if (s1 > s2)
            {
                // ikinci oyuncu savaşı kazanmış.. s1 daha önce  5 e ulaştığına göre...
                Console.WriteLine("Savaşı Oyuncu 2 kazandı..");
            }
            else if (s1 < s2)
            {
                // birinci oyuncu kazanmış...
                Console.WriteLine("Savaşı Oyuncu 1 kazandı..");
            }
            else
            {
                //oyuncular  yenişemedi, hayret..
                Console.WriteLine("Savaşta yenişemediler, sağ kalan yok..");
            }
        }
      
    }

    public class SavasDuzeni
    {
        public AskerTipleri[] OrduDuzeni;
        public double[] AskerSayilari;
       
        public SavasDuzeni()
        {
            OrduDuzeni = new AskerTipleri[5];
            AskerSayilari = new double[5] { 0, 0, 0, 0, 0 };
          
        }
    }

    public enum AskerTipleri
    {
        Piyade,
        Okcu,
        Sipahi,
        Suvari,
        Yeniceri
    }
}
