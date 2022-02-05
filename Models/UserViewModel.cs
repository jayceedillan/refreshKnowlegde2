using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models;

public class UserViewModel
{
    public int id { get; set; }

    [Required]
    public string Name { get; set; }

    // [Required]
    // [Display(Name = "Contact No.")]
    // [EmailAddress(ErrorMessage = "Invalid email address")]
    // public string ContactNo { get; set; }

}
