
public class print {
	public static void main(String args[]) {
		// 한줄 주석
		/*
		 * 여러줄 주석
		 * */
		
		// 출력문 :: 
		System.out.printf("printf를 통해서 출력합니다.");
		System.out.println("안녕하세요.");		// "안녕하세요." + "\n"
		System.out.print("안녕하세요.");		// "안녕하세요."
		System.out.println();	// "sysout" 입력 후, Ctrl+space 자동 생성
		
		int time=2;
		System.out.printf("현재 시각은 %d시입니다.\n", time);	// 서식지정자 활용
		System.out.println("현재 시각은 "+time+"시입니다.");	// +을 통해, 문자열을 덧붙임
	}
}
