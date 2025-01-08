package ex;

import java.io.IOException;
import java.net.URLEncoder;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class login_Controller
 */
@WebServlet("*.do")
public class login_Controller extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	int size=0;		// 계정의 개수
	private String id[] = new String [10];		// id 저장하는 배열
	private String pw[]	= new String [10];		// pw 저장하는 배열
	
    /**
     * @see HttpServlet#HttpServlet()
     */
    public login_Controller() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doAction(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doAction(request, response);
	}

	// get 방식이어서 post 방식이어도 doAction() 함수를 통해 실행
	protected void doAction(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException{
		// 링크 중에서, 필요한 부분(*.do 부분) 추출
		String command = request.getServletPath();
		System.out.println(command);
		
		if(command.equals("/signUp.do")) {
			// - signUp.html 상 입력받은 아이디, 비밀번호 저장
			String input_id = request.getParameter("id");
			String input_pw = request.getParameter("pw");
			
			boolean execute = true;		// false값으로 변경되면, 회원가입 진행X
			// 1) 저장된 계정이 10개 이상이라면, 회원가입 진행X
			if(size >= 10)	{execute = false;}
			// 2) 중복되는 아이디를 입력받았다면, 회원가입 진행X
			// 	=> html에서 입력받은 input_id 값이 이미 id[]에 있다면 -> 중복되는 아이디
			for(int i=0; i<size; i++) {
				if(input_id.equals(id[i]) == true) {
					execute = false;
				}
			}
			
			// 회원가입을 진행하면 안되는 경우에 대한 처리 (execute가 false일 때)
			if(execute == false) {
				// 콘솔상에서 로그인 실패함을 출력하며
				System.out.println("로그인에 실패하였습니다.");
				// front_login.html로 바로 이동
				response.sendRedirect("front_login.html");
				
				return;		// return;을 적어서 끝내지 않으면, 응답을 2번 하는 꼴 -> 500 에러
			}
			
			// 2. size(계정의 개수)를 통해, id[] pw[]에 값 삽입
			id[size] = input_id;
			pw[size] = input_pw;
			size++;
			
			// 3. 계정 정보 저장 후, 로그인 페이지로 이동
			System.out.println("회원가입을 완료하였습니다.");
			response.sendRedirect("front_login.html");
		}
		else if(command.equals("/login.do")) {
			// 1. front_login.html의 입력값 저장
			String input_id = request.getParameter("id");
			String input_pw = request.getParameter("pw");
			System.out.println(size);
			
			// 2. 입력값들이 배열(id[], pw[])에 존재하는지 확인
			boolean tf = false;
			for(int i=0; i<size; i++) {		// [0] ~ [size-1]
				if(input_id.equals(id[i]) && input_pw.equals(pw[i])) {
					tf = true;		// 로그인 성공 조건
				}
			}
			
			// 3. 로그인 성공 여부에 따른 페이지 이동 수행
			if(tf == false) {
				System.out.println("로그인에 실패하였습니다.");
				response.sendRedirect("front_login.html");
			}
			else {
				response.sendRedirect("welcome_login.jsp?id="
						+URLEncoder.encode(input_id, "UTF-8"));
			}
		}
	}
}





