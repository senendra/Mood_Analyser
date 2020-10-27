using System;
using System.Collections.Generic;
using System.Text;
namespace MyMoodAnalyser
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
       
        public string AnalyseMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL, "Mood shound not be null");
            }
        } 
    }
}
