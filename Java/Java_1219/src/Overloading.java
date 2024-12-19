
public class Overloading {
	// 함수 :: "명령문 묶음"
	
	// 일반적으로는 함수 이름이 동일하면 안 된다. 전제가 있음
	// 함수 오버로딩 :: "매개변수 수/타입 다른 경우" 같은 이름의 함수를 사용해도 됨
	
	// 반환형 다름 -> 오버로딩 조건X
//	public static double add(int a, int b) {
//		return (double)(a+b);
//	}
	
	public static double add(double a, double b) {	// 매개변수: double형 2개
		return a+b;
	}
	public static int add(int a, int b) {			// 매개변수: int형 2개
		return a+b;
	}
	public static int add(int a, int b, int c) {	// 매개변수: int형 3개
		return a+b+c;
	}
	
	public static void main(String args[]) {
		System.out.println("1.0+2.0 결과: "+add(1.0, 2.0));	// (double, double) -> add(double, double) 수행
		System.out.println("1+2 결과: "+add(1, 2));			// (int, int) -> add(int, int) 수행
		System.out.println("5+7+9 결과: "+add(5, 7, 9));	// (int, int, int) -> add(int, int, int) 수행
	}
}



