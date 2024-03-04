using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels;

public class QuizViewModel
{
    public ICollection<Question> Questions { get; set; }
    public Question Question { get; set; }
    public int QuizId { get; set; }
}
