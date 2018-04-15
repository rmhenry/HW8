//Copyright (c) 2002, Art Gittleman
//This example is provided WITHOUT ANY WARRANTY 
//either expressed or implied.

/* Declares a BankAccount class with an account balance 
 * attribute, two constructors,and getBalance, deposit, and 
 * withdraw operations. 
 */

using System;


// ReadAccount method added per Chapter 10 Exercise 9 instructions

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

  public virtual double Withdraw(double amount) {
    if (balance >= amount)
        {
            balance -= amount;
            return balance;
        }      
    else
        {
            Console.WriteLine("Insufficient funds");
            return -1;
        }
      
  } 

  public double GetBalance() {                                                         
    return balance;
  }

    // Creates a new BankAccount instance using the values
    // assigned to an existing BankAccount object's fields
    public virtual BankAccount ReadAccount()
    {
        BankAccount newInstance = new BankAccount();
        newInstance.balance = this.balance;
        return newInstance;
    } 
}

