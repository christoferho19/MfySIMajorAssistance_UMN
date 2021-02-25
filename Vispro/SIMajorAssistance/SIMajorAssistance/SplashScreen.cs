using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            onlytimer.Start();
            lbl2.Text = null;
            lbl1.Text = "Mafuyu Solution adalah sebuah Decission Support System (DSS) untuk menentukan" + Environment.NewLine
                + "peminatan yang cocok untuk mahasiswa Universistas Multimedia Nusantara" + Environment.NewLine
                + "program studi Sistem Informasi" + Environment.NewLine
                + "Program ini disusun sebagai proyek akhir mata kuliah IS-543 Decission Support System" + Environment.NewLine
                + "Algoritma yang digunakan adalah algoritma WP (Weighted Product)" + Environment.NewLine ;
        }

        private void onlytimer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if(progressBar.Value == 50)
            {
                lbl1.Text = null;
                lbl2.Text = "Mafuyu Solution disusun oleh mahasiswa kelas B, yaitu:" + Environment.NewLine
                + "Aria Eka Putra - 00000025749" + Environment.NewLine
                + "Catherine Anastasia - 00000020377" + Environment.NewLine
                + "Christofer Kemal Horas - 00000033887" + Environment.NewLine
                + "Patricia Altanny - 00000028877" + Environment.NewLine
                + "Vito Juliano - 0000026211" + Environment.NewLine;
            }

            if(progressBar.Value == 100)
            {
                onlytimer.Stop();
                NewEntry fne = new NewEntry();
                this.Hide();
                fne.Show();
            }
        }
    }
}
