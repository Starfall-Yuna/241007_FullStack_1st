package ex;

// JavaBean(자바빈) :: 객체 생성을 위한 틀
// 		=> 각각의 웹사이트 유저, 게시판, 관리자 계정, 상품, ...

// 동물 객체를 만들기 위한 Animal 자바 빈(클래스) 생성
public class Animal {
	// 4개의 값을 각각 담을 수 있는 멤버 생성
	private String kind;
	private String name;
	private int age;
	private String number;
	
	// 생성자 :: 실질적으로 객체 생성 시 활용되는 메소드
	public Animal(String k, String n, int a, String num) {
		// 매개변수로 전달받은 값을, 각 멤버에 초기화 작업
		System.out.println("Animal 객체 생성됩니다.");
		this.kind = k;
		this.name = n;
		this.age = a;
		this.number = num;
	}
	
	public String getKind() {
		return kind;
	}
	public void setKind(String kind) {
		this.kind = kind;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getNumber() {
		return number;
	}
	public void setNumber(String number) {
		this.number = number;
	}
}
