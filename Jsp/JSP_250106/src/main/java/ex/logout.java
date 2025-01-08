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
 * Servlet implementation class logout
 */
@WebServlet("/logout")
public class logout extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public logout() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 로그아웃을 위한 세션 제거 :: removeAttribute(세션이름)
		// 		사전 작업 :: HttpSession 객체 준비 / 저장된 세션 이름 불러오기
		
		// 1. HttpSession 객체 준비
		HttpSession session = request.getSession();
		
		// 2. 저장된 세션 이름 불러오기
		Enumeration en = session.getAttributeNames();
		
		// 3. 세션의 개수(en의 크기)만큼 removeAttribute() 수행
		while(en.hasMoreElements()) {
			// 제거할 세션 이름을 하나씩 불러오기
			String name = (String)en.nextElement();
			
			session.removeAttribute(name);
		}
		System.out.println("세션 제거가 완료되었습니다.");
		
		response.sendRedirect("review_session.html");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
