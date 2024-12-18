import java.util.Scanner;

// 여기에 함수 선언하면 곤란합니다 (클래스 선언부)

public class Func {
	// 함수는 여기에서 작성합니다..
	// 함수 :: 명령문 묶음
	// 접근제어자 :: 접근할 수 있는 위치 제어하는 문법 (public, private, ???)
//	접근제어자 static 반환형 함수이름(매개변수타입 매개변수명, ...) {
//		명령문들;
//	}
	// 반환형X -> void 타입으로 반환형 지정
	// 각 함수의 매개변수는 다른 함수에서는 사용X
	public static int add(int x, int y) {	// x에는 a값, y에는 b값
		return x+y;
	}
	public static int sub(int x, int y) {
		return x-y;
	}
	public static int mul(int x, int y) {
		return x*y;
	}
	public static int div(int x, int y) {
		return x/y;
	}
	public static int rest(int x, int y) {
		return x%y;
	}
	
	public static void main(String args[]) {	// 메인 함수
		// 예제 :: 숫자 2개를 입력을 받고, 사칙연산 결과를 출력
		// 1. 숫자 2개 입력
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		int b = sc.nextInt();
		
		// 2. 덧셈 결과 출력
		System.out.println("덧셈 결과: "+add(a, b));
		System.out.println("뺄셈 결과: "+sub(a, b));
		System.out.println("곱셈 결과: "+mul(a, b));
		System.out.println("몫 나누기 결과: "+div(a, b));
		System.out.println("나머지 나누기 결과: "+rest(a, b));
		
		// 4개의 사칙연산에 대해서도 함수 한번씩 해보기
	}
}




