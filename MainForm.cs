using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Paie_PFE
{
    public partial class MainForm : Form
    {
       // Boolean LeftPan;
        public MainForm()
        {
            InitializeComponent();
            this.ExistingAdmin.Text = CommonInfo.GetAdmin();
            //LeftPan = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Top = HomeBtn.Top;
            SidePanel.Height = HomeBtn.Height;
            dashboard1.Show();
            slaires1.Hide();
            fonctions1.Hide();
            employes1.Hide();
            parametres1.Hide();
            historique1.Hide();
            dashboard1.BringToFront();
            dashboard1.Dashboard_Load(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Top = EmpBtn.Top;
            SidePanel.Height = EmpBtn.Height;
            dashboard1.Hide();
            slaires1.Hide();
            fonctions1.Hide();
            employes1.Show();
            parametres1.Hide();
            historique1.Hide();
            employes1.BringToFront();
            employes1.Employes_Load(sender, e);
        }

        private void SalaireBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Top = SalaireBtn.Top;
            dashboard1.Hide();
            slaires1.Show();
            fonctions1.Hide();
            employes1.Hide();
            parametres1.Hide();
            historique1.Hide();
            SidePanel.Height = SalaireBtn.Height;
            slaires1.BringToFront();
            slaires1.Slaires_Load(sender, e);
        }

        private void FnctBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Top = FnctBtn.Top;
            SidePanel.Height = FnctBtn.Height;
            dashboard1.Hide();
            slaires1.Hide();
            fonctions1.Show();
            employes1.Hide();
            parametres1.Hide();
            historique1.Hide();
            fonctions1.BringToFront();
            fonctions1.Fonctions_Load(sender, e);
            
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Top = SettingBtn.Top;
            SidePanel.Height = SettingBtn.Height;
            dashboard1.Hide();
            slaires1.Hide();
            fonctions1.Hide();
            employes1.Hide();
            parametres1.Show();
            historique1.Hide();
            parametres1.BringToFront();
            parametres1.Parametres_Load(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            CommonInfo.SetFormi(historique1);
            CommonInfo.SetEmployes(employes1);
            CommonInfo.SetFonctins(fonctions1);
            CommonInfo.SetSalary(slaires1);
            CommonInfo.SetSettings(parametres1);
            CommonInfo.MySideLocation(SidePanel);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*EreurWind Er = new EreurWind("Menu Ouvert");
            Er.ShowDialog();*/

            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (LeftPan == true)
            {
                if (MenuPanel.Width != 55) MenuPanel.Width = MenuPanel.Width - 25;
                else
                {
                    timer1.Stop();
                    LeftPan = false;
                    this.Refresh();
                }
            }
            else
            {
                if (MenuPanel.Width != 230) MenuPanel.Width = MenuPanel.Width + 25;
                else
                {
                    timer1.Stop();
                    LeftPan = false;
                    this.Refresh();
                }

            }*/
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String FbURL = "https://www.facebook.com";
            System.Diagnostics.Process.Start(FbURL);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            String InstURL = "https://www.instagram.com";
            System.Diagnostics.Process.Start(InstURL);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String TwiURL = "https://twitter.com";
            System.Diagnostics.Process.Start(TwiURL);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            String MailURL = "https://mail.google.com";
            System.Diagnostics.Process.Start(MailURL);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Fr = new Form1();
            Fr.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Top = HistoriqueBtn.Top;
            SidePanel.Height = HistoriqueBtn.Height;
            dashboard1.Hide();
            slaires1.Hide();
            fonctions1.Hide();
            employes1.Hide();
            parametres1.Hide();
            historique1.Show();
            historique1.BringToFront();
            historique1.Historique_Load(sender, e);
            
        }

        private void historique1_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
