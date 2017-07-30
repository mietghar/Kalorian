using System;
using Kalorian.Helper.Themes.Forms;
using Kalorian.Interface;
using Kalorian.Presenter.Login;
using System.Windows.Forms;

namespace Kalorian.View.Login
{
    public partial class Frm_Register : Frm_BaseSimpleForm, I_Register
    {
        private new ClP_Register vrcPresenter;

        public Frm_Register()
        {
            InitializeComponent();
            InitializeControls();
            CreatePresenter();
        }

        private void CreatePresenter()
        {
            vrcPresenter = new ClP_Register(this);
        }

        private void InitializeControls()
        {
            btnClose.Text = "Anuluj";
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            try
            {
                vrcPresenter.RegisterNewUser();
            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
            }
        }

        public string UserName => frtxtUser.Text;
        public string Password => frtxtPassword.Text;
    }
}
