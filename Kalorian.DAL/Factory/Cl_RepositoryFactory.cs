using Kalorian.Common.Interface;
using Kalorian.DAL.Enum;
using Kalorian.DAL.Interface.Repository;
using Kalorian.DAL.Repository;

namespace Kalorian.DAL.Factory
{
    public class Cl_RepositoryFactory<T> where T : I_Identifiable
    {
        public virtual I_Repository<T> CreateRepository(E_Repositories vrpRepository)
        {
            I_Repository<T> vrlRepository = null;
            switch (vrpRepository)
            {
                case E_Repositories.User:
                    vrlRepository = new Cl_UserRepository() as I_Repository<T>;
                    break;
            }
            return vrlRepository;
        }
    }
}