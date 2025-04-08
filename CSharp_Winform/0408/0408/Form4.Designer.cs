namespace _0408
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.in_btn = new System.Windows.Forms.Button();
            this.out_btn = new System.Windows.Forms.Button();
            this.print_list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("굴림", 12F);
            this.name_input.Location = new System.Drawing.Point(80, 35);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(152, 26);
            this.name_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름: ";
            // 
            // in_btn
            // 
            this.in_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.in_btn.Location = new System.Drawing.Point(27, 76);
            this.in_btn.Name = "in_btn";
            this.in_btn.Size = new System.Drawing.Size(94, 38);
            this.in_btn.TabIndex = 2;
            this.in_btn.Text = "출근계";
            this.in_btn.UseVisualStyleBackColor = true;
            this.in_btn.Click += new System.EventHandler(this.in_btn_Click);
            // 
            // out_btn
            // 
            this.out_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.out_btn.Location = new System.Drawing.Point(152, 76);
            this.out_btn.Name = "out_btn";
            this.out_btn.Size = new System.Drawing.Size(94, 38);
            this.out_btn.TabIndex = 3;
            this.out_btn.Text = "퇴근계";
            this.out_btn.UseVisualStyleBackColor = true;
            this.out_btn.Click += new System.EventHandler(this.out_btn_Click);
            // 
            // print_list
            // 
            this.print_list.AutoSize = true;
            this.print_list.Font = new System.Drawing.Font("굴림", 12F);
            this.print_list.Location = new System.Drawing.Point(25, 145);
            this.print_list.Name = "print_list";
            this.print_list.Size = new System.Drawing.Size(40, 16);
            this.print_list.TabIndex = 4;
            this.print_list.Text = "label";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print_list);
            this.Controls.Add(this.out_btn);
            this.Controls.Add(this.in_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_input);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button in_btn;
        private System.Windows.Forms.Button out_btn;
        private System.Windows.Forms.Label print_list;
    }
}