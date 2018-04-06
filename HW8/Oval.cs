using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HW8
{
    public class Oval : Shape
    {
        int xdiam;
        int ydiam;

        public Oval(Point p, int ma, int mi)
        {
            xdiam = ma;
            ydiam = mi;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, location.X - 2 * xdiam,
                 location.Y - 2 * ydiam, xdiam, ydiam);
        }
    }

}
