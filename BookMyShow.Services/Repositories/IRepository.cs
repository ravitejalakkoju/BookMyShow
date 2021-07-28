using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories
{
    public interface IRepository<T>: IQueryRepository<T>, ICommandRepository<T> where T: IAggregateRoot
    {
    }
}
