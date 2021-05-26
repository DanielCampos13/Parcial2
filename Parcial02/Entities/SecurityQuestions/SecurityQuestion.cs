namespace Parcial02.Entities.SecurityQuestions
{
    public class SecurityQuestion
    {
        public int Id { get; set; }

        public string Question { get; set; }


        public SecurityQuestion()
        {
            
        }

        public SecurityQuestion(int id, string question)
        {
            Id = id;
            Question = question;
        }
    }
}