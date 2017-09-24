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
        private static Color Blue = Color.FromArgb(137, 133, 253);

        #endregion

        #region Public Properties

        public static Color LightBackground => LightBlue;
        public static Color StandardBackGround => Blue;
        public static Color LightCloseButton => LightRed;
        public static Color LightSimpleButton => LightYellow;
        public static Color LightAddButton => LightGreen;

        #endregion

    }
}
