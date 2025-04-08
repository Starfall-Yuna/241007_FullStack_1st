namespace _0408
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
            this.print_ing = new System.Windows.Forms.Button();
            this.print_end = new System.Windows.Forms.Button();
            this.print_list = new System.Windows.Forms.Label();
            this.delete_event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print_ing
            // 
            this.print_ing.Font = new System.Drawing.Font("굴림", 12F);
            this.print_ing.Location = new System.Drawing.Point(32, 37);
            this.print_ing.Name = "print_ing";
            this.print_ing.Size = new System.Drawing.Size(107, 52);
            this.print_ing.TabIndex = 0;
            this.print_ing.Text = "재직자 명단";
            this.print_ing.UseVisualStyleBackColor = true;
            this.print_ing.Click += new System.EventHandler(this.print_ing_Click);
            // 
            // print_end
            // 
            this.print_end.Font = new System.Drawing.Font("굴림", 12F);
            this.print_end.Location = new System.Drawing.Point(182, 37);
            this.print_end.Name = "print_end";
            this.print_end.Size = new System.Drawing.Size(107, 52);
            this.print_end.TabIndex = 1;
            this.print_end.Text = "퇴사자 명단";
            this.print_end.UseVisualStyleBackColor = true;
            this.print_end.Click += new System.EventHandler(this.print_end_Click);
            // 
            // print_list
            // 
            this.print_list.AutoSize = true;
            this.print_list.Font = new System.Drawing.Font("굴림", 12F);
            this.print_list.Location = new System.Drawing.Point(30, 111);
            this.print_list.Name = "print_list";
            this.print_list.Size = new System.Drawing.Size(220, 16);
            this.print_list.TabIndex = 2;
            this.print_list.Text = "<요청한 명단이 출력됩니다.>";
            // 
            // delete_event
            // 
            this.delete_event.Font = new System.Drawing.Font("굴림", 12F);
            this.delete_event.Location = new System.Drawing.Point(664, 363);
            this.delete_event.Name = "delete_event";
            this.delete_event.Size = new System.Drawing.Size(107, 52);
            this.delete_event.TabIndex = 3;
            this.delete_event.Text = "이벤트 삭제";
            this.delete_event.UseVisualStyleBackColor = true;
            this.delete_event.Click += new System.EventHandler(this.delete_event_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_event);
            this.Controls.Add(this.print_list);
            this.Controls.Add(this.print_end);
            this.Controls.Add(this.print_ing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button print_ing;
        private System.Windows.Forms.Button print_end;
        private System.Windows.Forms.Label print_list;
        private System.Windows.Forms.Button delete_event;
    }
}

