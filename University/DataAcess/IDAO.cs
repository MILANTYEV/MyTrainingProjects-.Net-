using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAcess
{
    public interface IDAO<T> : IDisposable where T : class
    {
        IEnumerable<T> GetList();
        void Add(T item);
        void Edit(T item);
        void Delete(T item);
    }
}
