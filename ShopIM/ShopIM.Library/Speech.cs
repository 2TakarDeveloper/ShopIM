using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Library
{
    public static class Speech
    {
     

        public static void WelcomeUser(String userName, String type)
        {
            if (SystemSettings.IsSpeechOn)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SpeakAsync("Welcome " + type + " " + userName);
            }
            
        }
        public static void NewNotification(String number)
        {
            if (SystemSettings.IsSpeechOn)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SpeakAsync("Sir, you got " + number + " New Notification");
            }
            
        }
        public static void NotificationUnchecked(String number)
        {
            if (SystemSettings.IsSpeechOn)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SpeakAsync("Sir, you have " + number + " Notification left unchecked");
            }
          
        }
        public static void ReadNotification()
        {
            if (SystemSettings.IsSpeechOn)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                int count = 1;
                synth.SpeakAsync("Sir, There are " + NotificationManager.Notifications.Count + " Notification. And they are ");
                foreach (var notification in NotificationManager.Notifications)
                {
                    synth.SpeakAsync("Number " + count + ",  " + notification.message);
                    count++;

                }
            }
            
        }

    }
}

