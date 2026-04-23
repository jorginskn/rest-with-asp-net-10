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

    public List<Book> FindAll()
    {
        return _repository.FindAll();
    }

    public Book FindById(long id)
    {
        return _repository.FindById(id);
    }
    public Book Create(Book book)
    {
        return _repository.Create(book);
    }

    public Book Delete(long id)
    {
        return _repository.Delete(id);
    }



    public Book Update(Book book)
    {
        return _repository.Update(book);
    }
}
