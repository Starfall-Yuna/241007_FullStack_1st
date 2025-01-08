package ch08;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CalcController
 */
@WebServlet("/calcControl")
public class CalcController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CalcController() {
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
		// 컨트롤러 :: (사용자 눈에는 보이지 않는) "서버 상의 연산 처리" 역할
		
		// html의 form 상에서 수행되었던 동작들 (아래는 자바 문법이기 때문에, 이게 수행되었다고 하기엔 힘듬)
		// request.setAttribute("n1", input[name="n1"].value)
		// request.setAttribute("n2", input[name="n2"].value)
		// request.setAttribute("op", input[name="op"].value)
		
		int num1 = Integer.parseInt(request.getParameter("n1"));
		int num2 = Integer.parseInt(request.getParameter("n2"));
		
		long result = 0;
		
		switch(request.getParameter("op")) {
		case "+":	result=num1+num2;	break;
		case "-":	result=num1-num2;	break;
		case "*":	result=num1*num2;	break;
		case "/":	result=num1/num2;	break;
		}
		
		// request(요청 정보)에 result 변수값 삽입
		request.setAttribute("result", result);
			// {name: result, value: 사칙연산 결과값}
			// 해당 서블릿 파일에서 다른 파일로 값을 넘겨주기 위한 작업
		
		// getServletContext() :: 현재 프로젝트 파일명 반환 ("/JSP_250107" 반환)
		// /calcResult.jsp로 (웹페이지 사용자에게 마저 응답할 것을) 요청으로 보냄
		// url 링크가 clacResult.jsp로 바뀌진 않음
		getServletContext().getRequestDispatcher("/calcResult.jsp").forward(request, response);
	}

}






