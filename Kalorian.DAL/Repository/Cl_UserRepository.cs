using System;
using System.Collections;
using Kalorian.DAL.Entity;
using Kalorian.DAL.Interface.Repository;
using System.Data.SqlClient;
using Kalorian.Common.LocalDB;
using Dapper;
using System.Data;
using Kalorian.Common.Utility.Cryptography;
using System.Linq;

namespace Kalorian.DAL.Repository
{
    public class Cl_UserRepository : I_Repository<ClE_User>
    {
        public void Add(ClE_User vrpUser)
        {
            vrpUser.Password = new Cl_Cryptography().SimpleEncrypt(vrpUser.Password);
            using(SqlConnection vrlConnection = new SqlConnection(new Cl_LocalDB().ConnectionString))
            {
                vrlConnection.Query("[dbo].[sp_UserSave]", new { @Username = vrpUser.Name, @Password = vrpUser.Password }, commandType: CommandType.StoredProcedure);
            }
        }

        public ClE_User GetById(Guid vrpId)
        {
            throw new NotImplementedException();
        }

        public ClE_User GetById(int vrpId)
        {
            using (SqlConnection vrlConnection = new SqlConnection(new Cl_LocalDB().ConnectionString))
            {
                return vrlConnection.Query<ClE_User>("[dbo].[sp_UserGetById]", new { @Id = vrpId }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public ClE_User GetByQuery(Queue query)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClE_User item)
        {
            throw new NotImplementedException();
        }

        public void Update(ClE_User item)
        {
            throw new NotImplementedException();
        }
    }
}
