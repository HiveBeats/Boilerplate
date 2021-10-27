using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Features.Locations.Requests;
using WebApi.Features.Locations.Responses;
using WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController: ControllerBase
    {
        private readonly AppDbContext _db;
        public LocationsController(AppDbContext db)
        {
            _db = db;
        }
        
        [HttpPost("Insert")]
        public async Task<IActionResult> CreateBudget(PostLocationsCommand request)
        {
            if (!ModelState.IsValid || request == null)
                return BadRequest("Incorrect input");
            try
            {
                var items = request.Locations.Select(x => new Location()
                {
                    Latitude = x.Latitude,
                    Longitude = x.Longitude,
                    Timestamp = x.Timestamp
                });
                await _db.Locations.AddRangeAsync(items);
                await _db.SaveChangesAsync();
            }
            catch
            {
                return BadRequest("Incorrect input");
            }
            
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetLocationsRequest request)
        {
            if (!ModelState.IsValid || request == null)
                return BadRequest("Incorrect input");
            IEnumerable<LocationDto> result = new List<LocationDto>();
            try
            {
                result = (await _db.Locations
                        .Where(x => x.DateCreated >= request.DateBegin && x.DateCreated <= request.DateEnd)
                        .AsNoTracking()
                        .ToListAsync())
                    .Select(d => new LocationDto()
                    {
                        Latitude = d.Latitude,
                        Longitude = d.Longitude,
                        Timestamp = d.Timestamp
                    });
            }
            catch
            {
                return BadRequest("fail");
            }

            return Ok(result);
        }
        
        [HttpGet("health")]
        public async Task<IActionResult> GetHealth()
        {
            return Ok(await Task.FromResult<string>("Hello World"));
        }
    }
}