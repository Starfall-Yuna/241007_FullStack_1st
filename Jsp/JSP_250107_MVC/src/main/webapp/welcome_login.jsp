<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- {"id", id 입력값} 여기에서 전달받음 --%>
	<h3>환영합니다!!!</h3>
	<p><%= request.getParameter("id")%>님</p>
</body>
</html>