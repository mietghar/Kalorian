using Kalorian.Entity;
using Kalorian.Enum;
using Kalorian.Interface.Repository;
using Kalorian.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Factory
{
    public class Cl_RepositoryFactory
    {
        public virtual I_Repository<Type> CreateRepository(E_Repositories vrpRepository)
        {
            I_Repository<Type> vrcFactory = null;
            switch (vrpRepository)
            {
                case E_Repositories.User:
                    vrcFactory = new Cl_UserRepository() as I_Repository<Type>;
                    break;
            }
            return vrcFactory;
        }
    }
}
