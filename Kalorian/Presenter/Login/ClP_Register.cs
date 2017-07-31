using Kalorian.DAL.Entity;
using Kalorian.DAL.Repository;
using Kalorian.Interface;
using System;
using System.Windows.Forms;

namespace Kalorian.Presenter.Login
{
    public class ClP_Register
    {
        private readonly I_Register vrcView;
        private readonly Cl_UserRepository vrcUserRepository = new Cl_UserRepository();

        public ClP_Register(I_Register vrpView)
        {
            vrcView = vrpView;
        }

        internal void RegisterNewUser()
        {
            try
            {
                vrcUserRepository.Add(new ClE_User { Name = vrcView.UserName, Password = vrcView.Password });
            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
            }
        }
    }
}
