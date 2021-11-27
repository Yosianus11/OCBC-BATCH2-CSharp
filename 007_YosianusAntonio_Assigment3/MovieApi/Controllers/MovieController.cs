using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models; 



namespace MovieApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
   
    public class MovieController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MovieController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovie()
        {
            var Movie = await _context.Movies.ToListAsync();
            return Ok(Movie);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.ID }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Movies.FirstOrDefaultAsync(x => x.ID == id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, MovieData item){
            if(id!= item.ID)
            return BadRequest();

            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.ID==id);

            if(existItem==null)
            return BadRequest();

            existItem.NAME = item.NAME;
            existItem.GENRE = item.GENRE;
            existItem.DURATION = item.DURATION;
            existItem.RELEASE_DATE = item.RELEASE_DATE;
            
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.ID == id);

            if(existItem == null)
            return NotFound();

            _context.Movies.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }


    }
}
