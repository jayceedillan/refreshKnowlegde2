using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace core.Models;
public class Profile
{
    [Key]
    [Display(Name = "Profile Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    [Required]
    public string Name { get; set; }

    public string ContactNo { get; set; }

}