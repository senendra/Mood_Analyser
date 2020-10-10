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
            string message = "I am in Sad Mood";
            string expected = "SAD";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
