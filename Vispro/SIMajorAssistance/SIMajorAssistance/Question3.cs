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
    public partial class Question3 : Form
    {
        public Question3()
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


            if (checkmatkul1.Checked == false && txbmatkul1.Text != "")
            {
                ValueGetSet.is534 = Convert.ToDouble(txbmatkul1.Text);
                countans++;
            }
            else if (checkmatkul1.Checked == true)
            {
                countans++;
            }

            if (checkmatkul2.Checked == false && txbmatkul2.Text != "")
            {
                ValueGetSet.is545 = Convert.ToDouble(txbmatkul2.Text);
                countans++;
            }
            else if (checkmatkul2.Checked == true)
            {
                countans++;
            }

            if (checkmatkul3.Checked == false && txbmatkul3.Text != "")
            {
                ValueGetSet.is556 = Convert.ToDouble(txbmatkul3.Text);
                countans++;
            }
            else if (checkmatkul3.Checked == true)
            {
                countans++;
            }

            if (checkmatkul4.Checked == false && txbmatkul4.Text != "")
            {
                ValueGetSet.is588 = Convert.ToDouble(txbmatkul4.Text);
                countans++;
            }
            else if (checkmatkul4.Checked == true)
            {
                countans++;
            }

            if (countans != 0)
            {
                ValueGetSet.statequestion3 = true;
                countans = 0;
            }

            Question4 fq4 = new Question4();
            fq4.Show();
            this.Hide();
        }

        private void Questionform_Load(object sender, EventArgs e)
        {
            lblheader.Text = "Mohon isi data nilai mata kuliah - mata kuliah dibawah ini";

            //Get nilai after back
            if (ValueGetSet.statequestion3 == true)
            {
                if (ValueGetSet.is534 == 0)
                {
                    checkmatkul1.Checked = true;
                }
                else if (ValueGetSet.is534 != 0)
                {
                    txbmatkul1.Text = ValueGetSet.is534.ToString();
                }

                if (ValueGetSet.is545 == 0)
                {
                    checkmatkul2.Checked = true;
                }
                else if (ValueGetSet.is545 != 0)
                {
                    txbmatkul2.Text = ValueGetSet.is545.ToString();
                }

                if (ValueGetSet.is556 == 0)
                {
                    checkmatkul3.Checked = true;
                }
                else if (ValueGetSet.is556 != 0)
                {
                    txbmatkul3.Text = ValueGetSet.is556.ToString();
                }

                if (ValueGetSet.is588 == 0)
                {
                    checkmatkul4.Checked = true;
                }
                else if (ValueGetSet.is588 != 0)
                {
                    txbmatkul4.Text = ValueGetSet.is588.ToString();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Question2 fq2 = new Question2();
            fq2.Show();
            this.Hide();
        }
    }
}
