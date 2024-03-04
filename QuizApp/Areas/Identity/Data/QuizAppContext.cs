
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizApp.Areas.Identity.Data;
using QuizApp.Models.Domain;

namespace QuizApp.Data;

public class QuizAppContext : IdentityDbContext<User>
{
    public QuizAppContext(DbContextOptions<QuizAppContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Choice> Choices { get; set; }
    public DbSet<AnswerModel> AnswerModels { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
         builder.ApplyConfigurationsFromAssembly(typeof(QuizAppContext).Assembly);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
