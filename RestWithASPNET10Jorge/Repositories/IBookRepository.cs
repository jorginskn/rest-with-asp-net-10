using RestWithASPNET9Jorge.Model;

namespace RestWithASPNET9Jorge.Repositories;

public interface IBookRepository
{
        Book Create(Book person);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book person);
        Book Delete(long id);
}
