using System.Drawing;

namespace Kalorian.Register.Interface
{
    public interface I_RegisterView
    {
        string UserName { get; }
        string Password { get; }
        Color NameFieldColor { get; set; }
        Color PasswordFieldColor { get; set; }
    }
}
