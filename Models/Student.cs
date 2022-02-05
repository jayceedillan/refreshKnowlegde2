using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace core.Models;
public class Student
{

    [Key]
    [Display(Name = "Student ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentId { get; set; }

    [Required]
    [Column(TypeName = "varchar(50)")]
    public string? StudentName { get; set; }

    public string? Year { get; set; }

}