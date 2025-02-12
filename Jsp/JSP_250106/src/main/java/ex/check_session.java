package ex;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class check_session
 */
@WebServlet("/check")
public class check_session extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public check_session() {
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
		// 쿠키 :: 개인pc 브라우저에 저장되는 변수				(브라우저 사용자가 임의로 값 변경O)
		// 세션 :: 홈페이지가 가동되는 서버에 저장되는 변수		(브라우저 사용자가 임의로 값 확인X, 변경X)
		
		String id = request.getParameter("id");
		String pw = request.getParameter("pw");
		
		// 관리자 로그인 성공했을 때에만, 세션 생성하게끔 하기
		if(id.equals("admin") && pw.equals("1234")) {
			// 1. 세션 작성 위한 객체 생성
			HttpSession hs = request.getSession();
			
			// 2. hs 객체를 통해서, 전송할 세션 변수 작성
			hs.setAttribute("id_session", id);	
			// {name: "id_session", value: request.getParameter("id")}+
			hs.setAttribute("pw_session", pw);
			
			// 톰캣 서버에 저장되는 변수이기 때문에, 어느 파일에서든 접근O
			// response에 굳이 세션 정보를 저장X
			response.sendRedirect("welcome_session.jsp");
		}
		else {
			System.out.println("관리자 로그인에 실패하였습니다.");
			response.sendRedirect("Login_session.html");
		}
	}
}






