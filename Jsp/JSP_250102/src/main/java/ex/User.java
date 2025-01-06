package ex;

// User 자바빈(클래스) 작성
// 이름과 이메일 정보를 저장하는 각각의 인스턴스를 생성하는 데에 사용

public class User {
	// 자바빈의 멤버 변수 :: name(이름), email(이메일)
	private String name;
	private String email;
	
	// 자바빈의 생성자 (객체 생성할 때 수행)
	public User() {
		this.name = "None";
		this.email = "No Email";
	}
	
	// 자바빈의 멤버 함수 :: 멤버 변수에 대한 get/set 함수 (값 반환 / 값 설정)
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	
}
