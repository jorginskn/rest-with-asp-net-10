using RestWithASPNET9Jorge.Data.DTO;
using RestWithASPNET9Jorge.Model;

namespace RestWithASPNET9Jorge.Data.Converter.Contract;

public class PersonConverter : IParser<PersonDTO, Person>, IParser<Person, PersonDTO>
{

    public PersonDTO Parse(Person origin)
    {
        if (origin == null)
            return null;
        return new PersonDTO
        {
            Id = origin.Id,
            FirstName = origin.FirstName,
            LastName = origin.LastName,
            Address = origin.Address,
            Gender = origin.Gender,
        };

    }

    public Person Parse(PersonDTO origin)
    {
        if (origin == null)
            return null;
        return new Person
        {
            Id = origin.Id,
            FirstName = origin.FirstName,
            LastName = origin.LastName,
            Address = origin.Address,
            Gender = origin.Gender,
        };

    }

    public List<Person> ParseList(List<PersonDTO> originList)
    {
        if (originList == null)
            return null;
        return originList.Select(Parse).ToList();
    }

    public List<PersonDTO> ParseList(List<Person> originList)
    {
        if (originList == null)
            return null;
        return originList.Select(Parse).ToList();
    }
}
