using Kalorian.DAL.Entity;
using Kalorian.DAL.Repository;
using Kalorian.Register.Interface;
using System;
using System.Windows.Forms;

namespace Kalorian.Register.Presenter
{
    public class ClP_Register
    {
        private readonly I_RegisterView vrcView;
        private readonly Cl_UserRepository vrcUserRepository = new Cl_UserRepository();

        public ClP_Register(I_RegisterView vrpView)
        {
            vrcView = vrpView;
        }

        internal bool RegisterNewUser()
        {
            try
            {
                ClE_User _User = vrcUserRepository.CheckIfExistsByName(vrcView.UserName);
                if (_User != null)
                {
                    MessageBox.Show("Istnieje użytkownik o takiej nazwie.");
                    return false;
                }
                vrcUserRepository.Add(new ClE_User { Name = vrcView.UserName, Password = vrcView.Password });
                return true;
            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
                return false;
            }
        }
    }
}
