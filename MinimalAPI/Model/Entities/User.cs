namespace MinimalAPI.Model.Entities
{
    public class User
    {
        public long Id { get; private set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public User() { }

        public User(long id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public override sealed string ToString()
        {
            return $"{Id}, {Name}, {Email}";
        }
    }
}
