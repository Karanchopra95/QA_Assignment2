using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA_Assignment2;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructors()
        {
            Rectangle r = new Rectangle();

            int width = r.Width;
            int height = r.Height;

            Assert.AreEqual(1, height);
            Assert.AreEqual(1, width);

            Rectangle r2 = new Rectangle(1, 2);

            width = r2.Width;
            height = r2.Height;

            Assert.AreEqual(1, width);
            Assert.AreEqual(2, height);
        }

        [TestMethod]
        public void TestPerimeterMethod()
        {
            Rectangle r = new Rectangle(1,2);
            Assert.AreEqual(6, r.getPerimeter());
            
        }

        [TestMethod]
        public void TestAreaMethod()
        {
            Rectangle r = new Rectangle(1, 2);
            Assert.AreEqual(2, r.getArea());

        }
    }
}
