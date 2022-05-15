using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Data
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        IList<T> GetAll();
    }
}
