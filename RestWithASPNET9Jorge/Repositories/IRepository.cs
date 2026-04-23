using RestWithASPNET9Jorge.Model;
using RestWithASPNET9Jorge.Model.Base;

namespace RestWithASPNET9Jorge.Repositories;

public interface IRepository<T> where T: BaseEntity
{
    List<T> FindAll();
    T FindById(long id);
    T Create(T item);
  
    T Update(T item);
    T Delete(long id);
}
