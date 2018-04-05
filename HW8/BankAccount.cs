//Copyright (c) 2002, Art Gittleman
//This example is provided WITHOUT ANY WARRANTY 
//either expressed or implied.

/* Declares a BankAccount class with an account balance 
 * attribute, two constructors,and getBalance, deposit, and 
 * withdraw operations. 
 */

using System;
public class BankAccount {
  private double balance;                                                                 

  public BankAccount()   {                                                                    
    balance = 0;
  }

  public BankAccount(double initialAmount) {
    balance = initialAmount;
  }

  public void Deposit(double amount) {                                             
    balance += amount;
  }

  public virtual void Withdraw(double amount) {
    if (balance >= amount)
      balance -= amount;
    else
      Console.WriteLine("Insufficient funds");
  } 

  public double GetBalance() {                                                         
    return balance;
  }
}

