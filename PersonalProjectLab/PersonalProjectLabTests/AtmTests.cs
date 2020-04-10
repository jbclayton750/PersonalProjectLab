using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class AtmTests
    {
        [TestMethod]
        public void WithdrawExample()
        {
            //arrange
            Atm attempt = new Atm(testWithdraw);

            //act
            //assert
        }

        [TestMethod]
        public void DepositExample()
        {
            //arrange
            Atm attempt = new Atm(testDeposit);

            //act
            //assert
        }
    }
}
