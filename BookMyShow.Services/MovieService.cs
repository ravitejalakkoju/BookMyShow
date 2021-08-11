using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.DBModels;
using BookMyShow.Models.Movie;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class MovieService: IMovieService
    {
        private readonly DBContext _context;

        private readonly IMapper _mapper;

        public MovieService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public MovieDTO GetDetails(int movieId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages")
                        .From("MovieWithLocations m")
                        .Where("m.ID = @0", movieId);

            return _mapper.Map<MovieDTO>(_context.FirstOrDefault<MovieView>(query));
        }   

        public IEnumerable<MovieDTO> GetAllAtLocation(int locationId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages")
                        .From("MovieWithLocations m")
                        .Where("m.LocationID = @0", locationId)
                        .GroupBy("m.ID, m.Name, m.ReleaseDate, m.EndingDate, m.Status, m.APIID, m.Genres, m.Languages");

            return _mapper.Map<IEnumerable<MovieDTO>>(_context.Query<MovieView>(query));
        }
    }
}
