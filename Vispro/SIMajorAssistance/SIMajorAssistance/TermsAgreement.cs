using System;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    public partial class TermsAgreement : Form
    {
        public TermsAgreement()
        {
            InitializeComponent();
        }

        private void Question1_Load(object sender, EventArgs e)
        {
            lblheader.Text = "Hello " + ValueGetSet.nama + " (" + ValueGetSet.nim + ")";

            lblinfo.Text = "Dalam membantu anda menentukan bidang peminatan yang cocok untuk anda," + Environment.NewLine +
                "maka kami mohon ketersediaan anda untuk menjawab beberapa pertanyaan " + Environment.NewLine +
                "yang akan kami ajukan" + Environment.NewLine + Environment.NewLine +
                "Seluruh data yang anda berikan akan dijamin kerahasiannya" + Environment.NewLine +
                "dan seluruh proses data perhitungan akan disimpan oleh prodi sebagai arsip" + Environment.NewLine + Environment.NewLine +
                "Metode perhitungan yang akan diterapkan dalam system ini adalah metode" + Environment.NewLine +
                "Weighted Product (WP)" + Environment.NewLine + Environment.NewLine +
                "System akan memulai proses perhitungan jika anda setuju dengan ketentuan di atas";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            NewEntry fnewentry = new NewEntry();
            fnewentry.Show();
            this.Hide();
        }

        private void btnsetuju_Click(object sender, EventArgs e)
        {
            Question1 fq1 = new Question1();
            fq1.Show();
            ValueGetSet.statequestion1 = false;
            ValueGetSet.statequestion2 = false;
            ValueGetSet.statequestion3 = false;
            ValueGetSet.statequestion4 = false;
            ValueGetSet.statequestion5 = false;
            this.Hide();
        }
    }
}