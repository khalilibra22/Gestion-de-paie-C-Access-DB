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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void gradPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonInfo.GetSalary().BringToFront();
            CommonInfo.GetSalary().Show();
            CommonInfo.setLocation(0, 322);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonInfo.GettFonctins().BringToFront();
            CommonInfo.GettFonctins().Show();
            CommonInfo.setLocation(0, 454);
        }

        private void gradPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Histo_Click(object sender, EventArgs e)
        {
            CommonInfo.GetFOrmi().BringToFront();
            CommonInfo.GetFOrmi().Show();
            CommonInfo.setLocation(0, 586);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TempsP.Text = DateTime.Now.ToString("hh:mm");
            DateP.Text = DateTime.Now.ToShortDateString();
            try
            {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                String Query = "SELECT COUNT(ID_Salaire) FROM Salaire WHERE Format(Date_creat,'MM/yyyy')='"+DateTime.Now.ToString("MM/yyyy") +"'";
                OleDbDataAdapter da = new OleDbDataAdapter(Query, Cc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SalTxt.Text = dt.Rows[0][0].ToString();

                String Query1 = "SELECT COUNT(ID_Emp) FROM Employe";
                String Query2 = "SELECT COUNT(ID_Fonction) FROM Fonction";
                OleDbDataAdapter da1 = new OleDbDataAdapter(Query1, Cc);
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                da2.Fill(dt1);
                EmpTxt.Text = dt1.Rows[0][0].ToString();
                FonctTxt.Text = dt1.Rows[1][0].ToString();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TempsP.Text = DateTime.Now.ToString("hh:mm");
            DateP.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonInfo.GettEmployes().BringToFront();
            CommonInfo.GettEmployes().Show();
            CommonInfo.setLocation(0, 388);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonInfo.GettSettings().BringToFront();
            CommonInfo.GettSettings().Show();
            CommonInfo.setLocation(0, 520);
        }
    }
}
