using RestWithASPNET10Jorge.Interfaces;
using RestWithASPNET10Jorge.Model;
using System;

namespace RestWithASPNET10Jorge.Services;

public class PersonService : IPersonService
{
    public Person Create(Person person)
    {
        person.Id = new Random().Next(1, 10000);
         return person;
    }

    public void Delete(long id)
    {
        throw new NotImplementedException();
    }

    public List<Person> FindAll()
    {
        List<Person> persons = new List<Person>();
        for (int i = 0; i < 8; i++)
        {
            var person = MockPerson(i);
            persons.Add(person);
        }
        return persons;
    }

    public Person FindById(long id)
    {
        var person = MockPerson((int)id);

        return person;
    }

    public Person Update(Person person)
    {
        throw new NotImplementedException();
    }

    private Person MockPerson(int i)
    {
        var person = new Person
        {
            Id = new Random().Next(1, 10000),
            FirstName = "Jorge " + i,
            LastName = "Silva " + i,
            Address = "Rua dos " + i,
            Gender = "Male"
        };
        return person;
    }
}
