using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Movie;

namespace BookMyShow.Services.Interfaces
{
    public interface ILanguageService
    {
        public LanguageDTO Get(int id);

        public IEnumerable<LanguageDTO> GetAll();
    }
}
