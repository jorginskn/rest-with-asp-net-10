using Microsoft.AspNetCore.Mvc;
using RestWithASPNET9Jorge.Interfaces;
using RestWithASPNET9Jorge.Model;
using RestWithASPNET9Jorge.Services;
using System;

namespace RestWithASPNET9Jorge.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly ILogger _logger;
    public BookController(IBookService bookService, ILogger<BookController> logger)
    {
        _bookService = bookService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Buscando todos os livros!");
        var books =  _bookService.FindAll();
        if (books == null)
        {
            _logger.LogInformation("Nenhum livro foi encontrado!");
            NotFound();
        }
        _logger.LogInformation("Livros foram encontrados!");

        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(long id)
    {
        _logger.LogInformation("Buscando livro por id:{id}", id);
        var book = _bookService.FindById(id);
        if(book == null)
        {
            _logger.LogInformation("Nenhum livro foi encontrado para o id:{id}!", id);
            NotFound();
        }
        _logger.LogInformation("Livro encontrado para o id:{id}!", id);
        return Ok(book);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Book book)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("Dados inválidos ao tentar criar livro: {@book}", book);
            return BadRequest(ModelState);
        }

        _logger.LogInformation("Criando novo livro: {@book}", book);
        var createdBook = _bookService.Create(book);
        _logger.LogInformation("Livro criado com sucesso: {@createdBook}", createdBook);

        return CreatedAtAction(nameof(GetById), new { id = createdBook.Id }, createdBook);
    }

    [HttpPut]
    public IActionResult Put([FromBody] Book book)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("Dados inválidos ao tentar atualizar livro: {@book}", book);
            return BadRequest(ModelState);
        }

        _logger.LogInformation("Atualizando dados do livro: {@book}", book);
        var updatedBook = _bookService.Update(book);
        if(updatedBook == null)
        {
            _logger.LogInformation("Nenhum livro foi encontrado para o id:{id}!", book.Id);
            return NotFound();
        }
        _logger.LogInformation("O Livro: {@updateBook} foi atualizado com sucesso!", book);

        return Ok(updatedBook);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _logger.LogInformation("Excluindo livro com id: {id}", id);
        var book = _bookService.Delete(id);
        if (book == null)
        {
            _logger.LogInformation("Nenhum livro foi encontrado para o id:{id}!", id);
            return NotFound();
        }
        _logger.LogInformation("Livro com ID: {id} deletado com sucesso!", id);

        return NoContent();
    }
}
