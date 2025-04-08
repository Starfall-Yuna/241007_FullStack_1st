namespace _0408
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
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.text_loca = new System.Windows.Forms.TextBox();
            this.insert_xy = new System.Windows.Forms.Button();
            this.print_xy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_x
            // 
            this.text_x.Location = new System.Drawing.Point(38, 56);
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(120, 21);
            this.text_x.TabIndex = 0;
            // 
            // text_y
            // 
            this.text_y.Location = new System.Drawing.Point(38, 117);
            this.text_y.Name = "text_y";
            this.text_y.Size = new System.Drawing.Size(120, 21);
            this.text_y.TabIndex = 1;
            // 
            // text_loca
            // 
            this.text_loca.Location = new System.Drawing.Point(38, 182);
            this.text_loca.Name = "text_loca";
            this.text_loca.Size = new System.Drawing.Size(120, 21);
            this.text_loca.TabIndex = 2;
            // 
            // insert_xy
            // 
            this.insert_xy.Font = new System.Drawing.Font("굴림", 12F);
            this.insert_xy.Location = new System.Drawing.Point(38, 246);
            this.insert_xy.Name = "insert_xy";
            this.insert_xy.Size = new System.Drawing.Size(120, 43);
            this.insert_xy.TabIndex = 3;
            this.insert_xy.Text = "좌표 추가";
            this.insert_xy.UseVisualStyleBackColor = true;
            this.insert_xy.Click += new System.EventHandler(this.insert_xy_Click);
            // 
            // print_xy
            // 
            this.print_xy.AutoSize = true;
            this.print_xy.Font = new System.Drawing.Font("굴림", 12F);
            this.print_xy.Location = new System.Drawing.Point(227, 56);
            this.print_xy.Name = "print_xy";
            this.print_xy.Size = new System.Drawing.Size(204, 16);
            this.print_xy.TabIndex = 4;
            this.print_xy.Text = "<위치 정보가 출력됩니다.>";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print_xy);
            this.Controls.Add(this.insert_xy);
            this.Controls.Add(this.text_loca);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.TextBox text_loca;
        private System.Windows.Forms.Button insert_xy;
        private System.Windows.Forms.Label print_xy;
    }
}