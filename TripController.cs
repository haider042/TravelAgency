using Microsoft.AspNetCore.Mvc;
using Travelia.Model;

namespace Travelia.Controllers
{
    public class TripController : Controller
    {
        private readonly TripDB_Context _DB_Context;
        private TripDB_Context _TripDB_Context;
        private object _tripDB_Context;

        public TripController(TripDB_Context tripDB_Context)
        {
            _TripDB_Context = tripDB_Context;
        }

        [HttpPut("TripData")]
        public IActionResult SaveTripData([FromBody]Trip trip)
        {
            _tripDB_Context.trip.Add(trip);
            _tripDB_Context.SaveChanges();

            return Ok();
        }

        [HttpGet("TripDataView")]
        public IEnumerable<Trip> GetTrip()
        {

            return _tripDB_Context.trip;

        }


    }
}
