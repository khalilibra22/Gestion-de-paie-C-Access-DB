using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paie_PFE
{
    public static class CommonInfo
    {

        private static String Admin = String.Empty;
        private static System.Windows.Forms.UserControl Salary;
        private static System.Windows.Forms.UserControl Emp;
        private static System.Windows.Forms.UserControl Fnc;
        private static System.Windows.Forms.UserControl Setting;
        private static System.Windows.Forms.UserControl Histo;
        private static System.Windows.Forms.Panel Side;
        public static void SetAdmin(String ADmName)
        {
            Admin = ADmName;
        }
        public static String GetAdmin()
        {
            return Admin;
        }
        public static void SetFormi(System.Windows.Forms.UserControl F)
        {
            Histo = F;
        }
        public static System.Windows.Forms.UserControl GetFOrmi(){
            return Histo;
        }
        public static void SetSalary(System.Windows.Forms.UserControl F)
        {
            Salary = F;
        }
        public static System.Windows.Forms.UserControl GetSalary()
        {
            return Salary;
        }

        public static void SetEmployes(System.Windows.Forms.UserControl F)
        {
            Emp = F;
        }
        public static System.Windows.Forms.UserControl GettEmployes()
        {
            return Emp;
        }

        public static void SetFonctins(System.Windows.Forms.UserControl F)
        {
            Fnc = F;
        }
        public static System.Windows.Forms.UserControl GettFonctins()
        {
            return Fnc;
        }
        public static void SetSettings(System.Windows.Forms.UserControl F)
        {
            Setting = F;
        }
        public static System.Windows.Forms.UserControl GettSettings()
        {
            return Setting;
        }
        public static void setLocation(int x, int y)
        {
            Side.Location=new Point(x, y);

        }
        public static System.Windows.Forms.Panel getLocation()
        {
            return Side;
        }
        public static void MySideLocation(System.Windows.Forms.Panel SD)
        {
            Side = SD;

        }
    }   
}
    

