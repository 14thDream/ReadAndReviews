using Managers.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ReadAndReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{email}")]
        public ActionResult<Account> GetAccount(string email)
        {
            return _accountService.GetAccount(email) switch
            {
                null => NotFound(),
                var account => Ok(account)
            };
        }

        [HttpPut]
        public ActionResult AddAccount(Account account)
        {
            return _accountService.AddAccount(account) switch
            {
                null => NotFound(),
                _ => CreatedAtAction(nameof(GetAccount), new { email = account.Email }, account)
            };
        }

        [HttpDelete("{email}")]
        public ActionResult DeleteAccount(string email)
        {
            return (_accountService.DeleteAccount(email)) ? NoContent() : NotFound();
        }
    }
}
