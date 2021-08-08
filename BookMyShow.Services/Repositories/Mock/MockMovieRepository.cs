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
    public class MockMovieRepository : IMovieRepository
    {
        public DBContext _context;

        public MockMovieRepository(DBContext context)
        {
            _context = context;
        }

        public Movie Get(int id)
        {
            return _context.SingleOrDefault<Movie>(id);
        }

        public MovieView GetDetails(int id)
        {
            Sql query = Sql.Builder
                        .Select("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages")
                        .From("MovieWithLocations m")
                        .Where("m.ID = @0", id);

            return _context.FirstOrDefault<MovieView>(query);
        }

        public IEnumerable<MovieView> GetAllAtLocation(int locationId)
        {
            Sql query = Sql.Builder
                        .Select("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages")
                        .From("MovieWithLocations m")
                        .Where("m.LocationID = @0", locationId)
                        .GroupBy("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages");

            return _context.Query<MovieView>(query);
        }

    }
}
