﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public class Picture : Shape
    {
        Shape[] shapesArray = new Shape[0];
        int width;
        int height;


        public Picture(Point p, int _width, int _height) : base(p)
        {
            width = _width;
            height = _height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, location.X, location.Y, width, height);

            for (int i = 0; i < shapesArray.Length; i++)
            {
                shapesArray[i].Move(location.X, location.Y);
                shapesArray[i].Draw(g);
                shapesArray[i].Move(-location.X, -location.Y);
            }
        }

        public override void Move(int xamount, int yamount)
        {
            base.Move(xamount, yamount);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Add(Object currentShape)
        // Adds the shape parameter to the next empty spot in the array.
        // Thanks to Joshua Coffman's support forum post for this solution.
        {
            int newSize = shapesArray.Length + 1;
            Array.Resize(ref shapesArray, newSize);
            shapesArray[newSize - 1] = (Shape)currentShape;
        }

        public void DisplayArrayContents()
        {
            for (int i = 0; i < shapesArray.Length; i++)
            {
                Console.WriteLine(shapesArray[i]);
            }
        }

    }
}
