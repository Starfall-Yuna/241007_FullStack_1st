import java.util.Scanner;

public class Ex_clock {
//	아래의 3개 함수를 선언하여라. (main의 sec와 각 함수의 sec는 다릅니다.)
//	- 매개변수로 받은 초(sec) 정보에 대한 hour(시간, 0 ~ 24) 반환
	public static int getHour(int sec) {
		return sec / 3600;
	}
//	- 매개변수로 받은 초(sec) 정보에 대한 minute(분, 0 ~ 59) 반환
	public static int getMin(int sec) {
		return (sec % 3600) / 60;
	}
//	- 매개변수로 받은 초(sec) 정보에 대한 second(초, 0 ~ 59) 반환
	public static int getSec(int sec) {
		return (sec % 3600) % 60;
	}
	// / :: "시간/분" 환산 가능한 결과
	// % :: "시간/분" 환산 불가능한 결과 
	
	public static void main(String args[]) {
		// 86400 이하의 숫자를 입력받기
		Scanner scan = new Scanner(System.in);
		int sec = scan.nextInt();

		if(sec > 86400) {
			// 86400을 초과하는 숫자는 "Error" 출력
			System.out.println("Error");
		}
		else {
			// 입력받은 값에 대해서, h시 m분 s초 양식으로 변환하여 출력
			int h = getHour(sec);	// 1h = (60m) * (60s) = 3600s
			int m = getMin(sec);	// 1m = 60s (sec % 3600 범위 : 0 ~ 3599)
			int s = getSec(sec);	// s 표현의 범위가 0~59 제한
			
			System.out.println(h+"시 "+m+"분 "+s+"초입니다.");
		}
	}
}




