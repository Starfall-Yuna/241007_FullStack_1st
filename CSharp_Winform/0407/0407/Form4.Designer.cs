namespace _0407
{
    partial class Form4
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
            this.print_adult = new System.Windows.Forms.Button();
            this.pring_kids = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print_adult
            // 
            this.print_adult.Font = new System.Drawing.Font("굴림", 12F);
            this.print_adult.Location = new System.Drawing.Point(29, 37);
            this.print_adult.Name = "print_adult";
            this.print_adult.Size = new System.Drawing.Size(110, 58);
            this.print_adult.TabIndex = 0;
            this.print_adult.Text = "성인만 출력";
            this.print_adult.UseVisualStyleBackColor = true;
            this.print_adult.Click += new System.EventHandler(this.print_adult_Click);
            // 
            // pring_kids
            // 
            this.pring_kids.Font = new System.Drawing.Font("굴림", 12F);
            this.pring_kids.Location = new System.Drawing.Point(170, 37);
            this.pring_kids.Name = "pring_kids";
            this.pring_kids.Size = new System.Drawing.Size(118, 58);
            this.pring_kids.TabIndex = 1;
            this.pring_kids.Text = "미성년만 출력";
            this.pring_kids.UseVisualStyleBackColor = true;
            this.pring_kids.Click += new System.EventHandler(this.pring_kids_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pring_kids);
            this.Controls.Add(this.print_adult);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button print_adult;
        private System.Windows.Forms.Button pring_kids;
    }
}