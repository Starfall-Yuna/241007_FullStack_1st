using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0407
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            check_event.Checked = true;
        }

        // EventHandler() :: 제3의 요소에 대한 이벤트 적용/삭제 활용

        private void event_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하십니까!!!");
        }

        private void insert_event_Click(object sender, EventArgs e)
        {
            // "이벤트 삽입" 클릭 시, "이벤트 발생"에 대한 이벤트 추가
            event_button.Click += new System.EventHandler(event_button_Click);
            check_event.Checked = true;
        }

        private void delete_evnet_Click(object sender, EventArgs e)
        {
            // "이벤트 삭제" 클릭 시, "이벤트 발생"에 대한 이벤트 삭제
            event_button.Click -= new System.EventHandler(event_button_Click);
            check_event.Checked = false;
        }

        private void check_event_CheckedChanged(object sender, EventArgs e)
        {
            if(check_event.Checked == true)
            {
                event_button.Click += new System.EventHandler(event_button_Click);
            }
            if (check_event.Checked == false) 
            {
                event_button.Click -= new System.EventHandler(event_button_Click);
            }
        }
    }
}
