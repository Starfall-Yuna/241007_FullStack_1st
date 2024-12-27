<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- form.html에서 입력받은 이름값 출력 --%>
	<%
		// - form.html에서 result.jsp로 요청 보냄
		// - 입력받은 이름값을 전송하면서 요청
	
		// 여기에서는, 전달받을 값을 기반으로 연산 처리
		
		// name 변수에, form.html에서 입력받은 이름값 저장
		String name = request.getParameter("User_name");
	%>
	
	<h1><%=name %>님, 환영합니다.</h1>
</body>
</html>