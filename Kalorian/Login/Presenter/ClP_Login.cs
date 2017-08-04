using Kalorian.DAL.Entity;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using Kalorian.DAL.Repository;
using Kalorian.Register.View;
using Kalorian.Login.Interface;

namespace Kalorian.Login.Presenter
{
    public class ClP_Login
    {
        private readonly Cl_UserRepository vrcUserRepository;
        private readonly I_LoginView vrcView;

        public ClP_Login(I_LoginView vrpView)
        {
            vrcView = vrpView;
            vrcUserRepository = new Cl_UserRepository();
        }

        public void ShowNewUserRegistrationForm()
        {
            try
            {
                using (Frm_Register vrfRegister = new Frm_Register())
                {
                    vrcView.SetVisibility(false);
                    vrfRegister.ShowDialog();
                }
                vrcView.SetVisibility(true);
            }
            catch(SqlException)
            {
                MessageBox.Show("Nie można ustanowić połączenia z bazą danych.");
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd.");
            }
        }

        internal ClE_User LoginUser(ClE_User vrpUser) => vrcUserRepository.GetByCredentials(vrpUser);
    }
}
