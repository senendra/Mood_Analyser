using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMoodAnalyser;
namespace MoodTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNull()
        {
            try
            {
                string message = null;
                MoodAnalyser mood = new MoodAnalyser(message);
                string result = mood.AnalyseMood();
            }
            catch(MoodAnalysisCustomException exception)
            {
                Assert.AreEqual("Mood should Not be null", exception.Message);
            }
        }
    }
}
