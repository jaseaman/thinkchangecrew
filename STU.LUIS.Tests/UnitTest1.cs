using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace STU.LUIS.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILanguageProccessingService service = new LUISService();

            service.ProcessQueryAsync("Book me a flight to LA at 3pm");
        }
    }
}
