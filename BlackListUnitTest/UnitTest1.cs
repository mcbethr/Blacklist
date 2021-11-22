using Blacklist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IPAddressOperations MyBlackList = new IPAddressOperations();
            MyBlackList.AddIPAddressToBlacklist("192.168.1.1");
            bool IsBlacklisted = MyBlackList.SearchForIPAddress("192.168.1.1");
            Assert.AreEqual(true, IsBlacklisted);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IPAddressOperations MyBlackList = new IPAddressOperations();
            MyBlackList.AddIPAddressToBlacklist("192.168.1.2");
            bool IsBlacklisted = MyBlackList.SearchForIPAddress("192.168.1.1");
            Assert.AreEqual(false, IsBlacklisted);
        }
    }
}
