package pack2;

// 	* 접근 제어자 *
// - private :: 자기 자신의 클래스 안에서만 접근 가능
// - default :: 같은 패키지 내부에서만 접근 가능
// - protected :: 같은 패키지 && 다른 패키지 상에서 상속받은 클래스에서 접근 가능
// - public :: 외부(다른 패키지, 다른 파일)에서 얼마든지 접근 가능

public class Phone {
	// 멤버 변수 :: model(모델명), size(용량(GB))
	private String model;
	String num;
	protected double size;
	public String os;
	
	public void Print() {
		// 같은 클래스 내부에서 접근 가능 ::
		//	private, default, protected, public
		System.out.println(this.model);
		System.out.println(this.num);
		System.out.println(this.size);
		System.out.println(this.os);
	}
}
// 같은 패키지 접근 여부 :: pack2.Ex_phone 참고
// 다른 패키지 && 상속받은 클래스 접근 여부 :: pack1.Ex_protected -> SmartPhone 클래스
// 다른 패키지 && 상속X 접근 여부 :: pack1.Ex_protected -> main 함수




