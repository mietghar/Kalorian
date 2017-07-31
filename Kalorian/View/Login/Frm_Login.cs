using Kalorian.DAL.Entity;
using Kalorian.DAL.Repository;
using Kalorian.Helper.Themes.Forms;
using Kalorian.Login.Presenter;
using System;
using System.Windows.Forms;

namespace Kalorian.View.Login
{
    public partial class Frm_Login : Frm_BaseSimpleForm
    {
        private new ClP_Login vrcPresenter;
        private Cl_UserRepository vrcUserRepository = new Cl_UserRepository();
        public Frm_Login()
        {
            vrcPresenter = new ClP_Login(this);
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vrcPresenter.CreateNewUser();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var vrlResult = vrcUserRepository.GetByCredentials(new ClE_User { Name = frtxtUser.Text, Password = frtxtPassword.Text });
            if (vrlResult != null)
            {
                MessageBox.Show(string.Format("Id: {0} Name: {1}, Password: {2}", vrlResult.Id, vrlResult.Name, vrlResult.Password));
            }
        }
    }
}
