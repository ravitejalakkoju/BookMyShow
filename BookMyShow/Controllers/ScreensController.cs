using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Models.DTO;
using BookMyShow.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreensController : ControllerBase
    {
        private ScreenService _screenService;

        public ScreensController(ScreenService screenService)
        {
            _screenService = screenService;
        }

        [HttpGet("{id}")]
        public ScreenDTO Get(int id)
        {
            return _screenService.Get(id);
        }

    }
}
