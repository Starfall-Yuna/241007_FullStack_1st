package ch07;

public class Calculator {
	// 2개의 숫자와 하나의 연산자를 저장할 멤버 선언
	private int n1;
	private int n2;
	private String op;
	
	public long calc() {
		long result = 0;	// 연산 결과 저장할 변수 선언
		switch(this.op) {
		case "+":	result = this.n1 + this.n2;	break;
		case "-":	result = this.n1 - this.n2;	break;
		case "*":	result = this.n1 * this.n2;	break;
		case "/":	result = this.n1 / this.n2;	break;
		}
		return result;	// 사칙연산 결과를 반환
	}

	// 멤버 변수 접근을 위한 get/set 함수
	public int getN1() {
		return n1;
	}

	public void setN1(int n1) {
		this.n1 = n1;
	}

	public int getN2() {
		return n2;
	}

	public void setN2(int n2) {
		this.n2 = n2;
	}

	public String getOp() {
		return op;
	}

	public void setOp(String op) {
		this.op = op;
	}
	
	
}
