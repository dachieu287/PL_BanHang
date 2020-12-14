using DTO;
using DAO;

namespace BUS
{
    public class AccountBUS
    {
        private readonly AccountDAO dao = null;
        
        public AccountBUS()
        {
            dao = new AccountDAO();
        }
        public LoginStatus Login(string username, string password)
        {
            Account account = dao.GetAccount(username);
            if (account == null)
            {
                return LoginStatus.WRONG_USERNAME;
            }
            else if (account.Password != password)
            {
                return LoginStatus.WRONG_PASSWORD;
            }
            else if (account.Active == false)
            {
                return LoginStatus.LOCKED;
            }
            else if (!account.Role.Equals("admin"))
            {
                return LoginStatus.NO_PERMISSION;
            }
            else
            {
                Session.Account = account;
                return LoginStatus.SUCCESS;
            }
        }
    }

    public enum LoginStatus
    {
        SUCCESS,
        WRONG_USERNAME,
        WRONG_PASSWORD,
        LOCKED,
        NO_PERMISSION
    }
}
