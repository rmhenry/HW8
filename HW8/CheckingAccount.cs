﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class CheckingAccount : BankAccount
    {
        private double minBalance;
        private double charge;

        public CheckingAccount(double minAmount, double charge) : base()
        {
            minBalance = minAmount;
            this.charge = charge;
        }

        public double ProcessCheck(double amount)
        {
            double result;

            if (GetBalance() >= minBalance)
                result = base.Withdraw(amount);
            else
                result = base.Withdraw(amount + charge);

            return result;
        }

        public override double Withdraw(double amount)
        {
            return ProcessCheck(amount);
        }

        // The override sets a value for a CheckingAccount
        // object's charge field
        public override BankAccount ReadAccount()
        {
            BankAccount newInstance = new CheckingAccount(this.GetBalance(), this.charge);
            return newInstance;
        }
    }
}
