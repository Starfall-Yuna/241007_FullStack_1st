import java.util.Scanner;

public class Ex_10807 {
	public static void main(String_Func args[]) {
		// 총 N개의 정수가 주어졌을 때, 정수 v가 몇 개인지 구하는 프로그램 작성
		// 입력 :: N, N개의 정수, V
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		int[] arr = new int [n];	// N개의 정수를 저장할 배열
		for(int i=0; i<n; i++) {
			arr[i] = scan.nextInt();	// i(0~n-1)값에 따라서 배열 순차적 입력
		}
		int v = scan.nextInt();	// 비교할 숫자
		
		// => arr의 원소 - v를 비교해서, v와 동일한(==) 숫자의 개수 출력
		int count = 0;	// 동일한 숫자 개수 저장
		for(int i=0; i<n; i++) {	// 입력받은 배열값 탐색
			if(v == arr[i]) {	// arr[0] ~ arr[n-1]까지 접근
				count++;	// 동일한 숫자 발견 시, count에 1을 더함
			}
		}	// 비교 완료 -> count에 정답이 저장되어있음
		System.out.println(count);
	}
}
