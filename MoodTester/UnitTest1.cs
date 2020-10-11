using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMoodAnalyser;
namespace MoodTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string message = "I am in any mood";
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser();
            //Act
            string result = mood.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
