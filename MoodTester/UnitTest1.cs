using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMoodAnalyser;
namespace MoodTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNullMoo0d()
        {
            try
            {
                string message = null;
                MoodAnalyser mood = new MoodAnalyser(message);
                string result = mood.AnalyseMood();
            }
            catch(MoodAnalysisCustomException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser mood = new MoodAnalyser(message);
                string result = mood.AnalyseMood();
            }
            catch (MoodAnalysisCustomException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }
        }
    }
}
