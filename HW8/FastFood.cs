using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class FastFood : Restaurant
    {
        public override void ExtraDetail()
        {
            Console.WriteLine("\tYou unwrap your order when you return to work.");
            Console.WriteLine("\tThe restaurant gave you a number one combo with a Diet Coke.");
            Console.WriteLine("\tYou are beginning to believe in the existence of karma.");
        }

        public override void GetBill()
        {
            Console.WriteLine("\tThe speaker voice says something that sounds like 'That will be $5.99 at the first window'.");
        }

        public override void GetMenu()
        {
            Console.WriteLine("\tDrive up to the order box, roll down the car window, and browse the menu board.");
        }

        public override void OrderFood()
        {
            Console.WriteLine("\tThe garbled voice over the speaker invites you to order whenever you're ready'.");
            Console.WriteLine("\tYou express that you would like a number four combo with a root beer.");
            Console.WriteLine("\tYou must shout your order three more times at increasing volume until the cashier finally comprehends.");
        }

        public override void PayBill()
        {
            Console.WriteLine("\tPull up to the first window and hand the disinterested teenager six dollars.");
            Console.WriteLine("\tYou're in a snarky mood, so you quip 'Keep the change'. The casher responds with a scathing glare.");
        }

        public override void EatOut()
        {
            DisplayHeading("The fast food restaurant");
            GetMenu();
            OrderFood();
            GetBill();
            PayBill();
            ExtraDetail();
            BlankLine();
        }
    }
}
