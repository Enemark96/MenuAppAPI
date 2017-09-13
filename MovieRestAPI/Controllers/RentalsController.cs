using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using menuAppBLL;
using menuAppBLL.BusinessObjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RentalsController : Controller
    {

        BLLFacade facade = new BLLFacade();

        // GET: api/rental
        [HttpGet]
        public IEnumerable<RentalBO> Get()
        {
            return facade.RentalServices.GetAll();
        }

        // GET api/rental/5
        [HttpGet("{id}")]
        public RentalBO Get(int id)
        {
            return facade.RentalServices.Get(id);
        }

        // POST api/rental
        [HttpPost]
        public IActionResult Post([FromBody]RentalBO rentalbo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(facade.RentalServices.Create(rentalbo));
        }

        // PUT api/rental/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]RentalBO rentalbo)
        {
            if (id != rentalbo.Id)
            {
                return StatusCode(405, "Path id does not match rental ID json object");
            }
            try
            {
                return Ok(facade.RentalServices.Update(rentalbo));
            }
            catch (InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        // DELETE api/rental/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.RentalServices.Delete(id);
        }
    }
}
