using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET9Jorge.Model.Context;

public class MSSQLContext : DbContext
{
    public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options)
    {
        
    }
     public DbSet<Person> Persons { get; set; }
    
}
