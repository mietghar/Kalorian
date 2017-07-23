using Kalorian.DAL.Entity;
using Kalorian.Helper.Themes;
using Kalorian.DAL.Interface.Repository;
using System.Windows.Forms;
using Kalorian.DAL.Repository;

namespace Kalorian.Presenter
{
    public class ClP_Login
    {
        private Form vrcView;
        private I_Repository<ClE_User> vrcUserRepository;

        public ClP_Login(Form vrpView)
        {
            vrcView = vrpView;
            SetTheme();
        }
        
        private void SetTheme()
        {
            if(vrcView !=null)
            vrcView.BackColor = Cl_BaseColor.StandardBackground;
        }

        public void CreateNewUser()
        {
            ClE_User test = new ClE_User();
            test.Name = "test name";
            test.Password = "";
            vrcUserRepository = new Cl_UserRepository();
            vrcUserRepository.Add(test);
        }
    }
}
