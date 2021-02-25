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
    public partial class Question4 : Form
    {
        public Question4()
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

            if(checkT.Checked == true)
            {
                ValueGetSet.TechnicalState = true;
                countans++;
            }

            if (checkA.Checked == true)
            {
                ValueGetSet.AnalyticalState = true;
                countans++;
            }

            if (checkM.Checked == true)
            {
                ValueGetSet.ManagerialState = true;
                countans++;
            }

            if(countans == 0)
            {
                MessageBox.Show("Mohon pilih minimal 1 kategori");
            }
            else if (countans != 0)
            {
                countans = 0;
                ValueGetSet.statequestion4 = true;
                Question5 fq5 = new Question5();
                 fq5.Show();
                this.Hide();
            }
        }

        private void Questionform_Load(object sender, EventArgs e)
        {
            lblheader.Text = "Bidang pekerjaan IT secara umum dibagi menjadi 3 bagian, yaitu: " + Environment.NewLine +
                "Technical (Contohnya Programming dan Coding)" + Environment.NewLine +
                "Analytical (Contohnya Study Case) " + Environment.NewLine +
                "Managerial (Contohnya Auditing dan Penentuan kebijakan)" + Environment.NewLine + Environment.NewLine +
                "Mohon pilih dua pilihan!";

            if(ValueGetSet.statequestion4 == true)
            {
                if (ValueGetSet.TechnicalState == true)
                {
                    checkT.Checked = true;
                }

                if (ValueGetSet.AnalyticalState == true)
                {
                    checkA.Checked = true;
                }

                if (ValueGetSet.ManagerialState == true)
                {
                    checkM.Checked = true;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Question3 fq3 = new Question3();
            fq3.Show();
            this.Hide();
        }
    }
}
