using RestWithASPNET9Jorge.Data.DTO;

namespace RestWithASPNET9Jorge.Interfaces;

public interface IPersonService
{
    PersonDTO Create(PersonDTO PersonDTO);
    PersonDTO FindById(long id);
    List<PersonDTO> FindAll();
    PersonDTO Update(PersonDTO PersonDTO);
    void Delete(long id);
}
