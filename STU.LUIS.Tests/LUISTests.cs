using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace STU.LUIS.Tests
{
    [TestClass]
    public class LUISTests
    {
        [TestMethod]
        public void TestBuildingLocation()
        {
            ILanguageProccessingService service = new LUISProcessingService();

            service.ProcessQueryAsync("Where is the peter johnson building");
        }
    }
}
