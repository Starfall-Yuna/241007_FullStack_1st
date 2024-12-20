
// 본 풀이에서는 private으로 진행하나, public으로 풀이를 진행하여도 무관합니다.

import java.util.Scanner;

// 클래스 구성요소 :: 필드(멤버 변수), 메소드(멤버 함수), 생성자
class Time{
	// 상태값(멤버 변수) :: hour(시), min(분), sec(초)
	private int hour;
	private int min;
	private int sec;
	
	// 생성자 :: 멤버 함수 중 하나 (목적 :: 객체 생성)
	// "생성자의 이름은 클래스의 이름과 동일함"
	// "반환형이 없음"
	// "객체 생성 구문에서만 생성자를 호출"		(watch.Time() -> 사용 불가)
	
//	public 클래스명(매개변수 구성) {
//		수행할 명령문 (멤버 변수 초기화에 많이 활용)
//	}
	public Time() {
		// hour, min, sec에 대해서 임의의 값으로 초기화
		this.hour = 0;
		this.min = 0;
		this.sec = 0;
	}
	
	
	// (함수 사용 목적 :: 연산 / 값 도출 / 명령어 수행)
	// - PrintTime() :: 현재 시각 출력 (상태값 3개 활용)
	public void PrintTime() {
		System.out.println("현재 시간은 "+this.hour+"시 "+this.min+"분 "+this.sec+"초입니다.");
	}
	
	// - PrintAmPm() :: 현재 시간이 오전/오후인지 출력
	public void PrintAmPm() {
		if(this.hour < 12) {	// 오전(AM) :: 0시 ~ 11시
			System.out.println("현재는 오전입니다.");
		}
		else {			// 오후(PM) :: 12시 ~ 23시
			System.out.println("현재는 오후입니다.");
		}
	}

	public int getHour() {
		return hour;
	}
	public void setHour(int hour) {
		this.hour = hour;
	}
	public int getMin() {
		return min;
	}
	public void setMin(int min) {
		this.min = min;
	}
	public int getSec() {
		return sec;
	}
	public void setSec(int sec) {
		this.sec = sec;
	}
}

public class Ex_class_clock {
	public static void main(String args[]) {
		Scanner scan = new Scanner(System.in);
		
//		- watch 객체 생성 + 3개의 입력값을 기반으로 필드 초기화
		Time watch = new Time();		// Time() 생성자 실행되면서 객체 생성 수행
		System.out.print("watch에 대한 시, 분, 초 정보 입력: ");
		watch.setHour(scan.nextInt());		// 입력 먼저 받고 -> set함수 실행
		watch.setMin(scan.nextInt());
		watch.setSec(scan.nextInt());
		
//		- digital 객체 생성 + 3개의 입력값을 기반으로 필드 초기화
		Time digital = new Time();		// Time() 생성자 실행되면서 객체 생성 수행
		System.out.print("digital에 대한 시, 분, 초 정보 입력: ");
		digital.setHour(scan.nextInt());
		digital.setMin(scan.nextInt());
		digital.setSec(scan.nextInt());
		System.out.println();
		
//		- watch와 digital에 대한 각 PrintTime() 함수 실행
//		- watch와 digital에 대한 각 PrintAmPm() 함수 실행
		watch.PrintTime();
		watch.PrintAmPm();
		System.out.println();
		digital.PrintTime();
		digital.PrintAmPm();
	}
}







