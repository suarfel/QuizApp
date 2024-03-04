namespace QuizApp.Models.Domain;

public class Quiz : BaseEntity
{
    public string Title { get; set; }

    public string Description { get; set; }

    public ICollection<Question> Questions { get; set; }
}