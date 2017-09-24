using Kalorian.DAL.Entity;
using Kalorian.Helper.Themes;
using Kalorian.Helper.Themes.Forms;
using Kalorian.Login.Interface;
using Kalorian.Login.Presenter;
using System;
using System.Windows.Forms;
using System.Drawing;
using Kalorian.Main.View;

namespace Kalorian.Login.View
{
    public partial class Frm_Login : Frm_BaseSimpleForm, I_LoginView
    {
        private new ClP_Login vrcPresenter;
        private ErrorProvider NoUserName = new ErrorProvider();
        private ErrorProvider NoPassword = new ErrorProvider();

        public Frm_Login()
        {
            vrcPresenter = new ClP_Login(this);
            InitializeComponent();
            SetTheme();
            this.HelpButton = true;
        }

        private void SetTheme()
        {
            this.BackColor = Cl_BaseColor.LightBackground;
        }

        private void btnAdd_Click(object sender, EventArgs e)
            => vrcPresenter.ShowNewUserRegistrationForm();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ClE_User vrlResult = null;
                if (ValidateLogin())
                    vrlResult = vrcPresenter.LoginUser(new ClE_User { Name = frtxtUser.Text, Password = frtxtPassword.Text });
                if (vrlResult != null)
                {
                    this.Visible = false;
                    using (Frm_Main vrfMainWindow = new Frm_Main(vrlResult))
                    {
                        vrfMainWindow.ShowDialog();
                    }
                    this.Close();
                }

            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
            }
        }

        private bool ValidateLogin()
        {
            bool IsWithoutError = true;

            if (string.IsNullOrEmpty(frtxtUser.Text))
            {
                NoUserName.SetError(frtxtUser, "Podaj nazwę użytkownika");
                IsWithoutError = false;
            }
            else NoUserName.SetError(frtxtUser,"");

            if (string.IsNullOrEmpty(frtxtPassword.Text))
            {
                NoPassword.SetError(frtxtPassword, "Podaj hasło użytkownika");
                IsWithoutError = false;
            }
            else NoPassword.SetError(frtxtPassword, "");

            return IsWithoutError;
        }

        public void SetVisibility(bool vrpVisibility) => this.Visible = vrpVisibility;

        #region Properties

        public string Password => frtxtPassword.Text;
        public string UserName => frtxtUser.Text;
        public Color NameFieldColor
        {
            get { return frtxtUser.BackColor; }
            set { frtxtUser.BackColor = value; }
        }
        public Color PasswordFieldColor
        {
            get { return frtxtPassword.BackColor; }
            set { frtxtPassword.BackColor = value; }
        }

        #endregion
    }
}
