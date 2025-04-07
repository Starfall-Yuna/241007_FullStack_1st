namespace _0404
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.ExecuteCalc = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.multi = new System.Windows.Forms.RadioButton();
            this.divide1 = new System.Windows.Forms.RadioButton();
            this.divide2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("굴림", 12F);
            this.num1.Location = new System.Drawing.Point(43, 68);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(112, 26);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("굴림", 12F);
            this.num2.Location = new System.Drawing.Point(189, 68);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(112, 26);
            this.num2.TabIndex = 1;
            // 
            // ExecuteCalc
            // 
            this.ExecuteCalc.Font = new System.Drawing.Font("굴림", 12F);
            this.ExecuteCalc.Location = new System.Drawing.Point(347, 68);
            this.ExecuteCalc.Name = "ExecuteCalc";
            this.ExecuteCalc.Size = new System.Drawing.Size(102, 46);
            this.ExecuteCalc.TabIndex = 2;
            this.ExecuteCalc.Text = "연산 수행";
            this.ExecuteCalc.UseVisualStyleBackColor = true;
            this.ExecuteCalc.Click += new System.EventHandler(this.ExecuteCalc_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("굴림", 12F);
            this.plus.Location = new System.Drawing.Point(43, 116);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(33, 20);
            this.plus.TabIndex = 3;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("굴림", 12F);
            this.minus.Location = new System.Drawing.Point(97, 116);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(33, 20);
            this.minus.TabIndex = 4;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Font = new System.Drawing.Font("굴림", 12F);
            this.multi.Location = new System.Drawing.Point(147, 116);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(32, 20);
            this.multi.TabIndex = 5;
            this.multi.TabStop = true;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // divide1
            // 
            this.divide1.AutoSize = true;
            this.divide1.Font = new System.Drawing.Font("굴림", 12F);
            this.divide1.Location = new System.Drawing.Point(192, 116);
            this.divide1.Name = "divide1";
            this.divide1.Size = new System.Drawing.Size(31, 20);
            this.divide1.TabIndex = 6;
            this.divide1.TabStop = true;
            this.divide1.Text = "/";
            this.divide1.UseVisualStyleBackColor = true;
            // 
            // divide2
            // 
            this.divide2.AutoSize = true;
            this.divide2.Font = new System.Drawing.Font("굴림", 12F);
            this.divide2.Location = new System.Drawing.Point(243, 116);
            this.divide2.Name = "divide2";
            this.divide2.Size = new System.Drawing.Size(39, 20);
            this.divide2.TabIndex = 7;
            this.divide2.TabStop = true;
            this.divide2.Text = "%";
            this.divide2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divide2);
            this.Controls.Add(this.divide1);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.ExecuteCalc);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button ExecuteCalc;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton multi;
        private System.Windows.Forms.RadioButton divide1;
        private System.Windows.Forms.RadioButton divide2;
    }
}