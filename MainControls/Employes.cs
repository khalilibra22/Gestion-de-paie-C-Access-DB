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
    public partial class Employes : UserControl
    {
        int Sx;
        int SitFam;
        String ID;
        public Employes()
        {
            InitializeComponent();
            Sx = 0;
            SitFam = 0;
            ID = "";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void Employes_Load(object sender, EventArgs e)
        {
            ModifierBtn.Hide();
            CancelModif.Hide();
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query1 = "Select Intitul_Fon from Fonction";
            String Query = "select * from Employe";
            try
            {
                OleDbDataAdapter da1 = new OleDbDataAdapter(Query1, Cc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                FoncBX.Items.Clear();
                foreach (DataRow item in dt1.Rows)
                {
                    FoncBX.Items.Add(item["Intitul_Fon"].ToString());
                }
                FoncBX.SelectedIndex = 0;
                OleDbDataAdapter da = new OleDbDataAdapter(Query,Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.Rows.Clear();
                foreach(DataRow Row in dt.Rows)
                {
                    int n=metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = Row["ID_Emp"].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = Row["Nom"].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = Row["Prenom"].ToString();
                    DateTime Date_Naissan = Convert.ToDateTime(Row["Date_Naiss"]);
                    metroGrid1.Rows[n].Cells[3].Value = Date_Naissan.ToShortDateString();
                    DateTime DatRecrut = Convert.ToDateTime(Row["Date_Recrt"]);
                    metroGrid1.Rows[n].Cells[4].Value = DatRecrut.ToShortDateString();
                    OleDbDataAdapter da3 = new OleDbDataAdapter("SELECT Intitul_Fon FROM Fonction WHERE ID_Fonction="+ Row["ID_Fonction"], Cc);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    metroGrid1.Rows[n].Cells[5].Value = dt3.Rows[0][0].ToString();
                    if (Convert.ToInt32(Row["Sexe"]) == 1)
                        metroGrid1.Rows[n].Cells[6].Value = "Femme";
                    else metroGrid1.Rows[n].Cells[6].Value = "Homme";
                    
                    switch (Convert.ToInt32(Row["Situation_fam"]))
                    {
                        case 0: metroGrid1.Rows[n].Cells[7].Value= "Célibataire"; break;
                        case 1: metroGrid1.Rows[n].Cells[7].Value = "Marié(e)"; break;
                        case 2: metroGrid1.Rows[n].Cells[7].Value = "Divorcé(e)"; break;
                        case 3: metroGrid1.Rows[n].Cells[7].Value = "Veuf(ve)"; break;
                    }
                    metroGrid1.Rows[n].Cells[8].Value = Row["N_Telph"].ToString();
                    metroGrid1.Rows[n].Cells[9].Value = Row["CCP"].ToString();
                    metroGrid1.Rows[n].Cells[10].Value = Row["NSS"].ToString();
                    metroGrid1.Rows[n].Cells[11].Value = Row["UserName"].ToString();

            }
                
            String Query2 = "SELECT COUNT(ID_Emp) As 'Tot' FROM Employe";
            OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            EmpTot.Text = dt2.Rows[0][0].ToString()+" Employés";
            }
            catch
            {

            }

        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            
            if (Sexe.Text == "Femme") Sx = 1;
            if (Sexe.Text == "Homme") Sx = 0;
            if (SituationFam.Text == "Célibataire") SitFam = 0;
            if (SituationFam.Text == "Marié(e)") SitFam = 1;
            if (SituationFam.Text == "Divorcé(e)") SitFam = 2;
            if (SituationFam.Text == "Veuf(ve)") SitFam = 3;
            try {
                String Query1 = "select ID_Fonction from Fonction where Intitul_Fon='" + FoncBX.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(Query1, Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                String FonId = dt.Rows[0][0].ToString();
                String Query = "insert into Employe(Nom,Prenom,Date_Naiss,Date_Recrt,Sexe,N_Telph,CCP,NSS,ID_Fonction,UserName,Situation_fam,Date_Crea_E)" +
                                 "values('" + NomBx.Text + "','" + PrenomBx.Text + "','" + DateNaiss.Value.ToShortDateString() + "','" + DateRecru.Value.ToShortDateString() + "'," + Sx +
                                 ",'" + TelphBx.Text + "','" + CCPbX.Text + "','" + NSSbX.Text + "'," + FonId + ",'" + CommonInfo.GetAdmin() + "'," + SitFam +", '"+DateTime.Now+"' )";
                OleDbCommand cmd = new OleDbCommand(Query, Cc);
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Employé Ajouté !!", AlertType.success);
                MS.ShowDialog();
                NomBx.Clear();
                PrenomBx.Clear();
                DateNaiss.Value = DateTime.Now;
                DateRecru.Value = DateTime.Now;
                TelphBx.Clear();
                CCPbX.Clear();
                NSSbX.Clear();
                LieuNaiss.Clear();
                Employes_Load(sender, e);
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
            var SelectedCell = metroGrid1.SelectedCells[0].Value;
            
            String Query = "DELETE FROM Employe WHERE ID_Emp="+ SelectedCell;
            try {
                OleDbCommand cmd = new OleDbCommand(Query, Cc);
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                Employes_Load(sender, e);
                MsBox MS = new MsBox("Supprimé !!", AlertType.success);
                MS.ShowDialog();
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
                NomBx.Text = metroGrid1.SelectedCells[1].Value.ToString();
                PrenomBx.Text = metroGrid1.SelectedCells[2].Value.ToString();
                FoncBX.Text = metroGrid1.SelectedCells[5].Value.ToString();
                DateNaiss.Value = Convert.ToDateTime(metroGrid1.SelectedCells[3].Value);
                //lieu de naissance ici !!
                DateRecru.Value = Convert.ToDateTime(metroGrid1.SelectedCells[4].Value);
                Sexe.Text = metroGrid1.SelectedCells[6].Value.ToString();
                SituationFam.Text = metroGrid1.SelectedCells[7].Value.ToString();
                TelphBx.Text = metroGrid1.SelectedCells[8].Value.ToString();
                CCPbX.Text = metroGrid1.SelectedCells[9].Value.ToString();
                NSSbX.Text = metroGrid1.SelectedCells[10].Value.ToString();
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
            NomBx.Clear();
            PrenomBx.Clear();
            DateNaiss.Value = DateTime.Now;
            DateRecru.Value = DateTime.Now;
            TelphBx.Clear();
            CCPbX.Clear();
            NSSbX.Clear();
            LieuNaiss.Clear();
            ModifierBtn.Hide();
            CancelModif.Hide();
            AJOUTER.Show();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                String Query1 = "select ID_Fonction from Fonction where Intitul_Fon='" + FoncBX.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(Query1, Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                var FonId = dt.Rows[0][0];
                String Query = "UPDATE Employe SET Nom='" + NomBx.Text + "' , Prenom='" + PrenomBx.Text +
                "' ,Date_Naiss='" + DateNaiss.Value + "', Date_Recrt='" + DateRecru.Value + "', Sexe=" + Sexe.SelectedIndex +
                ", N_Telph='" + TelphBx.Text + "', CCP='" + CCPbX.Text + "', NSS='" + NSSbX.Text + "',ID_Fonction=" + FonId +
                ", UserName='" + CommonInfo.GetAdmin() + "',Situation_fam=" + SituationFam.SelectedIndex + " , Date_Crea_E='"+DateTime.Now+ "' WHERE ID_Emp=" + ID;

                OleDbCommand cmd = new OleDbCommand(Query, Cc);
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Modifications Effectuées !!", AlertType.success);
                MS.ShowDialog();
                Employes_Load(sender, e);
                CancelModif_Click(sender, e);
            }
            catch
            {
                MsBox MS = new MsBox("Aucun élement selectioné !!", AlertType.error);
                MS.ShowDialog();
            }
        }

        private void SearchEmp_TextChanged(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "select * from Employe WHERE Nom LIKE '" + SearchEmp.Text + "%' OR Prenom LIKE '" + SearchEmp.Text + "%'";
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(Query, Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.Rows.Clear();
                foreach (DataRow Row in dt.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = Row["ID_Emp"].ToString();
                    metroGrid1.Rows[n].Cells[1].Value = Row["Nom"].ToString();
                    metroGrid1.Rows[n].Cells[2].Value = Row["Prenom"].ToString();
                    DateTime Date_Naissan = Convert.ToDateTime(Row["Date_Naiss"]);
                    metroGrid1.Rows[n].Cells[3].Value = Date_Naissan.ToShortDateString();
                    DateTime DatRecrut = Convert.ToDateTime(Row["Date_Recrt"]);
                    metroGrid1.Rows[n].Cells[4].Value = DatRecrut.ToShortDateString();
                    OleDbDataAdapter da3 = new OleDbDataAdapter("SELECT Intitul_Fon FROM Fonction WHERE ID_Fonction=" + Row["ID_Fonction"], Cc);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    metroGrid1.Rows[n].Cells[5].Value = dt3.Rows[0][0].ToString();
                    if (Convert.ToInt32(Row["Sexe"]) == 1)
                        metroGrid1.Rows[n].Cells[6].Value = "Femme";
                    else metroGrid1.Rows[n].Cells[6].Value = "Homme";

                    switch (Convert.ToInt32(Row["Situation_fam"]))
                    {
                        case 0: metroGrid1.Rows[n].Cells[7].Value = "Célibataire"; break;
                        case 1: metroGrid1.Rows[n].Cells[7].Value = "Marié(e)"; break;
                        case 2: metroGrid1.Rows[n].Cells[7].Value = "Divorcé(e)"; break;
                        case 3: metroGrid1.Rows[n].Cells[7].Value = "Veuf(ve)"; break;
                    }
                    metroGrid1.Rows[n].Cells[8].Value = Row["N_Telph"].ToString();
                    metroGrid1.Rows[n].Cells[9].Value = Row["CCP"].ToString();
                    metroGrid1.Rows[n].Cells[10].Value = Row["NSS"].ToString();
                    metroGrid1.Rows[n].Cells[11].Value = Row["UserName"].ToString();

                }
                //String Query2 = "SELECT COUNT(ID_Emp) As 'Tot' FROM Employe";
                //OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                //DataTable dt2 = new DataTable();
                //da2.Fill(dt2);
                //Tot_Emp.Text = dt2.Rows[0][0].ToString();
            }
            catch
            {

            }
        }
    }
}
