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
    public class MockGenreRepository: IGenreRepository
    {
        private readonly DBContext _context;

        public MockGenreRepository(DBContext context)
        {
            _context = context;
        }

        public Genre Get(int id)
        {
            return _context.SingleOrDefault<Genre>(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Genre");

            return _context.Query<Genre>(query);
        }

        public IEnumerable<Genre> GetAll(Expression<Func<IEntity, bool>> filter = null)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Genre")
                        .Where(filter.ToString());

            return _context.Query<Genre>(query);
        }
    }
}
