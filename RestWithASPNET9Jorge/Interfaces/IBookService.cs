using RestWithASPNET9Jorge.Model;

namespace RestWithASPNET9Jorge.Interfaces;

public interface IBookService
{
    Book Create(Book person);
    Book FindById(long id);
    List<Book> FindAll();
    Book Update(Book person);
    Book Delete(long id);
}
