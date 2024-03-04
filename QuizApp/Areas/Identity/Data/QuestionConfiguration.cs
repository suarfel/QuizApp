using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApp.Models.Domain;

namespace QuizApp.Areas.Identity.Data;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
  public void Configure(EntityTypeBuilder<Question> builder)
  {
    builder.HasData(
       new Question
       {
         Id = 1,
         Text = "What is the powerhouse of the cell?",
         QuizId = 2
       }, new Question
       {
         Id = 2,
         Text = "Which of the following is not a function of the liver?",
         QuizId = 2
       },
         new Question
         {
           Id = 3,
           Text = "What is the process by which plants make their own food?",
           QuizId = 2
         }
                , new Question
                {
                  Id = 4,
                  Text = "What is the main function of red blood cells?",
                  QuizId = 2
                }, new Question
                {
                  Id = 5,
                  Text = "Which organelle is responsible for protein synthesis?",
                  QuizId = 2
                },

                new Question
                {
                  Id = 6,
                  Text = "What is the value of π (pi) rounded to two decimal places?",
                  QuizId = 1
                }, new Question
                {
                  Id = 7,
                  Text = "What is the formula for calculating the area of a triangle?",
                  QuizId = 1
                },
         new Question
         {
           Id = 8,
           Text = "If x = 5 and y = 3, what is the value of 2x + 3y?",
           QuizId = 1
         }
                , new Question
                {
                  Id = 9,
                  Text = "Which of the following is the quadratic formula?",
                  QuizId = 1
                }, new Question
                {
                  Id = 10,
                  Text = "What is the value of log₁₀100?",
                  QuizId = 1
                },

                new Question
                {
                  Id = 11,
                  Text = "What is the SI unit of force?",
                  QuizId = 3
                }, new Question
                {
                  Id = 12,
                  Text = "Which of the following is a vector quantity?",
                  QuizId = 3
                },
         new Question
         {
           Id = 13,
           Text = "What is the first law of thermodynamics also known as?",
           QuizId = 3
         }
                , new Question
                {
                  Id = 14,
                  Text = "What is the acceleration due to gravity on Earth approximately?",
                  QuizId = 3
                }, new Question
                {
                  Id = 15,
                  Text = "Which of the following types of waves requires a medium to propagate?",
                  QuizId = 3
                },


                new Question
                {
                  Id = 16,
                  Text = "What is the chemical symbol for water?",
                  QuizId = 4
                }, new Question
                {
                  Id = 17,
                  Text = "Which of the following is NOT a noble gas?",
                  QuizId = 4
                },
         new Question
         {
           Id = 18,
           Text = "Which element has the chemical symbol 'Fe'?",
           QuizId = 4
         }
                , new Question
                {
                  Id = 19,
                  Text = "What is the pH value of a neutral substance?",
                  QuizId = 4
                }, new Question
                {
                  Id = 20,
                  Text = "Which of the following is a non-metal element?",
                  QuizId = 4
                }




    );
  }

}