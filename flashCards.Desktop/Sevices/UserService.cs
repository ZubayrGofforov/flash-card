using flashCards.Desktop.Common;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Interfaces.Services;
using flashCards.Desktop.Models;
using flashCards.Desktop.Repositories;
using flashCards.Desktop.Securities;
using flashCards.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Sevices
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService()
        {
            this._userRepository = new UserRepository();
        }
        public async Task<(bool IsSuccessful, string Message)> Loginasync(string username, string password)
        {
            var user = await _userRepository.FindByUsername(username);
            if (user is null) return (IsSuccessful: false, Message: "Username is wrong!");

            var hashResult = PasswordHasher.Verify(password, user.Salt, user.PasswordHash);
            if (hashResult)
            {
                IdentitySingelton.BuildInstance(user.Id);
                return (IsSuccessful: true, Message: "");
            }
            else return (IsSuccessful: false, Message: "Password is wrong!");
        }

        public async Task<(bool IsSuccessful, string Message)> RegisterAsync(UserViewModel viewModel)
        {
            var hashResult = PasswordHasher.Hash(viewModel.Password);
            User user = new User()
            {
                Username = viewModel.Username,
                FullName = viewModel.FullName,
                PasswordHash = hashResult.PasswordHash,
                Salt = hashResult.Salt,
                BirthDate = viewModel.BirthDate
            };

            var result = await _userRepository.CreateAsync(user);
            if (result) return (IsSuccessful: true, Message: "");
            else return (IsSuccessful: false, Message: "User can not created!");
        }
    }
}
