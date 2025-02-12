package ex;

import java.util.Scanner;

abstract class shape{
	abstract void whatShape();
}

class circle extends shape{
	@Override
	void whatShape() {
		System.out.println("원 도형 입니다.");
	}
}

class triangle extends shape{
	void whatShape() {
		System.out.println("삼각형 도형 입니다.");
	}
}
class rectangle extends shape{
	@Override
	void whatShape() {
		System.out.println("사각형 도형 입니다.");
	}
}

public class Main {
	public static void main(String[] args) {
		circle c = new circle();
		c.whatShape();
		triangle t = new triangle();
		t.whatShape();
		rectangle r = new rectangle();
		r.whatShape();
	}
}