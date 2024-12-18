import java.util.Scanner;

public class ASCII {
	public static void main(String_Func args[]) {
		// 아스키코드 :: 각 문자 정보 - 특정 숫자에 일대일대응해서 표현 약속
		// 강제 형변환
		
		// 예제 :: 영문자 또는 숫자 입력 시, 해당 문자의 아스키코드 출력
		// 문자 입력 -> 숫자 출력
		Scanner scan = new Scanner(System.in);
//		char asc = scan.next().charAt(0);
//		
//		System.out.println((int)asc);	// asc를 정수형으로 변환
//		// System.out.println(asc);		// asc의 원래 자료형으로 적용
		
		// 숫자 입력 -> 문자 출력
		int asc = scan.nextInt();
		System.out.println((char)asc);
	}	
}





