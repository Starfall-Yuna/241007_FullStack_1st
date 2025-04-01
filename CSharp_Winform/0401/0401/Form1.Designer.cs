// Form.cs에 요소 추가할때마다 코드 자동 생성

namespace _0401
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
            this.버튼 = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.multi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // 버튼
            // 
            this.버튼.Font = new System.Drawing.Font("굴림", 15F);
            this.버튼.Location = new System.Drawing.Point(250, 86);
            this.버튼.Name = "버튼";
            this.버튼.Size = new System.Drawing.Size(120, 44);
            this.버튼.TabIndex = 0;
            this.버튼.Text = "버튼";
            this.버튼.UseVisualStyleBackColor = true;
            this.버튼.Click += new System.EventHandler(this.버튼_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.PaleGreen;
            this.welcome_label.Font = new System.Drawing.Font("D2Coding", 15F);
            this.welcome_label.Location = new System.Drawing.Point(31, 97);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(190, 23);
            this.welcome_label.TabIndex = 4;
            this.welcome_label.Text = "버튼을 클릭하시오.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("D2Coding", 15F);
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "(이벤트 아이콘에서 이벤트 정보 확인 가능)";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(36, 291);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 21);
            this.num1.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(159, 291);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 21);
            this.num2.TabIndex = 7;
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("굴림", 12F);
            this.calc_button.Location = new System.Drawing.Point(281, 279);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(120, 43);
            this.calc_button.TabIndex = 8;
            this.calc_button.Text = "연산 수행";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("굴림", 12F);
            this.plus.Location = new System.Drawing.Point(36, 337);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(77, 20);
            this.plus.TabIndex = 9;
            this.plus.TabStop = true;
            this.plus.Text = "덧셈(+)";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("굴림", 12F);
            this.sub.Location = new System.Drawing.Point(130, 337);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(77, 20);
            this.sub.TabIndex = 10;
            this.sub.TabStop = true;
            this.sub.Text = "뺄셈(-)";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Font = new System.Drawing.Font("굴림", 12F);
            this.multi.Location = new System.Drawing.Point(228, 337);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(76, 20);
            this.multi.TabIndex = 11;
            this.multi.TabStop = true;
            this.multi.Text = "곱셈(*)";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.버튼);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 버튼;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.RadioButton multi;
    }
}

