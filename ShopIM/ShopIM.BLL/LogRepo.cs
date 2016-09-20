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
        public void CreateLog(string logmsg)
        {
            new LogContext().CreateLog(logmsg);
        }

        public List<Log> GetLogs()
        {
            return  new LogContext().GetLogs();
        }

        public void ClearLog()
        {
            new LogContext().clearLog();
        }


    }
}
