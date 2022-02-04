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
    public partial class MsBox : Form
    {
        public  MsBox(String Msg,AlertType Type)
        {
            InitializeComponent();
            switch (Type)
            {
                case AlertType.success:
                    this.BackColor = Color.FromArgb(38, 126, 89);
                    AlertIcon.Image = Image.FromFile(@"Images\success.png");
                    break;
                case AlertType.info:
                    this.BackColor = Color.FromArgb(65, 64, 65);
                    AlertIcon.Image = Image.FromFile(@"Images\Info.png");
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(225, 39, 41);
                    AlertIcon.Image = Image.FromFile(@"Images\Error.png");
                    break;
            }
            MsgTxt.Text = Msg;
            
            
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EreurWind_Load(object sender, EventArgs e)
        {
            this.Top = 10;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
public enum AlertType
{
    success, error, info
}