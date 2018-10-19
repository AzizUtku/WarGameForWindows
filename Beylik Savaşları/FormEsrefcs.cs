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
    public partial class FormEsrefcs : Form
    {
        public frmHarita harita;
        public FormEsrefcs()
        {
            InitializeComponent();
        }

        private void FormEsrefcs_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            harita.btnEsrefK.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
