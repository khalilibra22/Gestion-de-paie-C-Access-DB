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
using System.IO;

namespace Gestion_Paie_PFE.MainControls
{
    public partial class Parametres : UserControl
    {
        public Parametres()
        {
            InitializeComponent();
        }

        private void AddCodeBtn_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "insert into Codes(Code,Used)values("+CodeBox.Text+",0)";
            OleDbCommand cmd = new OleDbCommand(Query, Cc);
            try
            {
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                Parametres_Load(sender, e);
                CodeBox.Clear();
                MsBox MS = new MsBox("Ajouté !!", AlertType.success);
                MS.ShowDialog();

            }
            catch
            {
                MsBox MS = new MsBox("Vérifier les données entrées !!", AlertType.error);
                MS.ShowDialog();
            }
        }
        

        public void Parametres_Load(object sender, EventArgs e)
        {
           
            try {
                var Utilise="";
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());


                String Query = "select * from Admin where UserName='" + CommonInfo.GetAdmin() + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(Query, Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AdminNom.Text = dt.Rows[0][0].ToString();
                AdminEmail.Text = dt.Rows[0][1].ToString();
                UserName.Text = dt.Rows[0][2].ToString();
                Mtpasse.Text = dt.Rows[0][3].ToString();
           
            String Query2 = "SELECT * FROM Etablissement_Infos";
            OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if (dt2.Rows.Count != 0)
            {
                Etabl.Text = dt2.Rows[0][0].ToString();
                Ministere.Text = dt2.Rows[0][1].ToString();
                Email.Text = dt2.Rows[0][2].ToString();
                Adresse.Text = dt2.Rows[0][3].ToString();
                Telph.Text = dt2.Rows[0][4].ToString();
                LogoImg.Image = Image.FromFile(dt2.Rows[0][5].ToString());
                LogoPath.Text = dt2.Rows[0][5].ToString();

            }
                String Query3 = "SELECT * FROM Codes";
                OleDbDataAdapter da3 = new OleDbDataAdapter(Query3, Cc);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                metroGrid1.Rows.Clear();
                foreach( DataRow row in dt3.Rows)
                {
                    int n = metroGrid1.Rows.Add();
                    metroGrid1.Rows[n].Cells[0].Value = row["Code"].ToString();
                    if (Convert.ToBoolean(row["Used"].ToString())) Utilise = "OUI";
                    else Utilise = "NON";
                    metroGrid1.Rows[n].Cells[1].Value = Utilise.ToString();
                }
                CodeNum.Text = (metroGrid1.Rows.Count - 1).ToString() + " Codes";

            }
            catch
            {

            }
        }

        private void lollipopToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle1.Checked) AdminNom.ReadOnly = false;
            else AdminNom.ReadOnly = true;
        }

        private void lollipopToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle2.Checked) UserName.ReadOnly = false;
            else UserName.ReadOnly = true;
        }

        private void lollipopToggle3_CheckedChanged(object sender, EventArgs e)
        {
            if(lollipopToggle3.Checked) AdminEmail.ReadOnly = false;
            else AdminEmail.ReadOnly = true;
        }

        private void lollipopToggle4_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle3.Checked)
            {
                Mtpasse.Clear();
                Mtpasse.ReadOnly = false;
            }
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "UPDATE Etablissement_Infos SET  Nom_Etab='" + Etabl.Text+
                                                            "', Ministere='"+Ministere.Text+
                                                            "', Email='"+Email.Text+
                                                            "', Adresse='"+Adresse.Text+
                                                            "', TelephEtab='"+Telph.Text+"'"+
                                                            ",Logo='"+LogoPath.Text+"'";
            OleDbCommand cmd = new OleDbCommand(Query, Cc);
            //try {
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Modifications Effectuées", AlertType.success);
                MS.ShowDialog();
                Parametres_Load(sender, e);
            //}
            //catch
            //{
            //    MsBox MS = new MsBox("Erreur !!", AlertType.error);
            //    MS.ShowDialog();
            //}

        }

        private void lollipopToggle5_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle5.Checked) Etabl.ReadOnly = false;
            else Etabl.ReadOnly = true;
        }

        private void lollipopToggle6_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle6.Checked) Ministere.ReadOnly = false;
            else Ministere.ReadOnly = true;
        }

        private void lollipopToggle7_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle7.Checked) Adresse.ReadOnly = false;
            else Adresse.ReadOnly = true;
        }

        private void lollipopToggle8_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle8.Checked) Telph.ReadOnly = false;
            else Telph.ReadOnly = true;
        }

        private void lollipopToggle9_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle9.Checked) Email.ReadOnly = false;
            else Email.ReadOnly = true;
        }

        private void SaveAdminInfo_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "UPDATE Admin SET NomComplet='"+AdminNom.Text+
            "' , Email='"+AdminEmail.Text+ "' , Mot_passe='"+Mtpasse.Text+"'";
            OleDbCommand cmd = new OleDbCommand(Query, Cc);
           
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                MsBox MS = new MsBox("Modifications Effectuées", AlertType.success);
                MS.ShowDialog();
           
        }

        private void SuppCodBtn_Click(object sender, EventArgs e)
        {

            
            
            try {
                var SelectedCell = metroGrid1.SelectedCells[0].Value;
                String Query = "DELETE FROM Codes WHERE Code=" + SelectedCell;
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                OleDbCommand cmd = new OleDbCommand(Query, Cc);
                Cc.Open();
                cmd.ExecuteNonQuery();
                Cc.Close();
                Parametres_Load(sender, e);
                MsBox MS = new MsBox("Supprimé !!", AlertType.success);
                MS.ShowDialog();
            }
            catch
            {
                MsBox MS = new MsBox("Aucun élement selectioné !!", AlertType.error);
                MS.ShowDialog();
            }
        }
    }
}
