
// * Shape 추상 클래스 생성
abstract class Shape{
	// - 멤버 변수 :: dot(int, 점의 개수)
	private int dot;
	public void setDot(int d) {
		this.dot = d;
	}

	// - PrintShape() 	-> 추상 메소드
	public abstract void PrintShape();
	
	// - PrintDot() :: dot 값을 출력
	public void PrintDot() {
		System.out.println("점의 개수: "+this.dot);
	}
}

// * Triangle 클래스 생성
class Triangle extends Shape{
	// - 생성자 Triangle() :: dot을 3으로 초기화
	public Triangle(){
		// super();		-> Shape() 기본 생성자 실행
		this.setDot(3);
	}
	
	// - PrintShape() :: "이 객체는 삼각형입니다." 출력
	public void PrintShape() {
		System.out.println("이 객체는 삼각형입니다.");
	}
}
// * Circle 클래스 생성
class Circle extends Shape{
	// - 생성자 Circle() :: dot을 0으로 초기화
	public Circle() {
		// super();		-> Shape() 기본 생성자 실행
		this.setDot(0);
	}
	
	// - PrintShape() :: "이 객체는 원입니다." 출력
	public void PrintShape() {
		System.out.println("이 객체는 원입니다.");
	}
}
// 추상 메소드를 각기 다른 클래스에서 상속받아
// 각 클래스의 용도에 따라 다르게 정의		-> "다형성"

public class Ex_abstract {
	public static void main(String args[]) {
		// Shape s = new Shape(); 	-> 추상 클래스로는 객체 생성X
		Triangle t = new Triangle();
		Circle c = new Circle();
		
		t.PrintShape();
		t.PrintDot();
		System.out.println();
		c.PrintShape();
		c.PrintDot();
	}
}







