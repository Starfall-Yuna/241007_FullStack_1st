import java.util.Scanner;

public class Ex_10869 {
	public static void main(String args[]) {
		// 문제 10869번 사칙연산
		
		// 1. 2개의 자연수에 대한 입력	-> 정수 입력문 2개 작성
		Scanner scan = new Scanner(System.in);
		int a = scan.nextInt();
		int b = scan.nextInt();
		
		// 2. 사칙연산 결과 순차적으로 출력
		System.out.println(a+b);
		System.out.println(a-b);
		System.out.println(a*b);
		System.out.println(a/b);
		System.out.println(a%b);
	}
}