using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Text;

namespace CourseProject_
{
    public partial class Scene : Form
    {

        public Scene()
        {
            InitializeComponent();

            this.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer, true
              );

        }
        private List<Shape> _shapes = new List<Shape>();      
        private List<Shape> _selectedFigures = null;
        private Shape _selectedShape = null;
        private bool _tracingMouseLeft = false;
        private Point _mouseDownLocationLeft;
        private bool ContainFigure = false;
        private string fileNameNeeded = string.Empty;
        private bool IsFileOpen = false;

        private float ElementFromScene1 { get; set; }
        private float ElementFromScene2 { get; set; }
        private float ElementFromScene3 { get; set; }
        private int FigureFromScene { get; set; }
        private Color ColorFromScene { get; set; }


        private void CalculateAreaFromScene()
        {
            float area = 0;

            foreach(var shape in _shapes)
            {
                area += shape.CalculateArea();
            }

            textBoxArea.Text = area.ToString();
        }

        private void CalculatePerimeterFromScene()
        {
            float perimeter = 0;

            foreach(var shape in _shapes)
            {
                perimeter += shape.CalculatePerimeter();
            }

            textBoxPerimeter.Text = perimeter.ToString();

        }

        private void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var graphics in _shapes)
            {
                graphics.Paint(e.Graphics);
            }

        }

        private void Parameters_Click(object sender, EventArgs e)
        {
            if (Triangle.Checked)
            {
                Triangle triangle = new Triangle();
                triangle.ShowDialog();
                ElementFromScene1 = triangle.Element1;
                ElementFromScene2 = triangle.Element2;
                ElementFromScene3 = triangle.Element3;
                FigureFromScene = triangle.FigureChoosed;
                ColorFromScene = triangle.Color;
            }
            else if (Square.Checked)
            {
                Square square = new Square();
                square.ShowDialog();
                ElementFromScene1 = square.Element1;
                FigureFromScene = square.FigureChoosed;
                ColorFromScene = square.Color;
            }
            else if (Rectangle.Checked)
            {
                Rectangle rectangle = new Rectangle();                
                rectangle.ShowDialog();
                ElementFromScene1 = rectangle.Element1;
                ElementFromScene2 = rectangle.Element2;
                FigureFromScene = rectangle.FigureChoosed;
                ColorFromScene = rectangle.Color;

            }
            else if (Circle.Checked)
            {
                Circle circle = new Circle();
                circle.ShowDialog();
                ElementFromScene1 = circle.Element1;
                FigureFromScene = circle.FigureChoosed;
                ColorFromScene = circle.Color;
            }
        }

        private List<Shape> WhereContains(Point point)
        {
           var SelectedFigures = new List<Shape>();
           SelectedFigures = _shapes
                 .Where(shape => shape.Contains(point))
                 .ToList();
                
            return SelectedFigures;
        }
  
        private void Scene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (FigureFromScene == 0)
                {
                    MessageBox.Show("Choose Radio Button!");
                }
                if (FigureFromScene == 1)
                {
                    Shape drawTriangle = new DrawTriangle();
                    drawTriangle.Position = e.Location;
                    drawTriangle.Width = ElementFromScene1;
                    drawTriangle.Height = ElementFromScene2;
                    drawTriangle.Side3 = ElementFromScene3;
                    drawTriangle.Color = ColorFromScene;
                    drawTriangle.Order = _shapes
                        .Select(s => s.Order)
                        .OrderBy(o => o)
                        .LastOrDefault() + 1;

                    drawTriangle.ConstColor = drawTriangle.Color;
                    AddShape(drawTriangle);
                }
                else if(FigureFromScene == 2)
                {
                    Shape drawsquare = new DrawFigure();
                    drawsquare.Position = e.Location;
                    drawsquare.Width = ElementFromScene1;
                    drawsquare.Height = ElementFromScene1;
                    drawsquare.Color = ColorFromScene;
                    drawsquare.Order = _shapes
                        .Select(s => s.Order)
                        .OrderBy(o => o)
                        .LastOrDefault() + 1;

                    drawsquare.ConstColor = drawsquare.Color;
                    AddShape(drawsquare);
                }
                else if (FigureFromScene == 3)
                {
                    Shape drawrectangle = new DrawFigure();
                    drawrectangle.Position = e.Location;
                    drawrectangle.Height = ElementFromScene1;
                    drawrectangle.Width = ElementFromScene2;                    
                    drawrectangle.Color = ColorFromScene;
                    drawrectangle.Order = _shapes
                        .Select(s => s.Order)
                        .OrderBy(o => o)
                        .LastOrDefault() + 1;

                    drawrectangle.ConstColor = drawrectangle.Color;
                    AddShape(drawrectangle);
                }
                else if(FigureFromScene == 4)
                {
                    Shape drawCircle = new DrawCircle();
                    drawCircle.Position = e.Location;
                    drawCircle.Position = e.Location;
                    drawCircle.Height = ElementFromScene1;
                    drawCircle.Width = ElementFromScene1;
                    drawCircle.Color = ColorFromScene;
                    drawCircle.Order = _shapes
                        .Select(s => s.Order)
                        .OrderBy(o => o)
                        .LastOrDefault() + 1;

                    drawCircle.ConstColor = drawCircle.Color;
                    AddShape(drawCircle);
                }
                
            }
            else if(e.Button == MouseButtons.Left)
            {
                _mouseDownLocationLeft = e.Location;

                _selectedShape = _shapes
                    .OrderByDescending(o => o.Order)
                    .Where(shape => shape.Contains(e.Location))
                    .FirstOrDefault();

                if(_selectedShape != null)
                {
                    _selectedShape.Color = BackColor;
                    ContainFigure = true;
                }

               _selectedFigures = WhereContains(e.Location);                               
                    
                _tracingMouseLeft = true;
            }
            Invalidate();
           
        }

        private void Clear_Click(object sender, EventArgs e)
        {         

            if (_selectedFigures != null && _selectedFigures.Count() != 0)
            {
                foreach (var figure in _selectedFigures)
                {
                    _shapes.Remove(figure);
                }
                textBoxNumberFigures.Text = _shapes.Count.ToString();
            }                                              
            else if(_selectedFigures == null || _selectedFigures.Count() == 0)
                MessageBox.Show("There are not selected figures!");         

            Invalidate();
            CalculateAreaFromScene();
            CalculatePerimeterFromScene();
        }


        private void Scene_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxNumberFigures.Text = _shapes.Count.ToString();

            _tracingMouseLeft = false;

            ContainFigure = false;
            
            if(_selectedFigures != null && e.Button == MouseButtons.Left)
            {
                    foreach(var figure in _selectedFigures)
                        figure.Color = figure.ConstColor;
            }
            if(_selectedShape != null && e.Button == MouseButtons.Left)
            {
                _selectedShape.Color = _selectedShape.ConstColor;
            }
            
            Invalidate();
            CalculateAreaFromScene();
            CalculatePerimeterFromScene();
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {

            if (_tracingMouseLeft == false && ContainFigure == true)
                return;

            else if (_tracingMouseLeft == true && ContainFigure == false)
            {
                var width = Math.Abs(e.Location.X - _mouseDownLocationLeft.X);
                var height = Math.Abs(e.Location.Y - _mouseDownLocationLeft.Y);

                if (width > 0 && height > 0)
                {
                    var x = Math.Min(_mouseDownLocationLeft.X, e.Location.X);
                    var y = Math.Min(_mouseDownLocationLeft.Y, e.Location.Y);

                    DrawFigure grayRectangle = new DrawFigure();
                    grayRectangle.Color = Color.Gray;
                    grayRectangle.Position = new Point(x, y);
                    grayRectangle.Width = width;
                    grayRectangle.Height = height;

                    Invalidate();
                    Application.DoEvents();

                    using (var graphics = CreateGraphics())
                    {
                        grayRectangle.PaintPen(graphics);
                    }

                    foreach(var shape in _shapes)
                    {
                        if(shape.ContainShape(shape, grayRectangle))
                        {
                            shape.Color = BackColor;
                            _selectedFigures.Add(shape);
                        }
                        else
                        {
                            shape.Color = shape.ConstColor;
                        }
                    }
                }
               
            }
            else if(e.Button == MouseButtons.Left && ContainFigure == true)
            {     
                if(_selectedShape != null)
                {
                    _selectedShape.Position = new Point(e.X - _mouseDownLocationLeft.X + _selectedShape.Position.X,
                                                        e.Y - _mouseDownLocationLeft.Y + _selectedShape.Position.Y);
                    _mouseDownLocationLeft = e.Location;
                    Invalidate();
                }                    
                
            }
            
        }
        private void Scene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ContainFigure == false)
                MessageBox.Show("There are not selected figure!");

            else
            {
                
                if(_selectedShape != null)
                {
                    var TypeOfFigure = _selectedShape.GetType();
                    if (TypeOfFigure.Equals(typeof(DrawFigure)) && _selectedShape.Height != _selectedShape.Width)
                    {
                        Rectangle rectangle = new Rectangle();
                        rectangle.textBox1.Text = _selectedShape.Width.ToString();
                        rectangle.textBox2.Text = _selectedShape.Height.ToString();
                        rectangle.ShowDialog();
                        ElementFromScene1 = rectangle.Element1;
                        ElementFromScene2 = rectangle.Element2;
                        FigureFromScene = rectangle.FigureChoosed;
                        ColorFromScene = rectangle.Color;

                        Shape drawrectangle = new DrawFigure();
                        drawrectangle.Position = e.Location;
                        drawrectangle.Height = ElementFromScene1;
                        drawrectangle.Width = ElementFromScene2;
                        drawrectangle.Color = ColorFromScene;
                        drawrectangle.Order = _shapes
                            .Select(s => s.Order)
                            .OrderBy(o => o)
                            .LastOrDefault() + 1;

                        drawrectangle.ConstColor = drawrectangle.Color;
                        AddShape(drawrectangle);

                    }
                    else if(TypeOfFigure.Equals(typeof(DrawFigure)) && _selectedShape.Height == _selectedShape.Width)
                    {
                        Square square = new Square();
                        square.textBox1.Text = _selectedShape.Height.ToString();
                        square.ShowDialog();
                        ElementFromScene1 = square.Element1;
                        FigureFromScene = square.FigureChoosed;
                        ColorFromScene = square.Color;

                        Shape drawsquare = new DrawFigure();
                        drawsquare.Position = e.Location;
                        drawsquare.Width = ElementFromScene1;
                        drawsquare.Height = ElementFromScene1;
                        drawsquare.Color = ColorFromScene;
                        drawsquare.Order = _shapes
                            .Select(s => s.Order)
                            .OrderBy(o => o)
                            .LastOrDefault() + 1;

                        drawsquare.ConstColor = drawsquare.Color;
                        AddShape(drawsquare);


                    }
                    else if (TypeOfFigure.Equals(typeof(DrawTriangle)))
                    {
                        Triangle triangle = new Triangle();
                        triangle.textBox1.Text = _selectedShape.Width.ToString();
                        triangle.textBox2.Text = _selectedShape.Height.ToString();
                        triangle.textBox3.Text = _selectedShape.Side3.ToString();
                        triangle.ShowDialog();
                        ElementFromScene1 = triangle.Element1;
                        ElementFromScene2 = triangle.Element2;
                        ElementFromScene3 = triangle.Element3;
                        FigureFromScene = triangle.FigureChoosed;
                        ColorFromScene = triangle.Color;

                        Shape drawTriangle = new DrawTriangle();
                        drawTriangle.Position = e.Location;
                        drawTriangle.Width = ElementFromScene1;
                        drawTriangle.Height = ElementFromScene2;
                        drawTriangle.Side3 = ElementFromScene3;
                        drawTriangle.Color = ColorFromScene;
                        drawTriangle.Order = _shapes
                            .Select(s => s.Order)
                            .OrderBy(o => o)
                            .LastOrDefault() + 1;

                        drawTriangle.ConstColor = drawTriangle.Color;
                        AddShape(drawTriangle);

                    }
                    else if (TypeOfFigure.Equals(typeof(DrawCircle)))
                    {
                        Circle circle = new Circle();
                        circle.textBox1.Text = _selectedShape.Height.ToString();
                        circle.ShowDialog();
                        ElementFromScene1 = circle.Element1;
                        FigureFromScene = circle.FigureChoosed;
                        ColorFromScene = circle.Color;

                        Shape drawCircle = new DrawCircle();
                        drawCircle.Position = e.Location;
                        drawCircle.Position = e.Location;
                        drawCircle.Height = ElementFromScene1;
                        drawCircle.Width = ElementFromScene1;
                        drawCircle.Color = ColorFromScene;
                        drawCircle.Order = _shapes
                            .Select(s => s.Order)
                            .OrderBy(o => o)
                            .LastOrDefault() + 1;

                        drawCircle.ConstColor = drawCircle.Color;
                        AddShape(drawCircle);
                    }

                   _shapes.Remove(_selectedShape);     
                    
                }                
            }
        }

        private void Scene_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to open an existing file?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    IsFileOpen = true;
                    openFileDialog.Filter = "*.dat|*.dat";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        fileNameNeeded = filePath;

                        var binaryFormatter = new BinaryFormatter();
                        using (var fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            _shapes = (List<Shape>)binaryFormatter.Deserialize(fileStream2);
                                                       
                        }
                        CalculateAreaFromScene();
                        CalculatePerimeterFromScene();
                        textBoxNumberFigures.Text = _shapes.Count.ToString();
                    }
                }
            }
            if(dialogResult == DialogResult.No)
            {
                //Load Scene
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (_shapes == null || _shapes.Count() == 0)
                MessageBox.Show("There are not created figures!");

            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save this?", "Save to file", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    using(SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        IsFileOpen = true;
                        saveFileDialog.Title = "Save file";
                        saveFileDialog.DefaultExt = "dat";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var binaryFormatter = new BinaryFormatter();
                            using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                            {
                                binaryFormatter.Serialize(fileStream, _shapes);
                                fileNameNeeded = saveFileDialog.FileName;
                            }

                        }

                    }

                }
                if(dialogResult == DialogResult.No)
                {
                    //nothing
                }

            }
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (_selectedFigures != null && IsFileOpen == true) 
            {
                
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this from the file?","Delete from file", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    foreach (var figure in _selectedFigures)
                    {
                        _shapes.Remove(figure);
                    }                       
                     var binaryFormatter2 = new BinaryFormatter();
                     using (var fileStream2 = new FileStream(fileNameNeeded, FileMode.Create, FileAccess.Write))
                     {
                       binaryFormatter2.Serialize(fileStream2, _shapes);
                     }

                    textBoxNumberFigures.Text = _shapes.Count.ToString();
                    CalculatePerimeterFromScene();
                    CalculateAreaFromScene();

                }
                else if(dialogResult == DialogResult.No)
                {
                    //nothing
                }               

                Invalidate();
            }
            else if((_selectedFigures == null && IsFileOpen == false) || _selectedFigures == null && IsFileOpen == true)
            {
                MessageBox.Show("There are not selected figures!");

            }
            else if(_selectedFigures != null && IsFileOpen == false)
            {
                MessageBox.Show("There is not opened a file!");
            }
        }

    }
}
