﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public static void Ex10_9Test()
        {

        }

        public static void Ex10_13Test()
        {

        }

        public static void Ex10_17Test()
        {

        }
    }
}
