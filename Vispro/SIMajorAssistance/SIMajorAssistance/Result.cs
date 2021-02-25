using System;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resultform_Load(object sender, EventArgs e)
        {
            lblnama.Text = ValueGetSet.nama;
            lblnim.Text = ValueGetSet.nim;
            lblangkatan.Text = ValueGetSet.angkatan;

            lblhasil1.Text = Vektor.first;
            lblhasil2.Text = Vektor.second;
            lblhasil3.Text = Vektor.third;
            lblhasil4.Text = Vektor.last;
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima Kasih");
            Application.Exit();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kembali ke awal?", "New ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ValueGetSet fVGS = new ValueGetSet();
                fVGS.resetdata();

                CriteriaDetermination fCD = new CriteriaDetermination();
                fCD.resetdata();

                Vektor fv = new Vektor();
                fv.resetdata();

                NewEntry fnew = new NewEntry();
                fnew.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}