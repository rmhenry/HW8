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
            Console.WriteLine("You unwrap your order when you return to work.");
            Console.WriteLine("The restaurant gave you a number one combo with a Diet Coke.");
            Console.WriteLine("You are beginning to believe in the existence of karma.");
        }

        public override void GetBill()
        {
            Console.WriteLine("The speaker voice says something that sounds like 'That will be $5.99 at the first window'.");
        }

        public override void GetMenu()
        {
            Console.WriteLine("Drive up to the order box, roll down the car window, and browse the menu board.");
        }

        public override void OrderFood()
        {
            Console.WriteLine("The garbled voice over the speaker invites you to order whenever you're ready'.");
            Console.WriteLine("You express that you would like a number four combo with a root beer.");
            Console.WriteLine("You must shout your order three more times at increasing volume until the cashier finally comprehends.");
        }

        public override void PayBill()
        {
            Console.WriteLine("Pull up to the first window and hand the disinterested teenager six dollars.");
            Console.WriteLine("You're in a snarky mood, so you quip 'Keep the change'. The casher responds with a scathing glare.");
        }

        public override void EatOut()
        {
            GetMenu();
            OrderFood();
            GetBill();
            PayBill();
            ExtraDetail();
        }
    }
}
