﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Homework 8 \n");
            Console.WriteLine("Main Menu \n");
            Console.WriteLine("1 - Debugging Exercise");
            Console.WriteLine("2 - Exercise 10_9");
            Console.WriteLine("3 - Exercise 10_13");
            Console.WriteLine("4 - Exercise 10_17");
            Console.WriteLine("5 - Exit\n");
            Console.Write("Please enter a selection: ");

            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    DebugTest();
                    break;
                case "2":
                    Ex10_9Test();
                    break;
                case "3":
                    Ex10_13Test();
                    break;
                case "4":
                    Ex10_17Test();
                    break;
                default:
                    Console.Write("Exiting program.");
                    System.Threading.Thread.Sleep(3000);    //keep console open 3 seconds for user to read exit message
                    Environment.Exit(0);
                    break;
            }
        }

        public static void DebugTest()
        {
            Application.Run(new Ex10_8());
        }

        public static void Ex10_9Test()
        {
            //BankAccount newAccount = new BankAccount(100.00);
            //BankAccount copiedAccount = (BankAccount)newAccount.ReadAccount();
            //Console.WriteLine("The balance of copiedAccount is {0:C}",
            //    copiedAccount.GetBalance());

            //SavingsAccount savings = new SavingsAccount(100.00, 3.5);
            //SavingsAccount s = (SavingsAccount)savings.ReadAccount();
            //Console.WriteLine("The balance of s is {0:C}", s.GetBalance());
            //Console.WriteLine("The interest rate of s is {0:N}", s.GetInterestRate());
            //Console.ReadLine();


            SavingsAccount savings = new SavingsAccount(100.00, 3.5);
            SavingsAccount s = (SavingsAccount)savings.ReadAccount();
            CheckingAccount checking = new CheckingAccount(1000.00, .50);
            CheckingAccount c = (CheckingAccount)checking.ReadAccount();
            s.Deposit(135.22);
            s.PostInterest();
            s.Withdraw(50);
            Console.WriteLine
            ("The balance of SavingsAccount s is {0:C}",
                s.GetBalance());
            c.Deposit(1000.00);
            c.ProcessCheck(200.00);
            c.Withdraw(100.00);
            Console.WriteLine
            ("The balance of CheckingAccount c is {0:C}",
                c.GetBalance());
            Console.ReadLine();
        }

        public static void Ex10_13Test()
        {

        }

        public static void Ex10_17Test()
        {

        }
    }
}
