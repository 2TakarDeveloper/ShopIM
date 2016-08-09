using System;

using System.Data.SqlClient;


namespace ShopIM.FrameWork
{
    public class SqlDbDataAccess
    {
        const string ConnectiosnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\Programming\IDE\VisualStudio15\Project\Database\Database1.mdf;Integrated Security=True;Connect Timeout=30";

         public SqlCommand GetCommand(String query)
                {
                    var connection = new SqlConnection(ConnectiosnString);
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = connection;
                    return cmd;
                }
            }

}
