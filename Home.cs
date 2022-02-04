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


namespace Gestion_Paie_PFE
{
    public partial class Inscription : UserControl
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lollipopCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopCheckBox1.Checked == true) MTpasse.UseSystemPasswordChar = false;
            else MTpasse.UseSystemPasswordChar = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InscrBtn_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String AccExist = "select Code from Codes where Code="+CodeAcc.Text+" and Used=0";
            try
            {
                Cc.Open();
                OleDbDataAdapter Da = new OleDbDataAdapter(AccExist,Cc);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                if (dt.Rows.Count == 0) {
                    MsBox MS = new MsBox("Code n'existe pas !!", AlertType.error);
                    MS.ShowDialog();
                }
                else
                {
                    String Query = "insert into Admin(NomComplet,UserName,Mot_passe)values('" + NomCmplet.Text + "','" + UserName.Text + "','" + MTpasse.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(Query, Cc);
                    cmd.ExecuteNonQuery();
                    String Query1 = "UPDATE Codes set Used=1 where Code=" + CodeAcc.Text;
                    OleDbCommand cmd1 = new OleDbCommand(Query1, Cc);
                    cmd1.ExecuteNonQuery();
                    this.Hide();
                }
                Cc.Close();
            }
            catch
            {
                MsBox MS = new MsBox("Code n'existe pas !!", AlertType.error);
                MS.ShowDialog();
            }
        }
    }
}
