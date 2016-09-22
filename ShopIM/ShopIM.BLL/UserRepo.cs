
using ShopIM.DAL;
using ShopIM.Entity;


namespace ShopIM.BLL
{
    public class UserRepo
    {
        public bool ValidateUser(string name, string password)
        {

            UserContext userContext = new UserContext();
            if (userContext.ValidateUser(name, password))
            {
               
                //new LogContext().CreateLog(name + " logged in");

                return true;
            }
            return false;
        }


        public User GetUser(string name, string password)
        {
            UserContext userContext = new UserContext();
            return userContext.GetUser(name, password);
        }

        public bool UpdateUser(User user)
        {
           
            return new UserContext().UpdateUser(user);
        }

    }
}
