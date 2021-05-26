namespace Parcial02.Entities.Users
{
    public class User
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public User()
        {
            
        }

        public User(string fullName, string password, string securityQuestion, string securityAnswer)
        {
            FullName = fullName;
            Password = password;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
        }
    }
}