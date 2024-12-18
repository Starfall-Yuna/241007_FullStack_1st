import java.util.Scanner;

public class Ex_2744 {
	public static void main(String args[]) {
		// 영문자 입력에 대해서, 대소문자 뒤집어서 출력
		// 1. 영문자 입력
		Scanner scan=new Scanner(System.in);
		String input = scan.next();
		
		// [1] String 형태로 해결 시도
		// System.out.println(input);
//		for(int i=0;i<input.length();i++) {
//			char c = input.charAt(i);
//			if('A' <= c && c <= 'Z') {		// 대문자인 경우에는, 소문자로 변환하라
//				System.out.print((char)(c+32));
//			}
//			else {		// 소문자인 경우에는, 대문자로 변환하라
//				System.out.print((char)(c-32));
//			}
//		}
//		System.out.println();
		
		// [2] char[] 형태로 해결 시도
//		char[] cnt = input.toCharArray();	// cnt[] :: input을 char[]로 변환한 정보
//		for(int i=0; i<cnt.length; i++) {
//			if(97 <= cnt[i] && cnt[i] <= 122) {		// 소문자인 경우엔, 대문자로 변형
//				System.out.print((char)(cnt[i]-32));
//			}
//			else {		// 대문자인 경우엔, 소문자로 변형
//				System.out.print((char)(cnt[i]+32));
//			}
//		}
		
		// [3] 보너스
		// isLowerCase(char), isUpperCase(char) :: 소문자/대문자에 대해 판별 (true/false 반환)
		//		Character 클래스에 대해서 접근하는 함수
		// toLowerCase(), toUpperCase() :: 주어진 문자열에 대하여, 전체는 소문자/대문자로 변환
		//		String 클래스에 있는 함수	=> 이 문제에는 알맞지 않음
		
		System.out.println( input.toLowerCase() );	// 전체 소문자 변형
		System.out.println( input.toUpperCase() );	// 전체 대문자 변형
		
		for(int i=0; i<input.length() ;i++) {
			// isLowerCase(char) :: 소문자인지에 대해서 판별 (true/false 반환)
			if(Character.isLowerCase(input.charAt(i)) == true) {	// 소문자라면,
				System.out.print((char)(input.charAt(i) - 32));	// 대문자 변동
			}
			
			// isUpperCase(char) :: 대문자인지에 대해서 판별 (true/false 반환)
			else if(Character.isUpperCase(input.charAt(i)) == true) {	// 대문자라면,
				System.out.print((char)(input.charAt(i) + 32));	// 소문자 변동
			}
		}
	}
}
