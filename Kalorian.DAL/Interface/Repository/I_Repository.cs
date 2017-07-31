using System;
using System.Collections;

namespace Kalorian.DAL.Interface.Repository
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