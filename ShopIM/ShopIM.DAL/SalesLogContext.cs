using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.Entity;

namespace ShopIM.DAL
{
    public class SalesLogContext
    {
        public void AddSalesLog(SalesLog salesLog)
        {
            using (var context=new DatabaseContext())
            {
                
                    context.SalesLogs.Add(salesLog);
                    context.SaveChanges();
                
            }
        }


        public List<SalesLog> GetSalesLog()
        {
            using (var context=new DatabaseContext())
            {
                return (from SalesLog in context.SalesLogs select SalesLog).ToList();
            }
        }

        public void ClearLog()
        {
            using (var context = new DatabaseContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [dbo].[SalesLogs]");

            }
        }

    }
}
