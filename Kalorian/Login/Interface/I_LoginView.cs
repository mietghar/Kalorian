using System.Drawing;

namespace Kalorian.Login.Interface
{
    public interface I_LoginView
    {
        string UserName { get; }
        string Password { get; }
        Color NameFieldColor { get; set; }
        Color PasswordFieldColor { get; set; }
        void SetVisibility(bool vrpVisibility);
    }
}