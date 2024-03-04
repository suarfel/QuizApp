using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApp.Models.Domain;

namespace QuizApp.Areas.Identity.Data;



public class ChoiceConfiguration : IEntityTypeConfiguration<Choice>
{
    public void Configure(EntityTypeBuilder<Choice> builder)
    {
        builder.HasData(
// Question 1 - Biology
new Choice
{
    Id = 1,
    Text = "A) Mitochondria",
    IsCorrect = true,
    QuestionId = 1
},
new Choice
{
    Id = 2,
    Text = "B) Ribosome",
    IsCorrect = false,
    QuestionId = 1
},
new Choice
{
    Id = 3,
    Text = "C) Golgi Apparatus",
    IsCorrect = false,
    QuestionId = 1
},
new Choice
{
    Id = 4,
    Text = "D) Endoplasmic Reticulum",
    IsCorrect = false,
    QuestionId = 1
},

// Question 2 - Mathematics
new Choice
{
    Id = 5,
    Text = "A) Addition",
    IsCorrect = false,
    QuestionId = 2
},
new Choice
{
    Id = 6,
    Text = "B) Subtraction",
    IsCorrect = false,
    QuestionId = 2
},
new Choice
{
    Id = 7,
    Text = "C) Multiplication",
    IsCorrect = false,
    QuestionId = 2
},
new Choice
{
    Id = 8,
    Text = "D) Division",
    IsCorrect = true,
    QuestionId = 2
},

// Question 3 - Biology
new Choice
{
    Id = 9,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 3
},
new Choice
{
    Id = 10,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 3
},
new Choice
{
    Id = 11,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 3
},
new Choice
{
    Id = 12,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 3
},

// Add more questions and choices following the same pattern...
// Question 1 - Biology
new Choice
{
    Id = 13,
    Text = "A) Mitochondria",
    IsCorrect = true,
    QuestionId = 4
},
new Choice
{
    Id = 14,
    Text = "B) Ribosome",
    IsCorrect = false,
    QuestionId = 4
},
new Choice
{
    Id = 15,
    Text = "C) Golgi Apparatus",
    IsCorrect = false,
    QuestionId = 4
},
new Choice
{
    Id = 16,
    Text = "D) Endoplasmic Reticulum",
    IsCorrect = false,
    QuestionId = 4
},

// Question 2 - Mathematics
new Choice
{
    Id = 17,
    Text = "A) Addition",
    IsCorrect = false,
    QuestionId = 5
},
new Choice
{
    Id = 18,
    Text = "B) Subtraction",
    IsCorrect = false,
    QuestionId = 5
},
new Choice
{
    Id = 19,
    Text = "C) Multiplication",
    IsCorrect = false,
    QuestionId = 5
},
new Choice
{
    Id = 20,
    Text = "D) Division",
    IsCorrect = true,
    QuestionId = 5
},

// Question 3 - Biology
new Choice
{
    Id = 21,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 6
},
new Choice
{
    Id = 22,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 6
},
new Choice
{
    Id = 23,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 6
},
new Choice
{
    Id = 24,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 6
},

// Add more questions and choices following the same pattern...
// Question 1 - Biology
new Choice
{
    Id = 25,
    Text = "A) Mitochondria",
    IsCorrect = true,
    QuestionId = 7
},
new Choice
{
    Id = 26,
    Text = "B) Ribosome",
    IsCorrect = false,
    QuestionId = 7
},
new Choice
{
    Id = 27,
    Text = "C) Golgi Apparatus",
    IsCorrect = false,
    QuestionId = 7
},
new Choice
{
    Id = 28,
    Text = "D) Endoplasmic Reticulum",
    IsCorrect = false,
    QuestionId = 7
},

// Question 2 - Mathematics
new Choice
{
    Id = 29,
    Text = "A) Addition",
    IsCorrect = false,
    QuestionId = 8
},
new Choice
{
    Id = 30,
    Text = "B) Subtraction",
    IsCorrect = false,
    QuestionId = 8
},
new Choice
{
    Id = 31,
    Text = "C) Multiplication",
    IsCorrect = false,
    QuestionId = 8
},
new Choice
{
    Id = 32,
    Text = "D) Division",
    IsCorrect = true,
    QuestionId = 8
},

// Question 3 - Biology
new Choice
{
    Id = 33,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 9
},
new Choice
{
    Id = 34,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 9
},
new Choice
{
    Id = 35,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 9
},
new Choice
{
    Id = 36,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 9
},

// Add more questions and choices following the same pattern...
// Question 1 - Biology
new Choice
{
    Id = 37,
    Text = "A) Mitochondria",
    IsCorrect = true,
    QuestionId = 10
},
new Choice
{
    Id = 38,
    Text = "B) Ribosome",
    IsCorrect = false,
    QuestionId = 10
},
new Choice
{
    Id = 39,
    Text = "C) Golgi Apparatus",
    IsCorrect = false,
    QuestionId = 10
},
new Choice
{
    Id = 40,
    Text = "D) Endoplasmic Reticulum",
    IsCorrect = false,
    QuestionId = 10
},

// Question 2 - Mathematics
new Choice
{
    Id = 41,
    Text = "A) Addition",
    IsCorrect = false,
    QuestionId = 11
},
new Choice
{
    Id = 42,
    Text = "B) Subtraction",
    IsCorrect = false,
    QuestionId = 11
},
new Choice
{
    Id = 43,
    Text = "C) Multiplication",
    IsCorrect = false,
    QuestionId = 11
},
new Choice
{
Id = 44,
    Text = "D) Division",
    IsCorrect = true,
    QuestionId = 11
},

// Question 3 - Biology
new Choice
{
    Id = 45,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 12
},
new Choice
{
    Id = 46,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 12
},
new Choice
{
    Id = 47,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 12
},
new Choice
{
    Id = 48,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 12
},


// Add more questions and choices following the same pattern...


// Question 3 - Biology
new Choice
{
    Id = 49,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 13
},
new Choice
{
    Id = 50,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 13
},
new Choice
{Id = 51,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 13
},
new Choice
{
    Id = 52,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 13
}
,

// Question 3 - Biology
new Choice
{
    Id = 53,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 14
},
new Choice
{
    Id = 54,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 14
},
new Choice
{
    Id = 55,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 14
},
new Choice
{
    Id = 56,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 14
},



// Question 3 - Biology
new Choice
{
    Id = 57,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 15
},
new Choice
{
    Id = 58,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 15
},
new Choice
{
    Id = 59,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 15
},
new Choice
{
    Id = 60,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 15
},


// Question 3 - Biology
new Choice
{
    Id = 61,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 16
},
new Choice
{
    Id = 62,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 16
},
new Choice
{
    Id = 63,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 16
},
new Choice
{
    Id = 64,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 16
}
,


// Question 3 - Biology
new Choice
{
    Id = 65,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 17
},
new Choice
{
    Id = 66,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 17
},
new Choice
{
    Id = 67,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 17
},
new Choice
{
    Id = 68,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 17
},

// Question 3 - Biology
new Choice
{
    Id = 69,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 18
},
new Choice
{
    Id = 70,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 18
},
new Choice
{
    Id = 71,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 18
},
new Choice
{
    Id = 72,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 18
},


// Question 3 - Biology
new Choice
{
    Id = 73,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 19
},
new Choice
{
    Id = 74,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 19
},
new Choice
{
    Id = 75,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 19
},
new Choice
{
    Id = 76,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 19
},

// Question 3 - Biology
new Choice
{
    Id = 77,
    Text = "A) Photosynthesis",
    IsCorrect = true,
    QuestionId = 20
},
new Choice
{
    Id = 78,
    Text = "B) Respiration",
    IsCorrect = false,
    QuestionId = 20
},
new Choice
{
    Id = 79,
    Text = "C) Fermentation",
    IsCorrect = false,
    QuestionId = 20
},
new Choice
{
    Id = 80,
    Text = "D) Transpiration",
    IsCorrect = false,
    QuestionId = 20
}
        );
    }

}