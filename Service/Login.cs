using MVCCoreDemo.Data;
using MVCCoreDemo.Models;

namespace MVCCoreDemo.Service
{
    public class Login
    {

        ApplicationDbContext dbContext;

        public Login(ApplicationDbContext context)
        {
            dbContext = context;
        }


        public bool validateUser(string username, string password)
        {
            User userLoginIn = dbContext.Users.Where(u => u.Email == username && u.Password == password).SingleOrDefault();

            if(userLoginIn != null)
            {

                LoggedInUser.LoggedIn = true;
                LoggedInUser.Name=userLoginIn.Name;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
