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
     
        public static void ReadString(string speech)
        {
            if (!SystemSettings.IsSpeechOn) return;
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SpeakAsync(speech);
        }
      
      
      

    }
}

