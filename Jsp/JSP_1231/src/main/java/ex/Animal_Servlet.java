package ex;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Animal_Servlet
 */
@WebServlet("/animal")
public class Animal_Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Animal_Servlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// 요청으로 전달받은 4개의 값을 변수 저장
		String k = request.getParameter("kinds");
		String n = request.getParameter("name");
		int a = Integer.parseInt(request.getParameter("age"));
		String num = request.getParameter("num");
		
		// Animal 클래스에 대한 객체 생성
		// 4개의 값을 전송하여서, Animal 생성자를 실행
		Animal ani = new Animal(k, n, a, num);
		
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter pw = response.getWriter();
		
		pw.println("<h3>동물 객체에 대한 내용을 출력합니다.</h3>");
		pw.println("<p>종: "+ani.getKind()+"</p>");
		pw.println("<p>이름: "+ani.getName()+"</p>");
		pw.println("<p>나이: "+ani.getAge()+"</p>");
		pw.println("<p>번호: "+ani.getNumber()+"</p>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String n = request.getParameter("name");
		int a = Integer.parseInt(request.getParameter("age"));
		String num = request.getParameter("num");
		String g = request.getParameter("gender");
		
		Student st = new Student(n, a, num, g);
		
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter pw = response.getWriter();
		
		pw.println("<h3>인적사항에 대해 출력을 수행합니다</h3>");
		pw.println("<p>이름: "+st.getName()+"</p>");
		pw.println("<p>나이: "+st.getAge()+"</p>");
		pw.println("<p>번호: "+st.getNumber()+"</p>");
		pw.println("<p>성별: "+st.getGender()+"</p>");
	}
}




