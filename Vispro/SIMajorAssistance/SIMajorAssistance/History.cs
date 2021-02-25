using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    class History
    {

        public void RecordData()
        {
            string connstring = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\DatabaseMafuyu.mdb";
            string vquery = "INSERT INTO History (NIM,Nama,Angkatan,VektorSITGov,VektorSDatabase,VektorSERP,VektorSBigData,VektorITGov,VektorDatabase,VektorERP,VektorBigData) " +
                "values (@nim, @nama, @angkatan, @vsitgov, @vsdb, @vserp, @vsbd, @vitgov, @vdb, @verp, @vitgov)";
            OleDbConnection conn = new OleDbConnection(connstring);
            OleDbCommand cmd = new OleDbCommand(vquery, conn);
            cmd.Parameters.AddWithValue("@nim", ValueGetSet.nim);
            cmd.Parameters.AddWithValue("@nama", ValueGetSet.nama);
            cmd.Parameters.AddWithValue("@angkatan", ValueGetSet.angkatan);
            cmd.Parameters.AddWithValue("@vsitgov", Vektor.sitgov);
            cmd.Parameters.AddWithValue("@vsdb", Vektor.sdb);
            cmd.Parameters.AddWithValue("@vserp", Vektor.serp);
            cmd.Parameters.AddWithValue("@vsbd", Vektor.sbd);
            cmd.Parameters.AddWithValue("@vitgov", Vektor.vitgov);
            cmd.Parameters.AddWithValue("@vdb", Vektor.vdb);
            cmd.Parameters.AddWithValue("@verp", Vektor.verp);
            cmd.Parameters.AddWithValue("@vitgov", Vektor.vbd);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
