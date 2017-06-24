using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Helper.Themes
{
    public static class Cl_BaseColor
    {
        #region Private Fields

        private static Color LightBlue = Color.FromArgb(175, 206, 255);
        private static Color LightRed = Color.FromArgb(247, 160, 123);
        private static Color LightYellow = Color.FromArgb(255, 255, 135);
        private static Color LightGreen = Color.FromArgb(149, 242, 135);

        #endregion

        #region Public Properties

        public static Color StandardBackground
        {
            get { return LightBlue; }
        }

        public static Color StandardCloseButton
        {
            get { return LightRed; }
        }

        public static Color StandardSimpleButton
        {
            get { return LightYellow; }
        }

        public static Color StandardAddButton
        {
            get { return LightGreen; }
        }

        #endregion

    }
}
