using Microsoft.EntityFrameworkCore.Metadata;
using QuizApp.Areas.Identity.Data;
using QuizApp.Models.Domain;


namespace QuizApp.Models.Domain;

public class AnswerModel : BaseEntity
{
    public int QuizId{ get; set; }
    public Quiz Quiz { get; set; }
    public int Total { get; set; }
    public int  TotalQuestions { get; set; }
    public string UserEmail { get; set; }
    public string UserID { get; set; }

    public  User User { get; set; }

}
