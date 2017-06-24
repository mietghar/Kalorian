using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalorian.Interface.Repository
{
    public interface I_Repository<T>
    {
        T GetById(Guid id);
        T GetByQuery(Queue query);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
