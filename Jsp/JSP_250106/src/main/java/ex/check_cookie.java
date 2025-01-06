package ex;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class check_cookie
 */
@WebServlet("/cookie")		/* "localhost:8080/JSP_250106/cookie" 링크로 이 파일 접속 */
public class check_cookie extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public check_cookie() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 쿠키 :: 로컬pc의 브라우저에 저장되는 변수	=> 개인pc 데이터 
		// 세션 (오늘 설명드릴 예정)					=> 서버 데이터		(ex. 깃허브)
		
		// html에서 전달받은 값 저장
		String id_cookie = request.getParameter("id");
		String pw_cookie = request.getParameter("pw");
		
		// 쿠키 객체를 생성 => 객체 생성문
		Cookie ck_1 = new Cookie("ck1", id_cookie);	// ck_1 쿠키 객체 생성 ({name: ck1, value: request.getParameter("id")})
		Cookie ck_2 = new Cookie("ck2", pw_cookie);
		
		// 쿠키 객체 유효시간 설정 (아래 코드 상으로는 30초로 설정)
		ck_1.setMaxAge(30);
		ck_2.setMaxAge(10);
		
		// 쿠키 객체를 응답(response)에 포함시키기
		response.addCookie(ck_1);
		response.addCookie(ck_2);
		
		// 응답을 하기 위한 페이지 이동(sendRedirect)
		response.sendRedirect("welcome_cookie.jsp");
	}
}





