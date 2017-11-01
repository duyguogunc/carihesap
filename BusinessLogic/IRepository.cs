using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface IRepository<T>  where T : class
    {
        void Add(T record);

        void Delete(T record);

        void Update(T record);

        List<T> GetAll();

        T GetRecord(Predicate<T> kosul);
    }
}
