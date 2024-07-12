namespace SHA.ApplicationService.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }

        public Guid ID { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
        public string? Statement { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public Guid ID { get; set; }
        public Guid QuestionID { get; set; }
        public string? Value { get; set; }
        public bool Correct { get; set; }
    }

    public enum QuestionCategory
    {
        Science = 0,
        History = 1,
        Mathematics = 2,
        Geography = 3,
        Physics = 4,
        Philosophy = 5
    }
}
