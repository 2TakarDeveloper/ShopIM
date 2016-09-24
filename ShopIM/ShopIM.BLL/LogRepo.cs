using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopIM.DAL;
using ShopIM.Entity;

namespace ShopIM.BLL
{
    public class LogRepo
    {
        public void CreateUserLog(string logmsg)
        {
            new LogContext().CreateLog(logmsg);
        }

        public List<Log> GetUserLog()
        {
            return  new LogContext().GetLogs();
        }

        public void ClearUserLog()
        {
            new LogContext().clearLog();
        }

        public List<SalesLog> GetSalesLog()
        {
            return new SalesLogContext().GetSalesLog();
        }


        public void ClearSalesLog()
        {
            new SalesLogContext().ClearLog();
        }

    }
}
