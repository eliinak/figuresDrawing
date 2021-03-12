using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace CourseProject_
{
    [Serializable]
    public class DrawFigure : Shape
    {

        public override void Paint(Graphics graphics)
        {
            using (Brush brush = new SolidBrush(Color.FromArgb(
            Math.Min(byte.MaxValue, Color.R + 100),
            Math.Min(byte.MaxValue, Color.G + 100),
            Math.Min(byte.MaxValue, Color.B + 100))))
            {
                graphics.FillRectangle(brush, Position.X, Position.Y, Width, Height);
            }

            using (Pen pen = new Pen(Color, 2))
            {
                graphics.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
            }           
        
        }

        public void PaintPen(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                graphics.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
            }
        }

        public override bool Contains(Point point)
        {
            return base.Contains(point);
        }

        public override float CalculateArea()
        {            
                Area = Height * Width;
            return Area;
        }
        public override float CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override bool ContainShape(Shape drawFigure, Shape rectangleGray)
        {
            return
            drawFigure.Position.X < rectangleGray.Position.X + rectangleGray.Width &&
            rectangleGray.Position.X < drawFigure.Position.X + drawFigure.Width &&
            drawFigure.Position.Y < rectangleGray.Position.Y + rectangleGray.Height &&
            rectangleGray.Position.Y < drawFigure.Position.Y + drawFigure.Height;

        }
    }
   
}
