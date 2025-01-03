import java.util.Scanner;

public class Ex_factorial {
	public static void main(String args[]) {
		// 정수 n을 입력받고
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		
		// 1부터 n까지 곱한 수(n!)를 출력하시오.
		int result=1;
		for(int i=1; i<=n; i++) {	
			// 제어변수 i를 1부터 시작해서 루프를 반복할때마다 증가
			// 다만, n값을 넘어서게 된다면 반복을 멈춘다.
			
			// i :: 1부터 n까지
			// result = 1*2*3 ... *n
			// System.out.println(i+" ");
			result *= i;
		}
		// 루프를 끝나게 되면, result = n! 가지게 되있을 것
		
		System.out.println(result);
	}
}
