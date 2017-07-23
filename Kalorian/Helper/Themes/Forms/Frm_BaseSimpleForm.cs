using Kalorian.Helper.Themes.Forms.Interface;
using Kalorian.Helper.Themes.Forms.Presenter;
using System;
using System.Windows.Forms;
using Kalorian.Helper.Themes.Buttons;

namespace Kalorian.Helper.Themes.Forms
{
    public partial class Frm_BaseSimpleForm : Form, I_BaseSimpleFormView
    {
        public object vrcPresenter { get; set; }

        public Frm_BaseSimpleForm()
        {
            InitializeComponent();
            CreateInterface();
        }

        public void CreateInterface() => vrcPresenter = new ClP_BaseSimpleForm(this);

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
