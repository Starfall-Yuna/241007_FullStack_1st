package example;

// "추상적인" 개념 발전 -> 인터페이스 개념 생성

// 교통수단 인터페이스 생성 (interface 키워드 사용)
interface Vehicle{
	// 인터페이스 멤버 :: 상수, 추상 메소드 (생성자X)
	// 인터페이스의 멤버는 모두 public이다.
	
	// 멤버 상수 선언
	// public static final 키워드 생략
	public static final int Max_Speed = 120;
	int Min_Speed = 0;
	
	// 추상 메소드 선언 (일반적인 메소드 선언X)
	// public abstract 키워드 생략
	void move(int s);
	void stop();
}

// 인터페이스를 상속받아 구체화 진행 (implements)
class Bus implements Vehicle{
	// 멤버 변수 speed 생성
	private int speed;
	public Bus(int s) {		// Vehicle() 존재하지X
		this.speed = s;
	}
	
	// 인터페이스의 추상 메소드를 구체화 작업
	public void move(int s) {
		if(s < Min_Speed) {
			System.out.println("올바르지 않은 값입니다.");
		}
		else {
			System.out.println("입력한 값으로 주행을 시작합니다.");
			this.speed = s;
			
			if(s > Max_Speed) {
				System.out.println("주의 : 권장 최대 속도를 초과하였습니다.");
			}
		}
	}
	public void stop() {	// 버스 멈추기 
		System.out.println("잠시 정차합니다.");
		this.speed = 0;
	}
}

public class InterFace_ex {
	public static void main(String args[]) {
		// 인터페이스로 인스턴스 생성 불가능 -> 생성자가 없음
		// Vehicle v = new Vehicle();
		
		Bus b = new Bus(0);
		b.move(100);
		b.move(-11);
		b.move(150);
		b.stop();
	}
}









