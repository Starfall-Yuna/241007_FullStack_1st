namespace _0408
{
    partial class Form3
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
            this.input_x = new System.Windows.Forms.TextBox();
            this.input_y = new System.Windows.Forms.TextBox();
            this.location_button = new System.Windows.Forms.Button();
            this.element = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_x
            // 
            this.input_x.Location = new System.Drawing.Point(12, 12);
            this.input_x.Name = "input_x";
            this.input_x.Size = new System.Drawing.Size(100, 21);
            this.input_x.TabIndex = 0;
            // 
            // input_y
            // 
            this.input_y.Location = new System.Drawing.Point(128, 12);
            this.input_y.Name = "input_y";
            this.input_y.Size = new System.Drawing.Size(100, 21);
            this.input_y.TabIndex = 1;
            // 
            // location_button
            // 
            this.location_button.Font = new System.Drawing.Font("굴림", 12F);
            this.location_button.Location = new System.Drawing.Point(245, 12);
            this.location_button.Name = "location_button";
            this.location_button.Size = new System.Drawing.Size(94, 23);
            this.location_button.TabIndex = 2;
            this.location_button.Text = "좌표 이동";
            this.location_button.UseVisualStyleBackColor = true;
            this.location_button.Click += new System.EventHandler(this.location_button_Click);
            // 
            // element
            // 
            this.element.AutoSize = true;
            this.element.Location = new System.Drawing.Point(12, 47);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(29, 12);
            this.element.TabIndex = 3;
            this.element.Text = "요소";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.element);
            this.Controls.Add(this.location_button);
            this.Controls.Add(this.input_y);
            this.Controls.Add(this.input_x);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_x;
        private System.Windows.Forms.TextBox input_y;
        private System.Windows.Forms.Button location_button;
        private System.Windows.Forms.Label element;
    }
}