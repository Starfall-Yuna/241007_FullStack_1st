package pack1;

class Book{
	// 멤버 변수 :: title(제목), author(작가), page(쪽수)
	private String title;
	private String author;
	private int page;
	
	// eBook의 Display() 작성을 위해 필요한 함수
	public String getTitle() {
		return title;
	}
	public String getAuthor() {
		return author;
	}
	public int getPage() {
		return page;
	}
	
	// - makeBook(String, String, int) :: 3개의 멤버값 설정
	public void makeBook(String t, String a, int p) {
		this.title = t;
		this.author = a;
		this.page = p;
	}
	// - Display() :: 3개의 멤버값 출력
	public void Display() {
		System.out.println("책 제목: "+this.title);
		System.out.println("작가: "+this.author);
		System.out.println("책 페이지 수: "+this.page);
	}
}

class eBook extends Book{
	// - 멤버 변수 :: (title(제목), author(작가), page(쪽수)), size(파일 크기(MB)), type(파일 형식)
	private double size;
	private String type;
	
	// - makeBook(String, String, int) 		=> 상속 활용
	// - makeBook(String, String, int, double, String) :: 5개의 멤버값 설정
	public void makeBook(String t, String a, int p, double s, String type) {
//		this.title = t;
//		this.author = a;
//		this.page = p;
		this.makeBook(t, a, p);		// 3개의 멤버값 설정 (이름은 똑같으나 다른 함수를 불러옴 -> 오버로딩)
					// 자기 자신을 불러오는게 아니기 때문에, 재귀 함수로 작동X
		this.size = s;
		this.type = t;
	}
	// - Display() :: 5개의 멤버값 출력	-> Book의 Display()와 다른 내용으로 구성 -> 오버라이딩(재정의)
	public void Display() {
		// Display();		// 자기 자신을 불러옴 (부모 클래스의 Display() 불러올 수 없음) 
		System.out.println("책 제목: "+this.getTitle());
		System.out.println("작가: "+this.getAuthor());
		System.out.println("책 페이지 수: "+this.getPage());
		System.out.println("파일 용량(MB): "+this.size);
		System.out.println("파일 형식: "+this.type);
	}
	
	// 오버로딩 - 오버라이딩의 작동 차이 :: 공존하는가, 아니면 하나는 없어지는가
	// 오버로딩 - 오버라이딩의 구분 방법 :: (상속을 받았다는 전제 하) 매개변수 구성이 동일한 함수인가
}

public class Ex_book {
	public static void main(String args[]) {
		Book b = new Book();
		eBook eb = new eBook();
		
		b.makeBook("열혈 Java", "윤성우", 500);
		eb.makeBook("하루만에 Spring", "윤성우", 400, 350.5, "PDF");	
			// eb 객체에 대해, makeBook() 함수를 총 2개 추천  -> 오버로딩 적용
		
		b.Display();
		System.out.println();
		eb.Display();	// Book 클래스의 Display() 사용 추천X	-> 오버라이딩 적용
	}
}








