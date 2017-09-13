using menuAppBLL;
using menuAppBLL.BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MovieRestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        BLLFacade facade = new BLLFacade();


        // GET: api/Movies
        [HttpGet]
        public IEnumerable<MovieBO> Get()
        {
            return facade.MovieServices.GetAll();
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public MovieBO Get(int id)
        {
            return facade.MovieServices.Get(id);
        }
        
        // POST: api/Movies
        [HttpPost]
        public IActionResult Post([FromBody]MovieBO movie)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(facade.MovieServices.Create(movie));
        }
        
        // PUT: api/Movies/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]MovieBO movie)
        {
            if (id != movie.ID)
            {
               return StatusCode(405, "Path id does not match customer ID json object");
            }
            try
            {
                return Ok(facade.MovieServices.Update(movie));
            }
            catch (InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
           
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.MovieServices.Delete(id);
        }
    }
}
