namespace _0402
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
            this.input_box = new System.Windows.Forms.TextBox();
            this.add_element = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(49, 54);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(136, 21);
            this.input_box.TabIndex = 0;
            // 
            // add_element
            // 
            this.add_element.Location = new System.Drawing.Point(216, 52);
            this.add_element.Name = "add_element";
            this.add_element.Size = new System.Drawing.Size(75, 23);
            this.add_element.TabIndex = 1;
            this.add_element.Text = "요소 입력";
            this.add_element.UseVisualStyleBackColor = true;
            this.add_element.Click += new System.EventHandler(this.add_element_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "<숫자 정보가 나타납니다>";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_element);
            this.Controls.Add(this.input_box);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Button add_element;
        private System.Windows.Forms.Label label1;
    }
}