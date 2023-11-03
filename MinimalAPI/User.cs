namespace MinimalAPI
{
    public class User : IComparable<User>
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

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is User))
            {
                return false;
            }
            else
            {
                User user = (User)obj;
                return Id.Equals(user.Id);
            }
        }

        public int CompareTo(User? other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
