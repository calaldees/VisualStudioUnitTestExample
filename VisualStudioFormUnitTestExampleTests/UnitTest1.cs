using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using VisualStudioFormUnitTestExample;

namespace VisualStudioFormUnitTestExampleTests
{
    [TestClass]
    public class UnitTest1
    {
        
        /*
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
        */

        [TestMethod]
        public void TestExampleClass()
        {
            //VisualStudioFormUnitTestExample.ExampleClass1
            var tt = new ExampleClass1(10);
            Assert.AreEqual(tt.value, 10);
        }
    }
}
