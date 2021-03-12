namespace CourseProject_
{
    partial class Rectangle
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
            this.WidthRectangle = new System.Windows.Forms.Label();
            this.HeightRectangle = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.ColorsRectangle = new System.Windows.Forms.Label();
            this.ChooseColRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WidthRectangle
            // 
            this.WidthRectangle.AutoSize = true;
            this.WidthRectangle.Location = new System.Drawing.Point(16, 25);
            this.WidthRectangle.Name = "WidthRectangle";
            this.WidthRectangle.Size = new System.Drawing.Size(44, 17);
            this.WidthRectangle.TabIndex = 0;
            this.WidthRectangle.Text = "Width";
            // 
            // HeightRectangle
            // 
            this.HeightRectangle.AutoSize = true;
            this.HeightRectangle.Location = new System.Drawing.Point(16, 124);
            this.HeightRectangle.Name = "HeightRectangle";
            this.HeightRectangle.Size = new System.Drawing.Size(49, 17);
            this.HeightRectangle.TabIndex = 1;
            this.HeightRectangle.Text = "Height";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.AcceptsReturn = true;
            this.textBoxWidth.AcceptsTab = true;
            this.textBoxWidth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxWidth.Location = new System.Drawing.Point(19, 58);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxHeight.Location = new System.Drawing.Point(19, 164);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK.Location = new System.Drawing.Point(275, 328);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(112, 31);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorsRectangle
            // 
            this.ColorsRectangle.AutoSize = true;
            this.ColorsRectangle.Location = new System.Drawing.Point(254, 49);
            this.ColorsRectangle.Name = "ColorsRectangle";
            this.ColorsRectangle.Size = new System.Drawing.Size(48, 17);
            this.ColorsRectangle.TabIndex = 5;
            this.ColorsRectangle.Text = "Colors";
            // 
            // ChooseColRec
            // 
            this.ChooseColRec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseColRec.Location = new System.Drawing.Point(257, 96);
            this.ChooseColRec.Name = "ChooseColRec";
            this.ChooseColRec.Size = new System.Drawing.Size(120, 27);
            this.ChooseColRec.TabIndex = 6;
            this.ChooseColRec.Text = "Choose";
            this.ChooseColRec.UseVisualStyleBackColor = false;
            this.ChooseColRec.Click += new System.EventHandler(this.ChooseColRec_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::CourseProject_.Properties.Resources.Myrectangle1;
            this.ClientSize = new System.Drawing.Size(407, 380);
            this.Controls.Add(this.ChooseColRec);
            this.Controls.Add(this.ColorsRectangle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.HeightRectangle);
            this.Controls.Add(this.WidthRectangle);
            this.Name = "Rectangle";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WidthRectangle;
        private System.Windows.Forms.Label HeightRectangle;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label ColorsRectangle;
        private System.Windows.Forms.Button ChooseColRec;
    }
}