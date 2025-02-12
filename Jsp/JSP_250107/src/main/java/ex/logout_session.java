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
		// 세션 제거 :: removeAttribute(세션이름)
		//		사전 작업 :: HttpSession 객체 준비 / 제거할 세션 이름 불러오기
		
		// HttpSession 객체 준비
		HttpSession session=request.getSession();
		
		// 제거할 세션 이름 불러오기
		Enumeration en=session.getAttributeNames();
		
		// 세션의 개수(en의 크기)만큼 세션 제거 수행
		while(en.hasMoreElements()){
			String key=en.nextElement().toString();
			
			// key값을 통해서, 세션 삭세
			session.removeAttribute(key);
		}
		System.out.println("로그아웃이 완료되었습니다.");
		
		// 아이디 비밀번호 입력폼으로 돌아가기
		response.sendRedirect("Review_session.html");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
