using System;
using System.Collections.Generic;
using System.Drawing;
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
            MainMenu();
        }

        public static void Ex10_9Test()
        {
            Console.Clear();

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

            ReturnToMainMenu();
        }

        public static void Ex10_13Test()
        {
            Console.Clear();

            Restaurant fast = new FastFood();
            fast.EatOut();
            Restaurant coffee = new CoffeeShop();
            coffee.EatOut();
            Restaurant fancy = new FancyRestaurant();
            fancy.EatOut();

            ReturnToMainMenu();
        }

        public static void Ex10_17Test()
        {
            Application.Run(new Ex10_17());
            MainMenu();
        }

        public static void ReturnToMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ReadLine();
            MainMenu();
        }
    }
}
