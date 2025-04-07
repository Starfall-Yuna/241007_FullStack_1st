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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // 1. Score 클래스 구현
        //      속성 :: 이름, C# 점수, Java 점수, 평균값
        public class Score
        {
            public string name {  get; set; }
            public int CSharp { get; set; }
            public int Java { get; set; }
            public double avg { get; set; }
        }

        // 2. List<Score> 빈 리스트 선언
        List<Score> scoreList = new List<Score>();

        // 3. 차트 구축 (C#, Java는 막대그래프로, 평균값은 선그래프로 표현)
        //      < AddXY()에서 첫번째 매개변수 값을 학생의 이름값으로 설정하기 >
        // Form4가 로드가 완료되면, 차트 구성 작업 진행 예정
        private void Form4_Load(object sender, EventArgs e)
        {
            // 차트의 이름 지정
            score_chart.Titles.Add("학생 성적표");


            // + 테스트 데이터를 리스트에 삽입
            scoreList.Add(new Score { name = "Lee", CSharp = 80, Java = 100 });
            scoreList.Add(new Score { name = "Park", CSharp = 100, Java = 50 });
            scoreList.Add(new Score { name = "Kim", CSharp = 70, Java = 40 });
            foreach(var item in scoreList)
            {
                // 평균값 속성 설정
                item.avg = (item.CSharp + item.Java) / 2.0;
            }

            // 차트의 항목 이름 설정
            // Add(y좌표 값(그래프의 높이))
            // AddXY(x좌표 값(그래프의 위치), y좌표 값(그래프의 높이))
            score_chart.Series[0].Name = "C#";
            score_chart.Series[1].Name = "Java";
            score_chart.Series[2].Name = "Average";
            foreach(var obj in scoreList)   // obj 이름으로 객체 하나씩 접근
            {
                score_chart.Series[0].Points.AddXY(obj.name, obj.CSharp);
                score_chart.Series[1].Points.AddXY(obj.name, obj.Java);
                score_chart.Series[2].Points.AddXY(obj.name, obj.avg);
            }
        }

        // C# 윈폼에서는 2D/3D 형태 차트 지원
        //  (인터넷에서 서칭해보면 다양한 디자인이 있음)
    }
}
