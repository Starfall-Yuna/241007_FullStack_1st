namespace _0409
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
            this.name_input = new System.Windows.Forms.TextBox();
            this.in_button = new System.Windows.Forms.Button();
            this.out_button = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(26, 43);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(216, 21);
            this.name_input.TabIndex = 0;
            // 
            // in_button
            // 
            this.in_button.Font = new System.Drawing.Font("굴림", 12F);
            this.in_button.Location = new System.Drawing.Point(26, 88);
            this.in_button.Name = "in_button";
            this.in_button.Size = new System.Drawing.Size(98, 42);
            this.in_button.TabIndex = 1;
            this.in_button.Text = "출근계";
            this.in_button.UseVisualStyleBackColor = true;
            this.in_button.Click += new System.EventHandler(this.in_button_Click);
            // 
            // out_button
            // 
            this.out_button.Font = new System.Drawing.Font("굴림", 12F);
            this.out_button.Location = new System.Drawing.Point(143, 88);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(98, 42);
            this.out_button.TabIndex = 2;
            this.out_button.Text = "퇴근계";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.out_button_Click);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Font = new System.Drawing.Font("굴림", 12F);
            this.list.Location = new System.Drawing.Point(23, 147);
            this.list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(167, 16);
            this.list.TabIndex = 3;
            this.list.Text = "<여기에 기록됩니다.>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list);
            this.Controls.Add(this.out_button);
            this.Controls.Add(this.in_button);
            this.Controls.Add(this.name_input);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Button in_button;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Label list;
    }
}

