using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Paie_PFE.MainControls
{
    public partial class Fonctions : UserControl
    {
        String ID;
        public Fonctions()
        {
            InitializeComponent();
            //this.Admin = Admin;
            ID = "";
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Fonctions_Load(object sender, EventArgs e)
        {
            ModifierBtn.Hide();
            CancelModif.Hide();
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query1 = "select * from Fonction";
            String Query2 = "select count(ID_Fonction) As 'Tot' from Fonction ";
            try {
                OleDbDataAdapter da = new OleDbDataAdapter(Query1, Cc);
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TotFonc.Text = dt2.Rows[0][0].ToString() + " Fonctions";
                da.Fill(dt);

                metroGrid1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = row["ID_Fonction"].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = row["Intitul_Fon"].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = row["Decs_Fonc"].ToString();
                    metroGrid1.Rows[n].Cells[3].Value = row["UserName"].ToString();
                }
            }
            catch
            {

            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            try
            {
            
                String Query = "insert into Fonction (Intitul_Fon,Decs_Fonc,UserName,Date_crea_fon)values('" + NomFonc.Text+"','"+DescFnc.Text+"','"+CommonInfo.GetAdmin()+"' , '"+DateTime.Now + "')";
                OleDbCommand AddFnc = new OleDbCommand(Query,Cc);
                Cc.Open();
                AddFnc.ExecuteNonQuery();
                Cc.Close();
                NomFonc.Clear();
                DescFnc.Clear();
                MsBox MS = new MsBox("Fonction Ajoutée !!", AlertType.success);
                MS.ShowDialog();
                Fonctions_Load(sender, e);
            }
            catch
            {
                MsBox MS = new MsBox("Vérifier les données entrées !!", AlertType.error);
                MS.ShowDialog();

            }
        }

        private void SuppBtn_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            try
            {
                var SelectedCell = metroGrid1.SelectedCells[0].Value;
                
                String Query = "DELETE FROM Fonction WHERE ID_Fonction="+SelectedCell.ToString();
                OleDbCommand cmd = new OleDbCommand(Query, Cc);
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Fonction Supprimée !!", AlertType.success);
                MS.ShowDialog();
                Fonctions_Load(sender, e);
            }
            catch
            {
                MsBox MS = new MsBox("Aucun élement selectioné !!", AlertType.error);
                MS.ShowDialog();

            }
        }

        private void ModifBtn_Click(object sender, EventArgs e)
        {
            try {
                ID = metroGrid1.SelectedCells[0].Value.ToString();
                NomFonc.Text = metroGrid1.SelectedCells[1].Value.ToString();
                DescFnc.Text = metroGrid1.SelectedCells[2].Value.ToString();
                AJOUTER.Hide();
                ModifierBtn.Show();
                CancelModif.Show();
            }
            catch
            {
                MsBox MS = new MsBox("Aucun élement selectioné !!", AlertType.error);
                MS.ShowDialog();

            }
        }

        private void CancelModif_Click(object sender, EventArgs e)
        {
            NomFonc.Clear();
            DescFnc.Clear();
            ModifierBtn.Hide();
            CancelModif.Hide();
            AJOUTER.Show();

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                String Query = "UPDATE Fonction SET Intitul_Fon='" + NomFonc.Text + "' , Decs_Fonc='" + DescFnc.Text + "', UserName='" + CommonInfo.GetAdmin() + "', Date_crea_fon='" + DateTime.Now + "' WHERE ID_Fonction=" + ID;
                OleDbCommand cmd = new OleDbCommand(Query, Cc);

                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Modifications Effectuées !!", AlertType.success);
                MS.ShowDialog();
                Fonctions_Load(sender, e);
                CancelModif_Click(sender, e);
            }
            catch
            {
                MsBox MS = new MsBox("Vérifier les données entrées !!", AlertType.error);
                MS.ShowDialog();
            }

            
        }

        private void SearchFon_TextChanged(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query1 = "select * from Fonction WHERE Intitul_Fon LIKE '"+SearchFon.Text+"%'";
            String Query2 = "select count(ID_Fonction) As 'Tot' from Fonction ";
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(Query1, Cc);
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TotFonc.Text = dt2.Rows[0][0].ToString() + " Fonctions";
                da.Fill(dt);

                metroGrid1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = row["ID_Fonction"].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = row["Intitul_Fon"].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = row["Decs_Fonc"].ToString();
                    metroGrid1.Rows[n].Cells[3].Value = row["UserName"].ToString();
                }
            }
            catch
            {

            }
        }
    }
}
