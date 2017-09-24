using System.Windows.Forms;

namespace Kalorian.Helper.Themes.Forms.Presenter
{
    public class ClP_BaseSimpleForm
    {
        private readonly Form vrcView;
        public ClP_BaseSimpleForm(Form vrpView)
        {
            vrcView = vrpView;
            ColorBackground();
        }
        
        private void ColorBackground()
        {
            vrcView.BackColor = Cl_BaseColor.LightBackground;
        }
    }
}
