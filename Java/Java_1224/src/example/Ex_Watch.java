package example;

class Clock{
	// 멤버 변수 :: hour(시), minute(분), second(초)
	public int hour;
	public int minute;
	public int second;
	
	// Setting(int, int, int) :: 3개 멤버값 설정
	public void Setting(int h, int m, int s) {
		this.hour = h;
		this.minute = m;
		this.second = s;
	}
	// Print() :: 3개 멤버값 출력
	public void Print() {
		System.out.println("현재 시각은 "+this.hour+"시 "+this.minute+"분 "+this.second+"초입니다.");
	}
}

class Watch extends Clock{
	// 멤버 변수 :: hour(시), minute(분), second(초) -> 상속 활용
	// 		color(시계 색상)
	public String color;
	
	// Setting(int, int, int) :: 3개 멤버값 설정 + color값을 "Black"으로 설정
	//		=> 오버로딩, 오버라이딩 적용 (Clock의 Setting(int, int, int) 무시)
	public void Setting(int h, int m, int s) {
		this.hour = h;
		this.minute = m;
		this.second = s;
		this.color = "Black";
	}
	
	// Setting(int, int, int, String) :: 4개 멤버값 설정
	// 		=> 오버로딩 적용
	public void Setting(int h, int m, int s, String c) {
		this.hour = h;
		this.minute = m;
		this.second = s;
		this.color = c;
	}
	
	// Print() :: 4개 멤버값 출력
	// 		=> 오버라이딩 적용 (Clock의 Print() 내용 무시)
	public void Print() {
		System.out.println("hour(시): "+this.hour);
		System.out.println("minute(분): "+this.minute);
		System.out.println("second(초): "+this.second);
		System.out.println("color(색상): "+this.color);
	}
}

public class Ex_Watch {
	public static void main(String args[]) {
		// 객체 생성
		Clock c = new Clock();
		Watch w1 = new Watch();
		Watch w2 = new Watch();
		
		// Setting() 수행
		c.Setting(16, 40, 5);
		w1.Setting(18, 30, 30);
		w2.Setting(9, 10, 20, "Orange");
		
		// Print() 수행
		c.Print();		// Clock의 Print() 수행
		System.out.println();
		w1.Print();		// Watch의 Print() 수행
		System.out.println();
		w2.Print();
	}
}












