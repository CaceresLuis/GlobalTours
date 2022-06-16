using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class PlacesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Place> _place;
        private readonly IGenericRepository<Country> _country;

        public PlacesController(IMapper mapper, IGenericRepository<Place> place, IGenericRepository<Country> country)
        {
            _place = place;
            _mapper = mapper;
            _country = country;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlaceDto>>> GetPlaces()
        {
            PlacesWithCountryCategorySpecification spec = new();
            IReadOnlyList<Place> data = await _place.GetAll(spec);
            
            return Ok(_mapper.Map<IReadOnlyList<PlaceDto>>(data));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlaceDto>> GetPlace(int id)
        {
            var spec = new PlacesWithCountryCategorySpecification(id);
            Place place = await _place.GetSpec(spec);
            return _mapper.Map<PlaceDto>(place);
        }

        [HttpGet("country")]
        public async Task<ActionResult<List<PlaceDto>>> GetCountries()
        {
            IReadOnlyList<Country> data = await _country.GetAll();
            List<CountryDto> list = _mapper.Map<List<CountryDto>>(data);
            return Ok(list);
        }
    }
}