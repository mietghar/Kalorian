using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Helper.Themes.Forms.Interface
{
    public interface I_BaseSimpleFormView
    {
        object vrcPresenter { get; set; }
        void CreateInterface();
    }
}
