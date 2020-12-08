using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MoodAnalyser moodAnalyser;
        public UnitTest1()
        {
            moodAnalyser = new MoodAnalyser();
        }

        [TestMethod]
        public void givenMood_WhenHappy_ShouldReturnHappyMood()
        {
            var result = moodAnalyser.analyseMood("Happy");
            Assert.AreEqual("Happy mood", result);
        }
        [TestMethod]
        public void givenMood_WhenSad_ShouldReturnSadMood()
        {
            var result = moodAnalyser.analyseMood("Sad");
            Assert.AreEqual("Sad mood", result);
        }
        [TestMethod]
        public void givenSadMessage_WhenSad_ShouldReturnSAD()
        {
            var result = moodAnalyser.analyseMood("I am in Sad Mood");
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void givenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            var result = moodAnalyser.analyseMood("I am in Any Mood");
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void givenSadMessage_WhenToConstructo_ShouldReturnSAD()
        {
            var result = moodAnalyser.analyseMood1();
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void givenHappyMessage_WhenToConstructor_ShouldReturnHAPPY()
        {
            var result = moodAnalyser.analyseMood1();
            Assert.AreEqual("HAPPY", result);
        }
    }
}
