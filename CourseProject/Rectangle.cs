using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_
{
    public partial class Rectangle : Form
    {

        public float Element1 { get; set; }
        public float Element2 { get; set; }
        public int FigureChoosed { get; set; }
        public Color Color { get; set; }
        public TextBox textBox1 { get; set; }
        public TextBox textBox2 { get; set; }
        public Rectangle()
        {
            InitializeComponent();
            textBox1 = textBoxWidth;
            textBox2 = textBoxHeight;
            
        }
        
        private void OK_Click(object sender, EventArgs e)
        {
            if(textBoxHeight.Text != "" && textBoxWidth.Text != "" &&
               float.Parse(textBoxHeight.Text) <= 100 && float.Parse(textBoxWidth.Text) <= 100
               && float.Parse(textBoxHeight.Text) != 0 && float.Parse(textBoxWidth.Text) != 0)
            {
                FigureChoosed = 3;
                Element1 = float.Parse(textBoxHeight.Text);
                Element2 = float.Parse(textBoxWidth.Text);
                DialogResult = DialogResult.OK;               
            }
            else
            {
                MessageBox.Show("There are not entered values or they are invalid!");
            }          
        }

        private void ChooseColRec_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogRectangle = new ColorDialog();           
            if (colorDialogRectangle.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogRectangle.Color;
            }              
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
