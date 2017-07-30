using Dapper;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kalorian.Common.LocalDB
{
    public class Cl_LocalDB
    {
        public bool CheckLocalDBExistance(string vrpLocalDBName)
        {
            using (SqlConnection vrlConnection = new SqlConnection(this.LocalDBConnectionString))
            {
                return vrlConnection.Query<bool>(string.Format("IF (EXISTS ( SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = '{0}' OR name = '{0}'))) select 'true'", vrpLocalDBName)).FirstOrDefault();
            }
        }

        public void CreateLocalDB(string vrpLocalDBName)
        {
            using(SqlConnection vrlConnection = new SqlConnection(this.LocalDBConnectionString))
            {
                string[] files = {Path.Combine(Application.StartupPath, vrpLocalDBName + ".mdf"),
                Path.Combine(Application.StartupPath, vrpLocalDBName + ".ldf")};

                vrlConnection.Query(string.Format("CREATE DATABASE {0} ON PRIMARY (NAME = {0}, FILENAME = '{1}', SIZE = 3MB, MAXSIZE = 1024MB, FILEGROWTH = 10%) LOG ON (NAME = {0}_log, FILENAME = '{2}', SIZE = 1MB, MAXSIZE = 128MB, FILEGROWTH = 10%)",vrpLocalDBName,files[0],files[1]));
            }
        }

        public string LocalDBConnectionString 
            => "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=true;";
    }
}
