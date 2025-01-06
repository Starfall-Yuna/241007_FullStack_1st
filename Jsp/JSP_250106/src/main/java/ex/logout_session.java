package ex;

import java.io.IOException;
import java.util.Enumeration;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class logout_session
 */
@WebServlet("/logout")
public class logout_session extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public logout_session() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 로그아웃을 위한, 세션 제거 :: removeAttribute(세션이름)
		
		// 1. "어느 세션을 제거해야하는지" 세션 이름 추출
		// 1-1) 세션에 접근하기 위한 객체 생성
		HttpSession hs = request.getSession();
		
		// 1-2) 세션에 있는 변수 이름들을 Enum에 저장
		Enumeration en = hs.getAttributeNames();
		
		// 2. en을 통하여, 세션 변수 제거
		int size=0;
		while(en.hasMoreElements()) {	// "en의 크기만큼" 실행
			String key = en.nextElement().toString();	// 세션 이름 하나씩 접근
			hs.removeAttribute(key);	// 각 세션 변수에 대해 하나씩 제거
			
			size++;
		}
		System.out.println("removeAttribute() 실행 횟수: "+size);
		
		// 세션 제거 후 로그인 창으로 다시 이동
		response.sendRedirect("login_session.html");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
