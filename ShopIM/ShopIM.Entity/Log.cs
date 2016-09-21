using System;
using System.ComponentModel.DataAnnotations;

namespace ShopIM.Entity
{
    public class Log
    {
        public Log()
        {
        }

        public Log(string logData)
        {
            LogData = logData;
            LogDate = DateTime.Now;
        }

        [Key]
        public int Sl { get; set; }

        public DateTime LogDate { get; set; }
        public string LogData { get; set; }
    }
}