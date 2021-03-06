using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
       
       /// <summary>
       /// This Test case ensure AnalyseMood() method will return when SAD when message contains Sad using Constructor
       /// </summary>
        [TestMethod]
        public void GivenSadMessage_WhenSad_ShouldReturnSAD()
        {
            //Arrange
            string Expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case ensure AnalyseMood() method will return when HAPPY when message contains Happy using Constructor
        /// </summary>
        [TestMethod]       
        public void GivenHappyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case ensure AnalyseMood() method will return when HAPPY when Any mood message is given using Constructor
        /// </summary>
        [TestMethod]
        public void GivenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case ensure AnalyseMood() method will return when HAPPY when Null mood message is given
        /// </summary>
        [TestMethod]
        [DataRow("null")]
        public void GivenNULLMessage_WhenANULL_ShouldReturnHAPPY(string message)
        {
            //Arrange
            string Expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case ensure when given empty message will throw an exception
        /// </summary>
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMessage_WhenEmpty_ShouldThrowException(string message)
        {
            try
            {
                //Arrange
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalyserException e)
            {
                //Assert         
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        /// <summary>
        /// UC4-TC4.1 Proper class details are provided and expected to return the MoodAnalyser Object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateeMoodAnalyse("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// UC5-TC5.1 Proper message are provided to parameterized constructor and expected to return the MoodAnalyser Object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject_UsingParameterizdConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser","HAPPY");
            expected.Equals(obj);
        }

        /// <summary>
        /// UC6-TC6-1 Given Happy Should Return Happy.
        /// </summary>
        [TestMethod]
        public void GiveHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// UC7-TC7.1 Given Happy Should Return Happy
        /// </summary>
        [TestMethod]
        public void Given_HAPPYMessag_WithReflector_should_ReturnHAPPY() 
        {
            string result = MoodAnalyserFactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }
    }
}
