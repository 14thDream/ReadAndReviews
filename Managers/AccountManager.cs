using Managers.Services;
using Models;

namespace Managers
{
    public class AccountManager : IAccountService
    {
        private readonly Dictionary<string, Account> _accounts;

        public AccountManager()
        {
            _accounts = [];
        }

        public Account? AddAccount(Account account)
        {
            if (_accounts.ContainsKey(account.Email)) return null;

            _accounts.Add(account.Email, account);
            return account;
        }

        public bool DeleteAccount(string email)
        {
            return _accounts.Remove(email);
        }

        public Account? GetAccount(string email)
        {
            return _accounts.GetValueOrDefault(email);
        }
    }
}
