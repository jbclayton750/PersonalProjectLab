using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class AtmTests
    {
        [TestMethod]
        public void WithdrawExample()
        {
            //arrange
            Atm attempt = new Atm(500);
            //act
            int balance = attempt.processtransaction("W", 50);
            //assert
            Assert.AreEqual(450, balance);
        }

        [TestMethod]
        public void DepositExample()
        {
            //arrange
            Atm attempt = new Atm(500);
            //act
            int balance = attempt.processtransaction("D", 50);
            //assert
            Assert.AreEqual(450, balance);
        }
    }
}
