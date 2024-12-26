package pack2;

public class Ex_Phone {
	public static void main(String args[]) {
		Phone p = new Phone();
		
		// 같은 패키지 내부에서 접근 가능 ::
		//		default, protected, public
		// p.model = "Galaxy A32";		-> 접근 에러
		p.num = "1111";
		p.size = 5;
		p.os = "AOS";
	}
}
