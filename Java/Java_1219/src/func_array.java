import java.util.Scanner;

public class func_array {
	// 3명의 성적에 대해서 평균값 반환하는 함수
	public static double getAvr(int[] s) {	// getAvr() 수행 전, s 배열의 정보 받음
		double sum = 0;
		for(int i=0; i<s.length; i++) {	// s 배열의 크기만큼 반복 수행
			sum += s[i];
		}
		return sum / s.length;	// (double)/(int) -> (소수점이 있는 나눗셈)
								// (int)/(int)	  -> (몫 반환)
	}
	
	public static void main(String args[]) {
		// 3명의 성적 입력
		Scanner sc=new Scanner(System.in);
		int score[] = new int [3];
		for(int i=0; i<3; i++) {
			score[i] = sc.nextInt();
		}
		
		double a = getAvr(score);	// (점수총합)/(학생수) 데이터가 a로 저장
		System.out.println("성적 평균: "+a);
	}
}



