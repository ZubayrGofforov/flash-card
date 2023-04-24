using flashCards.Desktop.ViewModels;
using System.Threading.Tasks;

namespace flashCards.Desktop.Interfaces.Services
{
    public interface IUserService
    {
        Task<(bool IsSuccessful, string Message)> Loginasync(string username, string password);

        Task<(bool IsSuccessful, string Message)> RegisterAsync(UserViewModel viewModel);
    }
}
