using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class PlacesController : Controller
    {
        [HttpGet]
        public string GetPlaces()
        {
            return "Lugarcitos";
        }

        [HttpGet("{id}")]
        public string GetPlace(int id)
        {
            return "Lugar";
        }
    }
}