package pack1;

// import 키워드 :: 다른 패키지의 파일을 추가
import pack2.Phone;
import pack2.*;		// pack2 패키지의 모든 클래스 포함

class SmartPhone extends Phone{
	public void Print_SP() {
		// 다른 패키지 but 자식 클래스 접근 가능 ::
		// 		protected, public
		// System.out.println(this.model);
		// System.out.println(this.num);		// ->접근 에러
		System.out.println(this.size);
		System.out.println(this.os);
	}
}

public class Ex_protected {
	public static void main(String args[]) {		
		// 다른 패키지 클래스의 내용 -> import 없이는 접근X
		Phone p = new Phone();
		
		// 상속X 다른 패키지 접근 가능 ::
		// 		public
//		p.model = "IPhone 10";
//		p.num = "1111";
//		p.size = 4.5;		// => 접근 에러
		p.os = "IOS";
	}
}









