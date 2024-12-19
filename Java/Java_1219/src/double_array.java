import java.util.Scanner;

public class double_array {
	public static void main(String args[]) {
		// 2차원 배열 :: 행(가로)과 열(세로)이 함께 존재하는 배열
		
		// 예제 :: n명의 학생에 대해서 3과목 점수 입력
		// 각 과목의 점수를 그대로 출력
		Scanner scan=new Scanner(System.in);
		int n=scan.nextInt();
		// 2차원 배열 선언 :: 
		// (자료형) (배열이름)[][] = new (자료형) [행크기][열크기];
		//	<배열 크기 지정할 때>	1) 몇 개의 행을 갖고 있는지
		//							2) 각 행에 대해서 몇 개의 데이터를 넣을 수 있는지 (열 크기)
		int score[][] = new int [n][3];
		for(int i=0; i<n; i++) {		// i를 통해 각 행에 접근
			for(int j=0; j<3; j++) {	// j를 통해 (i번째 행의) 각 열에 접근
				// 2차원 배열 접근 :: (배열이름)[행번호][열번호]
				
				// score 배열의 i번째 행, j번째 열에 대해 접근
				// i (0 ~ n-1) -> 행번호로 작용, j(0 ~ 2) -> 열번호로 작용
				// System.out.print(i+"번째 행의 "+j+"번째 열: ");
				score[i][j] = scan.nextInt();
			}
		}
		
		for(int i=0; i<n; i++) {
			int sum=0;	// i번째 행에 대한 총합을 저장할 변수
			for(int j=0; j<3; j++) {	// i번째 행의 모든 열 접근
				sum += score[i][j];		// i=0 )  j=0~2
			}
			System.out.println("학생" + (i+1) + " 평균: " + sum/3);
			// 학생1에 대한 출력 끝내고 -> 학생2에 대한 연산을 시작
		}
	}
}


