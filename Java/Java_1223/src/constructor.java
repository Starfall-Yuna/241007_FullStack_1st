
class NoteBook{
	// 클래스 구성 요소 :: 필드(멤버 변수, 상태), 메소드(멤버 함수, 동작), "생성자"
	private String model;
	private String num;
	private String os;
	
	// 함수 :: (목적) 연산 또는 명령어 처리
	// 생성자 :: (목적) "객체 생성을 위한" 연산 처리 (메소드 중 하나)
	// 		- 생성자의 이름은 반드시 클래스 이름과 동일
	//		- 반환형도 존재X
	//		- 객체를 생성할 때에만 호출 가능 (임의 호출X)
//	public [클래스명](매개변수 구성){
//		객체 생성을 위한 명령어 나열
//	}
	
	// 생성자 오버로딩 :: 매개변수 구성만 다르게 하면 여러 개의 생성자 구현
	public NoteBook() {		// 생성자 :: 매개변수X
		this.model = "Undefined";
		this.num = "null";
		this.os = "FreeDos";
	}
	public NoteBook(String m, String n, String o) {		// 생성자 :: 매개변수 3개
		this.model = m;
		this.num = n;
		this.os = o;
	}
	
	public void Print() {
		System.out.println("모델명: "+this.model);
		System.out.println("품번호: "+this.num);
		System.out.println("운영체제: "+this.os);
	}
}

public class constructor {
	public static void main(String args[]) {
		// 객체 생성 :: [클래스명] [인스턴스명] = new [생성자_호출];
		NoteBook gram = new NoteBook();		// 매개변수가 없는 생성자 실행
		gram.Print();
		System.out.println();
		// gram.NoteBook();		-> 에러
		
		NoteBook vivo = new NoteBook();
		vivo.Print();
	}
}




