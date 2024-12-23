import java.util.Scanner;

class Todo{
	// 멤버 변수 :: title(할일), important(중요도, boolean)
	private String title;
	private boolean important;
	
	// 생성자 :: Todo(String, boolean)
	public Todo(String t, boolean i) {
		// 매개변수 값으로 title과 important 설정
		this.title = t;
		this.important = i;
	}

	// get/set 함수 :: 멤버 변수가 private인 경우에만 활용하시면 됩니다.
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public boolean isImportant() {
		return important;
	}
	public void setImportant(boolean important) {
		this.important = important;
	}
}

public class Ex_todo {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		
		// 1. n을 입력받고, n개의 Todo 객체 배열을 생성하여라
		//   (입력값을 기반으로 각 객체 멤버 초기화하기)
		System.out.print("할일의 개수를 입력하세요. ");
		int n = sc.nextInt();
		Todo td[] = new Todo [n];		// 객체 생성 이전에, 배열 공간 할당
		for(int i=0; i<n; i++) {	// td[0]~[n-1]
			System.out.print("할일과 중요도를 입력하세요. ");
			td[i] = new Todo(sc.next(), sc.nextBoolean());		// 생성자를 통한 객체 생성
		}
		System.out.println();
		
		// 2. "오늘 할일"에 대해 출력하여라
		// 	(important 값이 true인 Todo 객체의 title 값만 출력)
		System.out.println("<오늘 할일>");
		for(int i=0; i<n; i++) {	// td[0]~[n-1]
			if(td[i].isImportant() == true) {	// 해당 객체의 important 값이 true라면
				System.out.println(td[i].getTitle());
			}
		}
		System.out.println();
		
		// 3. "전체 할일"에 대해 출력하여라
		//	 (Todo 객체 배열의 모든 title 값 출력)
		System.out.println("<전체 할일>");
		for(int i=0; i<n; i++) {	// td[0]~[n-1]
			System.out.println(td[i].getTitle());
		}
	}
}







