using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0403
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // DataGridView :: 표 형식을 표현할 때 사용
        //      => 데이터의 칼럼, 실질적인 데이터
        // 바인딩 :: 표(DataGridView)와 데이터/칼럼을 정의하는 클래스와 연결짓는 작업

        // "표에 어떤 칼럼을 갖고 있는가?"  -> 클래스 선언하면서 정의
        // 칼럼으로 적용하고자 하는 멤버에 대해서는, 속성({ get; set; })으로 정의
        public class Product
        {
            // 속성 :: 연번, 이름, 가격
            public int num { get; set; }
            public string name { get; set; }
            public int price { get; set; }
        }

        // BindingList :: dataGridView와 연결지어, 자동으로 갱신
        BindingList<Product> pd = new BindingList<Product>()
        {
            new Product { num=1, name="갤럭시 S25", price=5000},
            new Product { num=2, name="그램 2025", price=10000 },
            new Product { num=3, name="갤럭시 워치4", price=3000 }
        };

        // Form3 화면이 로드가 완료된 뒤에, 수행할 이벤트
        private void Form3_Load(object sender, EventArgs e)
        {
            // dataGridView1에 pd 리스트의 데이터 삽입
            dataGridView1.DataSource = pd;
        }


        // "삽입" 버튼 눌렀을 때의 이벤트 구현
        private void insert_data_Click(object sender, EventArgs e)
        {
            //  - 입력한 상품의 이름과 가격 파싱
            string n = name_input.Text;
            int p = int.Parse(price_input.Text);

            //  - 파싱 결과물을 기반으로 pd에 요소 삽입
            //      (num은 입력받지 않고, 내부적으로 번호를 부여하여 삽입)
            Product pro = new Product();
            pro.num = pd.Count + 1;     // 현재 상품 리스트 길이 + 1
            pro.name = n;
            pro.price = p;
            pd.Add(pro);

            name_input.Text = "";
            price_input.Text = "";

            //  - 데이터 삽입한 이후의 pd를 기반으로, 표 데이터 갱신
            //      (이에 대한 코드를 추가하지 않고 갱신하는 방법이 있음)
            //       => 일반 List를 BindingList로 변환하여 자동 갱신되게끔 함
        }

    }
}
