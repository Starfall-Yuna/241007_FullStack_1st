// 객체 :: 실존하는 것 / 클래스로 찍어낸 것
//	(인스턴스 :: 객체 하나하나)
// 클래스 :: 객체를 찍어내는 틀

// 클래스 선언 (class 키워드 사용)
// class 클래스이름{
//		필드(멤버 변수) :: 상태값
//		메소드(멤버 함수) ::
// }
class Bread{	// 호빵 객체 생성하는 클래스 생성
	// 접근제어자 :: 멤버에 대한 접근을 제어하는 문법
	//		- public(디폴트) :: 어디에서든 접근 용이
	//		- private :: 자기 자신의 클래스 말고는 접근X
	//		(private가 있는 이유 :: 캡슐화, "상태값 정보를 클래스 외부로 노출X")
	
	// 멤버 변수 선언 :: (접근제어자) (자료형) (변수이름);
	// (ex) 호빵 멤버 변수 :: 이름, 맛, 가격
	private String name;
	private String taste;
	private int price;	// private으로 설정하면 Bread 클래스에서만 접근O
	
	// 멤버 함수 선언 ::
//	[접근제어자] [반환형] [함수이름](매개변수 구성){
//		수행할 명령문;
//	}
	// 멤버 함수 또한, 각각의 객체에 포함이 되고 객체가 공용으로 쓰는건 X (그림 참조)
	public void print() {
		// 멤버 변수값 출력
		// this :: "이 객체의"
		System.out.println("호빵 이름: "+this.name);
		System.out.println("호빵 맛: "+this.taste);
		System.out.println("호빵 가격: "+this.price+"원");
		System.out.println();
	}

	// 멤버 변수가 private일 때 :: get/set 함수 통해서 변수에 접근
	// get :: 데이터 반환하는 함수
	// set :: 값 설정하는 함수
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getTaste() {
		return taste;
	}
	public void setTaste(String taste) {
		this.taste = taste;
	}
	public int getPrice() {
		return price;
	}
	public void setPrice(int price) {
		this.price = price;
	}
}

// 대표 클래스 (public class 키워드 사용)	-> 파일에 하나씩만 존재
// 자바 실행 시, 대표 클래스 안의 main 실행
public class class_bread {
	// static 함수 :: 객체를 별도로 만들지 않고도, 접근할 수 있는 함수
	public static void main(String args[]) {
		// 객체 생성 :: new 키워드 활용
		// (클래스명) (인스턴스명) = new (클래스명)();
		Bread pizza = new Bread();
		// 멤버 접근 :: (인스턴스명).(멤버이름)
		pizza.setName("KB호빵");
		pizza.setTaste("피자맛");
		pizza.setPrice(2000);
		// is not visible :: 멤버가 없다(X), 멤버는 있지만 외부 접근을 차단함
		pizza.print();
		
		Bread redbean = new Bread();
		redbean.setName("삼양호빵");
		redbean.setTaste("단팥맛");
		redbean.setPrice(2000);
		redbean.print();
		
		Bread vegetable = new Bread();
		vegetable.setName("삼립호빵");
		vegetable.setTaste("야채맛");
		vegetable.setPrice(3000);
		vegetable.print();
		
		// 멤버 변수를 public으로 선언하고 외부에서 직접 접근하기
		// vegetable.name = "삼립호빵";
		// vegetable.taste = "야채맛";
		// vegetable.price = 3000;
	}
}
