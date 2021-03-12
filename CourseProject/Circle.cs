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
    public partial class Circle : Form
    {
        public float Element1 { get; set; }
        public int FigureChoosed { get; set; }
        public Color Color { get; set; }
        public TextBox textBox1 { get; set; }
        public Circle()
        {
            InitializeComponent();
            textBox1 = textBoxCircle;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(textBoxCircle.Text != "" && float.Parse(textBoxCircle.Text) <= 100 && float.Parse(textBoxCircle.Text) != 0)
            {
                FigureChoosed = 4;
                Element1 = float.Parse(textBoxCircle.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There is not entered value or it is invalid!");
            }
            
        }

        private void ChooseColCir_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogCirlce = new ColorDialog();
            if(colorDialogCirlce.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialogCirlce.Color;
            }
        }

        private void textBoxCircle_KeyPress(object sender, KeyPressEventArgs e)
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
