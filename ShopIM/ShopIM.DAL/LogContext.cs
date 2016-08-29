
using System.Collections.Generic;
using System.Linq;

using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class LogContext
    {

        public List<Log> GetLogs()
        {
            using (var context = new DatabaseContext())
            {
 
                return (from log in context.Logs select log).ToList();
            }
        }

        public void clearLog()
        {
            using (var context= new DatabaseContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [dbo].[Logs]");

            }
        }


    }
}
