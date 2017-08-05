using Kalorian.DAL.Enum;

namespace Kalorian.Main.Interface
{
    public interface I_MainView
    {
        int Age { get; set; }
        int Sex { get; set; }
        int UserId { get; }
        bool IsNewUser { get; set; }
        decimal Weight { get; set; }
    }
}
