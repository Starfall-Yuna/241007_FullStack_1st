namespace _0402
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
            this.ExecuteCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputNum1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.CheckBox();
            this.InputNum2 = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.CheckBox();
            this.multi = new System.Windows.Forms.CheckBox();
            this.division = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExecuteCalc
            // 
            this.ExecuteCalc.Font = new System.Drawing.Font("굴림", 12F);
            this.ExecuteCalc.Location = new System.Drawing.Point(338, 91);
            this.ExecuteCalc.Name = "ExecuteCalc";
            this.ExecuteCalc.Size = new System.Drawing.Size(96, 38);
            this.ExecuteCalc.TabIndex = 0;
            this.ExecuteCalc.Text = "연산 수행";
            this.ExecuteCalc.UseVisualStyleBackColor = true;
            this.ExecuteCalc.Click += new System.EventHandler(this.ExecuteCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 15F);
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "2개의 숫자와 1개 이상의 연산자를 입력하시오";
            // 
            // InputNum1
            // 
            this.InputNum1.Font = new System.Drawing.Font("굴림", 12F);
            this.InputNum1.Location = new System.Drawing.Point(42, 99);
            this.InputNum1.Name = "InputNum1";
            this.InputNum1.Size = new System.Drawing.Size(119, 26);
            this.InputNum1.TabIndex = 2;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("굴림", 12F);
            this.plus.Location = new System.Drawing.Point(42, 140);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 20);
            this.plus.TabIndex = 3;
            this.plus.Text = "덧셈(+)";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // InputNum2
            // 
            this.InputNum2.Font = new System.Drawing.Font("굴림", 12F);
            this.InputNum2.Location = new System.Drawing.Point(179, 99);
            this.InputNum2.Name = "InputNum2";
            this.InputNum2.Size = new System.Drawing.Size(119, 26);
            this.InputNum2.TabIndex = 4;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("굴림", 12F);
            this.sub.Location = new System.Drawing.Point(127, 140);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(78, 20);
            this.sub.TabIndex = 5;
            this.sub.Text = "뺄셈(-)";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Font = new System.Drawing.Font("굴림", 12F);
            this.multi.Location = new System.Drawing.Point(217, 140);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(77, 20);
            this.multi.TabIndex = 6;
            this.multi.Text = "곱셈(*)";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Font = new System.Drawing.Font("굴림", 12F);
            this.division.Location = new System.Drawing.Point(300, 140);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(92, 20);
            this.division.TabIndex = 7;
            this.division.Text = "나눗셈(/)";
            this.division.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 533);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.InputNum2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.InputNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExecuteCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputNum1;
        private System.Windows.Forms.CheckBox plus;
        private System.Windows.Forms.TextBox InputNum2;
        private System.Windows.Forms.CheckBox sub;
        private System.Windows.Forms.CheckBox multi;
        private System.Windows.Forms.CheckBox division;
    }
}

