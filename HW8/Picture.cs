using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    // This class fulfills the instructions for Chapter 10 Exercise 17
    // A Picture instance is an array of Shape objects and/or other Picture objects
    public class Picture : Shape
    {
        Object[] shapesAndPictures = new Object[0];
        int width;
        int height;


        public Picture(Point p, int _width, int _height) : base(p)
        {
            width = _width;
            height = _height;
        }

        // This is an implementation of the Draw method that James Bateman
        // shared in a support forum post.
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, location.X, location.Y, width, height);

            for (int i = 0; i < shapesAndPictures.Length; i++)
            {
                Shape objectToShape = (Shape)shapesAndPictures[i];

                objectToShape.Move(location.X, location.Y);
                objectToShape.Draw(g);
                objectToShape.Move(-location.X, -location.Y);
            }
        }

        public override void Move(int xamount, int yamount)
        {
            base.Move(xamount, yamount);
        }

        // Displays a text string listing the picture coordinates
        // and each element in the object's array
        public override string ToString()
        
        {
            string arrayElements = ArrayElementsToString();
            return "Picture at center " + base.ToString() + arrayElements;
        }

        // Resizes the array and adds a new object at the end.
        // Thanks to Joshua Coffman's support forum post for this solution.
        public void Add(Object currentShapeOrPicture)
        {
            int newSize = shapesAndPictures.Length + 1;
            Array.Resize(ref shapesAndPictures, newSize);
            shapesAndPictures[newSize - 1] = currentShapeOrPicture;
        }

        public string ArrayElementsToString()
        {
            string arrayElements = "";

            foreach (Object element in shapesAndPictures)
            {
                arrayElements += "\n" + element;
            }

            return arrayElements;
        }

    }
}
