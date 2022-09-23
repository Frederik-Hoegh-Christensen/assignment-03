namespace Assignment3.Entities;
using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    [StringLength(100), Required]
    public string Name { get; set; }
    [StringLength(100), Required]
    public string Email { get; set; }
    public 
}
