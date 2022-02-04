using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gestion_Paie_PFE.MainControls
{
    public partial class Historique : UserControl
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void Historique_Load(object sender, EventArgs e)
        {
            try {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());

                //Salaires
                String Query1 = "SELECT TOP 2 ID_Salaire , UserName ,Format(Date_creat,'dd/MM/yy hh:mm') FROM Salaire ORDER BY Date_creat DESC";
                OleDbDataAdapter da1 = new OleDbDataAdapter(Query1, Cc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                User1.Text = dt1.Rows[0][1].ToString() + ":";
                User2.Text = dt1.Rows[1][1].ToString() + ":";
                N1.Text = dt1.Rows[0][0].ToString();
                N2.Text = dt1.Rows[1][0].ToString();
                Tm1.Text = dt1.Rows[0][2].ToString();
                Tm2.Text = dt1.Rows[1][2].ToString();

                //Employés
                String Query2 = "SELECT TOP 2 ID_Emp , UserName , Format(Date_Crea_E,'dd/MM/yy hh:mm') FROM Employe ORDER BY Date_Crea_E DESC";
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                User3.Text = dt2.Rows[0][1].ToString() + ":";
                User4.Text = dt2.Rows[1][1].ToString() + ":";
                N3.Text = dt2.Rows[0][0].ToString();
                N5.Text = dt2.Rows[1][0].ToString();
                TM3.Text = dt2.Rows[0][2].ToString();
                TM4.Text = dt2.Rows[1][2].ToString();

                //Fonction
                String Query3 = "SELECT TOP 1 ID_Fonction , UserName , Format(Date_crea_fon,'dd/MM/yy hh:mm') FROM Fonction ORDER BY Date_crea_fon DESC";
                OleDbDataAdapter da3 = new OleDbDataAdapter(Query3, Cc);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                User5.Text = dt3.Rows[0][1].ToString() + ":";
                N6.Text = dt3.Rows[0][0].ToString();
                TM5.Text = dt3.Rows[0][2].ToString();

                //All

                String Query4 = "SELECT ID_Salaire  As 'ID', UserName, 'Salaires' AS 'Trait' , Format(Date_creat,'dd/MM/yy hh:mm') AS 'Tmp' FROM Salaire "
                               + "UNION "
                               + "SELECT ID_Emp  As 'ID', UserName, 'Employés' AS 'Trait' , Format(Date_Crea_E,'dd/MM/yy hh:mm') AS 'Tmp' FROM Employe "
                               + "UNION "
                               + "SELECT ID_Fonction  As 'ID', UserName, 'Fonctions' AS 'Trait' , Format(Date_crea_fon,'dd/MM/yy hh:mm') AS 'Tmp' FROM Fonction";

                OleDbDataAdapter da4 = new OleDbDataAdapter(Query4, Cc);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                metroGrid1.Rows.Clear();
                foreach (DataRow row in dt4.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = row[3].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = row[1].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = row[2].ToString();
                    metroGrid1.Rows[n].Cells[3].Value = row[0].ToString();
                }
                Tot_trait.Text = (metroGrid1.Rows.Count - 1).ToString() + " Traitements ";
            }
            catch
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
 
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            try {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                String Query = "SELECT ID_Salaire  As 'ID', UserName, 'Salaires' AS 'Trait' , Format(Date_creat,'dd/MM/yy hh:mm') AS 'Tmp' FROM Salaire "
                               + " WHERE UserName LIKE '" + Search.Text + "%'"
                               + "UNION "
                               + "SELECT ID_Emp  As 'ID', UserName, 'Employés' AS 'Trait' , Format(Date_Crea_E,'dd/MM/yy hh:mm') AS 'Tmp'  FROM Employe "
                               + " WHERE UserName LIKE '" + Search.Text + "%'"
                               + "UNION "
                               + "SELECT ID_Fonction  As 'ID', UserName, 'Fonctions' AS 'Trait' , Format(Date_crea_fon,'dd/MM/yy hh:mm') AS 'Tmp'  FROM Fonction  "
                               + " WHERE UserName LIKE '" + Search.Text + "%'";

                OleDbDataAdapter da4 = new OleDbDataAdapter(Query, Cc);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                metroGrid1.Rows.Clear();
                foreach (DataRow row in dt4.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = row[3].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = row[1].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = row[2].ToString();
                    metroGrid1.Rows[n].Cells[3].Value = row[0].ToString();
                }
            }
            catch
            {

            }
        }
    }
}
