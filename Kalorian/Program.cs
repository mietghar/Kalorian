using Kalorian.Common.LocalDB;
using Kalorian.View.Login;
using System;
using System.Windows.Forms;

namespace Kalorian
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string vrlLocalDBName = "kalorian";
            try
            {
                if (!new Cl_LocalDB().CheckLocalDBExistance(vrlLocalDBName))
                {
                    new Cl_LocalDB().CreateLocalDB(vrlLocalDBName);
                }
                if (!new Cl_LocalDB().CheckLocalDBExistance(vrlLocalDBName))
                {
                    MessageBox.Show("Nie udało się stworzyć lokalnej bazy danych, uruchom aplikację ponownie z uprawnieniami administratora.");
                }
            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
