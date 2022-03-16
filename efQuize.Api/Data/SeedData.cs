using efQuize.Api.Models;
using Microsoft.EntityFrameworkCore;
using efQuize.Api.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        var genreData = new List<Genre>(){new Genre()
                {
                    Subject = "GeneralKnowledge"
                },
                new Genre()
                {
                    Subject = "Science"
                },
                new Genre()
                {
                    Subject = "Logical"
                },
                new Genre()
                {
                    Subject = "Literature"
                }};

        using (var context = new ApiContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<ApiContext>>()))
        {
            if (context.Genre.Any())
            {
                return;
            }

            context.Genre.AddRange(genreData);

            context.SaveChanges();


            var genreList = context.Genre.ToList();
            if (context.Questions.Any())
            {
                return;
            }

            context.Questions.AddRange(
                new Questions()
                {
                    questionText = "Who is the head of WHO?",
                    GenreId = genreList[0].Id
                }, new Questions()
                {
                    questionText = "The iPhone was created by which company?",
                    GenreId = genreList[0].Id
                }, new Questions()
                {
                    questionText = "What is the capital of India?",
                    GenreId = genreList[0].Id
                }, new Questions()
                {
                    questionText = "What is the capital of Sweden?",
                    GenreId = genreList[0].Id
                }, new Questions()
                {
                    questionText = "How many Harry Potter books are there?",
                    GenreId = genreList[0].Id
                },new Questions()
                {
                    questionText = "All animals need food, air, and ____ to survive.",
                    GenreId = genreList[1].Id
                }, new Questions()
                {
                    questionText = "What is Earth’s only natural satellite?",
                    GenreId = genreList[1].Id
                }, new Questions()
                {
                    questionText = "What is Earth’s only natural satellite?",
                    GenreId = genreList[1].Id
                }, new Questions()
                {
                    questionText = "Who invented the first functional telephone?",
                    GenreId = genreList[1].Id
                }, new Questions()
                {
                    questionText = "What is the young one of a cow called?",
                    GenreId = genreList[1].Id
                }
            );
            context.SaveChanges();
            
            var questionList = context.Questions.ToList();
            if (context.Answers.Any())
            {
                return;
            }

            context.Answers.AddRange(
                new Answers()
                {
                    AnswerText = "Jeff Bezos",
                    IsCorrect = false,
                    QuestionsId = questionList[0].Id
                }, new Answers()
                {
                    AnswerText = "Tedros Adhanom",
                    IsCorrect = true,
                    QuestionsId = questionList[0].Id
                }, new Answers()
                {
                    AnswerText = "Bill Gates",
                    IsCorrect = false,
                    QuestionsId = questionList[0].Id
                }, new Answers()
                {
                    AnswerText = "Tony Stark",
                    IsCorrect = false,
                    QuestionsId = questionList[0].Id
                },new Answers()
                {
                    AnswerText = "Apple",
                    IsCorrect = true,
                    QuestionsId = questionList[1].Id
                }, new Answers()
                {
                    AnswerText = "Intel",
                    IsCorrect = false,
                    QuestionsId = questionList[1].Id
                }, new Answers()
                {
                    AnswerText = "Microsoft",
                    IsCorrect = false,
                    QuestionsId = questionList[1].Id
                }, new Answers()
                {
                    AnswerText = "Amazon",
                    IsCorrect = true,
                    QuestionsId = questionList[1].Id
                },new Answers()
                {
                    AnswerText = "Mumbai",
                    IsCorrect = false,
                    QuestionsId = questionList[2].Id
                }, new Answers()
                {
                    AnswerText = "Keral",
                    IsCorrect = false,
                    QuestionsId = questionList[2].Id
                }, new Answers()
                {
                    AnswerText = "Punjab",
                    IsCorrect = false,
                    QuestionsId = questionList[2].Id
                }, new Answers()
                {
                    AnswerText = "Delhi",
                    IsCorrect = true,
                    QuestionsId = questionList[2].Id
                },new Answers()
                {
                    AnswerText = "London",
                    IsCorrect = false,
                    QuestionsId = questionList[3].Id
                }, new Answers()
                {
                    AnswerText = "Stockholm",
                    IsCorrect = true,
                    QuestionsId = questionList[3].Id
                }, new Answers()
                {
                    AnswerText = "molmo",
                    IsCorrect = false,
                    QuestionsId = questionList[3].Id
                }, new Answers()
                {
                    AnswerText = "oslo",
                    IsCorrect = false,
                    QuestionsId = questionList[3].Id
                },new Answers()
                {
                    AnswerText = "5",
                    IsCorrect = false,
                    QuestionsId = questionList[4].Id
                }, new Answers()
                {
                    AnswerText = "7",
                    IsCorrect = true,
                    QuestionsId = questionList[4].Id
                }, new Answers()
                {
                    AnswerText = "8",
                    IsCorrect = false,
                    QuestionsId = questionList[4].Id
                }, new Answers()
                {
                    AnswerText = "2",
                    IsCorrect = false,
                    QuestionsId = questionList[4].Id
                },new Answers()
                {
                    AnswerText = "House",
                    IsCorrect = false,
                    QuestionsId = questionList[5].Id
                }, new Answers()
                {
                    AnswerText = "Water",
                    IsCorrect = true,
                    QuestionsId = questionList[5].Id
                }, new Answers()
                {
                    AnswerText = "Chocklate",
                    IsCorrect = false,
                    QuestionsId = questionList[5].Id
                }, new Answers()
                {
                    AnswerText = "Fruit",
                    IsCorrect = false,
                    QuestionsId = questionList[5].Id
                },new Answers()
                {
                    AnswerText = "Sun",
                    IsCorrect = true,
                    QuestionsId = questionList[6].Id
                }, new Answers()
                {
                    AnswerText = "Moon",
                    IsCorrect = false,
                    QuestionsId = questionList[6].Id
                }, new Answers()
                {
                    AnswerText = "Venus",
                    IsCorrect = false,
                    QuestionsId = questionList[6].Id
                }, new Answers()
                {
                    AnswerText = "Mars",
                    IsCorrect = false,
                    QuestionsId = questionList[6].Id
                },new Answers()
                {
                    AnswerText = "Alexander Graham Bell",
                    IsCorrect = false,
                    QuestionsId = questionList[7].Id
                }, new Answers()
                {
                    AnswerText = "Thomas Alva Edison",
                    IsCorrect = false,
                    QuestionsId = questionList[7].Id
                }, new Answers()
                {
                    AnswerText = "Nikola Tesla",
                    IsCorrect = false,
                    QuestionsId = questionList[7].Id
                }, new Answers()
                {
                    AnswerText = "Albert Einstein",
                    IsCorrect = true,
                    QuestionsId = questionList[7].Id
                },new Answers()
                {
                    AnswerText = "Puppy",
                    IsCorrect = false,
                    QuestionsId = questionList[8].Id
                }, new Answers()
                {
                    AnswerText = "Calf",
                    IsCorrect = true,
                    QuestionsId = questionList[8].Id
                }, new Answers()
                {
                    AnswerText = "Kitten",
                    IsCorrect = false,
                    QuestionsId = questionList[8].Id
                }, new Answers()
                {
                    AnswerText = "Baby",
                    IsCorrect = false,
                    QuestionsId = questionList[8].Id
                },new Answers()
                {
                    AnswerText = "Nikola Tesla",
                    IsCorrect = false,
                    QuestionsId = questionList[9].Id
                }, new Answers()
                {
                    AnswerText = "Albert Einstein",
                    IsCorrect = true,
                    QuestionsId = questionList[9].Id
                }, new Answers()
                {
                    AnswerText = "Thomas Alva Edison",
                    IsCorrect = false,
                    QuestionsId = questionList[9].Id
                }, new Answers()
                {
                    AnswerText = "Alexander Graham Bell",
                    IsCorrect = false,
                    QuestionsId = questionList[9].Id
                }
            );
            context.SaveChanges();
        }
    }
}
