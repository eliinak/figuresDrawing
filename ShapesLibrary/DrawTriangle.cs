using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace CourseProject_
{
    [Serializable]
    public class DrawTriangle : Shape
    {        
        
        private float areaTriangle;
        private float AreaFirstTriangle;
        private float AreaSecondTriangle;
        private float AreaThirdTriangle;
        
        private void Parameters(out float h, out float p, out float areaTriangle)
        {
           
            float hemisphereTriangle = (Width + Height + Side3) / 2;
            areaTriangle = (float)Math.Sqrt(hemisphereTriangle * (hemisphereTriangle - Width)
                * (hemisphereTriangle - Height) * (hemisphereTriangle - Side3));
            h = areaTriangle * 2 / Width;
            p = (float)Math.Sqrt((float)Math.Pow(Side3, 2) - (float)Math.Pow(h, 2));
            
        }

        public override void Paint(Graphics graphics)
        {
            Parameters(out h, out p, out areaTriangle);

            using (Pen pen = new Pen(Color, 2))
            {

                Point[] points = new Point[3];

                points[0].X = Position.X;
                points[0].Y = Position.Y;

                points[1].X = Position.X + (int)Width;
                points[1].Y = Position.Y;

                points[2].X = Position.X + (int)p;
                points[2].Y = Position.Y + (int)h;

                graphics.DrawPolygon(pen, points);

                using (Brush brush = new SolidBrush(Color.FromArgb(
                    Math.Min(byte.MaxValue, Color.R + 100),
                    Math.Min(byte.MaxValue, Color.G + 100),
                    Math.Min(byte.MaxValue, Color.B + 100))))
                {
                    graphics.FillPolygon(brush, points);
                }

            }
        }
       
        public override bool Contains(Point point)
        {
            Parameters(out h, out p, out areaTriangle);

            areaTriangle = CalculateSurface(Position.X, Position.Y, Position.X + (int)Width,
                Position.Y, Position.X + (int)p, Position.Y + (int)h);

            AreaFirstTriangle = CalculateSurface(point.X, point.Y, Position.X + (int)Width,
                Position.Y, Position.X + (int)p, Position.Y + (int)h);

            AreaSecondTriangle = CalculateSurface(Position.X, Position.Y, point.X,
                point.Y, Position.X + (int)p, Position.Y + (int)h);

            AreaThirdTriangle = CalculateSurface(Position.X, Position.Y, Position.X + (int)Width,
                Position.Y, point.X, point.Y);

            return
                areaTriangle == AreaFirstTriangle + AreaSecondTriangle + AreaThirdTriangle;
        }

        private float CalculateSurface(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return (float)Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }
     

        public override float CalculateArea()
        {
            Parameters(out h, out p, out areaTriangle);         
            return areaTriangle;
        }

        public override float CalculatePerimeter()
        {
            return Height + Width + Side3;
        }
        public override bool ContainShape(Shape triangle, Shape rectangleGray)
        {
            return
            triangle.Position.X < rectangleGray.Position.X + rectangleGray.Width &&
            rectangleGray.Position.X < triangle.Position.X + triangle.Width &&
            triangle.Position.Y < rectangleGray.Position.Y + rectangleGray.Height &&
            rectangleGray.Position.Y < triangle.Position.Y + triangle.Height;
        }
    }
}
