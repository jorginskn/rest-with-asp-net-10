using RestWithASPNET9Jorge.Data.Converter.Contract;
using RestWithASPNET9Jorge.Data.DTO.V1;
using RestWithASPNET9Jorge.Interfaces;
using RestWithASPNET9Jorge.Model;
using RestWithASPNET9Jorge.Repositories;

namespace RestWithASPNET9Jorge.Services;

public class PersonService : IPersonService
{
    private readonly IRepository<Person> _repository;
    private readonly PersonConverter _converter;
    public PersonService(IRepository<Person> repository)
    {
        _repository = repository;
        _converter = new PersonConverter();
    }
    public List<PersonDTO> FindAll()
    {
        var persons = _converter.ParseList(_repository.FindAll());
        return persons;
    }
    public PersonDTO FindById(long id)
    {
        var person = _converter.Parse(_repository.FindById(id));
        return person;
    }

    public PersonDTO Create(PersonDTO person)
    {
        var entity = _converter.Parse(person);
        entity = _repository.Create(entity);
        return _converter.Parse(entity);
    }

    public void Delete(long id)
    {
        try
        {
            var existingPerson = _repository.FindById(id);

            if (existingPerson == null)
            {
                return;
            }
            else
            {
                _repository.Delete(id);
                return;
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    public PersonDTO Update(PersonDTO person)
    {
        try
        {
            var existingPerson = _repository.FindById(person.Id);
            if (existingPerson == null)
            {
                return null;
            }
            else
            {
                var entity = _converter.Parse(person);
                entity = _repository.Update(entity);
                return _converter.Parse(entity);
            }

        }
        catch (Exception ex)
        {

            throw;
        }

    }


}
