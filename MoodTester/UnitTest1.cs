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
            string message = "I am in Any Mood";
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser();
            //Act
            string result = mood.analyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
