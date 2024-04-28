using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStorageSet<T> where T : User
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
