using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    // Part of Chapter 10 Exercise 13
    // This class provides base methods
    // common to various types of restaurants
    public abstract class Restaurant
    {
        public abstract void GetMenu();
        public abstract void GetBill();
        public abstract void OrderFood();
        public abstract void PayBill();
        public abstract void ExtraDetail();

        public void DisplayHeading(string heading)
        {
            Console.WriteLine(heading);
        }

        public void BlankLine()
        {
            Console.WriteLine();
        }

        public virtual void EatOut()
        {
            DisplayHeading("");
            GetMenu();
            OrderFood();
            ExtraDetail();
            GetBill();
            PayBill();
            BlankLine();
        }
    }
}
