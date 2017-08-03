using Kalorian.Common.LocalDB;
using Kalorian.Login.View;
using System;
using System.Data.SqlClient;
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
            //string vrlLocalDBName = "kalorian";
            try
            {
                Cl_RemoteDB vrlRemoteDB = new Cl_RemoteDB();
                vrlRemoteDB.CheckRemoteDBExistance();
            }
            catch(SqlException)
            {
                MessageBox.Show("Nie można połączyć się z bazą danych");
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd.");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
