namespace QuizApp.Models.Domain;

public class Choice  : BaseEntity
{
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    // Foreign key
    public int QuestionId { get; set; }
     public Question Question { get; set; }
}
