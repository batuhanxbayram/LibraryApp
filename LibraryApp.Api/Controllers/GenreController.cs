using LibraryApp.Api.Context;
using LibraryApp.Api.DTO.GenresDTO;
using LibraryApp.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly LibraryContext context;

        public GenreController(LibraryContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewGenreDTO genre)
        {
            var response = context.Genres.Add(genre.ToGenre());
            context.SaveChanges();

            return Ok(GenreInfo.FromGenre(response.Entity));
        }

        [HttpPut]
        public IActionResult Put()
        {


            return Ok();
        }

        [HttpGet]
        public IActionResult Get(int id )
        {
            var genre = context.Genres.FirstOrDefault(x=> x.Id == id);
            if (genre == null) return NotFound();

            return Ok(genre);
        }

        [HttpDelete]
        public IActionResult Delete()
        {


            return Ok();
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetAll()
        {
            var genre = context.Genres.ToList();
            if (genre == null) return NotFound();

            return Ok(genre);

        }

    }
}
