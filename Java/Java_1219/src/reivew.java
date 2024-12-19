import java.util.Scanner;

public class reivew {
	// 함수는 여기에 작성
	// 함수 :: "명령어의 묶음"
//	접근제어자 static 반환형 함수이름(매개변수타입 매개변수명, ...) {
//		수행할 명령문;
//	}
	public static int add(int x, int y) {
		return x+y;
	}
	
	public static void main(String args[]) {
		// (개인 권장사항) Scanner 선언문은 가장 위에 작성
		Scanner scan = new Scanner(System.in);
		
		// (1차원) 배열
		// 정보처리기사 5과목 점수에 대해서, 합불 결과 출력
		// 1. 5과목 점수 입력
//		int score[] = new int [5];	// int형 5개 크기의 score 배열 생성 (0번~4번 공간)
//		for(int i=0;i<5;i++) {		// i를 통해서 각 공간 접근
//			score[i] = scan.nextInt();
//		}
//		// 2. 합불 결과 판별
//		int sum = 0;				// 평균값 구하기 위한 총합
//		boolean ok = true;			// 불합격 요소가 하나라도 보이면 false값으로 바꿀 예정
//		for(int i=0;i<5;i++) {
//			// 2-1) 과락 여부 
//			if(score[i] < 40) { ok = false; }
//			
//			sum += score[i];		// 5개의 데이터를 sum에 하나씩 더해줌
//		}
//		// 2-2) 평균 누락 여부
//		if(sum/5 < 60) { ok = false; }
//		
//		// 3) 최종 저장된 ok값에 따라, 합불 여부 출력
//		if(ok == true) {System.out.println("합격하였습니다.");}
//		else {System.out.println("불합격하였습니다.");}
		
		// 문자열(String), 아스키코드
		// String형과 char[]은 용도는 비슷함 (여러 문자 데이터 저장하는 용도)
		
		// 문자열 입력받고, 문자들 중에서 아스키코드 값이 가장 큰 문자 출력 (최대값 연산)
		String s = scan.next();
		char c = '0';						// 최대값을 저장할 변수
		for(int i=0; i<s.length(); i++) {	// length() :: 문자열 길이 반환
			// c의 값보다 더 큰 값을 발견하면, c값을 바꿔줄 예정
			if(c < s.charAt(i)) {			// charAt(index) :: index번의 요소에 접근
				c = s.charAt(i);
			}
			System.out.println("최대 아스키코드 값 :: " + c);
		}
		// equals(), toCharArray() -> 전날 수업했던 파일 참고
	}
}






