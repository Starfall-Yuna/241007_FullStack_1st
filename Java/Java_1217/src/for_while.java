import java.util.Scanner;

public class for_while {
	public static void main(String args[]) {
		// 반복문 :: "특정 조건을 만족할" 때마다 일부 명령을 "반복"하는 구문
		// 반복 횟수를 "조건을 만족하는가?"에 따라서 조정
		// for, while, do-while
		
		// for(제어변수 초기화; 조건식; 루프한 뒤 후처리){
		// 		조건식 만족할 때 수행할 명령문;
		//}
		System.out.println("for문을 활용한 출력");
		for(int i=1; i<=5; i++) {
			System.out.print(i+" ");
		}
		System.out.println();
		// int i=1	-> 반복이 시작되기 이전에 1번만 실행
		// i++		-> 반복을 하는 동안 계속
		
//		while(조건식) {
//			조건식 만족할 때 수행할 명령문;
//		}
		System.out.println("while문을 활용한 출력");
		int i=1;
		while(i<=5) {
			System.out.print(i+" ");
			i++;
		}
		System.out.println();
		
		
		
		Scanner scan= new Scanner(System.in);
//		int index=scan.nextInt();
//		while(index >= 0) {
//			System.out.print(index+" ");
//			if(index % 2==0) {
//				System.out.println("짝수입니다.");
//			}
//			else {
//				System.out.println("홀수입니다.");
//			}
//			
//			index--;
//		}
		// 이 while문을 for문으로 변형해서 똑같이 작동하도록 해보시오.
		for(int index=scan.nextInt(); index >= 0; index--) {
			System.out.print(index+" ");
//			if(index % 2==0) {
//				System.out.println("짝수입니다.");
//			}
//			else {
//				System.out.println("홀수입니다.");
//			}
			
			// ? :: "반환" 목적으로 있는 삼항연산자
			System.out.println(index % 2 == 0 ? "짝수입니다." : "홀수입니다.");
			// (index%2==0) :: System.out.println("짝수입니다.");
			// (index%2!=0) :: System.out.println("홀수입니다.");
		}
	}
}
