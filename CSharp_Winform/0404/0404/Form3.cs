using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0404
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Product 클래스 생성
        public class Product
        {
            //  속성 :: num, name, price
            public int num { get; set; }
            public string name { get; set; }
            public int price { get; set; }

            //  메소드 :: getName(), getPrice(), getAll()
            // - getName() :: 객체 정보 중 name값을 mbox로 출력
            public void getName()
            {
                MessageBox.Show($"조회한 상품의 이름: {this.name}");
            }
            // - getPrice() :: 객체 정보 중 price값을 mbox로 출력
            public void getPrice()
            {
                MessageBox.Show($"조회한 상품의 가격: {this.price}원");
            }
            // - getAll() :: 객체 정보 전체를 mbox로 출력
            public void getAll()
            {
                string result = "";
                result += "상품 번호: " + this.num + Environment.NewLine;
                result += "상품 이름: " + this.name + Environment.NewLine;
                result += "상품 가격: " + this.price + "원" + Environment.NewLine;
                MessageBox.Show(result);
            }
        }

        // Product형의 빈 리스트(pList) 생성
        List<Product> pList = new List<Product>();

        // "입력" 버튼 클릭 :: 
        //      입력값 기반으로 pList에 객체 저장 + 라벨에 표현
        private void insert_data_Click(object sender, EventArgs e)
        {
            string n = name_input.Text;
            int p = int.Parse(price_input.Text);

            pList.Add(new Product
            {
                num = pList.Count + 1,
                name = n,
                price = p
            });

            string print = "";
            foreach (var item in pList)     // item으로 pList의 객체 하나씩 접근
            {
                print += "상품 번호: " + item.num + Environment.NewLine;
                print += "상품 이름: " + item.name + Environment.NewLine;
                print += "상품 가격: " + item.price + Environment.NewLine;
                print += Environment.NewLine; 
            }
            label2.Text = print;
        }

        // 아래 이벤트의 경우엔 아래의 델리게이트(자료형)를 활용하라.
        public delegate void get();
        // get 형식의 함수의 내용을 저장할 수 있는 g 변수 선언
        get g;

        // "이름 조회" 버튼 클릭 :: 해당되는 번호의 객체의 getName() 실행
        private void print_name_Click(object sender, EventArgs e)
        {
            // 1. 입력한 숫자에 대한 파싱
            int input_num = int.Parse(num_input.Text);

            // 2. pList에서 입력값에 따른 객체 output에 저장
            var output = from element
                         in pList
                         where element.num == input_num
                         select element;
            // 각 객체의 num값이 고유하기 때문에,
            //      output에 담긴 객체는 하나밖에 없음

            // 3. getName() 활용해서, name값 출력하는 함수 실행
            foreach(var item in output)
            {
                // g에, item 객체에 대한 getName() 함수 내용을 전달
                g = item.getName;
            }

            // 입력값과 동일한 번호를 가진 객체에 대한 getName() 실행
            g();    
        }

        private void print_price_Click(object sender, EventArgs e)
        {
            // 1. 입력한 숫자에 대한 파싱
            int input_num = int.Parse(num_input.Text);

            // 2. pList에서 입력값에 따른 객체 output에 저장
            var output = from element
                         in pList
                         where element.num == input_num
                         select element;
            // 각 객체의 num값이 고유하기 때문에,
            //      output에 담긴 객체는 하나밖에 없음

            foreach(var item in output)
            {
                // g에, item 객체에 대한 getPrice() 함수 내용 전달
                g = item.getPrice;
            }

            // 입력값과 동일한 번호를 가진 객체의 getPrice() 실행
            g();
        }

        private void print_all_Click(object sender, EventArgs e)
        {
            // 1. 입력한 숫자에 대한 파싱
            int input_num = int.Parse(num_input.Text);

            // 2. pList에서 입력값에 따른 객체 output에 저장
            var output = from element
                         in pList
                         where element.num == input_num
                         select element;
            // 각 객체의 num값이 고유하기 때문에,
            //      output에 담긴 객체는 하나밖에 없음

            foreach(var item in output)
            {
                g = item.getAll;
            }

            g();
        }
    }
}
