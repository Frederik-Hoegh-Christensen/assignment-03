namespace Assignment3.Entities;
using System.ComponentModel.DataAnnotations;

public class Tag
{
    public int Id { get; set; }
    [StringLength(50), Required]
    public string Name { get; set; }
    public ICollection<Task> Tasks { get; set; }
}
