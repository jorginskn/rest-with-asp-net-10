using RestWithASPNET9Jorge.Model;

namespace RestWithASPNET9Jorge.Interfaces;

public interface IPersonService
{
    Person Create(Person person);
    Person FindById(long id);
    List<Person> FindAll();
    Person Update(Person person);
    void Delete(long id);
}
