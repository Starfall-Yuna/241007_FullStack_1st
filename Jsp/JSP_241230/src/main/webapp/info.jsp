<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- JSP :: Java Servlet Page
		Java 문법을 활용할 수 있는 HTML 형식 파일 
		Java로 서버 연산 처리, HTML로 페이지 표현 --%>
		
	<%-- <%! %> :: 자바로 "선언"할 때 활용 
		이 태그에서는, 서버에 있는 값에 관여할 수 없음 --%>
	<%! 
		String name; 
		String gender;
	%>
	
	<%-- <% %> :: 스크립트릿 태그
		자바와 관련된 모든 구문을 작성 --%>
	<%
		name = request.getParameter("n");	// n 이름으로 전달된 value값을 삽입
		gender = request.getParameter("g");	// g 이름으로 전달된 value값을 삽입
	%>
	
	<%-- <%= %> :: 자바에 있는 값을 "표현"할 때 사용 --%>
	<p>이름: <%=name %></p>
	<p>성별: <%=gender %></p>
</body>
</html>




