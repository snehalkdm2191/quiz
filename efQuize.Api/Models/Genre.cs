using System.ComponentModel.DataAnnotations;

namespace efQuize.Api.Models;

public class Genre
{
    [Key]
    public int Id { get; set; }
    
    public string Subject { get; set; }

}