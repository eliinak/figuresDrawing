using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CourseProject_
{
    [Serializable]
    public abstract class Shape
    {
        protected float h;

        protected float p;
        public Point Position { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float Side3 { get; set; }
        public Color ConstColor { get; set; }
        public int Order { get; set; }

        public abstract void Paint(Graphics graphics);
           
        public virtual bool Contains(Point point)
        {     
            return
            Position.X < point.X && point.X < Position.X + Width &&
            Position.Y < point.Y && point.Y < Position.Y + Height;

        }
             
        public abstract float CalculateArea();

        public abstract float CalculatePerimeter();

        public abstract bool ContainShape(Shape shape, Shape rectangleGray);
 
    }
}
