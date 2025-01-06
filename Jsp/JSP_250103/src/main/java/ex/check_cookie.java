package ex;

import java.io.IOException;
import java.net.URLEncoder;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class check_cookie
 */
@WebServlet("/cookie")		// "localhost:8080/JSP_0103/cookie"로 접속할 시 이 파일을 불러옴
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
		String id = request.getParameter("id");
		String passwd = request.getParameter("pw");
		
		// 쿠키 :: 클라이언트(로컬pc 브라우저)에 저장하는 변수		(ex) 로컬pc
		//		(ex) 쇼핑몰의 최근에 본 상품
		// 세션 :: 웹사이트 서버에 저장하는 변수			(ex) 깃허브 서버
		// 		(ex) 로그인/로그아웃 정보
		
		
		// 아이디가 "admin"이고 비밀번호가 "1234"일 때	-> 로그인 성공
		if(id.equals("admin") && passwd.equals("1234")) {
			Cookie id_cookie = new Cookie("id_cookie", id);		// id_cookie 쿠키 객체 생성 (id_cookie = id(html 입력값))
			Cookie pw_cookie = new Cookie("pw_cookie", passwd);
			
			// 쿠키 객체 설정 -> 유효시간 설정
			id_cookie.setMaxAge(10);	// 유효시간을 30초로 설정 (30초가 지나면 자동 소멸)
			pw_cookie.setMaxAge(60);
			
			// welcome_cookie.jsp로 페이지 이동
			response.addCookie(id_cookie);		// 응답 페이지에 id_cookie 객체 삽입
			response.addCookie(pw_cookie);
			response.sendRedirect("welcome_cookie.jsp");
		}
		// 로그인 실패했을 경우엔, 로그인 실패를 콘솔에 출력 + html로 이동
		else {
			System.out.println("관리자 로그인에 실패했습니다.");
			response.sendRedirect("login_cookie.html");
		}
	}

}





