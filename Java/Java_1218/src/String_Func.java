import java.util.Scanner;

public class String_Func {
	public static void main(String args[]) {
		// char ch[50]	-> 최대 49개의 문자 저장 + '\0'
		//		=> 단점 :: 크기를 예상해서 지정 
		// String :: (칸이 나뉘어진 배열과 달리) 문자들을 하나의 칸에 보관하는 자료형
		//		=> 들어가는 값에 따라서 크기 자동 지정
		//		=> char[]은 또 다른 공간
		
		// 문자열 함수 사용 방법 :: [문자열_정보].문자열 함수()
		
		// String 함수
		// 1. charAt(index) :: String형 정보에 대해 index번째 문자 접근
		String s1 = "Hello, Hi";
		System.out.println("첫번째 문자: "+s1.charAt(0));	// s1[0] = s1.charAt(0)
		
		// 2. toCharArray() :: String형 -> char형 배열로 변환
		char[] ch = s1.toCharArray();	// char형 배열로 변환된 s1 데이터를 ch에 저장
		System.out.println("첫번째 문자: "+ch[0]);
		
		// 3. length() :: 문자열 길이 반환
		System.out.println("s1의 길이: "+s1.length());	// 문자열 끝에 '\0' 데이터 필요X
		
		// 4. equals() :: 두 문자열이 같은지를 판별
		System.out.println("string1"=="string1");
		Scanner scan = new Scanner(System.in);
		String s = scan.next();		// scan.next() 수행하고 엔터를 친 값
		System.out.println("== 사용 결과: "+("string1" == s));		// 문자열 비교에선, == 보다 equals()가 정확도가 더 높음
		System.out.println("equals() 사용 결과: " + "string1".equals(s));
	}
}
