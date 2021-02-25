using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    public partial class CheckHistory : Form
    {
        public CheckHistory()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dgvhistory.Font = new System.Drawing.Font("Times", 9);
            dgvhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(txbpassword.Text.Equals( "UMNSI2017"))
            {
                try
                {
                    string connstring = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\DatabaseMafuyu.mdb";
                    OleDbConnection conn = new OleDbConnection(connstring);
                    string vquery = "select * from History";
                    OleDbDataAdapter da = new OleDbDataAdapter(vquery, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "History");
                    dgvhistory.DataSource = ds;
                    dgvhistory.DataMember = "History";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mohon Masukkan Password admin untuk mengecek data");
            }
        }
    }
}
