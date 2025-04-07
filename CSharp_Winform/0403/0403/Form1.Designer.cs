namespace _0403
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_num1 = new System.Windows.Forms.TextBox();
            this.input_num2 = new System.Windows.Forms.TextBox();
            this.ExecuteCalc = new System.Windows.Forms.Button();
            this.print_calc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_num1
            // 
            this.input_num1.Font = new System.Drawing.Font("굴림", 12F);
            this.input_num1.Location = new System.Drawing.Point(47, 43);
            this.input_num1.Name = "input_num1";
            this.input_num1.Size = new System.Drawing.Size(100, 26);
            this.input_num1.TabIndex = 0;
            // 
            // input_num2
            // 
            this.input_num2.Font = new System.Drawing.Font("굴림", 12F);
            this.input_num2.Location = new System.Drawing.Point(184, 43);
            this.input_num2.Name = "input_num2";
            this.input_num2.Size = new System.Drawing.Size(100, 26);
            this.input_num2.TabIndex = 1;
            // 
            // ExecuteCalc
            // 
            this.ExecuteCalc.Font = new System.Drawing.Font("굴림", 12F);
            this.ExecuteCalc.Location = new System.Drawing.Point(325, 34);
            this.ExecuteCalc.Name = "ExecuteCalc";
            this.ExecuteCalc.Size = new System.Drawing.Size(107, 41);
            this.ExecuteCalc.TabIndex = 2;
            this.ExecuteCalc.Text = "나눗셈 진행";
            this.ExecuteCalc.UseVisualStyleBackColor = true;
            this.ExecuteCalc.Click += new System.EventHandler(this.ExecuteCalc_Click);
            // 
            // print_calc
            // 
            this.print_calc.AutoSize = true;
            this.print_calc.Font = new System.Drawing.Font("굴림", 12F);
            this.print_calc.Location = new System.Drawing.Point(44, 111);
            this.print_calc.Name = "print_calc";
            this.print_calc.Size = new System.Drawing.Size(252, 16);
            this.print_calc.TabIndex = 3;
            this.print_calc.Text = "<연산 기록이 여기에 입력됩니다>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print_calc);
            this.Controls.Add(this.ExecuteCalc);
            this.Controls.Add(this.input_num2);
            this.Controls.Add(this.input_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_num1;
        private System.Windows.Forms.TextBox input_num2;
        private System.Windows.Forms.Button ExecuteCalc;
        private System.Windows.Forms.Label print_calc;
    }
}

