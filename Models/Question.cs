namespace Quiz.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Text { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
