
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Communication;
using MyLibrary.Models;

namespace MyLibrary.Controllers;

public class BooksController : LibraryBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(BookModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id)
    {
        var response = new BookModel();
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(BookModel), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new BookModel
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Genres = request.Genres,
            Price = request.Price,
            QuantityAvailable = request.QuantityAvailable,
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestRegisterBookJson request)
    {

        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<BookModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var response = new List<BookModel>()
        {
            new BookModel { Id = 1, Title = "Livro", Author = "Autor", Genres = MoviesGenres.Scifi, Price = 200.12,  QuantityAvailable = 10},
            new BookModel { Id = 2, Title = "Livro", Author = "Autor", Genres = MoviesGenres.Romance, Price = 25.99,  QuantityAvailable = 2},
        };
        return Ok(response);
    }

}