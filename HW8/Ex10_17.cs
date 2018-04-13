using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public class Ex10_17 : Form
    {
        Shape s0 = new Line(10, 10, 20, 30);
        Shape s1 = new Circle(new Point(50, 50), 30);
        Shape s2 = new Circle(new Point(150, 150), 30);
        Picture p1 = new Picture(new Point(20, 40), 80, 80);
        Picture p2 = new Picture(new Point(120, 50), 200, 200);
        Shape t0 = new Line(10, 10, 20, 30);
        Shape t1 = new Circle(new Point(50, 50), 30);
        Picture p3 = new Picture(new Point(20, 40), 80, 80);

        public Ex10_17()
        {
            Size = new Size(700, 620);

            p1.Add(s0);
            p1.Add(s1);
            p2.Add(p1);
            p2.Add(s2);
            p2.Move(20, 50);
            p3.Add(t0);
            p3.Add(t1);

            //Console.WriteLine(p2);

            p1.DisplayArrayContents();
        }

    }
}
