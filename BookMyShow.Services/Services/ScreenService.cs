using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.DBModels;
using BookMyShow.Models.Theatre;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class ScreenService: IScreenService
    {
        private readonly DBContext _context;
        public IMapper _mapper;
        public ScreenService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ScreenDTO Get(int screenId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("Screen")
                                        .Where("ID=@0", screenId);

            return _mapper.Map<ScreenDTO>(_context.Query<Screen>(query).FirstOrDefault());
        }
    }
}
