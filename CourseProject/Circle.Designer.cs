namespace CourseProject_
{
    partial class Circle
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
            this.Radius = new System.Windows.Forms.Label();
            this.textBoxCircle = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.ColorsCircle = new System.Windows.Forms.Label();
            this.ChooseColCir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(12, 32);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(52, 17);
            this.Radius.TabIndex = 0;
            this.Radius.Text = "Radius";
            // 
            // textBoxCircle
            // 
            this.textBoxCircle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxCircle.Location = new System.Drawing.Point(12, 67);
            this.textBoxCircle.Name = "textBoxCircle";
            this.textBoxCircle.Size = new System.Drawing.Size(107, 22);
            this.textBoxCircle.TabIndex = 1;
            this.textBoxCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCircle_KeyPress);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OK.Location = new System.Drawing.Point(250, 299);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(117, 33);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorsCircle
            // 
            this.ColorsCircle.AutoSize = true;
            this.ColorsCircle.Location = new System.Drawing.Point(239, 32);
            this.ColorsCircle.Name = "ColorsCircle";
            this.ColorsCircle.Size = new System.Drawing.Size(48, 17);
            this.ColorsCircle.TabIndex = 3;
            this.ColorsCircle.Text = "Colors";
            // 
            // ChooseColCir
            // 
            this.ChooseColCir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseColCir.Location = new System.Drawing.Point(242, 67);
            this.ChooseColCir.Name = "ChooseColCir";
            this.ChooseColCir.Size = new System.Drawing.Size(107, 31);
            this.ChooseColCir.TabIndex = 4;
            this.ChooseColCir.Text = "Choose";
            this.ChooseColCir.UseVisualStyleBackColor = false;
            this.ChooseColCir.Click += new System.EventHandler(this.ChooseColCir_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::CourseProject_.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(397, 361);
            this.Controls.Add(this.ChooseColCir);
            this.Controls.Add(this.ColorsCircle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxCircle);
            this.Controls.Add(this.Radius);
            this.Name = "Circle";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.TextBox textBoxCircle;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label ColorsCircle;
        private System.Windows.Forms.Button ChooseColCir;
    }
}