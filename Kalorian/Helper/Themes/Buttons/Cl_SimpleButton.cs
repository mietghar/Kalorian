using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorian.Helper.Themes.Buttons
{
    public class Cl_SimpleButton : Button
    {
        public Cl_SimpleButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Cl_BaseColor.StandardSimpleButton;
        }
    }
}
