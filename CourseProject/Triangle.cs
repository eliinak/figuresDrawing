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
    public partial class Triangle : Form
    {
        public float Element1 { get; set; }
        public float Element2 { get; set; }
        public float Element3 { get; set; }
        public int FigureChoosed { get; set; }
        public Color Color { get; set; }
        public TextBox textBox1 { get; set; }
        public TextBox textBox2 { get; set; }
        public TextBox textBox3 { get; set; }

        public Triangle()
        {
            InitializeComponent();
            textBox1 = textBoxSide1;
            textBox2 = textBoxSide2;
            textBox3 = textBoxSide3;
  
        }

        private void OK_Click(object sender, EventArgs e)
        {

            if (textBoxSide1.Text != "" && textBoxSide2.Text != "" && textBoxSide3.Text != "" &&
               float.Parse(textBoxSide1.Text) <= 100 && float.Parse(textBoxSide2.Text) <= 100 && float.Parse(textBoxSide3.Text) <= 100 &&
               float.Parse(textBoxSide1.Text) != 0 && float.Parse(textBoxSide2.Text) != 0 && float.Parse(textBoxSide1.Text) != 0 &&
               float.Parse(textBoxSide1.Text) + float.Parse(textBoxSide2.Text) > float.Parse(textBoxSide3.Text) &&
               float.Parse(textBoxSide2.Text) + float.Parse(textBoxSide3.Text) > float.Parse(textBoxSide1.Text) &&
               float.Parse(textBoxSide3.Text) + float.Parse(textBoxSide1.Text) > float.Parse(textBoxSide2.Text))
            {
                FigureChoosed = 1;
                Element1 = float.Parse(textBoxSide1.Text);
                Element2 = float.Parse(textBoxSide2.Text);
                Element3 = float.Parse(textBoxSide3.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There are not entered values or they are invalid!");
            }
               
        }

        private void ChooseColTriangle_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogTriangle = new ColorDialog();
            if(colorDialogTriangle.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogTriangle.Color;
            }
        }

        private void textBoxSide1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSide2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSide3_KeyPress(object sender, KeyPressEventArgs e)
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
