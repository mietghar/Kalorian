using Kalorian.Entity;
using Kalorian.Enum;
using Kalorian.Factory;
using Kalorian.Helper.Themes;
using Kalorian.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorian.Presenter
{
    public class ClP_Login
    {
        Form vrcView;
        I_Repository<Type> vrcUserRepository = null;
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
            Cl_RepositoryFactory vrlFactory = new Cl_RepositoryFactory();
            this.vrcUserRepository = vrlFactory.CreateRepository(E_Repositories.User);
            this.vrcUserRepository.Add(ClE_User);
        }
    }
}
