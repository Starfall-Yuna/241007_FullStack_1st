﻿namespace _0407
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_string = new System.Windows.Forms.TextBox();
            this.revert_upper = new System.Windows.Forms.Button();
            this.revert_lower = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "영문자를 입력해주세요.";
            // 
            // input_string
            // 
            this.input_string.Font = new System.Drawing.Font("굴림", 12F);
            this.input_string.Location = new System.Drawing.Point(31, 85);
            this.input_string.Name = "input_string";
            this.input_string.Size = new System.Drawing.Size(259, 26);
            this.input_string.TabIndex = 1;
            // 
            // revert_upper
            // 
            this.revert_upper.Font = new System.Drawing.Font("굴림", 12F);
            this.revert_upper.Location = new System.Drawing.Point(31, 147);
            this.revert_upper.Name = "revert_upper";
            this.revert_upper.Size = new System.Drawing.Size(95, 42);
            this.revert_upper.TabIndex = 2;
            this.revert_upper.Text = "대문자로";
            this.revert_upper.UseVisualStyleBackColor = true;
            this.revert_upper.Click += new System.EventHandler(this.revert_upper_Click);
            // 
            // revert_lower
            // 
            this.revert_lower.Font = new System.Drawing.Font("굴림", 12F);
            this.revert_lower.Location = new System.Drawing.Point(155, 147);
            this.revert_lower.Name = "revert_lower";
            this.revert_lower.Size = new System.Drawing.Size(97, 42);
            this.revert_lower.TabIndex = 3;
            this.revert_lower.Text = "소문자로";
            this.revert_lower.UseVisualStyleBackColor = true;
            this.revert_lower.Click += new System.EventHandler(this.revert_lower_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("굴림", 12F);
            this.sum.Location = new System.Drawing.Point(282, 147);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(101, 42);
            this.sum.TabIndex = 4;
            this.sum.Text = "코드값 합";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.revert_lower);
            this.Controls.Add(this.revert_upper);
            this.Controls.Add(this.input_string);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_string;
        private System.Windows.Forms.Button revert_upper;
        private System.Windows.Forms.Button revert_lower;
        private System.Windows.Forms.Button sum;
    }
}

