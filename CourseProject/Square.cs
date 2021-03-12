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
    public partial class Square : Form
    {
        public float Element1 { get; set; }
        public int FigureChoosed { get; set; }
        public Color Color { get; set; }
        public TextBox textBox1 { get; set; }
        public Square()
        {
            InitializeComponent();
            textBox1 = textBoxSquare;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(textBoxSquare.Text != "" && float.Parse(textBoxSquare.Text) <= 100 && float.Parse(textBoxSquare.Text) != 0)
            {
                FigureChoosed = 2;
                Element1 = float.Parse(textBoxSquare.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There is not entered value or it is invalid!");
            }
        }

        private void ChooseColSqu_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogSquare = new ColorDialog();
            if(colorDialogSquare.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogSquare.Color;
            }
        }

        private void textBoxSquare_KeyPress(object sender, KeyPressEventArgs e)
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
