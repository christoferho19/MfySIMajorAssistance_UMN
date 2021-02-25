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
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        private int countclick = 0;

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            ValueGetSet.nama = txbnama.Text;
            ValueGetSet.nim = txbnim.Text;
            ValueGetSet.angkatan = txbangkatan.Text;

            TermsAgreement fq1 = new TermsAgreement();
            fq1.Show();
            this.Hide();
        }

        private void picboxlogo_Click(object sender, EventArgs e)
        {
            if(countclick < 2)
            {
                countclick++;
            }
            else if (countclick == 2 || countclick > 2)
            {
                CheckHistory fch = new CheckHistory();
                fch.Show();
            }
        }
    }
}
