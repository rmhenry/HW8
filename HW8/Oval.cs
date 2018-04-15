using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW8
{
    // Corrected code for Chapter 10 debugging exercise 8
    // Overrides the Shape class to create an Oval 
    // with a given center point, x-diameter, and y-diameter.
    public class Oval : Shape
    {
        int xdiam;
        int ydiam;

        public Oval(Point p, int ma, int mi) : base(p)
        {
            xdiam = ma;
            ydiam = mi;
        }
        public override void Draw(Graphics g)
        {
            // x and y radii are the diameter values divided by 2
            // upper-left corner of the bounding rectangle = center point minus radii
            g.FillEllipse(Brushes.Red, location.X - (xdiam / 2),
                 location.Y - (ydiam / 2), xdiam, ydiam);
        }
    }

}
