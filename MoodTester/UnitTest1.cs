using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMoodAnalyser;
using System;

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
        [TestMethod]
        public void GivenClassNameShouldRetrunMoodAnalyserObject()
        {
            //Arrange
            MoodAnalyser mood = new MoodAnalyser();
            object expected = mood;
            //Act
            object check = MoodAnalyserFactory.CreateMoodAnalyser("MyMoodAnalyser.MoodAnalyser", "MoodAnalyser");
            //Assert
            expected.Equals(check);
        }
        [TestMethod]
        public void GivenImproperClassNameShouldRetrunNo_SUCH_CLASS()
        {
            try
            {
                object check = MoodAnalyserFactory.CreateMoodAnalyser("My.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }
    }
}
