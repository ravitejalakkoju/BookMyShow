using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        public Genre Get(int id);

        public IEnumerable<Genre> GetAll();

        public IEnumerable<Genre> GetAll(Expression<Func<IEntity, bool>> filter = null);
    }
}
