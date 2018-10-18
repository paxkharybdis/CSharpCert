using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fundamentals;

namespace Week1.Fundamentals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            dinosaur dino = new dinosaur();
            string result = dino.Color;

            Assert.AreEqual("Green", result);

        }
    }
}
