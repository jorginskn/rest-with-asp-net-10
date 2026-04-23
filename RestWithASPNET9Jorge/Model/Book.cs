using RestWithASPNET9Jorge.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET9Jorge.Model;

 public class Book : BaseEntity
{
    public string Title { get;  set; }
    public string Author { get; set; }
    public decimal Price { get;  set; }
    public DateTime LaunchDate { get; set; }
}
