import java.util.Scanner;

public class array {
	public static void main(String_Func args[]) {
		// 배열 :: 여러 값을 하나의 이름으로 저장할 수 있는 공간
		
		// 1차원 배열 선언
		// (자료형)[] 배열이름 = new (자료형) [배열크기];
		// 		(배열크기에 숫자, int형 변수값도 집어넣을 수 있음)
		int n = 5;
		int[] arr = new int [n];	// int형 배열 arr을, int크기(4바이트)*5만큼 할당한다.
		
		// 배열 원소 접근 :: 배열이름[번호]
		
		
		// 예제 :: 임의의 숫자 x가 있고, 5개의 숫자에 대해서
		//		5개의 숫자 중 x보다 큰 숫자들을 출력
		//		(x, 5개의 숫자는 모두 입력으로 받을 것)
		
		// 1. x, 5개의 숫자 입력
		Scanner scan = new Scanner(System.in);
		int x = scan.nextInt();
		int[] num = new int [5];	// int형 정보 5개를 넣을 수 있는 배열 num 선언
		for(int i=0; i<5; i++) {	// i(0~4)를 통해서, num 원소에 하나씩 접근
			// 입력문 :: nextInt()
			num[i] = scan.nextInt();	// i번째 원소에 접근해서, 입력값 삽입
		}
		
		// 2. num 배열의 원소에 순차적으로 접근하고, 
		for(int i=0; i<5; i++) {
			// x보다 큰 숫자가 나타나면 즉시 출력
			if(num[i] > x) {System.out.println(num[i]);}
		}
	}
}






