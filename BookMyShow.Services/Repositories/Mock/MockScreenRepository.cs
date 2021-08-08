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
    public class MockScreenRepository : IScreenRepository
    {
        private readonly DBContext _context;

        public MockScreenRepository(DBContext context)
        {
            _context = context;
        }

        public Screen Get(int id)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Screen")
                        .Where("ID=@0", id);

            return _context.Query<Screen>(query).FirstOrDefault();
        }

    }
}
