
public class review2 {
	public static void main(String_Func args[]) {
		// 다중 반복문 
		for(int i=0; i<3; i++) {		// i :: 0부터 4까지
			for(int j=0; j<3; j++) {	// j :: 0부터 4까지
				System.out.print("*");
				System.out.print("("+i+","+j+") ");
			}
			System.out.println();	// 여기로 왔을 때는, 제어변수 j가 소멸된 상태
		}
		
		// i=0) j = 0 ~ 4
		// i=1) j = 0 ~ 4
		// i=2) j = 0 ~ 4
		// ...
	}
}
