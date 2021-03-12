namespace CourseProject_
{
    partial class Scene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Parameters = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Label();
            this.Perimeter = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.NumberFigures = new System.Windows.Forms.Label();
            this.textBoxNumberFigures = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.NumberOfFigures = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Triangle.Location = new System.Drawing.Point(8, 25);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(81, 21);
            this.Triangle.TabIndex = 0;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = false;
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Square.Location = new System.Drawing.Point(8, 108);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 21);
            this.Square.TabIndex = 1;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = false;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Rectangle.Location = new System.Drawing.Point(8, 189);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(93, 21);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = false;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Circle.Location = new System.Drawing.Point(8, 265);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(64, 21);
            this.Circle.TabIndex = 3;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = false;
            // 
            // Parameters
            // 
            this.Parameters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Parameters.Location = new System.Drawing.Point(118, 25);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(106, 23);
            this.Parameters.TabIndex = 4;
            this.Parameters.Text = "Parameters";
            this.Parameters.UseVisualStyleBackColor = false;
            this.Parameters.Click += new System.EventHandler(this.Parameters_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(20, 21);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(106, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Location = new System.Drawing.Point(143, 21);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete.Location = new System.Drawing.Point(264, 21);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(8, 316);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(38, 17);
            this.Area.TabIndex = 8;
            this.Area.Text = "Area";
            // 
            // Perimeter
            // 
            this.Perimeter.AutoSize = true;
            this.Perimeter.Location = new System.Drawing.Point(8, 398);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(69, 17);
            this.Perimeter.TabIndex = 9;
            this.Perimeter.Text = "Perimeter";
            // 
            // textBoxArea
            // 
            this.textBoxArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxArea.Location = new System.Drawing.Point(8, 346);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 22);
            this.textBoxArea.TabIndex = 10;
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPerimeter.Location = new System.Drawing.Point(11, 430);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 22);
            this.textBoxPerimeter.TabIndex = 11;
            // 
            // NumberFigures
            // 
            this.NumberFigures.AutoSize = true;
            this.NumberFigures.Location = new System.Drawing.Point(791, 376);
            this.NumberFigures.Name = "NumberFigures";
            this.NumberFigures.Size = new System.Drawing.Size(121, 17);
            this.NumberFigures.TabIndex = 12;
            this.NumberFigures.Text = "Number of figures";
            // 
            // textBoxNumberFigures
            // 
            this.textBoxNumberFigures.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumberFigures.Location = new System.Drawing.Point(118, 393);
            this.textBoxNumberFigures.Name = "textBoxNumberFigures";
            this.textBoxNumberFigures.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberFigures.TabIndex = 13;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelRight.Controls.Add(this.NumberOfFigures);
            this.panelRight.Controls.Add(this.textBoxNumberFigures);
            this.panelRight.Controls.Add(this.textBoxPerimeter);
            this.panelRight.Controls.Add(this.textBoxArea);
            this.panelRight.Controls.Add(this.Perimeter);
            this.panelRight.Controls.Add(this.Area);
            this.panelRight.Controls.Add(this.Parameters);
            this.panelRight.Controls.Add(this.Circle);
            this.panelRight.Controls.Add(this.Rectangle);
            this.panelRight.Controls.Add(this.Square);
            this.panelRight.Controls.Add(this.Triangle);
            this.panelRight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelRight.Location = new System.Drawing.Point(675, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(246, 495);
            this.panelRight.TabIndex = 14;
            // 
            // NumberOfFigures
            // 
            this.NumberOfFigures.AutoSize = true;
            this.NumberOfFigures.Location = new System.Drawing.Point(114, 359);
            this.NumberOfFigures.Name = "NumberOfFigures";
            this.NumberOfFigures.Size = new System.Drawing.Size(120, 17);
            this.NumberOfFigures.TabIndex = 14;
            this.NumberOfFigures.Text = "NumberOfFigures";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBottom.Controls.Add(this.Delete);
            this.panelBottom.Controls.Add(this.Clear);
            this.panelBottom.Controls.Add(this.Add);
            this.panelBottom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelBottom.Location = new System.Drawing.Point(-8, 430);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(684, 62);
            this.panelBottom.TabIndex = 15;
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(912, 486);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.NumberFigures);
            this.Name = "Scene";
            this.Text = "Scene";
            this.Load += new System.EventHandler(this.Scene_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseUp);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.Button Parameters;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Perimeter;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label NumberFigures;
        private System.Windows.Forms.TextBox textBoxNumberFigures;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label NumberOfFigures;
    }
}

