package example;

interface Device{
	// 멤버 함수 :: turnOn(), turnOff(), getBattery(), Charge()
	void turnOn();
	void turnOff();
	void getBattery();
	void Charge();
}

// => 구체화 할 수 있는 Class :: NoteBook, DeskTop, ...
abstract class Computer implements Device{
	// 멤버 :: turnOn(), turnOff(), getBattery(), Charge(), power
	
	// 멤버 변수 :: power(boolean)
	private boolean power;
	
	// 생성자 :: Computer() 	-> power을 false로 초기화
	public Computer() {
		this.power = false;
	}
	
	// 전달받은 추상 메소드 4개 중 2개를 구체화
	// - turnOn() -> "전원이 켜졌습니다" 출력 + power을 true로
	public void turnOn() {
		System.out.println("전원이 켜졌습니다.");
		this.power = true;
	}
	// - turnOff()	-> "전원이 꺼졌습니다" 출력 + power을 false로
	public void turnOff() {
		System.out.println("전원이 꺼졌습니다.");
		this.power = false;
	}
}

class NoteBook extends Computer{
	// 멤버 변수 :: (power(boolean)), battery(int)
	private int battery;
	public NoteBook(int b) {
		// super();
		this.battery = b;
	}
	
	// getBattery()	-> 현재 battery 출력
	public void getBattery() {
		System.out.println("현재 배터리양: "+this.battery+"%");
	}
	// Charge()	-> battery의 값을 100으로 변경
	public void Charge() {
		System.out.println("충전이 완료되었습니다");
		this.battery = 100;
	}
}
class DeskTop extends Computer{
	// 멤버 변수 :: power(boolean)
	
	public void getBattery() {
		System.out.println("데스크톱에는 배터리가 없습니다.");
	}
	public void Charge() {
		System.out.println("상시 충전중입니다.");
	}
}

public class Ex_Computer {
	public static void main(String args[]) {
		NoteBook nb = new NoteBook(80);
		nb.turnOn();
		nb.getBattery();
		nb.Charge();
		nb.turnOff();
	}
}










