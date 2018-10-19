using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace Beylik_Savaşları
{
    public partial class Form1 : Form
    {
       
        public frmHarita frmHarita;
        public Baslangic baslangic;
        public Yardim yardim;

        public Form1()
        {

            InitializeComponent();
            
            frmHarita = new frmHarita();
            frmHarita.frmoyuncu1 = this;
            yardim = new Yardim();
            yardim.frm1 = this;

        }
        int piu1, oku1, suu1, siu1, keu1, yeu1, tpu1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            pictureBox24.Hide();
            comboBox1.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox2.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox3.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox4.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox5.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox10.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox9.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox8.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox7.DataSource = Enum.GetValues(typeof(AskerTipleri));
            comboBox6.DataSource = Enum.GetValues(typeof(AskerTipleri));

            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..


        }
        double okcu1, okcu2, inttxt1okcu, inttxt2okcu, para1, para2, sg1, sg2, piyade1, piyade2, sipahi1, sipahi2, suvari1, suvari2, yeniceri1, yeniceri2, kervan1, kervan2, inttxt1piyade, inttxt2piyade, inttxt1sipahi, inttxt2sipahi, inttxt1suvari, inttxt2suvari, inttxt1yeniceri, inttxt2yeniceri, inttxt1kervan, inttxt2kervan;

        private void btn1Okcu_Click(object sender, EventArgs e)
        {

            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            #region Oyuncu 1 Asker Alımı

            try
            {
                if (txt1piyade.Text == "")
                {
                    txt1piyade.Text = "0";
                }
                if (txt1Okcu.Text == "")
                {
                    txt1Okcu.Text = "0";
                }

                if (txt1sipahi.Text == "")
                {
                    txt1sipahi.Text = "0";
                }
                if (txt1suvari.Text == "")
                {
                    txt1suvari.Text = "0";
                }

                if (txt1yeniceri.Text == "")
                {
                    txt1yeniceri.Text = "0";
                }
                if (txt1kervansaray.Text == "")
                {
                    txt1kervansaray.Text = "0";
                }
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                okcu1 = double.Parse(lbl1okcu.Text);
                inttxt1okcu = double.Parse(txt1Okcu.Text);

                piyade1 = double.Parse(lbl1piyade.Text);
                inttxt1piyade = double.Parse(txt1piyade.Text);

                sipahi1 = double.Parse(lbl1sipahi.Text);
                inttxt1sipahi = double.Parse(txt1sipahi.Text);

                suvari1 = double.Parse(lbl1suvari.Text);
                inttxt1suvari = double.Parse(txt1suvari.Text);

                yeniceri1 = double.Parse(lbl1yeniceri.Text);
                inttxt1yeniceri = double.Parse(txt1yeniceri.Text);

                kervan1 = double.Parse(lbl1kervansaray.Text);
                inttxt1kervan = double.Parse(txt1kervansaray.Text);

                para1 = double.Parse(lbl1para.Text);
                sg1 = double.Parse(lbl1sg.Text);



                if (para1 >= ((inttxt1okcu * 20) + (inttxt1kervan * 1000) + (inttxt1piyade * 15) + (inttxt1sipahi * 30) + (inttxt1suvari * 50) + (inttxt1yeniceri * 70)))
                {
                    if ((kervan1 + inttxt1kervan) <= 100)
                    {
                        lbl1okcu.Text = (okcu1 + inttxt1okcu).ToString();
                        lbl1piyade.Text = (piyade1 + inttxt1piyade).ToString();
                        lbl1sipahi.Text = (sipahi1 + inttxt1sipahi).ToString();
                        lbl1suvari.Text = (suvari1 + inttxt1suvari).ToString();
                        lbl1yeniceri.Text = (yeniceri1 + inttxt1yeniceri).ToString();
                        lbl1kervansaray.Text = (kervan1 + inttxt1kervan).ToString();


                        //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
                        lbl1sg.Text = ((double.Parse(lbl1okcu.Text) * 25) + (double.Parse(lbl1piyade.Text) * 20) + (double.Parse(lbl1sipahi.Text) * 40) + (double.Parse(lbl1suvari.Text) * 70) + (double.Parse(lbl1yeniceri.Text) * 100)).ToString();

                        lbl1para.Text = (para1 - ((inttxt1okcu * 20) + (inttxt1kervan * 1000) + (inttxt1piyade * 15) + (inttxt1sipahi * 30) + (inttxt1suvari * 50) + (inttxt1yeniceri * 70))).ToString();
                    }

                    else
                    {
                        MessageBox.Show("En fazla 100 Kervansaray'ınız olabilir.");
                    }


                }
                else
                {
                    MessageBox.Show("Paranız Yetersiz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Boş Yer Bırakmayın. Satın almayacaksanız 0 yazın.");

            }


            #endregion





        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

        }

        private void txt1Okcu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt1Okcu.Text != "")
                {
                    lbl1okcuucret.Text = (int.Parse(txt1Okcu.Text) * 20).ToString();
                }
                else
                {
                    lbl1okcuucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..

            }

        }




        #region Textboxlara sayı girimi
        //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
        private void txt1piyade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1Okcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1sipahi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1suvari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1yeniceri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1kervansaray_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2piyade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt2Okcu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt2sipahi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt2süvari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2yeniceri_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt2kervansaray_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ordu Düzeni Sıfırlama
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;

            #endregion

        }

        
        
     
     
        private void btnSavas_Click(object sender, EventArgs e)
        {







            //Piyade Sg = 20
            //Okçu Sg = 25
            //Süvari Sg = 40
            //Sipahi Sg = 70
            //Yeniçeri Sg = 100

            //Piyadeler ---> Sipahilere Karşı
            //Okçular ---> Yeniçerilere Karşı
            //Yeniçeriler ---> Süvarilere Karşı
            //Sipahiler ---> Okçulara Karşı
            //Süvariler ---> Piyadelere Karşı



        }





        private void txt1piyade_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            try
            {
                if (txt1piyade.Text != "")
                {
                    lbl1piyadeucret.Text = (int.Parse(txt1piyade.Text) * 15).ToString();
                }
                else
                {
                    lbl1piyadeucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }




        }

        private void txt1suvari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt1sipahi.Text != "")
                {
                    lbl1suvariucret.Text = (int.Parse(txt1sipahi.Text) * 30).ToString();
                }
                else
                {
                    lbl1suvariucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }




        }

        private void txt1sipahi_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt1suvari.Text != "")
                {
                    lbl1sipahiucret.Text = (int.Parse(txt1suvari.Text) * 50).ToString();
                }
                else
                {
                    lbl1sipahiucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }




        }

        private void txt1yeniceri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt1yeniceri.Text != "")
                {
                    lbl1yeniceriucret.Text = (int.Parse(txt1yeniceri.Text) * 70).ToString();
                }
                else
                {
                    lbl1yeniceriucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }


        }

        private void txt1kervansaray_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt1kervansaray.Text != "")
                {
                    lbl1kervansarayucret.Text = (int.Parse(txt1kervansaray.Text) * 1000).ToString();
                }
                else
                {
                    lbl1kervansarayucret.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }

        }

        private void lbl1piyadeucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }

        private void lbl1okcuucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }

        private void lbl1suvariucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }

        private void lbl1sipahiucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }

        private void lbl1yeniceriucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }

        private void lbl1kervansarayucret_TextChanged(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            piu1 = int.Parse(lbl1piyadeucret.Text);
            oku1 = int.Parse(lbl1okcuucret.Text);
            suu1 = int.Parse(lbl1suvariucret.Text);
            siu1 = int.Parse(lbl1sipahiucret.Text);
            keu1 = int.Parse(lbl1kervansarayucret.Text);
            yeu1 = int.Parse(lbl1yeniceriucret.Text);
            tpu1 = int.Parse(lbl1toplamucret.Text);
            lbl1toplamucret.Text = (piu1 + oku1 + suu1 + siu1 + yeu1 + keu1).ToString();
        }
        int enum1 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            

            try
            {
                
                frmHarita.label1.Text = "Oyuncu1";
                frmHarita.Show();
                frmHarita.Visible = true;
                frmHarita.WindowState = FormWindowState.Normal;

                #region Savaş Alanları Oyuncu1
                frmHarita.btnUstteki.Visible = false;
                frmHarita.btnAlttaki.Visible = false;
               
                frmHarita.btnAhiler.Visible = false;
                frmHarita.btnOsman.Visible = false;
                frmHarita.btnKaraman.Visible = false;
                frmHarita.btnEretna.Visible = false;
                frmHarita.btnCanik.Visible = false;
                frmHarita.btnTrabzon.Visible = false;
                frmHarita.btnDulkadir.Visible = false;
                frmHarita.btnRamazan.Visible = false;
                frmHarita.btnKolemen.Visible = false;
                frmHarita.btnMentese.Visible = false;
                frmHarita.btnEsref.Visible = false;
                frmHarita.btnKaresi.Visible = false;
                frmHarita.btnGermiyan.Visible = false;
                frmHarita.btnAydin.Visible = false;
                frmHarita.btnBizans.Visible = false;
                frmHarita.btnHamit.Visible = false;
                frmHarita.btnSaruhan.Visible = false;

                if (frmHarita.label1.Text == "Oyuncu1")
                {
                    #region Üstteki Oyuncu1se
                    if (frmHarita.lblUstteki.Text == "Oyuncu1")
                    {
                        frmHarita.btnOsman.Visible = true;
                        frmHarita.btnAhiler.Visible = true;
                        frmHarita.btnEretna.Visible = true;
                        frmHarita.btnCanik.Visible = true;
                        frmHarita.btnBizans.Visible = true;

                        if (frmHarita.lblAhiler.Text == "Oyuncu1")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu1")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu1")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu1")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu1")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu1")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu1")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu1")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }


                    }

                    #endregion
                    #region Alttaki Oyuncu1se
                    else
                    {
                        frmHarita.btnMentese.Visible = true;
                        frmHarita.btnKaraman.Visible = true;
                        frmHarita.btnHamit.Visible = true;
                        frmHarita.btnBizans.Visible = true;
                        if (frmHarita.lblAhiler.Text == "Oyuncu1")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu1")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu1")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu1")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu1")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu1")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu1")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu1")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }

                    }

                    #endregion

                }

                #endregion
                #region Savaş Alanları Oyuncu2
                else
                {
                    #region Üstteki Oyuncu1se
                    if (frmHarita.lblUstteki.Text == "Oyuncu2")
                    {
                        frmHarita.btnOsman.Visible = true;
                        frmHarita.btnAhiler.Visible = true;
                        frmHarita.btnEretna.Visible = true;
                        frmHarita.btnCanik.Visible = true;
                        frmHarita.btnBizans.Visible = true;

                        if (frmHarita.lblAhiler.Text == "Oyuncu2")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu2")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu2")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu2")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu2")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu2")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu2")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu2")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }


                    }

                    #endregion
                    #region Alttaki Oyuncu2se
                    else
                    {
                        frmHarita.btnMentese.Visible = true;
                        frmHarita.btnKaraman.Visible = true;
                        frmHarita.btnHamit.Visible = true;
                        frmHarita.btnBizans.Visible = true;
                        if (frmHarita.lblAhiler.Text == "Oyuncu2")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu2")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu2")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu2")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu2")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu2")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu2")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu2")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }

                    }

                    #endregion

                }
                #endregion
                //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
              
               
            }
            catch (Exception ex)
            {

            }

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
          

        }
        int timer = 5;

     

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void btn2Okcu_Click(object sender, EventArgs e)
        {
            //Bu yazıyı görüyorsanız demekki reflector kullanmışsınız. Helal etmiyorum..
            #region Oyuncu 2 Okcu Alımı

            try
            {
                if (txt2piyade.Text == "")
                {
                    txt2piyade.Text = "0";
                }
                if (txt2Okcu.Text == "")
                {
                    txt2Okcu.Text = "0";
                }

                if (txt2sipahi.Text == "")
                {
                    txt2sipahi.Text = "0";
                }
                if (txt2suvari.Text == "")
                {
                    txt2suvari.Text = "0";
                }

                if (txt2yeniceri.Text == "")
                {
                    txt2yeniceri.Text = "0";
                }
                if (txt2kervansaray.Text == "")
                {
                    txt2kervansaray.Text = "0";
                }

                okcu2 = double.Parse(lbl2okcu.Text);
                inttxt2okcu = double.Parse(txt2Okcu.Text);

                piyade2 = double.Parse(lbl2piyade.Text);
                inttxt2piyade = double.Parse(txt2piyade.Text);

                sipahi2 = double.Parse(lbl2sipahi.Text);
                inttxt2sipahi = double.Parse(txt2sipahi.Text);

                suvari2 = double.Parse(lbl2suvari.Text);
                inttxt2suvari = double.Parse(txt2suvari.Text);

                yeniceri2 = double.Parse(lbl2yeniceri.Text);
                inttxt2yeniceri = double.Parse(txt2yeniceri.Text);

                kervan2 = double.Parse(lbl2kervansaray.Text);
                inttxt2kervan = double.Parse(txt2kervansaray.Text);

                para2 = double.Parse(lbl2para.Text);
                sg2 = double.Parse(lbl2sg.Text);



                if (para2 >= ((inttxt2okcu * 20) + (inttxt2kervan * 1000) + (inttxt2piyade * 15) + (inttxt2sipahi * 30) + (inttxt2suvari * 50) + (inttxt2yeniceri * 70)))
                {

                    if ((kervan2 + inttxt2kervan) <= 100)
                    {
                        lbl2okcu.Text = (okcu2 + inttxt2okcu).ToString();
                        lbl2piyade.Text = (piyade2 + inttxt2piyade).ToString();
                        lbl2sipahi.Text = (sipahi2 + inttxt2sipahi).ToString();
                        lbl2suvari.Text = (suvari2 + inttxt2suvari).ToString();
                        lbl2yeniceri.Text = (yeniceri2 + inttxt2yeniceri).ToString();
                        lbl2kervansaray.Text = (kervan2 + inttxt2kervan).ToString();



                        lbl2sg.Text = ((double.Parse(lbl2okcu.Text) * 25) + (double.Parse(lbl2piyade.Text) * 20) + (double.Parse(lbl2sipahi.Text) * 40) + (double.Parse(lbl2suvari.Text) * 70) + (double.Parse(lbl2yeniceri.Text) * 100)).ToString();

                        lbl2para.Text = (para2 - ((inttxt2okcu * 20) + (inttxt2kervan * 1000) + (inttxt2piyade * 15) + (inttxt2sipahi * 30) + (inttxt2suvari * 50) + (inttxt2yeniceri * 70))).ToString();
                    }

                    else
                    {
                        MessageBox.Show("En fazla 100 Kervansaray'ınız olabilir.");
                    }

                }
                else
                {
                    MessageBox.Show("Paranız Yetersiz");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Boş Yer Bırakmayın. Satın almayacaksanız 0 yazın.");
            }

            #endregion
        }

        private void txt2suvari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt2suvari.Text != "")
                {
                    label25.Text = (int.Parse(txt2suvari.Text) * 50).ToString();
                }
                else
                {
                    label25.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt2piyade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt2piyade.Text != "")
                {
                    label27.Text = (int.Parse(txt2piyade.Text) * 15).ToString();
                }
                else
                {
                    label27.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt2Okcu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt2Okcu.Text != "")
                {
                    label29.Text = (int.Parse(txt2Okcu.Text) * 20).ToString();
                }
                else
                {
                    label29.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt2sipahi_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt2sipahi.Text != "")
                {
                    label26.Text = (int.Parse(txt2sipahi.Text) * 30).ToString();
                }
                else
                {
                    label26.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt2yeniceri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt2yeniceri.Text != "")
                {
                    label28.Text = (int.Parse(txt2yeniceri.Text) * 70).ToString();
                }
                else
                {
                    label28.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt2kervansaray_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt2kervansaray.Text != "")
                {
                    label24.Text= (int.Parse(txt2kervansaray.Text) * 1000).ToString();
                }
                else
                {
                    label24.Text = 0.ToString();
                }
            }
            catch (Exception)
            {


            }
        }
        int piu2, oku2, suu2, siu2, keu2, yeu2, tpu2;
        private void label27_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void label29_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void label26_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void label25_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void label28_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void label24_TextChanged(object sender, EventArgs e)
        {
            piu2 = int.Parse(label27.Text);
            oku2 = int.Parse(label29.Text);
            suu2 = int.Parse(label26.Text);
            siu2 = int.Parse(label25.Text);
            keu2 = int.Parse(label28.Text);
            yeu2 = int.Parse(label24.Text);
            tpu2 = int.Parse(label23.Text);
            label23.Text = (piu2 + oku2 + suu2 + siu2 + yeu2 + keu2).ToString();
        }

        private void txt2piyade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2Okcu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2sipahi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2suvari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2yeniceri_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2kervansaray_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox10.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                frmHarita.Visible = true;
                frmHarita.Show();
                frmHarita.WindowState = FormWindowState.Normal;
                frmHarita.label1.Text = "Oyuncu2";
                #region Savaş Alanları Oyuncu1
                frmHarita.btnUstteki.Visible = false;
                frmHarita.btnAlttaki.Visible = false;

                frmHarita.btnAhiler.Visible = false;
                frmHarita.btnOsman.Visible = false;
                frmHarita.btnKaraman.Visible = false;
                frmHarita.btnEretna.Visible = false;
                frmHarita.btnCanik.Visible = false;
                frmHarita.btnTrabzon.Visible = false;
                frmHarita.btnDulkadir.Visible = false;
                frmHarita.btnRamazan.Visible = false;
                frmHarita.btnKolemen.Visible = false;
                frmHarita.btnMentese.Visible = false;
                frmHarita.btnEsref.Visible = false;
                frmHarita.btnKaresi.Visible = false;
                frmHarita.btnGermiyan.Visible = false;
                frmHarita.btnAydin.Visible = false;
                frmHarita.btnBizans.Visible = false;
                frmHarita.btnHamit.Visible = false;
                frmHarita.btnSaruhan.Visible = false;

                if (frmHarita.label1.Text == "Oyuncu1")
                {
                    #region Üstteki Oyuncu1se
                    if (frmHarita.lblUstteki.Text == "Oyuncu1")
                    {
                        frmHarita.btnOsman.Visible = true;
                        frmHarita.btnAhiler.Visible = true;
                        frmHarita.btnEretna.Visible = true;
                        frmHarita.btnCanik.Visible = true;
                        frmHarita.btnBizans.Visible = true;

                        if (frmHarita.lblAhiler.Text == "Oyuncu1")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu1")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu1")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu1")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu1")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu1")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu1")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu1")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }


                    }

                    #endregion
                    #region Alttaki Oyuncu1se
                    else
                    {
                        frmHarita.btnMentese.Visible = true;
                        frmHarita.btnKaraman.Visible = true;
                        frmHarita.btnHamit.Visible = true;
                        frmHarita.btnBizans.Visible = true;
                        if (frmHarita.lblAhiler.Text == "Oyuncu1")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu1")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu1")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu1")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu1")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu1")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu1")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu1")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu1")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu1")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu1")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu1")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }

                    }

                    #endregion

                }

                #endregion
                #region Savaş Alanları Oyuncu2
                else
                {
                    #region Üstteki Oyuncu1se
                    if (frmHarita.lblUstteki.Text == "Oyuncu2")
                    {
                        frmHarita.btnOsman.Visible = true;
                        frmHarita.btnAhiler.Visible = true;
                        frmHarita.btnEretna.Visible = true;
                        frmHarita.btnCanik.Visible = true;
                        frmHarita.btnBizans.Visible = true;

                        if (frmHarita.lblAhiler.Text == "Oyuncu2")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu2")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu2")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu2")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu2")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu2")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu2")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu2")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }


                    }

                    #endregion
                    #region Alttaki Oyuncu2se
                    else
                    {
                        frmHarita.btnMentese.Visible = true;
                        frmHarita.btnKaraman.Visible = true;
                        frmHarita.btnHamit.Visible = true;
                        frmHarita.btnBizans.Visible = true;
                        if (frmHarita.lblAhiler.Text == "Oyuncu2")
                        {
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblMentese.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                        }

                        if (frmHarita.lblCanik.Text == "Oyuncu2")
                        {
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblHamit.Text == "Oyuncu2")
                        {
                            frmHarita.btnMentese.Visible = true;
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblKaraman.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnEsref.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblEsref.Text == "Oyuncu2")
                        {
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }


                        if (frmHarita.lblTrabzon.Text == "Oyuncu2")
                        {
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblAydin.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnMentese.Visible = true;
                        }

                        if (frmHarita.lblEretna.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnTrabzon.Visible = true;
                            frmHarita.btnCanik.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblSaruhan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                        }

                        if (frmHarita.lblGermiyan.Text == "Oyuncu2")
                        {
                            frmHarita.btnAydin.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnHamit.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                        }

                        if (frmHarita.lblRamazan.Text == "Oyuncu2")
                        {
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblDulkadir.Text == "Oyuncu2")
                        {
                            frmHarita.btnRamazan.Visible = true;
                            frmHarita.btnKolemen.Visible = true;
                            frmHarita.btnEretna.Visible = true;
                        }

                        if (frmHarita.lblKolemen.Text == "Oyuncu2")
                        {
                            frmHarita.btnDulkadir.Visible = true;
                            frmHarita.btnRamazan.Visible = true;
                        }

                        if (frmHarita.lblKaresi.Text == "Oyuncu2")
                        {
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnSaruhan.Visible = true;
                            frmHarita.btnOsman.Visible = true;
                        }

                        if (frmHarita.lblOsman.Text == "Oyuncu2")
                        {
                            frmHarita.btnBizans.Visible = true;
                            frmHarita.btnKaresi.Visible = true;
                            frmHarita.btnGermiyan.Visible = true;
                            frmHarita.btnKaraman.Visible = true;
                            frmHarita.btnAhiler.Visible = true;
                        }

                        if (frmHarita.lblBizans.Text == "Oyuncu2")
                        {
                            frmHarita.btnUstteki.Visible = true;
                            frmHarita.btnAlttaki.Visible = true;
                        }

                    }

                    #endregion

                }
                #endregion
            }
            catch (Exception)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            pictureBox24.Show();
            pictureBox24.BringToFront();
            pnlOyuncu2.Hide();
           
        }
        int timers = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timers--;
            if (timers == 0)
            {
                pictureBox24.Hide();
                pictureBox24.SendToBack();
                pnlOyuncu1.Show();
                
                timers = 5;
                timer2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox24.Show();
            pictureBox24.BringToFront();
            pnlOyuncu1.Hide();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            timer--;
            if (timer == 0)
            {

                pictureBox24.Hide();
                pictureBox24.SendToBack();
                pnlOyuncu2.Show();
                
              //  WindowState = FormWindowState.Normal;
                timer = 5;
                timer1.Enabled = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beylik Savaşları | Aziz Utku K. \n(Burak S.'ya Teşekkür Ederim.) \n 09.02.2013  v1.0 Beta \n Telif Hakkı © 2013 Azutka. Tüm hakları saklıdır.  ", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yardim = new Yardim();
            yardim.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yardim = new Yardim();
            yardim.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beylik Savaşları | Aziz Utku K. \n (Burak S.'ya Teşekkür Ederim.) \n 09.02.2013  v1.0 Beta \n Telif Hakkı © 2013 Azutka. Tüm hakları saklıdır.  ", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string key = @"http\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            string defaultbrowserpath = ((string)registryKey.GetValue(null, null)).Split('"')[1];
            Process.Start(defaultbrowserpath, "http://www.facebook.com/AzutkaBeylikSavaslari");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string key = @"http\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            string defaultbrowserpath = ((string)registryKey.GetValue(null, null)).Split('"')[1];
            Process.Start(defaultbrowserpath, "http://www.facebook.com/AzutkaBeylikSavaslari");
        }















    }




}


