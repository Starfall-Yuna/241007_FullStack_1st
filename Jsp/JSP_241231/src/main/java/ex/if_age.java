package ex;

import java.io.IOException;
import java.net.URLEncoder;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class if_age
 */

/* "localhost:8080/JSP_1231/if_servlet" 주소로 접속하면, 이 파일로 이동 */

@WebServlet("/if_servlet")
public class if_age extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public if_age() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// - 이름과 나이 파라미터 받기
		String name = request.getParameter("name");
		int age = Integer.parseInt(request.getParameter("age"));
		
		// - 나이가 20세 미만인 경우, 이름값(name) 전달하며 kid.jsp로 페이지 이동
		if(age < 20) {
			// sendRedirect() :: 어떤 url값으로 응답을 할 것인지 정의 
			response.sendRedirect("kid.jsp?name=" + URLEncoder.encode(name, "UTF-8"));	// name값을 UTF-8 인코딩 방식으로 전달
		}
		// - 나이가 20세 이상인 경우, 이름값(name) 전달하며 adult.jsp로 페이지 이동
		else {
			response.sendRedirect("adult.jsp?name="+URLEncoder.encode(name, "UTF-8"));
		}
		
		// 한글은 특수기호 취급해서 전달 -> 값 전달할 때, 인코딩 방식을 정해줄 필요가 있음
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
