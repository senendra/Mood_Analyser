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
            object check = MoodAnalyserRefection.CreateMoodAnalyser("MyMoodAnalyser.MoodAnalyser", "MoodAnalyser");
            //Assert
            expected.Equals(check);
        }
        [TestMethod]
        public void GivenImproperClassNameShouldRetrunNo_SUCH_CLASS()
        {
            try
            {
                object check = MoodAnalyserRefection.CreateMoodAnalyser("My.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }
        [TestMethod]
        public void GivenImproperConstructorNameShouldRetrunNo_SUCH_METHOD()
        {
            try
            {
                object check = MoodAnalyserRefection.CreateMoodAnalyser("MyMoodAnalyser.MoodAnalyser", "Mood");
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyserClassNameShouldReturnMoodAnalyserObjectUsingParametrizedConstructor()
        { 
            //Arrange
            MoodAnalyser expected = new MoodAnalyser("HAPPY");
            //Act
            object check = MoodAnalyserRefection.CreateMoodAnalyseUsingParameterizedConstructor("MyMoodAnalyser.MoodAnalyser", "MoodAnalyser","HAPPY");
            //Assert
            expected.Equals(check);
        }
        [TestMethod]
        public void GivenImproperClassNameShouldReturnNO_SUCH_CLASS()
        {
            try
            {
                object check = MoodAnalyserRefection.CreateMoodAnalyseUsingParameterizedConstructor("My.MoodAnalyser", "MoodAnalyser", "HAPPY");
            }
            catch(MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }
        }
        [TestMethod]
        public void GivenImproperClassNameShouldReturnNO_SUCH_METHOD()
        {
            try
            {
                object check = MoodAnalyserRefection.CreateMoodAnalyseUsingParameterizedConstructor("MyMoodAnalyser.MoodAnalyser", "Mood", "HAPPY");
            }
            catch (MoodAnalysisCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }
        [TestMethod]
        public void GivenHappyMessageUsingReflectionWhenProperShouldReturnHappy()
        {
            //Arrange
            //Act
            string check = MoodAnalyserRefection.InvokeAnalyseMood("HAPPY", "AnalyseMood");
            //Assert
            Assert.AreEqual("HAPPY", check);
        }
        [TestMethod]
        public void GivenImproperMethodNameShouldThrowMoodAnalysisCustomExceptionIndicatingNo_Such_Method()
        {
            try
            {
                //Act
                string actual = MoodAnalyserRefection.InvokeAnalyseMood("HAPPY", "WrongMethodName");
            }
            catch (MoodAnalysisCustomException e)
            {
                //Assert
                Assert.AreEqual("no such method.", e.Message);
            }
        }
        [TestMethod]
        public void GivenHappyMessageWithReflectionShouldReturnHappy()
        {
            //Act
            string actual = MoodAnalyserRefection.SetField("HAPPY", "message");
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }
        [TestMethod]
        public void GivenImproperFieldNameShouldThrowMoodAnalysisCUstomExceptionIndicatingNoSuchField()
        {
            try
            {
                //Act
                string actual = MoodAnalyserRefection.SetField("HAPPY", "wrongName");
            }
            catch (MoodAnalysisCustomException e)
            {
                //Assert
                Assert.AreEqual("NO such field found", e.Message);
            }
        }
        [TestMethod]
        public void GivenNullMessageShouldThrowMoodAnalysisCUstomExceptionIndicatingNullMessage()
        {
            try
            {
                //Act
                string actual = MoodAnalyserRefection.SetField( null , "message");
            }
            catch (MoodAnalysisCustomException e)
            {
                //Assert
                Assert.AreEqual("Message should not be null.", e.Message);
            }
        }
    }
}
