using Kalorian.Main.Interface;
using Kalorian.DAL.Repository;
using Kalorian.DAL.ViewModel;
using System;

namespace Kalorian.Main.Presenter
{
    public class ClP_Main
    {
        private readonly I_MainView vrcView;
        private readonly Cl_UserRepository vrcUserRepository;

        public ClP_Main(I_MainView vrpView)
        {
            vrcUserRepository = new Cl_UserRepository();
            vrcView = vrpView;
        }

        internal void LoadUserAdditionalData()
        {
            Cl_UserViewModel vrlUserViewModel = vrcUserRepository.GetAdditionalUserDataById(vrcView.UserId);
            if (vrlUserViewModel == null)
            {
                vrcView.IsNewUser = true;
                return;
            }

            vrcView.Age = vrlUserViewModel.Age;
            vrcView.Sex = vrlUserViewModel.Sex;
        }

        internal void AddUserAdditionalDataById(int vrpUserId) => vrcUserRepository.AddUserAdditionalDataById
            (new Cl_UserViewModel() { Age = vrcView.Age, Sex = vrcView.Sex, Id = vrpUserId });
    }
}
