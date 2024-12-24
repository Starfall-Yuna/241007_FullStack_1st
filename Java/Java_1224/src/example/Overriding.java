package example;

// Setting() 메소드에 대해선, "오버로딩" 적용
// Print() 메소드에 대해선, "오버라이딩" 적용
// 함수명이 똑같은 경우를 보면, "매개변수 구성(개수, 타입)을 확인하여" 오버로딩/오버라이딩 구분

class Coffee{	// 커피 클래스
	// 멤버 변수 :: ess(에스프레소 양)
	private int ess;
	
	// 멤버 함수
	public void Setting(int e) {
		this.ess = e;
	}
	public void Print() {
		// Americano 객체에 대해서는 해당 함수 내용 실행X
		System.out.println("Coffee 클래스의 Print()가 수행되고 있습니다.");
	}
}

// 오버라이딩 :: "덮어쓰기", 부모 클래스에 있는 함수를 "재정의"
// 	반환형, 함수이름, 매개변수를 똑같이 구성하고, 함수 내용만 바꾸어서 사용
class Americano extends Coffee{	// 아메리카노 클래스
	// 멤버 변수 :: ess(상속), water
	private int water;
	
	// 멤버 함수
	// 해당 클래스에서는 Setting(int), Setting(int, int) 함께 공존
//	public void Setting(int e) {
//		this.ess = e;
//	}
	public void Setting(int e, int w) {
		Setting(e);		// 부모 클래스의 Setting(int) 수행
		this.water = w;
	}
	public void Print() {
		System.out.println("Americano 클래스의 Print()가 수행되고 있습니다.");
	}
}

class Latte extends Coffee{		// 라떼 클래스
	// 멤버 변수 :: ess(상속), milk
	private int milk;
	
	// 멤버 함수
	public void Setting(int e, int m) {
		Setting(e);
		this.milk = m;
	}
	public void Print() {
		System.out.println("Latte 클래스의 Print()가 수행되고 있습니다.");
	}
}

public class Overriding {
	public static void main(String args[]) {
		// Coffee, Americano, Latte 객체 생성
		Coffee c = new Coffee();
		Americano a = new Americano();
		Latte l = new Latte();
		
		c.Setting(50);
		a.Setting(100, 100);
		l.Setting(100, 200);
		
		c.Print();
		a.Print();
		l.Print();
	}
}








