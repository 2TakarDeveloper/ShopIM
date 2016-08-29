using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Entity
{
    public class Log
    {
        [Key]
        public int Sl { get; set; }
        public DateTime LogDate { get; set; }
        public string LogData { get; set; }

        public Log()
        {
            
        }

        public Log(string logData)
        {
            LogData = logData;
            LogDate = DateTime.Now;
        }

    }
}
