import java.util.Scanner;

public class review1 {
	public static void main(String args[]) {
		Scanner scan = new Scanner(System.in);
		// 2차원 배열 :: 행과 열이 함께 존재하는 배열
		// (자료형) (배열이름)[][] = new (자료형) [행크기][열크기];
		
		// 2차원 배열로 커피 메뉴판을 만들고
		int coffee[][] = new int [3][2];
		for(int i=0; i<3; i++) {	// i :: 행 번호에 대해 접근(0번 ~ 2번)
			System.out.print("메뉴"+(i+1)+"의 가격을 입력해주세요.(small / big)");
			for(int j=0; j<2; j++) {	// j :: 열 번호에 대해 접근(0번 ~ 1번)
				coffee[i][j] = scan.nextInt();
			}
		}
		
		// 특정 메뉴의 가격을 출력
		System.out.print("메뉴 번호를 입력하세요.(1 ~ 3)");
		int num = scan.nextInt();	// 메뉴 번호 입력 (행으로 접근 예정)
		System.out.print("사이즈를 입력하세요. (small은 0, big은 1을 입력하세요.)");
		int size = scan.nextInt();	// 사이즈 입력 (열로 접근 예정)
		
		// 배열 접근 :: (배열이름)[행번호][열번호]
		System.out.println("해당 메뉴의 가격은 "+coffee[num-1][size]+"원입니다.");
	}
}
