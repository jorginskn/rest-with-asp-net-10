using RestWithASPNET9Jorge.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET9Jorge.Model;

 public class Book : BaseEntity
{
    [Required(ErrorMessage = "Título é obrigatório")]
    [Column("title", TypeName = "varchar(80)")]
    [MaxLength(80, ErrorMessage = "O título deve conter no máximo 80 caracteres")]
    public string Title { get;  set; }
    [Required(ErrorMessage = "Autor é obrigatório")]
    [Column("author", TypeName = "varchar(80)")]
    [MaxLength(80, ErrorMessage = "O autor deve conter no máximo 80 caracteres")]
    public string Author { get; set; }
    [Required(ErrorMessage = "Preço é obrigatório")]
    [Column("price", TypeName = "decimal(18,2)")]
    public decimal Price { get;  set; }
    [Required(ErrorMessage = "Data de lançamento é obrigatória")]
    [Column("launch_date", TypeName = "datetime ")]
    public DateTime LaunchDate { get; set; }
}
