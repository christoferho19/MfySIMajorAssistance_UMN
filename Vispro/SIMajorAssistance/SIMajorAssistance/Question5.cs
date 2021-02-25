using System;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int countans = 0;

            if(cmbbox1.Text == "- Pilihan 1 -")
            {
                MessageBox.Show("Mohon pilih peminatan utama anda");
            }
            else if (cmbbox1.Text != "- Pilihan 1 -")
            {
                ValueGetSet.minat1 = cmbbox1.Text;
                countans++;
            }

            if(cmbbox2.Text == "- Pilihan 2 -")
            {
                MessageBox.Show("Mohon pilih peminatan alternatif anda");
            }
            else  if (cmbbox2.Text != "- Pilihan 2 -")
            {
                ValueGetSet.minat2 = cmbbox2.Text;
                countans++;
            }

            if (cmbbox3.Text == "- Pilihan 3 -")
            {
                MessageBox.Show("Mohon pilih pekerjaan yang anda inginkan");
            }
            else if (cmbbox2.Text != "- Pilihan 3 -")
            {
                ValueGetSet.jobofchoice = cmbbox3.Text;
                countans++;
            }

            if (countans == 3)
            {
                ValueGetSet.statequestion5 = true;

                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin dengan data yang telah anda berikan?", "Proses data ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WP cwp = new WP();
                    countans = 0;
                    cwp.NilaiITGOV();
                    cwp.NilaiDB();
                    cwp.NilaiERP();
                    cwp.NilaiBD();
                    cwp.CountNilaiW();
                    cwp.CountBidang();
                    cwp.CountPeminatan();
                    cwp.CountPekerjaan();
                    cwp.CountVektorS();
                    cwp.CountFinalVektor();
                    cwp.SortFinalVektor();

                    History fdata = new History();
                    fdata.RecordData();

                    Result fresult = new Result();
                    fresult.Show();
                    this.Hide();

                    /*
                    MessageBox.Show(CriteriaDetermination.criteriavalueitgov.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriavaluedb.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriavalueerp.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriavaluebd.ToString());

                    MessageBox.Show(CriteriaDetermination.criteriabidangitgov.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriabidangdb.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriabidangerp.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriabidangbd.ToString());

                    MessageBox.Show(CriteriaDetermination.criteriaminatitgov.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriaminatdb.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriaminaterp.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriaminatbd.ToString());

                    MessageBox.Show(CriteriaDetermination.criteriakerjaitgov.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriakerjadb.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriakerjaerp.ToString() + Environment.NewLine
                        + CriteriaDetermination.criteriakerjabd.ToString());

                    MessageBox.Show(CriteriaDetermination.Wnilai.ToString() + Environment.NewLine
                        + CriteriaDetermination.Wdiminati.ToString() + Environment.NewLine
                        + CriteriaDetermination.Wpeminatan.ToString() + Environment.NewLine
                        + CriteriaDetermination.Wpekerjaan.ToString());

                    MessageBox.Show(Vektor.sitgov.ToString() + Environment.NewLine
                        + Vektor.sdb.ToString() + Environment.NewLine
                        + Vektor.serp.ToString() + Environment.NewLine
                        + Vektor.sbd.ToString());

                    MessageBox.Show(Vektor.vitgov.ToString() + Environment.NewLine
                        + Vektor.vdb.ToString() + Environment.NewLine
                        + Vektor.verp.ToString() + Environment.NewLine
                        + Vektor.vbd.ToString());

                    MessageBox.Show(Vektor.first + Environment.NewLine
                        + Vektor.second + Environment.NewLine
                        + Vektor.third + Environment.NewLine
                        + Vektor.last);*/
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void Questionform_Load(object sender, EventArgs e)
        {
            cmbbox1.SelectedIndex = 0;
            cmbbox2.SelectedIndex = 0;
            cmbbox3.SelectedIndex = 0;

            if (ValueGetSet.statequestion5 == true)
            {
                cmbbox1.Text = ValueGetSet.minat1;
                cmbbox2.Text = ValueGetSet.minat2;
                cmbbox3.Text = ValueGetSet.jobofchoice;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Question4 fq4 = new Question4();
            fq4.Show();
            this.Hide();
        }
    }
}