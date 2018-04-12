using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class Picture : Shape
    {
        Shape[] shapesArray = new Shape[] { };


        public Picture(Point p, int xVal, int yVal) : base(p)
        {

        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void Move(int xamount, int yamount)
        {
            base.Move(xamount, yamount);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Add(Shape shape)
        // Adds the shape parameter to the next empty spot in the array.
        // Thanks to Joshua Coffman's support forum post for this solution.
        {
            int emptySpot = Array.IndexOf(shapesArray, null);
            shapesArray[emptySpot] = shape;
        }
    }
}
