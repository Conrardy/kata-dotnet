using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangerEonsLtd
{
    [TestClass]
    public class StrangerEonsLtdTest
    {
        [TestMethod]
        public void TestSecret()
        {
            UI ui = new UI(new ApplicationStrangerEonsLtd());
            Assert.AreEqual("Leeted: 5ecret", ui.EncryptMessage("Secret"));
        }
    }
}
