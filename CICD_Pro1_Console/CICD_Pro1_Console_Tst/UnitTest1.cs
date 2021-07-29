using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
 
namespace CICD_Pro1_Console_Tst
{
    [TestClass]
    public class UnitTest1
    {
        private const string strExpected = "Hellow world this CICD";
        [TestMethod]
        public void TestMethod1()
        {
            using (var w = new StringWriter())
            {
                Console.SetOut(w);
                CICD_Pro1_Console.MyCICD.Main();
                var result = w.ToString().Trim();
                Assert.AreEqual(strExpected, result);
            }
        }
    }
}
