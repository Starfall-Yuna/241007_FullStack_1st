<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<% 
		String name = request.getParameter("name");
		// String형 name 변수 :: input_info.html 파일에서 받아낸 이름값 전달
	%>
	<h3><%=name %>님은 어른입니다...!</h3>
</body>
</html>