using System;
using System.Collections;
using Kalorian.DAL.Entity;
using Kalorian.DAL.Interface.Repository;
using Kalorian.Common.LocalDB;
using Dapper;
using System.Data;
using Kalorian.Common.Utility.Cryptography;
using System.Linq;
using MySql.Data.MySqlClient;
using Kalorian.DAL.ViewModel;

namespace Kalorian.DAL.Repository
{
    public class Cl_UserRepository : I_Repository<ClE_User>
    {
        public void Add(ClE_User vrpUser)
        {
            vrpUser.Password = new Cl_Cryptography().SimpleEncrypt(vrpUser.Password);
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                vrlConnection.Query("sp_UserSave", new { in_Username = vrpUser.Name, in_Password = vrpUser.Password }, commandType: CommandType.StoredProcedure);
                vrlConnection.Close();
            }
        }

        public Cl_UserViewModel GetAdditionalUserDataById(int vrpUserId)
        {
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                Cl_UserViewModel _User = vrlConnection.Query<Cl_UserViewModel>
                    ("SELECT usd_usr_Id as Id, usd_Sex as Sex, usd_Age as Age, usd_Weight as Weight from kal_UserData where usd_usr_Id = '" + vrpUserId + "'").FirstOrDefault();
                vrlConnection.Close();
                return _User;
            }
        }

        public void EditUserAdditionalDataById(Cl_UserViewModel vrpUser)
        {
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                vrlConnection.Query("UPDATE kal_UserData SET usd_Age = "+vrpUser.Age+", usd_Sex = "+vrpUser.Sex+", usd_Weight = "+vrpUser.Weight+" WHERE usd_usr_Id = "+vrpUser.Id);
                vrlConnection.Close();
            }
        }

        public ClE_User CheckIfExistsByName(string vrpUserName)
        {
            using(MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                ClE_User _User =  vrlConnection.Query<ClE_User>("SELECT usr_Name from kal_User where usr_Name = '"+ vrpUserName+"'").FirstOrDefault();
                vrlConnection.Close();
                return _User;
            }
        }

        public void AddUserAdditionalDataById(Cl_UserViewModel vrpUser)
        {
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                vrlConnection.Query("INSERT INTO kal_UserData(usd_usr_Id, usd_Age, usd_Sex, usd_Weight) VALUES('" +vrpUser.Id+ "', '"+vrpUser.Age+"','"+vrpUser.Sex+"', '"+vrpUser.Weight+"')");
                vrlConnection.Close();
            }
        }

        public ClE_User GetById(Guid vrpId)
        {
            throw new NotImplementedException();
        }

        public ClE_User GetById(int vrpId)
        {
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                return vrlConnection.Query<ClE_User>("[dbo].[sp_UserGetById]", new { @Id = vrpId }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public ClE_User GetByCredentials(ClE_User vrpUser)
        {
            using (MySqlConnection vrlConnection = new MySqlConnection(new Cl_RemoteDB().ConnectionString))
            {
                vrlConnection.Open();
                vrpUser.Password = new Cl_Cryptography().SimpleEncrypt(vrpUser.Password);
                var vrlResult = vrlConnection.Query<ClE_User>("sp_UserGetByCredentials", new { in_UserName = vrpUser.Name, in_Password = vrpUser.Password }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                vrlConnection.Close();
                if (vrlResult != null)
                vrlResult.Password = new Cl_Cryptography().SimpleDecrypt(vrlResult.Password);
                return vrlResult;
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