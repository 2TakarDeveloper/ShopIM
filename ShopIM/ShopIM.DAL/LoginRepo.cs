using ShopIM.Entity;
using ShopIM.FrameWork;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ShopIM.DAL
{
    public class LoginRepo
    {

        List<User> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> list = new List<User>();
            using (reader)
            {
                while (reader.Read())
                {
                    User obj = new User
                    {
                        UserName = reader.GetString(1),
                        UserPassword = reader.GetString(2)
                    };

                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }

        public bool ValidUser(User user)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from User");
            List<User> User = GetData(cmd);
            if (User != null)
            {
                return true;
            }
            return false;
        }

    }
}
