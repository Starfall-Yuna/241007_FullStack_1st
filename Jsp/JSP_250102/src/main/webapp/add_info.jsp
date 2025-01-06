<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h3>자바빈 활용해서 출력</h3>
	<jsp:useBean id="user1" class="ex.User" />
	<jsp:setProperty name="user1" property="name" value="${param.n }" />
	<jsp:setProperty name="user1" property="email" value="${param.e }" />
	<!-- EL 태그를 활용하면, 자동으로 형변환 -->

	<p>
		이름: <jsp:getProperty name="user1" property="name" />	<br>
		이메일: <jsp:getProperty name="user1" property="email" />	<br>
	</p>
</body>
</html>