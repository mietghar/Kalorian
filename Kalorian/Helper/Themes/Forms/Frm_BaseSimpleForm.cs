using Kalorian.Helper.Themes.Forms.Interface;
using Kalorian.Helper.Themes.Forms.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorian.Helper.Themes.Forms
{
    public partial class Frm_BaseSimpleForm : Form, I_BaseSimpleFormView
    {
        
        public Frm_BaseSimpleForm()
        {
            InitializeComponent();
            CreateInterface();
        }

        public object vrcPresenter { get; set; }

        public void CreateInterface()
        {
            vrcPresenter = new ClP_BaseSimpleForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
