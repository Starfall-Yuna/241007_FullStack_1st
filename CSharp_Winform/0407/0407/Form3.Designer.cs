namespace _0407
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
            this.input_num = new System.Windows.Forms.TextBox();
            this.execute_plus = new System.Windows.Forms.Button();
            this.execute_multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_num
            // 
            this.input_num.Font = new System.Drawing.Font("굴림", 12F);
            this.input_num.Location = new System.Drawing.Point(29, 58);
            this.input_num.Name = "input_num";
            this.input_num.Size = new System.Drawing.Size(166, 26);
            this.input_num.TabIndex = 0;
            // 
            // execute_plus
            // 
            this.execute_plus.Font = new System.Drawing.Font("굴림", 12F);
            this.execute_plus.Location = new System.Drawing.Point(235, 47);
            this.execute_plus.Name = "execute_plus";
            this.execute_plus.Size = new System.Drawing.Size(88, 43);
            this.execute_plus.TabIndex = 1;
            this.execute_plus.Text = "덧셈 수행";
            this.execute_plus.UseVisualStyleBackColor = true;
            this.execute_plus.Click += new System.EventHandler(this.execute_plus_Click);
            // 
            // execute_multi
            // 
            this.execute_multi.Font = new System.Drawing.Font("굴림", 12F);
            this.execute_multi.Location = new System.Drawing.Point(355, 47);
            this.execute_multi.Name = "execute_multi";
            this.execute_multi.Size = new System.Drawing.Size(88, 43);
            this.execute_multi.TabIndex = 2;
            this.execute_multi.Text = "곱셈 수행";
            this.execute_multi.UseVisualStyleBackColor = true;
            this.execute_multi.Click += new System.EventHandler(this.execute_multi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.execute_multi);
            this.Controls.Add(this.execute_plus);
            this.Controls.Add(this.input_num);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.Button execute_plus;
        private System.Windows.Forms.Button execute_multi;
    }
}