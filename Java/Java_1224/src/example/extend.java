package example;

// "상속" -> 부모 클래스와 자식 클래스 개념 존재 (클래스 간의 "관계")
// extends 키워드 사용

class PC{
	// 멤버 변수 :: os(운영체제), num(품번호)
	// private 멤버인 경우엔, 상속 여부 상관없이 PC에서만 접근O
	private String os;
	private String num;
	
	public String getOs() {
		return os;
	}
	public void setOs(String os) {
		this.os = os;
	}
	public String getNum() {
		return num;
	}
	public void setNum(String num) {
		this.num = num;
	}
}
class DeskTop extends PC{
	// 멤버 변수 :: os(운영체제), num(품번호), model(모델명)
	
	// "extends PC"를 통하여, DeskTop이 내부적으로 "빌려와서" 재사용하고 있는 코드
	// 아래 주석의 코드의 주인이 DeskTop이 아닌 PC
	// 접근제어자에 따라 접근에 제한이 있을 순 있지만, 활용은 가능
//	private String os;
//	private String num;
//	public String getOs() {
//		return os;
//	}
//	public void setOs(String os) {
//		this.os = os;
//	}
//	public String getNum() {
//		return num;
//	}
//	public void setNum(String num) {
//		this.num = num;
//	}
	
	private String model;
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public void Print() {
//		System.out.println("운영체제: "+this.os);
//		System.out.println("품번호: "+this.num);	-> os, num는 PC로만 접근 (private)
		System.out.println("운영체제: "+this.getOs());
		System.out.println("품번호: "+this.getNum());
		System.out.println("모델명: "+this.model);
	}
}
class NoteBook extends DeskTop{
	// 멤버 변수 :: os, num, model, gram(무게)
	// os, num, model 멤버는, DeskTop에서 "빌려와서" 재사용
	//	=> 3개의 멤버에 대해서는 직접 접근X
	
	private double gram;
}

public class extend {
	public static void main(String args[]) {
		PC p = new PC();			// p의 멤버 :: os, num
		DeskTop dt = new DeskTop();	// dt의 멤버 :: os, num(물려받은 것), model
		
		p.setOs("Windows 10");
		p.setNum("1111");
		
		dt.setModel("VivoBook");
		dt.setOs("Windows 11");
		dt.setNum("1234");
		
		dt.Print();
	}
}











