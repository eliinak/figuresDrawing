namespace CourseProject_
{
    partial class Triangle
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
            this.Side1 = new System.Windows.Forms.Label();
            this.Side2 = new System.Windows.Forms.Label();
            this.Side3 = new System.Windows.Forms.Label();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.textBoxSide3 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.ColorsTriangle = new System.Windows.Forms.Label();
            this.ChooseColTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Side1
            // 
            this.Side1.AutoSize = true;
            this.Side1.Location = new System.Drawing.Point(38, 35);
            this.Side1.Name = "Side1";
            this.Side1.Size = new System.Drawing.Size(36, 17);
            this.Side1.TabIndex = 0;
            this.Side1.Text = "Side";
            // 
            // Side2
            // 
            this.Side2.AutoSize = true;
            this.Side2.Location = new System.Drawing.Point(38, 133);
            this.Side2.Name = "Side2";
            this.Side2.Size = new System.Drawing.Size(36, 17);
            this.Side2.TabIndex = 1;
            this.Side2.Text = "SIde";
            // 
            // Side3
            // 
            this.Side3.AutoSize = true;
            this.Side3.Location = new System.Drawing.Point(38, 235);
            this.Side3.Name = "Side3";
            this.Side3.Size = new System.Drawing.Size(36, 17);
            this.Side3.TabIndex = 2;
            this.Side3.Text = "Side";
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSide1.Location = new System.Drawing.Point(38, 65);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(100, 22);
            this.textBoxSide1.TabIndex = 3;
            this.textBoxSide1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide1_KeyPress);
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSide2.Location = new System.Drawing.Point(38, 164);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(100, 22);
            this.textBoxSide2.TabIndex = 4;
            this.textBoxSide2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide2_KeyPress);
            // 
            // textBoxSide3
            // 
            this.textBoxSide3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSide3.Location = new System.Drawing.Point(38, 270);
            this.textBoxSide3.Name = "textBoxSide3";
            this.textBoxSide3.Size = new System.Drawing.Size(100, 22);
            this.textBoxSide3.TabIndex = 5;
            this.textBoxSide3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide3_KeyPress);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK.Location = new System.Drawing.Point(252, 350);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 32);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorsTriangle
            // 
            this.ColorsTriangle.AutoSize = true;
            this.ColorsTriangle.Location = new System.Drawing.Point(249, 35);
            this.ColorsTriangle.Name = "ColorsTriangle";
            this.ColorsTriangle.Size = new System.Drawing.Size(48, 17);
            this.ColorsTriangle.TabIndex = 7;
            this.ColorsTriangle.Text = "Colors";
            // 
            // ChooseColTriangle
            // 
            this.ChooseColTriangle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseColTriangle.Location = new System.Drawing.Point(252, 63);
            this.ChooseColTriangle.Name = "ChooseColTriangle";
            this.ChooseColTriangle.Size = new System.Drawing.Size(122, 23);
            this.ChooseColTriangle.TabIndex = 8;
            this.ChooseColTriangle.Text = "Choose";
            this.ChooseColTriangle.UseVisualStyleBackColor = false;
            this.ChooseColTriangle.Click += new System.EventHandler(this.ChooseColTriangle_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::CourseProject_.Properties.Resources.tr;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.ChooseColTriangle);
            this.Controls.Add(this.ColorsTriangle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxSide3);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.textBoxSide1);
            this.Controls.Add(this.Side3);
            this.Controls.Add(this.Side2);
            this.Controls.Add(this.Side1);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Side1;
        private System.Windows.Forms.Label Side2;
        private System.Windows.Forms.Label Side3;
        private System.Windows.Forms.TextBox textBoxSide1;
        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.TextBox textBoxSide3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label ColorsTriangle;
        private System.Windows.Forms.Button ChooseColTriangle;
    }
}