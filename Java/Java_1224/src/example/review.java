// 패키지 :: 파일을 담는 폴더 개념
// package 키워드 :: "해당 파일이 example 패키지 안에 있다" 선언
package example;

import java.util.Scanner;

class Phone{
	// 멤버 변수 :: 번호, 모델명, OS
	private String number;
	private String model;
	private String os;
	
	// 메소드(멤버 함수) :: 클래스 안에 있는 "명령문의 묶음"
	// 생성자 :: 메소드 중 하나, 객체 생성을 위해 있는 메소드
	//		클래스에 생성자 별도로 선언X 경우, 기본 생성자 숨어있음
	// public Phone() {}		-> 순수 객체 생성을 위한 생성자
	
	// 생성자 오버로딩
	public Phone() {	// 매개변수가 없는 생성자
		// 객체 생성을 하면서 수행할 명령문 나열
		this.number="000-0000-0000";
		this.model="None";
		this.os="FreeDos";
	}
	public Phone(String n, String m, String o) {	// 매개변수가 3개 있는 생성자
		this.number = n;
		this.model = m;
		this.os = o;
	}
	
	public void Print() {
		System.out.println("휴대폰 번호: "+this.number);
		System.out.println("모델명: "+this.model);
		System.out.println("운영체제: "+this.os);
	}
}

public class review {
	public static void main(String args[]) {
		Scanner sc=new Scanner(System.in);
		
		// 인스턴스 생성
		Phone p1 = new Phone();	// Phone() :: Phone 생성자 실행
		Phone p2 = new Phone("010-1111-2222", "Galaxy S24", "AOS");	// Phone(String, String, String) 실행
		// p1.Phone();	-> 에러
		
		// 인스턴스 배열 :: 여러 인스턴스를 하나의 이름으로 저장할 수 있는 공간
		// 1) 인스턴스를 저장할 공간 배정 (배열 선언)
		// int arr[] = new int [3];
		Phone p[] = new Phone [2];		// Phone 타입의 크기가 2인 p 배열 선언
		
		// 2) 선언한 배열의 원소들에 대해서 인스턴스 생성 (생성자 실행)
//		p[0] = new Phone();
//		p[1] = new Phone();
		for(int i=0; i<2; i++) {	// p[0]~[1] 접근
			System.out.print("값을 입력해주세요.(번호, 모델명, 운영체제) ");
			p[i] = new Phone(sc.next(), sc.next(), sc.next());
			
			p[i].Print();
			System.out.println();
		}
	}
}




