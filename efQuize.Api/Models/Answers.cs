using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efQuize.Api.Models;
public class Answers
{
    [Key]
    public int Id { get; set; }
    
    public string AnswerText { get; set; }

    public bool IsCorrect { get; set; }
    
    [ForeignKey("QuestionsId")]
    public virtual int QuestionsId { get; set; }

}