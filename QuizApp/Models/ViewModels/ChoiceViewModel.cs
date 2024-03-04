using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels;

public class ChoiceViewModel
{
    public Question Question { get; set; }
    public int AnswerId { get; set; }
    public int QuestionId { get; set; }
}
