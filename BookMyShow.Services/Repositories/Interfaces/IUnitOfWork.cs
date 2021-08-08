using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public ILocationWrapper Locations { get; }

        public IMovieWrapper Movies { get; }

        public ITheatreWrapper Theatres { get; }

        public ICustomerWrapper Customers { get; }
    }
}
