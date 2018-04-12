using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class CoffeeShop : Restaurant
    {
        public override void ExtraDetail()
        {
            Console.WriteLine("The barista asks whether you would prefer whole, skim, soy, almond, cashew, or hemp milk.");
            Console.WriteLine("Ever the traditionalist, you select good old whole milk; however, you assume the barista is judging your decision.");
        }

        public override void GetBill()
        {
            Console.WriteLine("No one has brought your check yet in the fifteen minutes since you finished your beverage.");
            Console.WriteLine("");
        }

        public override void GetMenu()
        {
            Console.WriteLine("Approach the counter and examine the menu board on the rear wall.");
        }

        public override void OrderFood()
        {
            Console.WriteLine("The regulars have no patience for uncertainty in line.");
            Console.WriteLine("You panic and order a cappuccino, which is the only beverage on the menu with which you are familiar.");
        }

        public override void PayBill()
        {
            throw new NotImplementedException();
        }
    }
}
