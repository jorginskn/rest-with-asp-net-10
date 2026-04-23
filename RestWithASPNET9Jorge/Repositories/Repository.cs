using Microsoft.EntityFrameworkCore;
using RestWithASPNET9Jorge.Model.Base;
using RestWithASPNET9Jorge.Model.Context;

namespace RestWithASPNET9Jorge.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly MSSQLContext _context;
    private DbSet<T> _dataset;   
    public Repository(MSSQLContext context)
    {
        _context = context;
        _dataset = _context.Set<T>();
    }
    public List<T> FindAll()
    {
       return _dataset.AsNoTracking().ToList();
    }

    public T FindById(long id)
    {
        return _dataset.AsNoTracking().FirstOrDefault(p => p.Id == id);
    }
    public T Create(T item)
    {
         _dataset.Add(item);
         _context.SaveChanges();
         return item;
    }
    public T Update(T item)
    {
        var existingItem = _dataset.Find(item.Id);
        if (existingItem == null)
        {
            return null;
        }
        _context.Entry(existingItem).CurrentValues.SetValues(item);
        _context.SaveChanges();
        return item;
    }
    public T Delete(long id)
    {
        var existingItem = _dataset.Find(id);
        if (existingItem == null)
        {
            return null;
        }
        _dataset.Remove(existingItem);
        _context.SaveChanges();
        return existingItem;
    }


}
