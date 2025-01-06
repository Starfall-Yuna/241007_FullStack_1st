<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- <%= %> :: 표현 태그 사용 --%>
	<%-- <jsp:getProperty /> :: 자바빈의 객체에 한해서 멤버 반환 --%>
	<%-- EL :: ${불러올 값} --%>
	
	<jsp:useBean id="com" class="ch07.Calculator" />
	<jsp:setProperty name="com" property="n1" value="5" />
	<jsp:setProperty name="com" property="n2" value="10" />
	<jsp:setProperty name="com" property="op" value="+" />
	<%-- 
		Calculator com = new Calculator();
		com.n1 = 5;
		com.n2 = 10;
		com.op = "+";
	--%>
	
	10 + 20 = ${10+20}	<br>
	10 * 20 = ${10*20}	<br>
	true && false = ${true&&false }	<br>
	10 >= 20 = ${10>=20}	<br>
	com 객체의 calc() 수행 결과: ${com.calc()}
</body>
</html>