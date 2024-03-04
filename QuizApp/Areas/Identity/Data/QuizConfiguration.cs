using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApp.Models.Domain;

namespace QuizApp.Areas.Identity.Data;

  public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder){
         builder.HasData(
                new  Quiz
                {
                    Id = 1,
                     Title = "Maths quiz on Diferential Calculs",
                     Description = "It holds ten questions "
                },
                new  Quiz
                {
                     Id = 2,
                     Title = "Biology quiz on Cell body",
                     Description = "It holds ten questions "
                },
                 new  Quiz
                {
                     Id = 3,
                     Title = "Physics quiz on Quantum mechanics ",
                     Description = "It holds ten questions "
                },
                 new  Quiz
                {
                     Id = 4,
                     Title = "Chemistry quiz on Diferential Calculs",
                     Description = "It holds ten questions "
                }
               
            );
    }
}
