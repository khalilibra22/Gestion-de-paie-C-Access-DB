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
    public partial class Print_Form : Form
    {
        public Print_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_Form_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'FicheDePaieDataSet.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.DataTable1TableAdapter.Fill(this.FicheDePaieDataSet.DataTable1);

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
