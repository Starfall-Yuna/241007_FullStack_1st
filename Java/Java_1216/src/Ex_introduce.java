import java.util.Scanner;

public class Ex_introduce {
	public static void main(String args[]) {
		// 1. 이름, 혈액형, 나이, 키, 자기소개 순차적으로 입력
		// (Java 입력받기 전, Scanner 객체 선언)
		Scanner sc = new Scanner(System.in);
		String name = sc.next();
		char blood = sc.next().charAt(0);
		int age = sc.nextInt();
		double height = sc.nextDouble();	// height 입력받고 엔터 칠때, 엔터값이 intro에 들어감
		sc.nextLine();	// height 입력받은 뒤 엔터값을 받고, 메모리에서 삭제가 된다.
		String intro = sc.nextLine();	// nextLine() :: 공백 입력O 
		
		// 입력받은 순서대로 데이터를 출력
		System.out.println("이름: "+name);
		System.out.println("혈액형: "+blood+"형");
		System.out.println("나이: "+age+"세");
		System.out.println("키: "+height+"cm");
		System.out.println("자기소개: "+intro);
	}
}