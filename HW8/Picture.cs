using System;
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
        Object[] shapesAndPictures = new Object[0];
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

        public override string ToString()
        {
            return "Picture at center " + base.ToString();
        }

        public void Add(Object currentShapeOrPicture)
        // Resizes the array and adds a new object at the end.
        // Thanks to Joshua Coffman's support forum post for this solution.
        {
            int newSize = shapesAndPictures.Length + 1;
            Array.Resize(ref shapesAndPictures, newSize);
            shapesAndPictures[newSize - 1] = currentShapeOrPicture;
        }

        public void DisplayArrayContents()
        {
            for (int i = 0; i < shapesAndPictures.Length; i++)
            {
                Console.WriteLine(shapesAndPictures[i]);
            }
        }

    }
}
