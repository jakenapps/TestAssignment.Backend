using System.ComponentModel.DataAnnotations;

namespace TaskAssignment.Backend.Models;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    [Timestamp]
    public byte[] ConcurrencyStamp { get; set; }
}