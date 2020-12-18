using NUnit.Framework;
using System.IO;
using System;
namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);   
                ConApp01.Program.Main();
                string expected = "Hello World!";
                string result = sw.ToString().Trim();
                Assert.AreEqual(expected,result);
            }
            
           
        }
    }
}