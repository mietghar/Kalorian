using Kalorian.Common.Interface;

namespace Kalorian.DAL.Entity
{
    public class ClE_User : I_Identifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}