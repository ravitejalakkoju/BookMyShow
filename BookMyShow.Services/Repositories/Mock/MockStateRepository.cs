using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockStateRepository: IStateRepository
    {
        public DBContext _context;

        public MockStateRepository(DBContext context)
        {
            _context = context;
        }

        public State Get(int id)
        {
            return _context.SingleOrDefault<State>(id);
        }

        public IEnumerable<State> GetAll()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("State");

            return _context.Query<State>(query);
        }
    }
}
