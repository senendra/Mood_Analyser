using System;
using System.Collections.Generic;
using System.Text;
namespace MyMoodAnalyser
{
    public class MoodAnalyser
    {
        public string analyseMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        } 
    }
}
