using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbpendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan Anda {0}", pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, hebat !!", pekerjaan);
        }
    }
}
