<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- JSP :: Java Servlet Page --%>
	<%-- 	=> 자바 문법을 쓸수 있는 HTML 파일
		Java(연산 처리 담당) && HTML(웹페이지 상 표현 담당)--%>

	<!-- html 주석 :: 브라우저 검사창 & 페이지 소스에서는 확인 가능 -->
	<%-- jsp 주석 :: 브라우저 검사창 & 페이시 소스에서 확인 불가능 --%>
	
	<%-- <%! %> :: (자바 문법으로) "선언"할 때 사용
		선언 이외의 문법 사용할 시에는 에러 발생 --%>
	<%! 
		String[] member = {"김길동", "홍길동", "김사랑", "박사랑"};
		int num1 = 10;
		
		int calc(int num2){
			return num1 + num2;
		}
	%>
	<hr>
	
	<%-- <%= %> :: (자바 문법에서) 값을 "표현"할 때 사용 --%>
	<h3>calc(10) 함수 실행 결과: <%=calc(10) %></h3>
	<h3>num1 값: <%=num1 %></h3>
	<hr>
	
	<%-- <%@ include %> :: 특정 내용을 불러올 때 사용 --%>
	<h3>include Hello.jsp</h3>
	<%@ include file="../Hello.jsp" %>
	<hr>
	
	<%-- <% %> :: 스크립트릿, 자바 문법을 자유롭게 사용 --%>
	<h3>배열 데이터 출력</h3>
	<% for (String name : member) { System.out.println(name); }%>
	<% for (String name : member) { %>
		<li><%=name %></li>
	<%} %>
</body>
</html>







