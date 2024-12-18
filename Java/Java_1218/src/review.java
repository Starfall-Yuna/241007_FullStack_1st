import java.util.Scanner;

public class review {
	public static void main(String_Func args[]) {
		// 연산자 :: (Java_1217) operator.java 참고
		
		// 조건문 :: if-else if-else문, switch문
		// 반복문 :: for문, while문, do-while문
		// break(자체 종료), continue(처음으로 돌아간다)
		
		// switch문 -> if문(O)	/ if문 -> switch문(부분적)
		// for문 -> while문(O)  / while문 -> for문(O)
		
		// 조건문+반복문 예제
		// 2개의 숫자랑 하나의 연산자를 입력을 받고, 연산 결과를 출력
		// (위 연산을 반복 실행하되 2개의 숫자를 0 0으로 입력받으면 실행 종료)
		
//		while(조건식) {
//			조건식 만족할 때 수행할 명령문;
//		}
		
		Scanner scan = new Scanner(System.in);
		while(true) {		// 무한 반복문 :: 우선 반복을 시키되, 중단점을 반복문 안에서 설정 
			// 1. 2개의 숫자와 하나의 연산자를 입력 (중단점 설정)
			System.out.print("두 숫자를 입력하세요 ");
			int a = scan.nextInt();
			int b = scan.nextInt();
			if(a==0 && b==0) { break; }		// break :: 반복문 자체 종료
			System.out.print("연산자를 입력하세요 ");
			char c = scan.next().charAt(0);
			
			// 2. 입력받은 연산자, 숫자를 기반으로 연산 결과 출력
			//	연산자 c 값에 따라서, 연산 방법을 달리해줄 필요가 있음  => 조건문으로 선택지 만들어줌
			System.out.print("연산 결과: ");
			if(c == '+') 	  {System.out.println(a+b);}
				// "c가 +라면, a+b를 출력하라."
			else if(c == '-') {System.out.println(a-b);}
				// "위 사항을 만족하지 않고 c가 -라면, a-b를 출력하라."
			else if(c == '*') {System.out.println(a*b);}
			else if(c == '/') {System.out.println(a/b);}
			else if(c == '%') {System.out.println(a%b);}
			else {
				System.out.println("Error!!!");
			}
				// "위 사항을 모두 만족하지 않는다면, 해당 양식대로 출력하라."
		}
	}
}
