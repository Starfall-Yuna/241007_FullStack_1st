import java.util.Scanner;

public class review2 {
	// 일반적으로 같은 이름의 함수를 구현 X
	// 함수 오버로딩 :: 함수 이름이 동일하여도 "매개변수 구성이 다르면" 함께 사용 O
	
	// 3개의 printTime() 함수 구현
	public static void printTime(int h) {			// 매개변수가 1개인 경우
		System.out.println("현재 시간은 "+h+"시입니다.");
	}
	public static void printTime(int h, int m) {	// 매개변수가 2개인 경우
		System.out.println("현재 시간은 "+h+"시 "+m+"분입니다.");
	}
	public static void printTime(int h, int m, int s) {	// 매개변수가 3개인 겨우
		System.out.println("현재 시간은 "+h+"시 "+m+"분 "+s+"초입니다.");
	}
	
	// 팩토리얼 함수 (재귀)
	public static int factorial(int num) {
		// 0! = 1, 1! = 1
		if(num == 0 || num == 1) {
			return 1;
		}
		System.out.println(num);
		return num * factorial(--num);
	}
	// 5! = 5*4*3*2*1
	
	public static void main(String args[]){
//		printTime(10);			// printTime(int) 수행
//		printTime(10, 20);		// printTime(int, int) 수행
//		printTime(10, 20, 30);	// printTime(int, int, int) 수행
		
		Scanner scan=new Scanner(System.in);
		int n = scan.nextInt();
		
		System.out.println(factorial(n));
	}
}





