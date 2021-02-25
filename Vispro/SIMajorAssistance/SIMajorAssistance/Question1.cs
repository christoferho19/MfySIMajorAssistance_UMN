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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            /* if(txbmatkul1.Text != "")
             {
                 if(checkmatkul1.Checked == false)
                 {
                     ValueGetSet.if100 = Convert.ToInt64(txbmatkul1.Text);
                 }
             }
             else if (txbmatkul1.Text == "")
             {
                 MessageBox.Show("Mohon isi nilai mata kuliah IF-100 atau centang kotak belum mengambil jika belum mengambil mata kuliah");
             }*/

            int countans = 0;


            if(checkmatkul1.Checked == false && txbmatkul1.Text != "")
            {
                try
                {
                    ValueGetSet.if100 = Convert.ToDouble(txbmatkul1.Text);
                    countans++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (checkmatkul1.Checked == true)
            {
                countans++;
            }

            if (checkmatkul2.Checked == false && txbmatkul2.Text != "")
            {
                ValueGetSet.is100 = Convert.ToDouble(txbmatkul2.Text);
                countans++;
            }
            else if (checkmatkul2.Checked == true)
            {
                countans++;
            }

            if (checkmatkul3.Checked == false && txbmatkul3.Text != "")
            {
                ValueGetSet.ea100 = Convert.ToDouble(txbmatkul3.Text);
                countans++;
            }
            else if (checkmatkul3.Checked == true)
            {
                countans++;
            }

            if (checkmatkul4.Checked == false && txbmatkul4.Text != "")
            {
                ValueGetSet.em190 = Convert.ToDouble(txbmatkul4.Text);
                countans++;
            }
            else if (checkmatkul4.Checked == true)
            {
                countans++;
            }

            if (checkmatkul5.Checked == false && txbmatkul5.Text != "")
            {
                ValueGetSet.is201 = Convert.ToDouble(txbmatkul5.Text);
                countans++;
            }
            else if (checkmatkul5.Checked == true)
            {
                countans++;
            }

            if (checkmatkul6.Checked == false && txbmatkul6.Text != "")
            {
                ValueGetSet.is228 = Convert.ToDouble(txbmatkul6.Text);
                countans++;
            }
            else if (checkmatkul6.Checked == true)
            {
                countans++;
            }

            if (checkmatkul7.Checked == false && txbmatkul7.Text != "")
            {
                ValueGetSet.is240 = Convert.ToDouble(txbmatkul7.Text);
                countans++;
            }
            else if (checkmatkul7.Checked == true)
            {
                countans++;
            }



            if(countans != 0)
            {
                ValueGetSet.statequestion1 = true;
                countans = 0;
            }

            Question2 fq2 = new Question2();
            fq2.Show();
            this.Hide();
        }

        private void Questionform_Load(object sender, EventArgs e)
        {
            lblheader.Text = "Mohon isi data nilai mata kuliah - mata kuliah dibawah ini, "+" Contoh format pengisian : 92.1";

            //Get nilai after back
            if (ValueGetSet.statequestion1 == true)
            {
                if (ValueGetSet.if100 == 0)
                {
                    checkmatkul1.Checked = true;
                }
                else if (ValueGetSet.if100 != 0)
                {
                    txbmatkul1.Text = ValueGetSet.if100.ToString();
                }

                if (ValueGetSet.is100 == 0)
                {
                    checkmatkul2.Checked = true;
                }
                else if (ValueGetSet.is100 != 0)
                {
                    txbmatkul2.Text = ValueGetSet.is100.ToString();
                }

                if (ValueGetSet.ea100 == 0)
                {
                    checkmatkul3.Checked = true;
                }
                else if (ValueGetSet.ea100 != 0)
                {
                    txbmatkul3.Text = ValueGetSet.ea100.ToString();
                }

                if (ValueGetSet.em190 == 0)
                {
                    checkmatkul4.Checked = true;
                }
                else if (ValueGetSet.em190 != 0)
                {
                    txbmatkul4.Text = ValueGetSet.em190.ToString();
                }

                if (ValueGetSet.is201 == 0)
                {
                    checkmatkul5.Checked = true;
                }
                else if (ValueGetSet.is201 != 0)
                {
                    txbmatkul5.Text = ValueGetSet.is201.ToString();
                }

                if (ValueGetSet.is228 == 0)
                {
                    checkmatkul6.Checked = true;
                }
                else if (ValueGetSet.is228 != 0)
                {
                    txbmatkul6.Text = ValueGetSet.is228.ToString();
                }

                if (ValueGetSet.is240 == 0)
                {
                    checkmatkul7.Checked = true;
                }
                else if (ValueGetSet.is240 != 0)
                {
                    txbmatkul7.Text = ValueGetSet.is240.ToString();
                }
            }
        }

        private void checkmatkul1_CheckedChanged(object sender, EventArgs e)
        {
            /*if(checkmatkul1.Checked == true)
            {
                txbmatkul1.Enabled = false;
            }
            else if (checkmatkul1.Checked == false)
            {
                txbmatkul1.Enabled = true;
            }*/
        }
    }
}
