using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockLanguageRepository: ILanguageRepository
    {
        private readonly DBContext _context;

        public MockLanguageRepository(DBContext context)
        {
            _context = context;
        }

        public Language Get(int id)
        {
            return _context.SingleOrDefault<Language>(id);
        }

        public IEnumerable<Language> GetAll()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Language");

            return _context.Query<Language>(query);
        }

        public IEnumerable<Language> GetAll(Expression<Func<IEntity, bool>> filter = null)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Language")
                        .Where(filter.ToString());

            return _context.Query<Language>(query);
        }
    }
}
