
using ShopIM.DAL;


namespace ShopIM.BLL
{
    public class UserRepo
    {
        public bool ValidateUser(string name, string password, out string type)
        {

            UserContext userContext = new UserContext();
            if (userContext.ValidateUser(name, password, out type))
            {
               
                //new LogContext().CreateLog(name + " logged in");

                return true;
            }
            return false;
        }
    }
}
