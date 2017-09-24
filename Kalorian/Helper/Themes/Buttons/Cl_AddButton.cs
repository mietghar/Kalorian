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
    public class Cl_AddButton : Cl_SimpleButton
    {
        public Cl_AddButton()
        {
            this.BackColor = Cl_BaseColor.LightAddButton;
            this.Name = "btnAdd";
            this.Text = "Dodaj";
        }
    }
}
