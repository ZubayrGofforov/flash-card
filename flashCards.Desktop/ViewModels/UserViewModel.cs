using flashCards.Desktop.Models;
using System;

namespace flashCards.Desktop.ViewModels
{
    public class UserViewModel
    {
        public string FullName { get; set; } = String.Empty;

        public string Username { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public DateTime BirthDate { get; set; }

        public static implicit operator User(UserViewModel userCreateViewModel)
        {
            return new User()
            {
                FullName = userCreateViewModel.FullName,
                Username = userCreateViewModel.Username,
                PasswordHash = userCreateViewModel.Password,
                BirthDate = userCreateViewModel.BirthDate
            };
        }
    }
}
