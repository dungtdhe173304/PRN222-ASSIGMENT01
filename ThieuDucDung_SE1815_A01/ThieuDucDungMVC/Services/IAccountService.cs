using ThieuDucDungMVC.Models;

namespace ThieuDucDungMVC.Services
{
    public interface IAccountService
    {
        SystemAccount Authenticate(string email, string password);
    }
}
