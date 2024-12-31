package ex;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Print_Input
 */

/* 서블릿 :: 서버에 대한 연산 처리를 진행하는 파일 
 *		서블릿 파일 안에 있는 명령문들은, 전부 (톰캣)서버 안에서 이루어짐 */
/* "localhost:8080/JSP_1231/print"로 접속할 때에 여기로 이동 */

@WebServlet("/print")
public class Print_Input extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Print_Input() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// form의 method 값이 get일 때 여기로 이동
		// 반려동물의 이름과 성별을 출력
		
		// 응답을 하기 위한 준비
		response.setContentType("text/html; charset=UTF-8");	// 응답으로 작성할 파일 형식 지정
		PrintWriter pw = response.getWriter();					// html 형식으로 출력하기 위한 객체 생성
		
		// 입력폼에서 작성한 값을 불러오기
		String name = request.getParameter("n");
		String gender = request.getParameter("g");
		
		// 전달받은 값을 html 페이지 상 출력
		pw.append("<html><body>")
			.append("<h3>반려동물 정보 출력</h3>")
			.append("<p>이름: "+name+"</p>")
			.append("<p>성별: "+gender+"</p>")
			.append("</body></html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// form의 method 값이 post일 때 여기로 이동
		
		// 인적사항(이름, 성별) 출력
		response.setContentType("text/html; charset=utf-8");
		PrintWriter pw = response.getWriter();
		
		// 영어 빼고는 전부 특수기호 취급하고 처리 -> 글자가 깨진다면 인코딩 설정
		request.setCharacterEncoding("UTF-8");
		String name = request.getParameter("n");
		String gender = request.getParameter("g");
		String hobby[] = request.getParameterValues("h");	// 복수값 전달
		
		pw.println("<h3>인적사항 정보 입력</h3>");
		pw.println("<p>이름: "+name+"</p>");
		pw.println("<p>성별: "+gender+"</p>");
		pw.println("<p>취미: ");
		for(int i=0; i<hobby.length; i++) {
			pw.println(hobby[i]+" ");
		}
	}

}


