using System.Collections.Generic;
using WebModel;

namespace WebData
{
    public interface IDataSource <T>
    {
        
        List<T> GetAll();
        T GetById(int id);
        void Write(T ts);
        T GetByUnique(string id);
        IEnumerable<Product> Sort(string sort);
    }
}