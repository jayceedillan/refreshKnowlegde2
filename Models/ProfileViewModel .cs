using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models;

public class ProfileViewModel
{
    public int id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string ContactNo { get; set; }
}
