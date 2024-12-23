// 객체 :: 실존하는 모든 것 (클래스로 찍혀진 것, 실질적인 데이터 보유)
//		동일한 클래스에서 생성된 인스턴스를 묶은 것
// 인스턴스 :: 객체의 하나하나
// 클래스 :: 객체를 찍어내는 틀

// 클래스 선언 :: class 키워드 활용
class PC{
	// 클래스 구성 요소 :: 필드(멤버 변수), 메서드(멤버 함수), 생성자
	
	// PC의 멤버 변수 :: model(모델명), num(품번호), OS(운영체제)
	// 	(접근제어자 :: 멤버의 접근을 제어하는 문법 (private, public), 디폴트값 public )
	// 		private 접근O 위치 :: 자기 자신(클래스) 안에서만 접근
	// private 사용 이유 :: "캡슐화"
	private String model;
	private String num;
	private String os;
	
	// 멤버 함수 :: get(반환)/set(값 설정) 함수, Print()
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public String getNum() {
		return num;
	}
	public void setNum(String num) {
		this.num = num;
	}
	public String getOs() {
		return os;
	}
	public void setOs(String os) {
		this.os = os;
	}
	
	// 멤버 함수 임의로 선언
	public void Print() {
		// this :: "이 객체의"
		System.out.println("모델명: "+this.model);
		System.out.println("품번호: "+this.num);
		System.out.println("운영체제: "+this.os);
	}
	
}

public class review {
	public static void main(String args[]) {
		// 객체 생성 :: [클래스명] [객체명] = new [클래스명]();
		PC gram = new PC();
		// 멤버 접근 :: [객체명].[멤버이름]
		// gram.model
		gram.setModel("그램");
		gram.setNum("10001000");
		gram.setOs("Windows 11");
		gram.Print();
		System.out.println();
		// "is not visible" :: 변수가 있는 상태, 다만 현재 위치에서 접근X
		
		PC vivo = new PC();
		vivo.setModel("VivoBook");
		vivo.setNum("11111111");
		vivo.setOs("Windows 10");
		vivo.Print();
	}
}
