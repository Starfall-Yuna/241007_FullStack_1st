namespace _0402
{
    partial class Form2

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
            this.number = new System.Windows.Forms.TextBox();
            this.add_number = new System.Windows.Forms.Button();
            this.print_number = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.select_index = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(32, 37);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(128, 21);
            this.number.TabIndex = 0;
            this.number.Text = "9";
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // add_number
            // 
            this.add_number.Location = new System.Drawing.Point(184, 31);
            this.add_number.Name = "add_number";
            this.add_number.Size = new System.Drawing.Size(82, 31);
            this.add_number.TabIndex = 1;
            this.add_number.Text = "숫자 추가";
            this.add_number.UseVisualStyleBackColor = true;
            this.add_number.Click += new System.EventHandler(this.add_number_Click);
            // 
            // print_number
            // 
            this.print_number.AutoSize = true;
            this.print_number.Location = new System.Drawing.Point(329, 37);
            this.print_number.Name = "print_number";
            this.print_number.Size = new System.Drawing.Size(77, 12);
            this.print_number.TabIndex = 2;
            this.print_number.Text = "\"표시될 공간\"";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(184, 80);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(82, 31);
            this.add.TabIndex = 3;
            this.add.Text = "덧셈 결과";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // select_index
            // 
            this.select_index.Location = new System.Drawing.Point(32, 86);
            this.select_index.Name = "select_index";
            this.select_index.Size = new System.Drawing.Size(128, 21);
            this.select_index.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.select_index);
            this.Controls.Add(this.add);
            this.Controls.Add(this.print_number);
            this.Controls.Add(this.add_number);
            this.Controls.Add(this.number);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button add_number;
        private System.Windows.Forms.Label print_number;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox select_index;
    }
}