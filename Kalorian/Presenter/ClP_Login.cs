using Kalorian.Helper.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorian.Presenter
{
    public class ClP_Login
    {
        Form vrcView;
        public ClP_Login(Form vrpView)
        {
            vrcView = vrpView;
            SetTheme();
        }
        
        void SetTheme()
        {
            if(vrcView !=null)
            vrcView.BackColor = Cl_BaseColor.StandardBackground;
        }
    }
}
