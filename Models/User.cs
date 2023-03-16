using System.ComponentModel.DataAnnotations;

namespace uh_sample.Models;

public class User
{
    public Guid UserId { get; set; }
    
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    
    public virtual ICollection<Address> Addresses { get; set; }
}