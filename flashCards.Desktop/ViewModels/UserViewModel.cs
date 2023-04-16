using flashCards.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
