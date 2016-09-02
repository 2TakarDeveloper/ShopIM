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
        public void AddSalesLog(List<SalesLog> salesLogs)
        {
            using (var context=new DatabaseContext())
            {
                foreach (var salesLog in salesLogs)
                {
                    context.SalesLogs.Add(salesLog);
                    context.SaveChanges();
                }
            }
        }


        public List<SalesLog> GetSalesLog()
        {
            using (var context=new DatabaseContext())
            {
                return (from SalesLog in context.SalesLogs select SalesLog).ToList();
            }
        }

        public void clearLog()
        {
            using (var context = new DatabaseContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [dbo].[SalesLogs]");

            }
        }

    }
}
