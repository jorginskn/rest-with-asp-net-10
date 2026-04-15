using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET9Jorge.Model;

[Table("books")]
public class Book
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get;  set; }

    [Required]
    [Column("title")]
    [MaxLength(200)]
    public string Title { get;  set; }

    [Required]
    [Column("author")]
    [MaxLength(250)]
    public string Author { get; set; }

    [Required(ErrorMessage = "O campo Price é obrigatório")]
    [Column("price")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal? Price { get;  set; }

    [Required(ErrorMessage = "O campo LaunchDate é obrigatório")]
    [Column("launch_date")]
    public DateTime? LaunchDate { get; set; }


}
