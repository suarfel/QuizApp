using QuizApp.Models.Domain;

namespace QuizApp.Models.ViewModels;

public class StatQuizModel
{
    public ICollection<AnswerModel> AnswerModels {get;set;}
    public Quiz Quiz { get; set; }
}
