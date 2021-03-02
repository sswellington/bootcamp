
using System.Collections.Generic;

namespace Serie.Interface
{
    public interface IRepository<T>
    {
        List<T> list();
        T getId(int id);        
        void insert(T entity);        
        void delete(int id);        
        void update(int id, T entity);
        int nextId();
    }
}