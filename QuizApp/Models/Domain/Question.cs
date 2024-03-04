
namespace QuizApp.Models.Domain;

public class Question : BaseEntity
{
    public string Text { get; set; }
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }
    public ICollection<Choice> Choices { get; set; }

   

}