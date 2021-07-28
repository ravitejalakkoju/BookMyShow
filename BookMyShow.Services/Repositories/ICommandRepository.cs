using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories
{
    public interface ICommandRepository<T> where T: IAggregateRoot
    {
        void Save(T t);
        void Delete(long id);
        void Update(T t);
    }
}
