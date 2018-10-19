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
    public partial class Baslangic : Form
    {
        public Form1 frm1;
        public Hakkinda hakkinda;
        public Yardim yardim;
        public Baslangic()
        {
            InitializeComponent();
            frm1=new Form1();
            frm1.baslangic=this;
            hakkinda = new Hakkinda();
            hakkinda.baslangic = this;
            yardim = new Yardim();
            yardim.baslangic = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                
                frm1.Show();
                yardim.Show();
                this.Hide();
            }

            else
            {
                frm1.Show();
                this.Hide();
            }
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            a = 1;
            yardim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beylik Savaşları | Aziz Utku K. \n(Burak S.'ya Teşekkür Ederim.) \n 09.02.2013  v1.0 Beta \n Telif Hakkı © 2013 Azutka. Tüm hakları saklıdır.  ", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
          
            string key = @"http\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            string defaultbrowserpath = ((string)registryKey.GetValue(null, null)).Split('"')[1];
            Process.Start(defaultbrowserpath, "http://www.facebook.com/AzutkaBeylikSavaslari");


        }
    }
}
