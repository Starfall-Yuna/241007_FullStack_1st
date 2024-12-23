import java.util.Scanner;

class User{
	// 멤버 변수 :: 닉네임, 이메일, 휴대폰 번호
	private String nickname;
	private String email;
	private String phone;
	
	// 사용자가 생성자를 별도로 선언하지 않으면,
	// 내부적으로 "기본 생성자"가 생략되어 있다.
	//	=> 생성자를 별도로 선언하면, 기본 생성자는 없는 것처럼 취급
	
	// * 기본 생성자 형태 :: 매개변수X, 명령문X
//	public User() {
//		
//	}
	public User(String n, String e, String p) {
		this.nickname = n;
		this.email = e;
		this.phone = p;
	}
	
	public void Print() {
		System.out.println("닉네임: "+this.nickname);
		System.out.println("이메일: "+this.email);
		System.out.println("전화번호: "+this.phone);
	}
}

public class object_array {
	public static void main(String args[]) {
		Scanner scan = new Scanner(System.in);
		// 인스턴스 배열 :: 하나의 이름으로 여러 인스턴스를 저장할 수 있는 공간	
		// 객체 배열 선언 :: 1) User타입 배열 선언(공간 할당) -> 2) User 객체 생성
		
		// 1) User 타입으로 배열 선언(공간 할당)
		// int array[] = new int [3];
		User userArray[] = new User [3];	// User 타입의 배열 선언
		
		// 2) User 객체 생성 -> 객체 생성 구문을 총 3번 수행
		//		객체 선언은 1)에서 이미 수행 -> 생성자 호출하여 객체 생성만 수행
//		userArray[0] = new User();
//		userArray[1] = new User();
//		userArray[2] = new User();
		for(int i=0; i<3; i++) {	// userArray[0] ~ [2]
			System.out.print("유저"+(i+1)+"번 정보 입력: ");
			userArray[i] = new User(scan.next(), scan.next(), scan.next());		// 기본 생성자 3번 호출
		}
		System.out.println();
		
		// 객체 배열 멤버 접근 :: (객체명)[배열번호].(멤버이름)
		for(int i=0; i<3; i++) {
			System.out.println("유저"+(i+1)+"번 정보 조회");
			userArray[i].Print();	// userArray[0]~[2].Print();
			System.out.println();
		}
	}
}



