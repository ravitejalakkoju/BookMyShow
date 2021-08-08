using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ILanguageRepository
    {
        public Language Get(int id);

        public IEnumerable<Language> GetAll();

        public IEnumerable<Language> GetAll(Expression<Func<IEntity, bool>> filter = null);
    }
}
