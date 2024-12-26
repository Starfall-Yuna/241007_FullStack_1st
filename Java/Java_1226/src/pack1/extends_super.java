package pack1;

class Lecture{	// 강의 클래스
	// 멤버 변수 :: 강의 이름(name), 권장 학년(grade)
	private String name;
	private int grade;
	public Lecture(String n, int g) {		// Lecture() 실행 시, 2개의 정보 필요
		//System.out.println("Lecture 생성자 실행");
		this.name = n;
		this.grade = g;
	}
	
	public void Print() {
		System.out.println("Lecture 생성자를 통해서 초기화되었습니다.");
		System.out.println("강의 이름: "+this.name);
		System.out.println("권장 수강학년: "+this.grade);
	}
}
class Liberal extends Lecture{	// 교양 강의 클래스
	// 멤버 변수 :: (강의 이름(name), 권장 학년(grade)), 카테고리(category)
	private String category;
	public Liberal(String n, int g, String c) {
		// super(); 	=> Liberal() 첫 줄에 생략되어있음 (부모클래스 생성자 실행)
		super(n, g);		// 매개변수 쌍에 맞게 데이터 전송하여 실행 중
		//System.out.println("Liberal 생성자 실행");
		this.category = c;
		
		// "부모 클래스 생성자를 실행한 후에, 자식 클래스 생성자를 실행해야함"
	}
	
	public void Print_Liberal() {
		this.Print();
		System.out.println("Liberal 생성자를 통해서 초기화되었습니다.");
		System.out.println("분류: "+this.category);
	}
}
class Major extends Liberal{
	// - 멤버 변수 :: (강의 이름(name), 권장 학년(grade), 카테고리(category)), 전공(depart)
	private String depart;
	public Major(String n, int g, String c, String d) {
		super(n, g, c);		// name, grade, category 값 설정을 Liberal() 넘기고
		this.depart = d;	// 전공 값 설정은 스스로 함
	}
	
	public void Print_Major() {
		this.Print_Liberal();		// 멤버 3개값 출력
		System.out.println("Major 생성자를 통해서 초기화되었습니다.");
		System.out.println("전공: "+this.depart);
	}
}

public class extends_super {
	public static void main(String args[]) {
		// Lecture, Liberal 객체 생성
		Lecture lt = new Lecture("리더십", 3);
		Liberal lb = new Liberal("선택", 2, "교양선택");
			// super()를 통하여 Lecture() 생성자 실행
		Major mj = new Major("자료구조", 2, "전공필수", "컴퓨터공학전공");	
			// Major 생성자의 super()를 통하여, Liberal() 생성자 실행
			// Liberal 생성자의 super()를 통하여, Lecture() 생성자 실행		=> super() 2번 실행
		
		lb.Print_Liberal();
		System.out.println();
		mj.Print_Major();
		
		// Lecture 클래스 :: (Liberal의)부모클래스
		// Liberal 클래스 :: (Lecture의)자식클래스 && (Major의)부모클래스
		// Major 클래스 :: (Liberal의)자식클래스
		
		// "부모 클래스 생성자를 실행한 후에, 자식 클래스 생성자를 실행해야함"
	}
}






