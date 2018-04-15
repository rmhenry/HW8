using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    // Part of Chapter 10 Exercise 13
    // Generates console output that describes the experience
    // of ordering food from a fancy restaurant
    public class FancyRestaurant : Restaurant
    {
        public override void ExtraDetail()
        {
            Console.WriteLine("  After waiting a month for a reservation, you finally sit down for dinner at Chez Henri.");
        }

        public override void GetBill()
        {
            Console.WriteLine("  After dinner and a deft raking of crumbs from the tablecloth,");
            Console.WriteLine("  the waiter sets down the sterling silver tray in which the bill is perched.");
        }

        public override void GetMenu()
        {
            Console.WriteLine("  The waiter supplies leather-bound menus with pages that appear to have been printed on vellum.");
        }

        public override void OrderFood()
        {
            Console.WriteLine("  Intending for this to be a gastronomical event rather than a mere meal,");
            Console.WriteLine("  you order the thirteen course chef's tasting menu complete with wine parings.");
        }

        public override void PayBill()
        {
            Console.WriteLine("  You peek at the check and realize what a scary phrase 'prix fixe' can be.");
            Console.WriteLine("  You reach for the credit card that gives you the most airline miles,");
            Console.WriteLine("  and you wonder how many extra shifts you can realistically work this month.");
        }

        public override void EatOut()
        {
            DisplayHeading("The fancy restaurant");
            ExtraDetail();
            GetMenu();
            OrderFood();
            GetBill();
            PayBill();
            BlankLine();
        }
    }
}
