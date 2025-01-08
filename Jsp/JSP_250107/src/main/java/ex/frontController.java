package ex;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class frontController
 */
@WebServlet("*.do")		/* .do로 끝나는 링크에 대해선 이 파일로 이동 */
public class frontController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public frontController() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 프론트 컨트롤러 :: 웹페이지의 기능들을 한 데 모아서, 
		//	사용자의 요청에 따라 어느 로직 파일을 실행시킬건지 "결정"하는 Control Tower(중앙 제어)
		//	웹페이지의 관련된 기능들을 한 데 모아서 볼 수 있음
		
		// "insert.do", "delete.do"...	=> 링크 중 필요한 부분을 추출할 필요
		// * 어려운 방법
		//	1) 사용자가 접속하고자 하는 링크를 가져오기	("/JSP_250107/insert.do")
		String uri = request.getRequestURI();
		System.out.println("uri 값: "+uri);
		//	2) 사용자가 접속하고 있는 프로젝트 파일 링크를 가져오기 ()
		String conPath = request.getContextPath();
		System.out.println("실행 중인 프로젝트 파일: "+conPath);
		// 	3) uri에 conPath의 내용을 빼서, 필요한 부분 추출
		// 	uri에서 일부를 제거 (0번째 문자부터 conPath 변수의 길이만큼)
		String command = uri.substring(conPath.length());
		System.out.println("command 추출 결과: "+command);
		
		if(command.equals("/insert.do")) {
			response.getWriter().println("insert를 실행합니다.");
		}
		else if(command.equals("/delete.do")) {
			response.getWriter().println("delete를 실행합니다.");
		}
		else if(command.equals("/update.do")) {
			response.getWriter().println("update를 실행합니다.");
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
