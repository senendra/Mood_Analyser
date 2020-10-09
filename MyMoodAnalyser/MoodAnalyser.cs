using System;
using System.Collections.Generic;
using System.Text;
namespace MyMoodAnalyser
{
    class MoodAnalyser
    {
        private string message;
        public string analyseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        } 
    }
}
