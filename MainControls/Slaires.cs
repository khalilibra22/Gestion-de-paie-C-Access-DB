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
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Gestion_Paie_PFE.MainControls
{
    public partial class Slaires : UserControl
    {
        Decimal Salaire_Base;
        Decimal irg;
        Decimal _1Cacul;
        Decimal Abtt;
        Boolean Saved;
        Boolean EmpAjouté;
        Boolean Calculé;
        Boolean Check;
        Boolean Check2;
        String ID;
        public Slaires()
        {
            InitializeComponent();
            irg = 0;
            _1Cacul = 0;
            Abtt = 0;
            Saved = false;
            EmpAjouté = false;
            Calculé = false;
            Check = false;
            Check2 = false;

        }

        private void metroTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Decimal Indemnite_exp_professionnelle()
        {
            Decimal Taux = Convert.ToDecimal(TauxIEP.Text.Replace('.', ','));

            Decimal IEP = (Salaire_Base * Taux) / 100;

            return IEP;
        }
        Decimal Indemnite_service_permanent()
        {
            Decimal Taux = Convert.ToDecimal(TauxISP.Text.Replace('.', ','));
            Decimal ISP=(Salaire_Base * Taux)/100;
            return ISP;
        }
        Decimal Indemnite_nuisance()
        {
            Decimal Taux = Convert.ToDecimal(TauxIN.Text.Replace('.',','));
            Decimal IN = (Salaire_Base * Taux) / 100;
            return IN;
        }
        Decimal Salaire_Poste()
        {
            Decimal Sal_Poste=Salaire_Base+this.Indemnite_exp_professionnelle()+this.Indemnite_service_permanent()+this.Indemnite_nuisance();
            return Sal_Poste;
        }
        Decimal Retenue_Sec_Sociale()
        {
            Decimal SS = (Salaire_Poste() * 9) / 100;
            return SS;
        }
        Decimal Indemnite_Transport()
        {
            Decimal Trans=Convert.ToDecimal(ItJr.Text.Replace('.', ',')) * Convert.ToDecimal(ItPU.Text.Replace('.', ','));
            return Trans;
        }
        Decimal Indemnite_Panier()
        {
            Decimal Panier = Convert.ToDecimal(IpJr.Text.Replace('.', ',')) * Convert.ToDecimal(IpPU.Text.Replace('.', ','));
            return Panier;
        }
        Decimal BaseIrg()
        {
            Decimal Base=(this.Salaire_Poste()+this.Indemnite_Panier()+this.Indemnite_Transport())-Retenue_Sec_Sociale();
            return Base;
        }
        Decimal Retenue_IRG()
        {
            Decimal LaBase = this.BaseIrg();
            if (LaBase <= 10000) irg = 0;
            else if(LaBase>10000 && LaBase <= 30000)
            {
                _1Cacul = ((LaBase - 10000)*20)/100;
                 
            }
            else if(LaBase>30000 && LaBase <= 120000)
            {
                _1Cacul = (((LaBase - 30000) * 30) / 100) + 4000;
                
            }
            else if (LaBase > 120000)
            {
                _1Cacul = (((LaBase - 120000) * 35) / 100) + 31000;
                
            }
            Abtt = (_1Cacul * 40) / 100;
            if (Abtt < 1000) Abtt = 1000;
            else if (Abtt > 1500) Abtt = 1500;
            irg = _1Cacul - Abtt;
            if (irg < 0) irg = 0;
            return irg;
        }
        Decimal ToT_Revenues()
        {
            
            
            Decimal AutresRev = Convert.ToDecimal(IZG.Text.Replace('.', ',')) + Convert.ToDecimal(Mission.Text.Replace('.', ',')) + Convert.ToDecimal(Autre.Text.Replace('.', ','));
          
            Decimal Tot = this.Salaire_Poste() + this.Indemnite_Panier() + this.Indemnite_Transport() + AutresRev;
            
            return Tot;
           
        }
        Decimal Tot_retenues()
        {
            Decimal Tot = this.Retenue_IRG() + this.Retenue_Sec_Sociale() + Convert.ToDecimal(AcompteVerse.Text.Replace('.', ','));
            return Tot;
        }
        Decimal Salaire_Net()
        {
            return this.ToT_Revenues() - this.Tot_retenues();
        }
        public void Slaires_Load(object sender, EventArgs e)
        {
            ISNewSalary_CheckedChanged(sender, e);
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "select * from Employe";
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
                String Query2 = "SELECT COUNT(ID_Emp) As 'Tot' FROM Employe";
                OleDbDataAdapter da2 = new OleDbDataAdapter(Query2, Cc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                Tot_Emp.Text = dt2.Rows[0][0].ToString();
            }
            catch
            {

            }
           
        }

        private void Cacul_Salaire_Click(object sender, EventArgs e)
        {
            if (!EmpAjouté)
            {
                MsBox MS = new MsBox("Ajouter un employé d'abord!!", AlertType.info);
                MS.ShowDialog();
            }
            else
            {
                Check_info();
                if (Check && Check2)
                {

                    Salaire_Base = Convert.ToDecimal(SlrBaseBox.Text.Replace('.', ','));
                    IEP.Text = Indemnite_exp_professionnelle().ToString();
                    ISP.Text = Indemnite_service_permanent().ToString();
                    IN.Text = Indemnite_nuisance().ToString();
                    RSS.Text = Retenue_Sec_Sociale().ToString();
                    IT.Text = Indemnite_Transport().ToString();
                    IP.Text = Indemnite_Panier().ToString();
                    IRG.Text = Retenue_IRG().ToString();
                    TotRetenues.Text = this.Tot_retenues().ToString() + " DA";
                    TotalGains.Text = this.ToT_Revenues().ToString() + " DA";
                    NetSal.Text = this.Salaire_Net().ToString() + " DA";

                    Calculé = true;
                }
            }
        }

        private void SaveSalary_Click(object sender, EventArgs e)
        {
            if (!Calculé)
            {
                MsBox MS = new MsBox("Calculé le salaire d'abord puis sauvegarder", AlertType.info);
                MS.ShowDialog();
            }
            else 
            {
                try {
                    BDD Bd = new BDD();
                    OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                    String LaPeriode = PeriodBox.Value.ToString("MM/yyyy");
                    String SalaryExist = "SELECT ID_Salaire FROM Salaire WHERE Format(Periode ,'MM/yyyy') ='" + LaPeriode + "' AND ID_Emp=" + IDbox.Text;
                    OleDbDataAdapter da = new OleDbDataAdapter(SalaryExist, Cc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count != 0)
                    {
                        MsBox MS1 = new MsBox("Le salaire du mois: " + LaPeriode + " etait déjà ajouté", AlertType.info);
                        MS1.ShowDialog();
                    }
                    else
                    {
                        String Salaire_Base = SlrBaseBox.Text.Replace(',', '.');
                        String Taux_IEP = TauxIEP.Text.Replace(',', '.');
                        String Taux_ISP = TauxISP.Text.Replace(',', '.');
                        String Taux_IN = TauxIN.Text.Replace(',', '.');
                        String PrixU_ITrans = ItPU.Text.Replace(',', '.');
                        String NbrJourTrans = ItJr.Text.Replace(',', '.');
                        String PrixU_IPanier = IpPU.Text.Replace(',', '.');
                        String NbrJrPanier = IpJr.Text.Replace(',', '.');
                        String I_Zone_Geo = IZG.Text.Replace(',', '.');
                        String Frais_Mission = Mission.Text.Replace(',', '.');
                        String Acompte_Verse = AcompteVerse.Text.Replace(',', '.');
                        String Periode = PeriodBox.Value.ToShortDateString();
                        String ID_Emp = IDbox.Text;
                        String UserName = CommonInfo.GetAdmin();
                        String IRG_R = IRG.Text.Replace(',', '.');
                        String RSS_R = RSS.Text.Replace(',', '.');
                        String Salaire_poste = Salaire_Poste().ToString().Replace(',', '.');
                        String AutrPr = Autre.Text.Replace(',', '.');

                        String Query = "INSERT INTO Salaire(Salaire_Base,Taux_IEP,Taux_ISP,Taux_IN,PrixU_ITrans,NbrJourTrans,PrixU_IPanier,NbrJrPanier,I_Zone_Geo,Frais_Mission,Acompte_Verse,Periode,ID_Emp,UserName,IRG,RSS,Salaire_poste, Autres_Primes , Date_creat) VALUES " +
                        "( " + Salaire_Base + " , " + Taux_IEP + " , " + Taux_ISP + " , " + Taux_IN + " , " + PrixU_ITrans + " , " + NbrJourTrans + " , " + PrixU_IPanier + " , " + NbrJrPanier + " , " + I_Zone_Geo + " , " + Frais_Mission + " , " + Acompte_Verse + " , '" + Periode + "' , " + ID_Emp + " , '" + UserName + "' , " + IRG_R + " , " + RSS_R + " , " + Salaire_poste + " , " + AutrPr +",'"+DateTime.Now + "' )";


                        OleDbCommand cmd = new OleDbCommand(Query, Cc);

                        Cc.Open();
                        cmd.ExecuteNonQuery();
                        OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT @@IDENTITY", Cc);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        ID = dt1.Rows[0][0].ToString();
                        Cc.Close();

                        Saved = true;
                        MsBox MS = new MsBox("Salaire Ajouté !!", AlertType.success);
                        MS.ShowDialog();
                    }
                }
                catch
                {
                    MsBox MS = new MsBox("Vérifier les données entrées !!", AlertType.error);
                    MS.ShowDialog();
                }
            }
        }

        private void ISNewSalary_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Click(sender, e);
            if (!ISNewSalary.Checked)
            {
                Calcul_Salaire.Hide();
                SaveSalary.Hide();
                Search_Salary.Show();
                ModifSalary.Show();
                Recalcul.Show();
            }
            else
            {
                Calcul_Salaire.Show();
                SaveSalary.Show();
                Search_Salary.Hide();
                ModifSalary.Hide();
                Recalcul.Hide();
                Saved = false;
                Calculé = false;
                EmpAjouté = false;
            }
        }

        private void PrintSalary_Click(object sender, EventArgs e)
        {
            
            if (!Saved && ISNewSalary.Checked) {
                MsBox MS = new MsBox("Salaire n'est pas enregistré !!", AlertType.info);
                MS.ShowDialog();
            }
            else
            {
                BDD Bd = new BDD();
                OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                Print_Form Pt = new Print_Form();
                String Query = "SELECT Salaire.Salaire_Base, Salaire.Taux_IEP, Salaire.Taux_ISP, Salaire.Taux_IN, Salaire.PrixU_ITrans, Salaire.NbrJourTrans, Salaire.PrixU_IPanier, Salaire.NbrJrPanier, "+
                         "Salaire.I_Zone_Geo, Salaire.Frais_Mission, Salaire.Acompte_Verse, Salaire.Periode, Salaire.UserName, Salaire.IRG, Salaire.ID_Emp, Salaire.RSS, "+
                         "Salaire.Salaire_poste, Salaire.Autres_Primes, Employe.Nom, Employe.Prenom, Employe.Date_Naiss, Employe.Date_Recrt, Employe.Sexe, Employe.N_Telph, "+
                         "Employe.CCP, Employe.NSS, Employe.Situation_fam, Etablissement_Infos.*, Fonction.Intitul_Fon"+
                         " FROM ((Salaire INNER JOIN Employe ON Salaire.ID_Emp = Employe.ID_Emp) INNER JOIN"+
                        " Fonction ON Employe.ID_Fonction = Fonction.ID_Fonction), Etablissement_Infos WHERE ID_Salaire="+ID;
                try {
                    OleDbDataAdapter dt = new OleDbDataAdapter(Query, Cc);
                    dt.Fill(Pt.FicheDePaieDataSet.DataTable1);
                    Pt.reportViewer1.LocalReport.EnableExternalImages = true;
                    //FileInfo fi = new FileInfo(");
                    ReportParameter ImgPh = new ReportParameter("ImgPath",@"C: \Users\KHALIL\Desktop\output-1.png");

                    Pt.reportViewer1.LocalReport.SetParameters(ImgPh);
                    Pt.reportViewer1.RefreshReport();
                    Pt.ShowDialog();
                }
                catch
                {
                    MsBox MS = new MsBox("Connexion echouée !!", AlertType.error);
                    MS.ShowDialog();
                }
            }

           
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {  
            IDbox.Text = metroGrid1.SelectedCells[0].Value.ToString();
            NomBox.Text = metroGrid1.SelectedCells[1].Value.ToString();
            PrenomBox.Text= metroGrid1.SelectedCells[2].Value.ToString();
            FonctionBox.Text = metroGrid1.SelectedCells[5].Value.ToString();
            EmpAjouté = true;
        }

        private void ChangeEmp_Click(object sender, EventArgs e)
        {
            IDbox.Clear();
            NomBox.Clear();
            PrenomBox.Clear();
            FonctionBox.Clear();
            EmpAjouté = false;
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            AddEmp_Click(sender, e);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ChangeEmp_Click(sender, e);
            SlrBaseBox.Text = "0";
            TauxIEP.Text = "10";
            TauxISP.Text = "15";
            TauxIN.Text = "20";
            ItPU.Text = "150";
            ItJr.Text = "22";
            IpPU.Text = "300";
            IpJr.Text = "22";
            IZG.Text = "0";
            Mission.Text = "0";
            AcompteVerse.Text = "0";
            IRG.Text = "0";
            RSS.Text="0";
            IEP.Text = "0";
            ISP.Text = "0";
            IN.Text = "0";
            IT.Text = "0";
            IP.Text = "0";
            TotalGains.Text = "0";
            TotRetenues.Text = "0";
            NetSal.Text = "0";
            Autre.Text = "0";
            Saved = false;
            EmpAjouté = false;
            Calculé = false;


        }
        private void ChampChange()
        {
            if(Calculé) Calculé = false;
        }

        private void SlrBaseBox_Click(object sender, EventArgs e)
        {

        }

        private void SlrBaseBox_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void TauxIEP_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void TauxISP_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        
        private void TauxIN_Click(object sender, EventArgs e)
        {

        }

        private void TauxIN_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void ItJr_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void ItPU_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void IpJr_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void IpPU_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void IZG_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void Mission_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void Autre_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }

        private void AcompteVerse_TextChanged(object sender, EventArgs e)
        {
            ChampChange();
        }
        private void Check_info()
        {
            try {
                Decimal Base = Convert.ToDecimal(SlrBaseBox.Text.Replace('.', ','));
                Decimal Taux1 = Convert.ToDecimal(TauxIEP.Text.Replace('.', ','));
                Decimal Taux2 = Convert.ToDecimal(TauxISP.Text.Replace('.', ','));
                Decimal Taux3 = Convert.ToDecimal(TauxIN.Text.Replace('.', ','));
                Decimal ItJr_ = Convert.ToDecimal(ItJr.Text.Replace('.', ','));
                Decimal ItPU_ = Convert.ToDecimal(ItPU.Text.Replace('.', ','));
                Decimal IpJr_ = Convert.ToDecimal(IpJr.Text.Replace('.', ','));
                Decimal IpPU_ = Convert.ToDecimal(IpPU.Text.Replace('.', ','));
                Decimal IZG_ = Convert.ToDecimal(IZG.Text.Replace('.', ','));
                Decimal Mission_ = Convert.ToDecimal(Mission.Text.Replace('.', ','));
                Decimal Autre_ = Convert.ToDecimal(Autre.Text.Replace('.', ','));
                Decimal AcompteVerse_ = Convert.ToDecimal(AcompteVerse.Text.Replace('.', ','));

                if (Taux1 < 0 || Taux1 > 100 || Taux2 < 0 || Taux2 > 100 || Taux3 < 0 || Taux3 > 100)
                {
                    Check = false;
                    MsBox MS = new MsBox("Vérifier les pourcentages entrés!!", AlertType.error);
                    MS.ShowDialog();
                }
                else Check = true;
                if (Base < 0 || ItJr_ < 0 || ItPU_ < 0 || IpJr_ < 0 || IpPU_ < 0 || IZG_ < 0 || Mission_ < 0 || Autre_ < 0 || AcompteVerse_ < 0)
                {
                    MsBox MS = new MsBox("Il y a des valeurs négatives!!", AlertType.error);
                    MS.ShowDialog();
                    Check2 = false;
                }
                else Check2 = true;

            }
            catch
            {

            }
            
        }

        private void Search_Salary_Click(object sender, EventArgs e)
        {
            if (!EmpAjouté)
            {
                MsBox MS = new MsBox("Ajouter un employé d'abord!!", AlertType.info);
                MS.ShowDialog();
            }
            else
            {
                try {

                    BDD Bd = new BDD();
                    OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                    String LaPeriode = PeriodBox.Value.ToString("MM/yyyy");
                    String Query = "SELECT * FROM Salaire WHERE Format(Periode ,'MM/yyyy')='" + LaPeriode + "' AND ID_Emp=" + IDbox.Text;
                    OleDbDataAdapter da = new OleDbDataAdapter(Query, Cc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MsBox MS = new MsBox("Salaire n'existe pas !!", AlertType.info);
                        MS.ShowDialog();
                    }
                    else
                    {
                        ID = dt.Rows[0][0].ToString();
                        SlrBaseBox.Text = dt.Rows[0][1].ToString();
                        TauxIEP.Text = dt.Rows[0][2].ToString();
                        TauxISP.Text = dt.Rows[0][3].ToString();
                        TauxIN.Text = dt.Rows[0][4].ToString();
                        ItPU.Text = dt.Rows[0][5].ToString();
                        ItJr.Text = dt.Rows[0][6].ToString();
                        IpPU.Text = dt.Rows[0][7].ToString();
                        IpJr.Text = dt.Rows[0][8].ToString();
                        IZG.Text = dt.Rows[0][9].ToString();
                        Mission.Text = dt.Rows[0][10].ToString();
                        AcompteVerse.Text = dt.Rows[0][11].ToString();
                        IRG.Text = dt.Rows[0][15].ToString();
                        RSS.Text = dt.Rows[0][16].ToString();
                        Autre.Text = dt.Rows[0][18].ToString();

                        //Calcul
                        Check_info();
                        if (Check && Check2)
                        {
                            Salaire_Base = Convert.ToDecimal(SlrBaseBox.Text);

                            IEP.Text = Indemnite_exp_professionnelle().ToString();
                            ISP.Text = Indemnite_service_permanent().ToString();
                            IN.Text = Indemnite_nuisance().ToString();
                            IT.Text = Indemnite_Transport().ToString();
                            IP.Text = Indemnite_Panier().ToString();
                            TotRetenues.Text = this.Tot_retenues().ToString() + " DA";
                            TotalGains.Text = ToT_Revenues().ToString() + " DA";
                            NetSal.Text = this.Salaire_Net().ToString() + " DA";

                            Calculé = true;
                        }
                    }

                }
                catch
                {
                    MsBox MS = new MsBox("Connexion Echouée !!", AlertType.error);
                    MS.ShowDialog();
                }
            }
        }

        private void ModifSalary_Click(object sender, EventArgs e)
        {
            if (Calculé)
            {
                try
                {
                    BDD Bd = new BDD();
                    OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
                    String Query = "UPDATE Salaire SET Salaire_Base=" + SlrBaseBox.Text.Replace(",", ".") + ", Taux_IEP=" + TauxIEP.Text.Replace(",", ".")
                                   + ", Taux_ISP=" + TauxISP.Text.Replace(",", ".") + " , Taux_IN=" + TauxIN.Text.Replace(",", ".") + ", PrixU_ITrans=" + ItPU.Text.Replace(",", ".")
                                   + ", NbrJourTrans=" + ItJr.Text.Replace(",", ".") + " ,PrixU_IPanier=" + IpPU.Text.Replace(",", ".") + " , NbrJrPanier=" + IpJr.Text.Replace(",", ".")
                                   + " , I_Zone_Geo=" + IZG.Text.Replace(",", ".") + ", Frais_Mission=" + Mission.Text.Replace(",", ".") + ", Acompte_Verse=" + AcompteVerse.Text.Replace(",", ".")
                                   + " , Periode='" + PeriodBox.Value + "',UserName='" + CommonInfo.GetAdmin() + "', IRG=" + IRG.Text.Replace(",", ".") + ", RSS=" + RSS.Text.Replace(",", ".")
                                   + ", Salaire_poste=" + Salaire_Poste().ToString().Replace(",", ".") + " ,Autres_Primes=" + Autre.Text.Replace(",", ".") + ", ID_Emp=" + IDbox.Text + " , Date_creat='" + DateTime.Now + "' WHERE ID_Salaire=" + ID;
                    OleDbCommand cmd = new OleDbCommand(Query, Cc);
                    Cc.Open();
                    cmd.ExecuteNonQuery();
                    Cc.Close();
                    MsBox MS = new MsBox("Modifications Effectuées !!", AlertType.success);
                    MS.ShowDialog();
                }
                catch
                {
                    MsBox MS = new MsBox("Champs vides !!", AlertType.error);
                    MS.ShowDialog();
                }
            }
            else
            {
                MsBox MS = new MsBox("Calculé le salaire d'abord puis appliquer les modifications", AlertType.info);
                MS.ShowDialog();
            }
        }

        private void metroTextBox24_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox24_TextChanged(object sender, EventArgs e)
        {
            BDD Bd = new BDD();
            OleDbConnection Cc = new OleDbConnection(Bd.getConnectionString());
            String Query = "select * from Employe WHERE Nom LIKE '"+EmplySearch.Text+ "%' OR Prenom LIKE '"+EmplySearch.Text+"%'";
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

        private void Recalcul_Click(object sender, EventArgs e)
        {
            Cacul_Salaire_Click(sender, e);
        }
    }
}
