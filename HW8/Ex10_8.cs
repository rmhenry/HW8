using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HW8
{
    public class Ex10_8 : Form
    {
        Shape s;

        public Ex10_8()
        {
            Size = new Size(300, 200);
            s = new Oval(new Point(100, 100), 70, 30);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            s.Draw(g);
            base.OnPaint(e);
        }

    }
}
