using Kalorian.Helper.Themes.Forms;
using Kalorian.Presenter.Login;

namespace Kalorian.View.Login
{
    public partial class Frm_Register : Frm_BaseSimpleForm
    {
        private new ClP_Register vrcPresenter;

        public Frm_Register()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            btnClose.Text = "Anuluj";
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {

        }
    }
}
