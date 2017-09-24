using System.ComponentModel;

namespace Kalorian.Helper.Themes.Buttons
{
    [ToolboxItem(true)]
    [DisplayName("Standard close button")]
    public class Cl_CloseButton : Cl_SimpleButton
    {
        public Cl_CloseButton()
        {
            this.BackColor = Cl_BaseColor.LightCloseButton;
            this.Name = "btnClose";
            this.Text = "Zamknij";
        }
    }
}
