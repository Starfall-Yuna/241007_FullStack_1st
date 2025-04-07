namespace _0404
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insert_data = new System.Windows.Forms.Button();
            this.print_name = new System.Windows.Forms.Button();
            this.print_price = new System.Windows.Forms.Button();
            this.print_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품 입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label2.Location = new System.Drawing.Point(392, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "<여기에 상품 정보가 표시됩니다.>";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(138, 80);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 21);
            this.name_input.TabIndex = 2;
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(138, 120);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(100, 21);
            this.price_input.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label3.Location = new System.Drawing.Point(76, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label4.Location = new System.Drawing.Point(76, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "가격: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label5.Location = new System.Drawing.Point(118, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "상품 정보 조회";
            // 
            // num_input
            // 
            this.num_input.Location = new System.Drawing.Point(189, 275);
            this.num_input.Name = "num_input";
            this.num_input.Size = new System.Drawing.Size(100, 21);
            this.num_input.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("D2Coding", 12F);
            this.label6.Location = new System.Drawing.Point(47, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "상품 번호 입력: ";
            // 
            // insert_data
            // 
            this.insert_data.Font = new System.Drawing.Font("D2Coding", 12F);
            this.insert_data.Location = new System.Drawing.Point(121, 158);
            this.insert_data.Name = "insert_data";
            this.insert_data.Size = new System.Drawing.Size(102, 35);
            this.insert_data.TabIndex = 9;
            this.insert_data.Text = "입력";
            this.insert_data.UseVisualStyleBackColor = true;
            this.insert_data.Click += new System.EventHandler(this.insert_data_Click);
            // 
            // print_name
            // 
            this.print_name.Font = new System.Drawing.Font("D2Coding", 12F);
            this.print_name.Location = new System.Drawing.Point(59, 311);
            this.print_name.Name = "print_name";
            this.print_name.Size = new System.Drawing.Size(102, 35);
            this.print_name.TabIndex = 10;
            this.print_name.Text = "이름 조회";
            this.print_name.UseVisualStyleBackColor = true;
            this.print_name.Click += new System.EventHandler(this.print_name_Click);
            // 
            // print_price
            // 
            this.print_price.Font = new System.Drawing.Font("D2Coding", 12F);
            this.print_price.Location = new System.Drawing.Point(185, 311);
            this.print_price.Name = "print_price";
            this.print_price.Size = new System.Drawing.Size(102, 35);
            this.print_price.TabIndex = 11;
            this.print_price.Text = "가격 조회";
            this.print_price.UseVisualStyleBackColor = true;
            this.print_price.Click += new System.EventHandler(this.print_price_Click);
            // 
            // print_all
            // 
            this.print_all.Font = new System.Drawing.Font("D2Coding", 12F);
            this.print_all.Location = new System.Drawing.Point(59, 361);
            this.print_all.Name = "print_all";
            this.print_all.Size = new System.Drawing.Size(226, 35);
            this.print_all.TabIndex = 12;
            this.print_all.Text = "전체 조회";
            this.print_all.UseVisualStyleBackColor = true;
            this.print_all.Click += new System.EventHandler(this.print_all_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print_all);
            this.Controls.Add(this.print_price);
            this.Controls.Add(this.print_name);
            this.Controls.Add(this.insert_data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert_data;
        private System.Windows.Forms.Button print_name;
        private System.Windows.Forms.Button print_price;
        private System.Windows.Forms.Button print_all;
    }
}