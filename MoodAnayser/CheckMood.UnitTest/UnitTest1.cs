using MoodAnayser;
using NUnit.Framework.Internal;

namespace CheckMood.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveMoodShouldReturnSadMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodSadOrHappy mood = new MoodSadOrHappy();
            string AcutalResult = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, AcutalResult);
        }
        [TestMethod]
        public void GiveMoodShouldReturnHappMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodSadOrHappy mood = new MoodSadOrHappy();
            string AcutalResult = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, AcutalResult);
        }
    }
}