using Kalorian.Helper.Themes.Forms;
using Kalorian.Login.Presenter;
using System;

namespace Kalorian.View.Login
{
    public partial class Frm_Login : Frm_BaseSimpleForm
    {
        private new ClP_Login vrcPresenter;
        public Frm_Login()
        {
            vrcPresenter = new ClP_Login(this);
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vrcPresenter.CreateNewUser();
        }
    }
}
