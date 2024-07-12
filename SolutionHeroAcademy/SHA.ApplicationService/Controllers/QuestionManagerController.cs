using Microsoft.AspNetCore.Mvc;
using SHA.ApplicationService.Models;

namespace SHA.ApplicationService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class QuestionManagerController : ControllerBase
    {
        [HttpGet(Name = "GetQuestionListAsync")]
        public async Task<ActionResult<List<Question>>> GetQuestionListAsync()
        {
            var questions = await GetStoredQuestionListAsync();

            return Ok(new
            {
                Ok = true,
                Message = "Successfully retrieved the list of questions.",
                Result = questions
            });
        }

        [HttpGet(Name = "GetRandomQuestionAsync")]
        public async Task<ActionResult> GetRandomQuestionAsync()
        {
            var questions = await GetStoredQuestionListAsync();

            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);

            var randomQuestion = questions[randomIndex];

            return Ok(new
            {
                Ok = true,
                Message = "Question retrieved successfully.",
                Result = randomQuestion
            });
        }

        public ActionResult GetTest()
        {
            return new JsonResult(new {Name = "Joao Mantovani"});
        }

        public async Task<List<Question>> GetStoredQuestionListAsync()
        {
            await Task.Yield(); //TODO: Review.

            var questions = new List<Question>
            {
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.Science,
                    Statement = "What science studies the Earth's atmosphere and climatology?",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Astronomy.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Meteorology.",
                            Correct = true
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Atmospheric dispersion.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Horology",
                            Correct = false
                        }
                    }
                },
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.History,
                    Statement = "What does the expression “Achilles heel” mean?",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Part where people concentrate their strength.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Someone's Invulnerable point.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Someone's most vulnerable point.",
                            Correct = true
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "The most predominant characteristic of people",
                            Correct = false
                        }
                    }
                },
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.Mathematics,
                    Statement = "How many elements does the set of natural numbers have?",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Two elements.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Thousand elements.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Hundred elements",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Infinite elements.",
                            Correct = true
                        }
                    }
                },
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.Geography,
                    Statement = "What is the largest country in the world by area (km²)?",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Russia.",
                            Correct = true
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Canada.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Brazil.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "United States of America.",
                            Correct = false
                        }
                    }
                },
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.Physics,
                    Statement = "What is Newton's third law?",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Inertia.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Fundamental principle of dynamics.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Universal gravitation.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Action and reaction",
                            Correct = true
                        }
                    }
                },
                new Question
                {
                    ID = Guid.NewGuid(),
                    QuestionCategory = QuestionCategory.Philosophy,
                    Statement = "Which of the following philosophers asserts that human societies progress through class struggle? A conflict between the bourgeoisie who controls the reduction and the proletariat who is the hand of the hand.",
                    Answers =
                    {
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Karl Marx",
                            Correct = true
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Edgar Morin",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "James Mill.",
                            Correct = false
                        },
                        new Answer
                        {
                            ID = Guid.NewGuid(),
                            Value = "Peter Unger",
                            Correct = false
                        }
                    }
                },
            };

            return await OrganizingQuestionList(questions);
        }

        public async Task<List<Question>> OrganizingQuestionList(List<Question> questions)
        {
            await Task.Yield(); //TODO: Review.

            foreach (var question in questions)
            {
                var questionID = question.ID;

                foreach (var answer in question.Answers)
                {
                    answer.QuestionID = questionID;
                }
            }

            return questions.OrderBy(q => q.QuestionCategory).ToList();
        }

    }
}