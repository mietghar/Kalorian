using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Helper.Themes.Buttons
{
    [ToolboxItem(true)]
    [DisplayName("Standard close button")]
    class Cl_CloseButton : Cl_SimpleButton
    {
        public Cl_CloseButton()
        {
            this.BackColor = Cl_BaseColor.StandardCloseButton;
            this.Name = "btnClose";
            this.Text = "Zamknij";
        }
    }
}
