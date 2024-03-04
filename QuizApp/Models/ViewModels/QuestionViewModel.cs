using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels;

public class QuestionViewModel
{
    public Question Question { get; set; }
    public Choice Choice { get; set; }
    public ICollection<Choice> Choices { get; set; }
    
}
