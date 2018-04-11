using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public abstract class Restaurant
    {
        public abstract void GetMenu();
        public abstract void GetBill();
        public abstract void OrderFood();
        public abstract void PayBill();
        public abstract void ExtraDetail();

        public virtual void EatOut()
        {
            GetMenu();
            OrderFood();
            ExtraDetail();
            GetBill();
            PayBill();
        }
    }
}
