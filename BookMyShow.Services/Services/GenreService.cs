using System.Collections.Generic;
using AutoMapper;
using BookMyShow.Models.Movie;
using BookMyShow.DBModels;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class GenreService: IGenreService
    {
        private readonly DBContext _context;

        private readonly IMapper _mapper;

        public GenreService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenreDTO Get(int id)
        {
            return _mapper.Map<GenreDTO>(_context.SingleOrDefault<Genre>(id));
        }

        public IEnumerable<GenreDTO> GetAll()
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("*")
                        .From("Genre");

            return _mapper.Map<IEnumerable<GenreDTO>>(_context.Query<Genre>(query));
        }
    }
}
