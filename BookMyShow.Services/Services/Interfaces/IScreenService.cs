using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Theatre;

namespace BookMyShow.Services.Interfaces
{
    public interface IScreenService
    {
        public ScreenDTO Get(int screenId);
    }
}
