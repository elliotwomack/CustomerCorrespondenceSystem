using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CustomerVoicemailSystem;
using CustomerVoicemailSystem.Presentation;
using System.Data;

namespace CustomerCorrespondenceSystemTest
{
    [TestClass]
    public class CorrespondenceTests
    {
        Correspondence correspondence;

        [TestInitialize]
        public void setup()
        {
            correspondence = new Correspondence();
        }

        [TestMethod]
        public void testClearContents()
        {
            Assert.IsInstanceOfType(correspondence, typeof(Correspondence));
        }
    }
}
