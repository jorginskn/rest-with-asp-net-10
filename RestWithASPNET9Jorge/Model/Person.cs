using RestWithASPNET9Jorge.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET9Jorge.Model;

[Table("person")]
public class Person : BaseEntity
{
    [Required(ErrorMessage = "Primeiro nome é obrigatório")]
    [Column("first_name", TypeName = "varchar(80)")]
    [MaxLength(80, ErrorMessage = "O primeiro nome deve conter no máximo 80 caracteres")]
    public string FirstName { get;  set; }

    [Required(ErrorMessage = "Sobrenome é obrigatório")]
    [Column("last_name", TypeName = "varchar(80)")]
    [MaxLength(80, ErrorMessage = "O sobrenome deve conter no máximo 80 caracteres")]
    public string LastName { get;   set; }

    [Required(ErrorMessage = "Gênero é obrigatório")]
    [Column("gender", TypeName = "varchar(6)")]
    [MaxLength(6, ErrorMessage = "O gênero deve conter no máximo 6 caracteres")]
    public string Gender     { get;   set; }

    [Required(ErrorMessage = "Endereço é obrigatório")]
    [Column("address", TypeName = "varchar(100)")]
    [MaxLength(100, ErrorMessage = "O endereço deve conter no máximo 100 caracteres")]
    public string Address { get;   set; }

}
