using Mapster;
using RestWithASPNET9Jorge.Data.DTO;
using RestWithASPNET9Jorge.Interfaces;
using RestWithASPNET9Jorge.Model;
using RestWithASPNET9Jorge.Repositories;

namespace RestWithASPNET9Jorge.Services;

public class BookService : IBookService
{
    private readonly IRepository<Book> _repository;

    public BookService(IRepository<Book> repository)
    {
        _repository = repository;
    }

    public List<BookDTO> FindAll()
    {
        return _repository.FindAll().Adapt<List<BookDTO>>();
    }

    public BookDTO FindById(long id)
    {
        return _repository.FindById(id).Adapt<BookDTO>();
    }
    public BookDTO Create(BookDTO book)
    {
        var entity = book.Adapt<Book>();
        entity = _repository.Create(entity);
        return entity.Adapt<BookDTO>();
    }

    public BookDTO Delete(long id)
    {

        return _repository.Delete(id).Adapt<BookDTO>();
    }



    public BookDTO Update(BookDTO book)
    {
        var entity = book.Adapt<Book>();
        entity = _repository.Update(entity);
        return entity.Adapt<BookDTO>();
    }
}
