using System;
using System.Collections;
using Kalorian.DAL.Entity;
using Kalorian.DAL.Interface.Repository;
using System.Windows.Forms;

namespace Kalorian.DAL.Repository
{
    public class Cl_UserRepository : I_Repository<ClE_User>
    {
        public void Add(ClE_User item)
        {
            MessageBox.Show("Created new User");
        }

        public ClE_User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClE_User GetByQuery(Queue query)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClE_User item)
        {
            throw new NotImplementedException();
        }

        public void Update(ClE_User item)
        {
            throw new NotImplementedException();
        }
    }
}
