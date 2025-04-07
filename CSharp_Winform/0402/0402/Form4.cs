using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0402
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Linq     => 익명 "객체" (여러 데이터를 하나로 묶어서 표현할 때 사용)
        //      Linq의 select에서 활용

        List<int> number = new List<int>();
        private void add_element_Click(object sender, EventArgs e)
        {
            // 1. 입력값을 int형으로 파싱
            int n = int.Parse(input_box.Text);
            number.Add(n);

            var output = from element
                         in number
                         select new
                         {
                             // 하나의 값으로,
                             // 3개의 데이터를 만들고 이들을 하나의 객체로 묶음
                             originalValue = element,
                             powValue = element * element,
                             OddEven = element % 2 == 0 ? "짝수" : "홀수"
                         };

            string result = "";
            foreach(var item in output)
            {
                result += "원래 값: " + item.originalValue + Environment.NewLine;
                result += "제곱 값: " + item.powValue + Environment.NewLine;
                result += "홀/짝: " + item.OddEven + Environment.NewLine;
                result += Environment.NewLine;
            }
            label1.Text = result;
        }
    }
}
