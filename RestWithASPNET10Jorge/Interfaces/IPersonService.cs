using RestWithASPNET10Jorge.Model;

namespace RestWithASPNET10Jorge.Interfaces;

public interface IPersonService
{
    Person Create(Person person);
    Person FindById(long id);
    List<Person> FindAll();
    Person Update(Person person);
    void Delete(long id);
}
