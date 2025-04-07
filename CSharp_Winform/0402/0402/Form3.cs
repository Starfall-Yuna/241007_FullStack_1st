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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<int> n = new List<int>();  

        private void add_element_Click(object sender, EventArgs e)
        {
            // 1. 입력값을 int형으로 파싱 & 리스트에 삽입
            int el = int.Parse(number.Text);
            n.Add(el);

            if(el <= 0)
            {
                MessageBox.Show("자연수를 입력해주세요.");
            }

            // 2. 리스트의 값을 라벨에 표현
            // Linq(Language-Integrated-Query) ::
            //      컬렉션(배열, 리스트) 형태의 데이터를 sql문처럼 조회
            // <필수 키워드> from :: 컬렉션의 데이터를 조회할 때 사용할 이름
            //              in :: 데이터를 불러올 컬렉션 지정
            //              select :: 가져올 데이터의 형식
            // <부가 키워드> where :: 조건문 의미
            //              orderby :: 정렬할 기준 의미
            //              descending, ascending :: 내림차순/오름차순(디폴트)
            var output = from element
                         in n
                         where element > 0
                         orderby element descending
                         select element;
            // "리스트 n을 element로 하나씩 접근,
            //      element 값을 내림차순 정렬하고, 이 값을 그대로 불러온다."

            string result = "";     // 라벨에 표시할 텍스트
            foreach(var item in output)
            {
                result += item + Environment.NewLine;
            }
            label1.Text = result;

            // var output2에 대해 아래처럼 Linq 구성해보기
            //   리스트 n에 대해서 하나씩 element 이름을 통해 접근,
            //      element를 기준으로 내림차순 정렬을 하고
            //      element값에 대해서 홀수인지 짝수인지에 대한 string 반환
            var output2 = from element
                          in n
                          where element > 0
                          orderby element descending
                          select element % 2 == 0 ? "짝수" : "홀수";

            string result2 = "";
            foreach (var item in output2)
            {
                result2 += item + Environment.NewLine;
            }
            label2.Text = result2;
        }
    }
}
