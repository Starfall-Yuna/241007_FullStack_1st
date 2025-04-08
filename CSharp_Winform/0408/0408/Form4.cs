using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0408
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // 사람의 이름(string)을 인덱스([])로 넣고 싶을 때
        //      => 딕셔너리(Dictionary)
        List<string> l = new List<string>();        // l[0] = "퇴근"
        Dictionary<string, string> InOut = new Dictionary<string, string>()
            {
                {"Lee", "Out" },
                {"Park", "Out" },
                {"Choi", "Out" },
                {"Kim", "Out" }
            };
        //  InOut["Lee"] = "Out";
        //      key ::      딕셔너리 요소의 각 공간의 이름 (ex) "Lee"
        //      value ::    딕셔너리 요소의 각 공간의 실질적인 값 (ex) "Out"

        // 딕셔너리에 없는 key 공간에 접근?
        //      => 자동으로 공간이 생성되서 {key, value} 형태로 삽입

        private void Form4_Load(object sender, EventArgs e)
        {
            string print_text = "";
            foreach(KeyValuePair<string, string> kv in InOut)    // 총 4개의 요소 접근
            {
                // kv.key :: 특정 요소의 key값 불러옴
                // kv.value :: 특정 요소의 value값 불러옴
                //      "Lee: Out" 식으로 문자열 추가
                print_text += kv.Key + ": " + kv.Value + Environment.NewLine;
            }
            print_list.Text = print_text;
        }

        // "출근계" :: 입력된 이름에 대해 value값을 "In"으로 수정
        //      변경된 이후에 라벨의 텍스트값 갱신
        private void in_btn_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            InOut[name] = "In";

            string result = "";
            foreach(KeyValuePair<string, string> kv in InOut)
            {
                result += kv.Key + ": " + kv.Value + Environment.NewLine;
            }
            print_list.Text = result;
            MessageBox.Show($"{name}님, 반갑습니다.");
        }

        // "퇴근계" :: 입력된 이름에 대해 value값을 "Out"으로 수정
        //      변경된 이후에 라벨의 텍스트값 갱신
        private void out_btn_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            InOut[name] = "Out";

            string result = "";
            foreach(KeyValuePair<string, string> kv in InOut)
            {
                result += kv.Key + ": " + kv.Value + Environment.NewLine;
            }
            print_list.Text = result;
            MessageBox.Show($"{name}님, 안녕히 가세요.");
        }
    }
}
