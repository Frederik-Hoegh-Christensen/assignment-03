namespace Assignment3.Entities;
using System.ComponentModel.DataAnnotations;

public class Task
{
    public int Id { get; set; }
    [StringLength(100), Required]
    public string Title { get; set; }
    public User? AssignedTo { get; set; }
    [StringLength(int.MaxValue)]
    public string? Description { get; set; }
    [Required]
    public State State { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }



    public Task(int id, string t, User? a, string? d, State s, ICollection<Tag>? tag)
    {
        this.Id = id;
        this.Title = t;
        this.AssignedTo = a;
        this.Description = d;
        this.State = s;
        this.Tags = tag;
    }

    

}

public enum State {
    New,
    Active,
    Resolved,
    Closed,
    Removed
}