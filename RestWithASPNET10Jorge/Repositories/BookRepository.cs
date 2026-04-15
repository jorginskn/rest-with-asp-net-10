using RestWithASPNET9Jorge.Model;
using RestWithASPNET9Jorge.Model.Context;

namespace RestWithASPNET9Jorge.Repositories;

public class BookRepository : IBookRepository
{
    private readonly MSSQLContext _context;

    public BookRepository(MSSQLContext context)
    {
        _context = context;
    }
    public List<Book> FindAll()
    {
         var books = _context.Books.ToList();
        return books;
    }
    public Book FindById(long id)
    {
        var book = _context.Books.Find(id);
        return book;
    }
    public Book Create(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return book;
    }

    public Book Delete(long id)
    {
        var existingBook = _context.Books.Find(id);
        if(existingBook == null) 
            return null;
        else
            _context.Books.Remove(existingBook);
            _context.SaveChanges();
            return existingBook;
    }


  

    public Book Update(Book book)
    {
        try
        {
            var existingBook = _context.Books.Find(book.Id);
            if (existingBook == null)
            {
                return null;
            }
            else
            {
                _context.Entry(existingBook).CurrentValues.SetValues(book);
                _context.SaveChanges();
                return book;
            }

        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
