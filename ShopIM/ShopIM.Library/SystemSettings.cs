using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Library
{
    public static class SystemSettings
    {
       
        public static bool IsSystemLocked { get; set; }
        public  static bool IsNotificationsOn { get; set; }
        public static bool IsSpeechOn { get; set; }


        public static void LoadSettings()
        {
            using (var reader = new StreamReader("settings.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var sarr = line.Split(',');

                    if (sarr[0]=="1")
                    {
                        IsNotificationsOn = true;
                    }
                    if (sarr[1] == "1")
                    {
                        IsSpeechOn = true;
                    }
                }
            }
        }

        public static void SaveSettings()
        {
            var notificationStat = IsNotificationsOn ? "1" : "0";
            var speechStat = IsSpeechOn ? "1" : "0";
            string text = notificationStat + "," + speechStat;

            using (StreamWriter writer = new StreamWriter("settings.txt"))
            {
               
                writer.WriteLine(text);
            }
        }

    }
}
