package ch05;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class HelloWorld
 */
@WebServlet(description = "My first Servlet", urlPatterns = { "/hello" })
public class HelloWorld extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public HelloWorld() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 서블릿(Servlet) :: "서버에 대한 연산 처리"를 주로 진행하는 파일 
		
		// 문서 형식 지정 (응답에 대해 정의 :: html 형식으로, 인코딩은 utf-8로)
		response.setContentType("text/html; charset=utf-8");
		
		// PrintWriter 타입의 out 객체 생성
		// out 객체를 통해서, html 문서를 작성해서 출력할 예정
		PrintWriter out = response.getWriter();
		
		out.append("<!doctype html><html><head><title>Hello World Servlet</title></head><body>")
			.append("<h2>Hello World !!</h2><hr>")
			.append("현재 날짜와 시간은: "+java.time.LocalDateTime.now())
			.append("</body></html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
