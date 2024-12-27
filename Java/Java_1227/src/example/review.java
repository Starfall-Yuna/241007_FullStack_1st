package example;

// 접근제어자(4) :: Java_1226 >> pack2 >> Phone.java 참고

// 추상클래스 :: "덜 정의된 클래스", 추상 메소드를 최소 하나 가지는 클래스
// abstract 키워드를 사용해서 정의
abstract class Animal{
	// 멤버 변수, 멤버 함수, 생성자, 추상 메소드 활용
	private String name;
	public Animal(String n) {
		this.name=n;
	}
	
	// 추상 메소드 선언 :: abstract 키워드 + 함수의 선언부만 작성 (정의부X)
	public abstract void Sound();
	public void PrintAnimal() {		// (구체화된) 멤버 함수
		System.out.println("이 동물은 "+this.name+"입니다.");
		Sound();
	}
}

// 추상 클래스를 상속받아, 자식 클래스에서 구체화	-> 오버라이딩
class Dog extends Animal{
	// "부모 클래스 생성자를 실행한 후에, 자식 클래스 생성자를 실행해야함"
	// "Animal() 생성자 실행 후에, Dog() 생성자 실행"
	public Dog() {
		// super();			=> "첫줄에서" 부모 클래스 생성자 호출
		super("강아지");	// => "강아지" 데이터를 전송하며 부모 클래스 생성자 호출
		System.out.println("Dog 생성자가 실행되었습니다.");
	}
	
	// 추상 메소드 구체화 -> 오버라이딩(재정의)
	public void Sound() {
		System.out.println("월월월");
	}
}
class Bird extends Animal{
	public Bird() {
		super("새");
	}
	
	public void Sound() {
		System.out.println("짹짹짹");
	}
}

public class review {
	public static void main(String args[]) {
		// 추상 클래스로 인스턴스 생성 불가능
		// Animal a = new Animal("None"); 	
		
		Dog d = new Dog();
		d.PrintAnimal();
		System.out.println();
		
		Bird b = new Bird();
		b.PrintAnimal();
	}
}








