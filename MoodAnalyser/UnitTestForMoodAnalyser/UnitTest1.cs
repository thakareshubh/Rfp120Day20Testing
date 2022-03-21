using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestForMoodAnalyser;

namespace UnitTestForMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MoodAnalyser.Program program;

        public UnitTest1()
        {
            program = new MoodAnalyser.Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            string mood = "sad";
            var result=program.CheckMood(mood);
           Assert.AreEqual(mood, result);
        }
    }
}
