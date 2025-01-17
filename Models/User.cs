namespace QBank.Models 
{
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public DateTime birthDate { get; set; }
        public string phone { get; set; } = string.Empty;

        public User() { }

        public User(int userId, string name, string cpf, string email)
        {
            this.userId = userId;
            this.name = name;
            this.CPF = cpf;
            this.email = email;
        }
    }
}