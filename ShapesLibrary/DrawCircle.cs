using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseProject_
{
    [Serializable]
    public class DrawCircle : Shape
    {
        public override void Paint(Graphics graphics)
        {

            using (Brush brush = new SolidBrush(Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 100),
                Math.Min(byte.MaxValue, Color.G + 100),
                Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillEllipse(brush, Position.X, Position.Y, Height, Width);
            }

            using (Pen pen = new Pen(Color, 2))
            {
                graphics.DrawEllipse(pen, Position.X, Position.Y, Height, Width);
            }             
          
        }

        public override bool Contains(Point point)
        {
            return base.Contains(point);
        }
        public override float CalculateArea()
        {
            const double PI = 3.14;
            return
               (float) PI * (float)Math.Pow(Width, 2);
        }

        public override float CalculatePerimeter()
        {
            const double PI = 3.14;
            return 2 *(float)PI * Width;
        }
        public override bool ContainShape(Shape circle, Shape rectangleGray)
        {
            return
            circle.Position.X < rectangleGray.Position.X + rectangleGray.Width &&
            rectangleGray.Position.X < circle.Position.X + circle.Width &&
            circle.Position.Y < rectangleGray.Position.Y + rectangleGray.Height &&
            rectangleGray.Position.Y < circle.Position.Y + circle.Height;
        }
    }
}
