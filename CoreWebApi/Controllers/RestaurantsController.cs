using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreWebApi.Models;
using CoreWebApi.Models.Repository;

namespace CoreWebApi.Controllers
{
    [Route("api/Restaurants")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IDataRepository<Restaurant> _dataRepository;

        public RestaurantsController(IDataRepository<Restaurant> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Restaurants
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Restaurant> restaurants = _dataRepository.GetAll();
            return Ok(restaurants);
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Restaurant restaurant = _dataRepository.Get(id);

            if (restaurant == null)
            {
                return NotFound("The Restaurant record couldn't be found.");
            }

            return Ok(restaurant);
        }

        // POST: api/Restaurants
        [HttpPost]
        public IActionResult Post([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest("Restaurant is null.");
            }

            _dataRepository.Add(restaurant);
            return CreatedAtRoute(
                  "Get",
                  new { Id = restaurant.RestaurantId },
                  restaurant);
        }

        // PUT: api/Restaurants/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest("Restaurant is null.");
            }

            Restaurant restaurantToUpdate = _dataRepository.Get(id);
            if (restaurantToUpdate == null)
            {
                return NotFound("The Restaurant record couldn't be found.");
            }

            _dataRepository.Update(restaurantToUpdate, restaurant);
            return NoContent();
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Restaurant restaurant = _dataRepository.Get(id);
            if (restaurant == null)
            {
                return NotFound("The Restaurant record couldn't be found.");
            }

            _dataRepository.Delete(restaurant);
            return NoContent();
        }
    }
}
