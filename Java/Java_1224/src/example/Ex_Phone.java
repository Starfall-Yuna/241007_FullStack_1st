package example;

class CellPhone{
	// 멤버 변수 :: phone_num, fordable(접을 수 있는 유무)
	private String phone_num;
	private boolean fordable;
	
	public void setPhone_num(String phone_num) {
		this.phone_num = phone_num;
	}
	public void setFordable(boolean fordable) {
		this.fordable = fordable;
	}

	// 멤버 함수
	public void Print_Phone() {
		// 2개 멤버값 출력
		System.out.println("휴대폰 번호: "+this.phone_num);
		if(this.fordable==true) {
			System.out.println("접기 여부: 가능");
		}
		else {
			System.out.println("접기 여부: 불가능");
		}
	}
}
class SmartPhone extends CellPhone{
	// 멤버 변수 :: (phone_num, fordable), os, network
	// "extends CellPhone" 통해, phone_num 및 fordable 멤버 활용 (private이라 직접 접근X)
	private String os;
	private String network;		// "4G", "5G"
	
	public void setOs(String os) {
		this.os = os;
	}
	public void setNetwork(String network) {
		this.network = network;
	}

	// 멤버 함수
	public void Print_SP() {
		this.Print_Phone();					// => CellPhone 클래스의 함수 활용
		System.out.println("운영체제: "+this.os);
		System.out.println("네트워크: "+this.network);
	}
}

public class Ex_Phone {
	public static void main(String args[]) {
		CellPhone cp = new CellPhone();
		SmartPhone sp = new SmartPhone();
		
		cp.setPhone_num("010-1111-1111");
		cp.setFordable(true);
		
		sp.setPhone_num("010-2222-3333");	// => CellPhone 클래스의 함수 활용
		sp.setFordable(false);				// => CellPhone 클래스의 함수 활용
		sp.setOs("AOS");
		sp.setNetwork("4G");
		
		cp.Print_Phone();
		System.out.println();
		sp.Print_SP();
	}
}










