using Models;

namespace Managers.Services
{
    public interface IAccountService
    {
        Account? AddAccount(Account account);
        bool DeleteAccount(string email);
        Account? GetAccount(string email);

    }
}
