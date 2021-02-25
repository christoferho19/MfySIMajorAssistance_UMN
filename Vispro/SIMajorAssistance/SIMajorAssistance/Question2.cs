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
    public partial class Question2 : Form
    {
        public Question2()
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
                ValueGetSet.is251 = Convert.ToDouble(txbmatkul1.Text);
                countans++;
            }
            else if (checkmatkul1.Checked == true)
            {
                countans++;
            }

            if (checkmatkul2.Checked == false && txbmatkul2.Text != "")
            {
                ValueGetSet.is255 = Convert.ToDouble(txbmatkul2.Text);
                countans++;
            }
            else if (checkmatkul2.Checked == true)
            {
                countans++;
            }

            if (checkmatkul3.Checked == false && txbmatkul3.Text != "")
            {
                ValueGetSet.is341 = Convert.ToDouble(txbmatkul3.Text);
                countans++;
            }
            else if (checkmatkul3.Checked == true)
            {
                countans++;
            }

            if (checkmatkul4.Checked == false && txbmatkul4.Text != "")
            {
                ValueGetSet.is388 = Convert.ToDouble(txbmatkul4.Text);
                countans++;
            }
            else if (checkmatkul4.Checked == true)
            {
                countans++;
            }

            if (checkmatkul5.Checked == false && txbmatkul5.Text != "")
            {
                ValueGetSet.ik402 = Convert.ToDouble(txbmatkul5.Text);
                countans++;
            }
            else if (checkmatkul5.Checked == true)
            {
                countans++;
            }

            if (checkmatkul6.Checked == false && txbmatkul6.Text != "")
            {
                ValueGetSet.is403 = Convert.ToDouble(txbmatkul6.Text);
                countans++;
            }
            else if (checkmatkul6.Checked == true)
            {
                countans++;
            }

            if (checkmatkul7.Checked == false && txbmatkul7.Text != "")
            {
                ValueGetSet.is431 = Convert.ToDouble(txbmatkul7.Text);
                countans++;
            }
            else if (checkmatkul7.Checked == true)
            {
                countans++;
            }



            if (countans != 0)
            {
                ValueGetSet.statequestion2 = true;
                countans = 0;
            }

            Question3 fq3 = new Question3();
            fq3.Show();
            this.Hide();
        }

        private void Questionform_Load(object sender, EventArgs e)
        {
            lblheader.Text = "Mohon isi data nilai mata kuliah - mata kuliah dibawah ini";

            //Get nilai after back
            if(ValueGetSet.statequestion2 == true)
            {
                if (ValueGetSet.is251 == 0)
                {
                    checkmatkul1.Checked = true;
                }
                else if (ValueGetSet.is251 != 0)
                {
                    txbmatkul1.Text = ValueGetSet.is251.ToString();
                }

                if (ValueGetSet.is255 == 0)
                {
                    checkmatkul2.Checked = true;
                }
                else if (ValueGetSet.is255 != 0)
                {
                    txbmatkul2.Text = ValueGetSet.is255.ToString();
                }

                if (ValueGetSet.is341 == 0)
                {
                    checkmatkul3.Checked = true;
                }
                else if (ValueGetSet.is341 != 0)
                {
                    txbmatkul3.Text = ValueGetSet.is341.ToString();
                }

                if (ValueGetSet.is388 == 0)
                {
                    checkmatkul4.Checked = true;
                }
                else if (ValueGetSet.is388 != 0)
                {
                    txbmatkul4.Text = ValueGetSet.is388.ToString();
                }

                if (ValueGetSet.ik402 == 0)
                {
                    checkmatkul5.Checked = true;
                }
                else if (ValueGetSet.ik402 != 0)
                {
                    txbmatkul5.Text = ValueGetSet.ik402.ToString();
                }

                if (ValueGetSet.is403 == 0)
                {
                    checkmatkul6.Checked = true;
                }
                else if (ValueGetSet.is403 != 0)
                {
                    txbmatkul6.Text = ValueGetSet.is403.ToString();
                }

                if (ValueGetSet.is431 == 0)
                {
                    checkmatkul7.Checked = true;
                }
                else if (ValueGetSet.is431 != 0)
                {
                    txbmatkul7.Text = ValueGetSet.is431.ToString();
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Question1 fq1 = new Question1();
            fq1.Show();
            this.Hide();
        }
    }
}
