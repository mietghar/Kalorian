using Kalorian.Helper.Themes.Forms;
using Kalorian.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorian.View.Login
{
    public partial class Frm_Login : Frm_BaseSimpleForm
    {
        ClP_Login vrcPresenter;
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
