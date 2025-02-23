using System.Threading.Tasks;

namespace ThieuDucDungMVC.Services
{
    public interface IAuthService
    {
        Task SignInUser(string email, string name, string role, string accountId);
    }
}
