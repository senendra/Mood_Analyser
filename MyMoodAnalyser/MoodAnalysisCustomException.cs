using System;
using System.Collections.Generic;
using System.Text;
namespace MyMoodAnalyser
{
    public class MoodAnalysisCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL,
            EMPTY,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        private readonly ExceptionType type;
        public MoodAnalysisCustomException(ExceptionType type , string message) : base(message)
        {
            this.type = type;
        }
    }
}
