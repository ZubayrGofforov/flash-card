using System;

namespace flashCards.Desktop.Models
{
    public class User
    {
        public long Id { get; set; }

        public string FullName { get; set; } = String.Empty;

        public string Username { get; set; } = String.Empty;

        public string PasswordHash { get; set; } = String.Empty;

        public string Salt { get; set; } = String.Empty;

        public DateTime BirthDate { get; set; }
    }
}
