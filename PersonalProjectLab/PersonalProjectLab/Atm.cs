using System;
namespace PersonalProjectLab
{
    public class Atm
    {
        private int _balance;
        public Atm(int startingbalance)
        {
            _balance = startingbalance;
        }
        public int processtransaction(string transactiontype, int transactionamount)
        {
            string withdraw = "W";
            string deposit = "D";

            if (transactiontype.Equals(withdraw))
            {
                if (transactionamount <= _balance)
                {
                    _balance -= transactionamount;
                }
                else
                {
                    Console.WriteLine("Insufficent Funds");
                }
            }

            if (transactiontype.Equals(deposit))
            {
                _balance += transactionamount;
            }
            return _balance;
        }
    }
}
