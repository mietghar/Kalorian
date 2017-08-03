using System;
using Kalorian.Helper.Themes.Forms;
using System.Windows.Forms;
using Kalorian.Register.Presenter;
using Kalorian.Register.Interface;
using System.Drawing;
using System.Data.SqlClient;

namespace Kalorian.Register.View
{
    public partial class Frm_Register : Frm_BaseSimpleForm, I_RegisterView
    {
        private new ClP_Register vrcPresenter;
        private ErrorProvider NoPassword = new ErrorProvider();
        private ErrorProvider NoUsername = new ErrorProvider();

        public Frm_Register()
        {
            InitializeComponent();
            InitializeControls();
            CreatePresenter();
        }

        private bool ValidateRegister()
        {
            bool _IsWithoutError = true;
            if (string.IsNullOrEmpty(Password))
            {
                NoPassword.SetError(frtxtPassword, "Podaj hasło użytkownika.");
                _IsWithoutError = false;
            }
            else NoPassword.SetError(frtxtPassword, "");

            if (string.IsNullOrEmpty(UserName))
            {
                NoPassword.SetError(frtxtUser, "Podaj nazwę użytkownika.");
                _IsWithoutError = false;
            }
            else NoPassword.SetError(frtxtUser, "");

            return _IsWithoutError;
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
                if (ValidateRegister())
                {
                    if (vrcPresenter.RegisterNewUser())
                    {
                        MessageBox.Show("Poprawnie zarejestrowano nowego użytkownika.");
                        this.Close();
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.");
            }
            catch(Exception vrlException)
            {
                MessageBox.Show(vrlException.Message);
            }
        }

        public string UserName => frtxtUser.Text;
        public string Password => frtxtPassword.Text;
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
    }
}
