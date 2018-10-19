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
    public partial class FormTrabzon : Form
    {
        public frmHarita harita;
        public FormTrabzon()
        {
            InitializeComponent();
        }

        private void FormTrabzon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            harita.btnTrabzonK.PerformClick();
        }
    }
}
