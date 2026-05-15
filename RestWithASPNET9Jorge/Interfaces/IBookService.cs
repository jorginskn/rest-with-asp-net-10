using RestWithASPNET9Jorge.Data.DTO.V1;
using RestWithASPNET9Jorge.Model;

namespace RestWithASPNET9Jorge.Interfaces;

public interface IBookService
{
    BookDTO Create(BookDTO person);
    BookDTO FindById(long id);
    List<BookDTO> FindAll();
    BookDTO Update(BookDTO person);
    BookDTO Delete(long id);
}
