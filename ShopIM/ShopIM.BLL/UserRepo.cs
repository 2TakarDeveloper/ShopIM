
using ShopIM.DAL;
using ShopIM.Entity;


namespace ShopIM.BLL
{
    public class UserRepo
    {
        public bool ValidateUser(string name, string password)
        {

            UserContext userContext = new UserContext();
            if (!userContext.ValidateUser(name, password)) return false;
            

            return true;
        }


        public User GetUser(string name, string password)
        {
            UserContext userContext = new UserContext();
            User user= userContext.GetUser(name, password);
            if (user!=null)
            {
                new LogRepo().CreateUserLog(name + " logged in");
               
            }
            return user;
        }

        public bool UpdateUser(User user)
        {
           
            return new UserContext().UpdateUser(user);
        }

    }
}
