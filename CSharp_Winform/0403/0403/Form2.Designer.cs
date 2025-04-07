namespace _0403
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.gender_input = new System.Windows.Forms.TextBox();
            this.age_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insert_data = new System.Windows.Forms.Button();
            this.print_adult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "인적사항을 입력해주세요.";
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("D2Coding", 12F);
            this.name_input.Location = new System.Drawing.Point(109, 96);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(147, 26);
            this.name_input.TabIndex = 1;
            // 
            // gender_input
            // 
            this.gender_input.Font = new System.Drawing.Font("D2Coding", 12F);
            this.gender_input.Location = new System.Drawing.Point(109, 228);
            this.gender_input.Name = "gender_input";
            this.gender_input.Size = new System.Drawing.Size(147, 26);
            this.gender_input.TabIndex = 2;
            // 
            // age_input
            // 
            this.age_input.Font = new System.Drawing.Font("D2Coding", 12F);
            this.age_input.Location = new System.Drawing.Point(109, 160);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(147, 26);
            this.age_input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label2.Location = new System.Drawing.Point(45, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "성별: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label3.Location = new System.Drawing.Point(45, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "나이: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label4.Location = new System.Drawing.Point(45, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "이름: ";
            // 
            // insert_data
            // 
            this.insert_data.Font = new System.Drawing.Font("D2Coding", 12F);
            this.insert_data.Location = new System.Drawing.Point(181, 286);
            this.insert_data.Name = "insert_data";
            this.insert_data.Size = new System.Drawing.Size(75, 36);
            this.insert_data.TabIndex = 7;
            this.insert_data.Text = "입력";
            this.insert_data.UseVisualStyleBackColor = true;
            this.insert_data.Click += new System.EventHandler(this.insert_data_Click);
            // 
            // print_adult
            // 
            this.print_adult.AutoSize = true;
            this.print_adult.Font = new System.Drawing.Font("D2Coding", 12F);
            this.print_adult.Location = new System.Drawing.Point(349, 38);
            this.print_adult.Name = "print_adult";
            this.print_adult.Size = new System.Drawing.Size(224, 18);
            this.print_adult.TabIndex = 8;
            this.print_adult.Text = "<성인의 정보만 출력됩니다.>";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 365);
            this.Controls.Add(this.print_adult);
            this.Controls.Add(this.insert_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.age_input);
            this.Controls.Add(this.gender_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox gender_input;
        private System.Windows.Forms.TextBox age_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insert_data;
        private System.Windows.Forms.Label print_adult;
    }
}