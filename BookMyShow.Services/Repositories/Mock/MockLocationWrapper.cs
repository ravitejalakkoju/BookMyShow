using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockLocationWrapper : ILocationWrapper
    {
        private readonly DBContext _context;

        private ILocationRepository _locationRepository;

        private IStateRepository _stateRepository;

        public MockLocationWrapper(DBContext context)
        {
            _context = context;
        }

        public ILocationRepository LocationRepository {
            get
            {
                if (_locationRepository == null)
                {
                    _locationRepository = new MockLocationRepository(_context);
                }
                return _locationRepository;
            }
        }

        public IStateRepository StateRepository
        {
            get
            {
                if (_stateRepository == null)
                {
                    _stateRepository = new MockStateRepository(_context);
                }
                return _stateRepository;
            }
        }
    }
}
