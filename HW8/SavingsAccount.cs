using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(double amount, double rate) : base(amount)
        {
            interestRate = rate;
        }

        public void PostInterest()
        {
            double balance = GetBalance();
            double interest = interestRate / 100 * balance;
            Deposit(interest);
        }

        public override BankAccount ReadAccount()
        {
            BankAccount newInstance = new BankAccount();
            return newInstance;
        }
    }
}
