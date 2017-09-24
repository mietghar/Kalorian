using Kalorian.Main.Interface;
using Kalorian.DAL.Repository;
using Kalorian.DAL.ViewModel;
using Kalorian.DAL.Enum;
using System;
using Kalorian.Common;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kalorian.Main.Presenter
{
    public class ClP_Main
    {
        private readonly I_MainView vrcView;
        private readonly Cl_UserRepository vrcUserRepository;
        private Cl_UserViewModel vrcUserViewModel;

        public ClP_Main(I_MainView vrpView)
        {
            vrcUserRepository = new Cl_UserRepository();
            vrcView = vrpView;
        }

        internal void LoadUserAdditionalData()
        {
            try
            {
                Cl_UserViewModel vrlUserViewModel = vrcUserRepository.GetAdditionalUserDataById(vrcView.UserId);
                if (vrlUserViewModel == null)
                {
                    vrcView.IsNewUser = true;
                    return;
                }

                vrcView.Age = vrlUserViewModel.Age;
                vrcView.Sex = (int)vrlUserViewModel.Sex;
                vrcView.Weight = vrlUserViewModel.Weight;
                vrcView.HeightInCm = vrlUserViewModel.HeightInCm;
                SetUserViewModelData(vrcView.Age, vrcView.Sex, vrcView.Weight, vrcView.HeightInCm);
                vrcView.BMR = CalculateAndSetUserBMR(vrcUserViewModel);
            }
            catch (SqlException vrlSqlException)
            {
                MessageBox.Show("Wystąpił błąd bazy danych" + vrlSqlException.Message);
            }
            catch (Exception vrlException)
            {
                MessageBox.Show("Wystąpił błąd" + vrlException.Message);
            }
        }

        internal bool AddUserAdditionalDataById(int vrpUserId) => vrcUserRepository.AddUserAdditionalDataById
            (new Cl_UserViewModel() { Age = vrcView.Age, Sex = vrcView.Sex, Weight = vrcView.Weight, Id = vrpUserId, HeightInCm = vrcView.HeightInCm });

        internal bool EditUserAdditionalDataById(int vrpUserId) => vrcUserRepository.EditUserAdditionalDataById
            (new Cl_UserViewModel() { Age = vrcView.Age, Sex = vrcView.Sex, Weight = vrcView.Weight, Id = vrpUserId, HeightInCm = vrcView.HeightInCm });

        internal decimal CalculateAndSetUserBMR(Cl_UserViewModel vrpUserViewModel)
        {
            try
            {
                if (vrpUserViewModel == null
                    || vrpUserViewModel.Age <= 0
                    || vrpUserViewModel.HeightInCm <= decimal.Zero
                    || vrpUserViewModel.Sex <= 0
                    || vrpUserViewModel.Weight <= decimal.Zero) return decimal.Zero;

                switch (vrpUserViewModel.Sex)
                {
                    case (int)E_Sex.Female:
                        {
                            return 655 + (decimal)9.6 * vrpUserViewModel.Weight + (decimal)1.8 * vrpUserViewModel.HeightInCm - (decimal)4.7 * vrpUserViewModel.Age;
                        }
                    case (int)E_Sex.Male:
                        {
                            return 66 + (decimal)13.7 * vrpUserViewModel.Weight + 5 * vrpUserViewModel.HeightInCm - (decimal)6.8 * vrpUserViewModel.Age;
                        }
                    default: return decimal.Zero;
                }
            }
            catch (Exception vrlException)
            {
                MessageBox.Show("Wystąpił błąd " + vrlException.Message);
                return decimal.Zero;
            }

        }

        private void SetUserViewModelData(int vrpAge, int vrpSex, decimal vrpWeight, decimal vrpHeight)
        {
            vrcUserViewModel = new Cl_UserViewModel
            {
                Age = vrpAge,
                HeightInCm = vrpHeight,
                Weight = vrpWeight,
                Sex = vrpSex
            };
        }
    }
}
