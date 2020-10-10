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
            string message = null;
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
