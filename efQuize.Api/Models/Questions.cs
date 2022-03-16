using System.ComponentModel.DataAnnotations;

namespace efQuize.Api.Models;

public class Questions
{
    [Key]
    public int Id { get; set; }
    public string questionText { get; set; }
    
    public virtual int GenreId { get; set; }
    
    public virtual List<Answers> Answer {get; set;}
    
}