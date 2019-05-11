using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Data;
using TripTracker.Models;

namespace TripTracker.Controllers
{

    [Route("api/[controller]")]
    public class TripsController : Controller
    {

        TripContext _context;

        public TripsController(TripContext context)
        {
            _context = context;
        }

        
        // GET api/Trips
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _context.Trips.ToList();   
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _context.Trips.Find(id);
            
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody]Trip value)
        {
            _context.Add(value);
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip value)
        {
            _context.Update(value);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Remove(id);
        }
    }
}
