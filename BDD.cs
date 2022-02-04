using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paie_PFE
{
    class BDD
    {
        private String Chaine;
        
        public BDD()
        {
            this.Chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Gestion_Paie.accdb";
        } 
        public String getConnectionString()
        {
            return Chaine;
        }
    }
}
