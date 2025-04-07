namespace _0407
{
    partial class Form5
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
            this.event_button = new System.Windows.Forms.Button();
            this.check_event = new System.Windows.Forms.CheckBox();
            this.insert_event = new System.Windows.Forms.Button();
            this.delete_evnet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // event_button
            // 
            this.event_button.Font = new System.Drawing.Font("굴림", 12F);
            this.event_button.Location = new System.Drawing.Point(44, 39);
            this.event_button.Name = "event_button";
            this.event_button.Size = new System.Drawing.Size(127, 68);
            this.event_button.TabIndex = 0;
            this.event_button.Text = "이벤트 발생";
            this.event_button.UseVisualStyleBackColor = true;
            this.event_button.Click += new System.EventHandler(this.event_button_Click);
            // 
            // check_event
            // 
            this.check_event.AutoSize = true;
            this.check_event.Font = new System.Drawing.Font("굴림", 12F);
            this.check_event.Location = new System.Drawing.Point(210, 59);
            this.check_event.Name = "check_event";
            this.check_event.Size = new System.Drawing.Size(111, 20);
            this.check_event.TabIndex = 1;
            this.check_event.Text = "이벤트 적용";
            this.check_event.UseVisualStyleBackColor = true;
            this.check_event.CheckedChanged += new System.EventHandler(this.check_event_CheckedChanged);
            // 
            // insert_event
            // 
            this.insert_event.Font = new System.Drawing.Font("굴림", 12F);
            this.insert_event.Location = new System.Drawing.Point(44, 144);
            this.insert_event.Name = "insert_event";
            this.insert_event.Size = new System.Drawing.Size(127, 68);
            this.insert_event.TabIndex = 2;
            this.insert_event.Text = "이벤트 삽입";
            this.insert_event.UseVisualStyleBackColor = true;
            this.insert_event.Click += new System.EventHandler(this.insert_event_Click);
            // 
            // delete_evnet
            // 
            this.delete_evnet.Font = new System.Drawing.Font("굴림", 12F);
            this.delete_evnet.Location = new System.Drawing.Point(210, 144);
            this.delete_evnet.Name = "delete_evnet";
            this.delete_evnet.Size = new System.Drawing.Size(127, 68);
            this.delete_evnet.TabIndex = 3;
            this.delete_evnet.Text = "이벤트 삭제";
            this.delete_evnet.UseVisualStyleBackColor = true;
            this.delete_evnet.Click += new System.EventHandler(this.delete_evnet_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_evnet);
            this.Controls.Add(this.insert_event);
            this.Controls.Add(this.check_event);
            this.Controls.Add(this.event_button);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button event_button;
        private System.Windows.Forms.CheckBox check_event;
        private System.Windows.Forms.Button insert_event;
        private System.Windows.Forms.Button delete_evnet;
    }
}