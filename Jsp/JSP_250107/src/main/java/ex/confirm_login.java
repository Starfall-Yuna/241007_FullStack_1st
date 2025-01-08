package ex;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class confirm_login
 */
@WebServlet("/confirm")		/* "localhost:8080/JSP_250107/confirm"로 접속했을 때에 이 파일로 이동 */
public class confirm_login extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public confirm_login() {
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
		// 쿠키 :: 개인 pc의 브라우저 상에 저장되는 변수			(일반적인 사용자 개입O)
		// "세션" :: 홈페이지가 가동되는 서버에 저장되는 변수		(일반적인 사용자 개입X)
		
		String id=request.getParameter("id");
		String pw=request.getParameter("pw");
		
		// 1. HttpSession 클래스에 대한 객체 생성 (세션 접근 목적)
		HttpSession session = request.getSession();
		
		// * 선언한 세션 객체에 대한 만료시간 설정 (초 단위)
		// session 객체에 저장된 값들 전체적으로 30초라는 유효시간 설정
		session.setMaxInactiveInterval(30);
		
		// 2. session 통해서, 세션 값을 저장
		session.setAttribute("session_id", id);		
			// 서버에 {name: session_id, value: request.getParameter("id")} 저장
		session.setAttribute("session_pw", pw);
			// 서버에 {name: session_pw, value: request.getParameter("pw")} 저장
		// 톰캣 서버에 변수 2개의 저장
		
		response.sendRedirect("success_login.jsp");
	}
}




