namespace CourseProject_
{
    partial class Square
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
            this.SideSquare = new System.Windows.Forms.Label();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.ColorsSquare = new System.Windows.Forms.Label();
            this.ChooseColSqu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SideSquare
            // 
            this.SideSquare.AutoSize = true;
            this.SideSquare.Location = new System.Drawing.Point(23, 38);
            this.SideSquare.Name = "SideSquare";
            this.SideSquare.Size = new System.Drawing.Size(36, 17);
            this.SideSquare.TabIndex = 0;
            this.SideSquare.Text = "Side";
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSquare.Location = new System.Drawing.Point(26, 75);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(104, 22);
            this.textBoxSquare.TabIndex = 1;
            this.textBoxSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSquare_KeyPress);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK.Location = new System.Drawing.Point(253, 308);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(112, 31);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorsSquare
            // 
            this.ColorsSquare.AutoSize = true;
            this.ColorsSquare.Location = new System.Drawing.Point(250, 38);
            this.ColorsSquare.Name = "ColorsSquare";
            this.ColorsSquare.Size = new System.Drawing.Size(48, 17);
            this.ColorsSquare.TabIndex = 3;
            this.ColorsSquare.Text = "Colors";
            // 
            // ChooseColSqu
            // 
            this.ChooseColSqu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseColSqu.Location = new System.Drawing.Point(253, 73);
            this.ChooseColSqu.Name = "ChooseColSqu";
            this.ChooseColSqu.Size = new System.Drawing.Size(112, 24);
            this.ChooseColSqu.TabIndex = 4;
            this.ChooseColSqu.Text = "Choose";
            this.ChooseColSqu.UseVisualStyleBackColor = false;
            this.ChooseColSqu.Click += new System.EventHandler(this.ChooseColSqu_Click);
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::CourseProject_.Properties.Resources.MySquare;
            this.ClientSize = new System.Drawing.Size(409, 370);
            this.Controls.Add(this.ChooseColSqu);
            this.Controls.Add(this.ColorsSquare);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.SideSquare);
            this.Name = "Square";
            this.Text = "Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SideSquare;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label ColorsSquare;
        private System.Windows.Forms.Button ChooseColSqu;
    }
}