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

namespace Gestion_Paie_PFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void lollipopLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            inscription1.Hide();
            
        }

        private void gradPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "select UserName,Mot_passe from Admin where UserName='"+UserNameBox.Text+"' and Mot_passe='"+PassWordBox.Text+"'";
            //try
            //{
                Cc.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(Query, Cc);
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                if (Dt.Rows.Count == 0)
            {
                MsBox MS = new MsBox("Informations Incorrect !!", AlertType.error);
                MS.ShowDialog();
            }
                else
                {
                    CommonInfo.SetAdmin(UserNameBox.Text);
                    MainForm MainF = new MainForm();
                    MainF.Show();
                    this.Hide();
                }
                Cc.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Erreur !! 14 ");
            //}


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            inscription1.Show();
            

        }

        private void lollipopToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (lollipopToggle1.Checked == true) PassWordBox.UseSystemPasswordChar = false;
            else PassWordBox.UseSystemPasswordChar = true;
        }
    }
}
