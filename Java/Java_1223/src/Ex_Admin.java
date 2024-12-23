
class Admin{
	// 상태값 :: nickname(관리자 닉네임), permission[](권한), per_count(권한개수)
	private String nickname;
	private String permission[];
	private int per_count;
	
	// 생성자 2개 작성
	// Admin() 함수 내용
	public Admin() {
		this.nickname = "Undefined";
		this.per_count = 0;
		this.permission = new String [10];
	}
	// Admin(String) :: String값을 nickname 초기화
	public Admin(String adm) {
		this.nickname = adm;
		this.per_count = 0;
		this.permission = new String [10];
	}
	
	// 멤버 함수 3개 작성
	// sayHello() :: nickname값과 함께 인사말 출력
	public void sayHello() {
		System.out.println(this.nickname+"님 환영합니다.");
	}
	
	// [per_count 값을 활용하여, permission의 배열 크기 확인]
	// showPermission() :: permission[] 안에 있는 내용 전체 출력
	public void showPermission() {
		if(per_count == 0) {	// 주어진 권한이 없을 때
			System.out.println("주어진 권한이 없는 상태입니다.");
		}
		else {
			for(int i=0; i<this.per_count; i++) {	// (ex)per_count = 3 => i = 0~2
				System.out.println(this.permission[i]);
			}
		}
	}
	// addPermission(String per_name) :: permission[]에 per_name 추가
	public void addPermission(String per_name) {
		// 이때, 10개의 권한이 이미 저장되어있다면 Error 출력
		if(this.per_count >= 10) {	// "이 인스턴스의 권한 배열의 길이"가 10 이상이라면
			System.out.println("Error : 권한이 이미 찼습니다.");
			return;		// 즉시 종료
		}
		
		// 이미 존재하는 권한이라면 관련 안내문 출력 (permission 배열에 per_name 값이 이미 있다면)
		for(int i=0; i<this.per_count; i++) {	// permission에 저장된 권한 전체 조회
			if(this.permission[i].equals(per_name)) {	// per_name과 동일한 값이 발견되면
				System.out.println("Error : 이미 존재하는 권한입니다.");
				return;		// 즉시 종료
			}
		}
		
		this.permission[this.per_count] = per_name;		// 권한 배열의 뒷부분에 per_name 추가
		this.per_count++;		// 권한 개수에 1 증가
	}
}

public class Ex_Admin {
	public static void main(String args[]) {
		// 테스트를 위한 객체 생성 (Admin(String) 생성자 활용)
		Admin ad = new Admin("admin1234");
		
		ad.sayHello();
		System.out.println();
		
		ad.showPermission();		// per_count=0 -> 주어진 권한X 출력
		System.out.println();
		
		ad.addPermission("read");
		ad.addPermission("write");
		ad.addPermission("delete");
		ad.addPermission("write");		// 중복되는 권한으로 취급 -> Error 출력, 즉시 종료
		
		ad.showPermission();
	}
}






