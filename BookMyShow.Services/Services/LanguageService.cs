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
    public class LanguageService: ILanguageService
    {
        private readonly DBContext _context;

        private readonly IMapper _mapper;

        public LanguageService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public LanguageDTO Get(int id)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("Language")
                                        .Where("ID=@0", id);

            return _mapper.Map<LanguageDTO>(_context.Query<Language>(query));
        }

        public IEnumerable<LanguageDTO> GetAll()
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("Language");

            return _mapper.Map<IEnumerable<LanguageDTO>>(_context.Query<Language>(query));
        }
    }
}
