import java.util.Scanner;

public class review {	// 파일명과 동일해야함
	public static void main(String args[]) {	// 메인 함수
		// 출력문 :: printf(), print(), println()
		System.out.println("안녕하세요");	// "안녕하세요" + "\n(줄바꿈)"
		System.out.printf("안녕하세요");	// "안녕하세요"
		System.out.print("안녕하세요\n");		// "안녕하세요"
		// println()을 대표적으로 많이 씀
		// sysout+Ctrl+space 단축키로 활용O
		System.out.printf("저의 키는 %.3f입니다.\n", 171.1);	// 소수점 3번째 자리까지
		
		// 자료형 & 입력문
		// [정수형] :: int, long, long long int
		// [실수형] :: double
		// [문자형] :: char, String(문자열, char형 배열)
		// [진위형] :: boolean
		
		// 상수 선언 키워드 (final)
		// 입력문 사용을 위해서는, Scanner 클래스 객체 활용
		Scanner sc = new Scanner(System.in);
		System.out.print("int형 입력: ");
		int i = sc.nextInt();		// int형 i 변수 생성 + 입력값으로 초기값을 설정
		System.out.print("long형 입력: ");
		long l = sc.nextLong();
		System.out.print("double형 입력: ");
		double d = sc.nextDouble();
		System.out.print("boolean형 입력: ");
		boolean b = sc.nextBoolean();
		System.out.print("String형 입력(공백X): ");
		String s1 = sc.next();	//  공백을 만나면 입력 종료
		sc.nextLine();
		System.out.print("String형 입력(공백O): ");
		String s2 = sc.nextLine();	// 엔터를 만나면 입력 종료
		System.out.print("char형 입력: ");
		char c = sc.next().charAt(0);	// charAt(i) :: 문자열 중 i번째 요소 접근
			// 문자열(문자 1개 이상) 입력값 중 가장 먼저 입력된 문자에만 접근
			// 입력값("Hello") -> c = 'H' ("ello"는 입력문 종료와 동시에 사라짐)
	}
}
