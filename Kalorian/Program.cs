using Kalorian.Common.LocalDB;
using Kalorian.View.Login;
using System;
using System.Security.AccessControl;
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

                vrlRemoteDB.AddDirectorySecurity(@"MYDOMAIN\MyAccount", FileSystemRights.ReadData, AccessControlType.Allow);
                vrlRemoteDB.AddDirectorySecurity(@"MYDOMAIN\MyAccount", FileSystemRights.WriteData, AccessControlType.Allow);
                vrlRemoteDB.CheckRemoteDBExistance();
                //Cl_LocalDB vrlLocalDB = new Cl_LocalDB();
                //vrlLocalDB.AddDirectorySecurity(@"MYDOMAIN\MyAccount", FileSystemRights.ReadData, AccessControlType.Allow);
                //vrlLocalDB.AddDirectorySecurity(@"MYDOMAIN\MyAccount", FileSystemRights.WriteData, AccessControlType.Allow);
                //if (!vrlLocalDB.CheckLocalDBExistance(vrlLocalDBName))
                //{
                //    vrlLocalDB.CreateLocalDB(vrlLocalDBName);
                //}
                //if (!vrlLocalDB.CheckLocalDBExistance(vrlLocalDBName))
                //{
                //    MessageBox.Show("Nie udało się stworzyć lokalnej bazy danych, uruchom aplikację ponownie z uprawnieniami administratora.");
                //}
                //else
                //{
                //    //vrlLocalDB.InitializeTablesAndScripts();
                //}
            }
            catch(Exception vrlException)
            {
                MessageBox.Show("Nie można ustanowić połączenia z bazą danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
