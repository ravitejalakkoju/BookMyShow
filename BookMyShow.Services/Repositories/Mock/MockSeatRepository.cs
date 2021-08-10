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
    public class MockSeatRepository: ISeatRepository
    {
        private readonly DBContext _context;

        public MockSeatRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Seat> GetAllInScreen(int screenId)
        {
            return _context.Query<Seat>("select * from Seat where ScreenID = @0", screenId);
        }

        public IEnumerable<SeatsInScreen> GetAvailableSeatsPerScreen()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("SeatsInScreen");

            return _context.Query<SeatsInScreen>(query);
        }
    }
}
