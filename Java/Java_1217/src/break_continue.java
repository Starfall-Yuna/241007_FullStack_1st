import java.util.Scanner;

public class break_continue {
	public static void main(String args[]) {
		// 반복문 제어 키워드 :: break, continue
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		
		System.out.println("1부터 n까지의 숫자 중 홀수만 출력");
		for(int i=1; i<=n; i++) {	// 1부터 n까지의 숫자
			if(i % 2 == 0) {	// 2로 나누어 떨어진다면 (짝수라면)
				// break;	// break :: 반복문 자체 종료	
				continue;	// continue :: 반복문의 윗부분 이동 (루프 한번 돈 것으로 간주)
			}
			
			System.out.println(i);
//			if(i % 2 != 0) {	// 홀수인 조건을 걸어주고 (2로 나누어 떨어지지 않는다.)
//				System.out.println(i);	// 현재 숫자가 홀수이기 때문에, 출력 수행
//			}
		}
	}
}