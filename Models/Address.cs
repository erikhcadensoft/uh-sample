using System.ComponentModel.DataAnnotations;

namespace uh_sample.Models;

public enum AddressType
{
    Home,
    Work,
    Other
}

public class Address
{
    public Guid AddressId { get; set; }
    
    [Required, Display(Name = "Street Address")]
    public string StreetAddress { get; set; }
    
    [Required]
    public string City { get; set; }
    
    [Required]
    public string State { get; set; }
    
    [Required]
    public int Zip { get; set; }
    
    [Required]
    public AddressType Type { get; set; }
    
    public virtual Guid UserId { get; set; }
}