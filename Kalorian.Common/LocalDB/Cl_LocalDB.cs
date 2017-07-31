using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace Kalorian.Common.LocalDB
{
    public class Cl_LocalDB
    {     
        public bool CheckLocalDBExistance(string vrpLocalDBName = "kalorian")
        {
            using (SqlConnection vrlConnection = new SqlConnection(this.LocalDBConnectionString))
            {
                return vrlConnection.Query<bool>(string.Format("IF (EXISTS ( SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = '{0}' OR name = '{0}'))) select 'true'", vrpLocalDBName)).FirstOrDefault();
            }
        }

        public void CreateLocalDB(string vrpLocalDBName = "kalorian")
        {
            using(SqlConnection vrlConnection = new SqlConnection(this.LocalDBConnectionString))
            {
                string[] files = {Path.Combine(Directory.GetCurrentDirectory(), vrpLocalDBName + ".mdf"),
                Path.Combine(Directory.GetCurrentDirectory(), vrpLocalDBName + ".ldf")};

                vrlConnection.Query(string.Format("CREATE DATABASE {0} ON PRIMARY (NAME = {0}, FILENAME = '{1}', SIZE = 3MB, MAXSIZE = 1024MB, FILEGROWTH = 10%) LOG ON (NAME = {0}_log, FILENAME = '{2}', SIZE = 1MB, MAXSIZE = 128MB, FILEGROWTH = 10%)",vrpLocalDBName,files[0],files[1]));
            }
        }

        public void InitializeTablesAndScripts(string vrpLocalDBName = "kalorian")
        {
            var vrlSQLDirectory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(),"..\\..\\..\\Kalorian.Common\\Files"));
            var vrlSQLTableFile = new FileInfo(Path.Combine(vrlSQLDirectory.FullName,"tables.sql"));
            var vrlTableFileContent = vrlSQLTableFile.OpenText().ReadToEnd();
            var vrlSQLScriptFile = new FileInfo(Path.Combine(vrlSQLDirectory.FullName, "scripts.sql"));
            var vrlSQLScriptFileContent = vrlSQLScriptFile.OpenText().ReadToEnd();
            using (SqlConnection vrlConnection = new SqlConnection(this.ConnectionString))
            {
                vrlConnection.Query(vrlTableFileContent);
                vrlConnection.Query(vrlSQLScriptFileContent);
            }
        }

        public void AddDirectorySecurity(string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Kalorian.Common\\Files")); ;

            // Get a DirectorySecurity object that represents the 
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings. 
            dSecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);

        }

        private string vrlCurrentDirectoryPath 
            => Path.GetFullPath(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        private string LocalDBConnectionString 
            => "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=true;";

        public string ConnectionString 
            => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=kalorian;Integrated Security=true;";
    }
}
