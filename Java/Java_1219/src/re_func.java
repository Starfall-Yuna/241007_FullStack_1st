import java.util.Scanner;

public class re_func {
	// 재귀 함수 :: 자기 자신을 호출하는 함수
	public static int CountDown(int sec) {
		// 인수로 전달받은 남은 시간 출력
		System.out.println("남은 시간: "+sec);
		
		// sec값이 0에 다다르면, "폭탄이 터졌습니다." 출력 + 함수 시행 중단
		// sec가 0인 경우에는 return 0; 실행 종료
		if(sec == 0) {	
			System.out.println("폭탄이 터졌습니다...!");
			return 0;	// 함수 시행 중단 (반드시 필요)
		}
		
		// 재귀함수는 보통 return문에서 스스로를 호출함
		return CountDown(--sec);
	}
	
	
	public static void main(String args[]) {
		// 숫자 n을 입력하기
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		
		// n값 전달하며, 카운트다운 함수 호출
		CountDown(n);
	}
}
