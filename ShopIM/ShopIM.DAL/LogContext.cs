
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class LogContext
    {

        public void CreateLog(string logmsg)
        {
            using (var context = new DatabaseContext())
            {

                var log = new Log(logmsg);
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }


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
