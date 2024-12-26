package pack1;

// 추상 클래스 :: "추상적인 클래스, 덜 정의된 클래스"		<-> 구체화된 클래스
// "추상 메소드"를 최소 하나 가지고 있는 클래스
// abstract 키워드 사용

abstract class Person{
	String name;
	String gender;
	// 생성자가 있음, 자식 클래스의 생성자 실행을 위한 생성자가 있음
	// 자체적으로 객체 생성을 할 수는 없음
	
	// 추상 메소드 선언 방법 :: abstract 키워드 + 함수 선언부만 남겨놓음
	// 추상 메소드 구현 방법 :: 다른 클래스 상속 + 오버라이딩(재정의)
	public abstract void Setting();
}

class Student extends Person{
	// Setting() 함수 정의부 구현
	
	// 자식 클래스에서 구체화{} 수행 -> 오버라이딩 활용(재정의)
	public void Setting() {
		this.name = "None";
		this.gender = "None";
	}
}

public class abstract_class {
	public static void main(String args[]) {
		// 추상 클래스로는 객체 생성 불가능
		// Person p = new Person();		-> 객체 생성 불가능한 생성자
		Student s = new Student();
	}
}








