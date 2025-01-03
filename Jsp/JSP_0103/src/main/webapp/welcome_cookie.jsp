<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h3>환영합니다!!!</h3>
	
<%-- 	<%
		// 이 페이지에 도달했을 때엔, id_cookie request정보 전달
		
		// 전달받은 쿠키 내용을, 배열에 삽입
		Cookie[] ck = request.getCookies();
	
 		for(int i=0; i<ck.length; i++){	// ck 배열 탐색
 			String v = ck[i].getValue();	// i번째 ck의 value값 가져옴

 			out.println(v + "<br>");		// out (PrintWriter 객체)
		}
 		
 		System.out.println("쿠키 객체의 개수: "+ck.length);
	%> --%>
	
	<%-- ${cookie} :: 요청으로 전달받은 쿠키 배열 --%>
	<c:forEach var="ck" items="${cookie}">
		<%-- Cookie id = new Cookie("id_cookie", "admin"); --%>
		<%-- ck :: 쿠키
			ck.key => 쿠키의 이름					id 반환
			ck.value => 쿠키의 객체 내용			{"id_cookie", "admin"} 반환
			ck.value.key	=> 쿠키 변수의 이름	ㄴ	id_cookie 반환
			ck.value.value 	=> 쿠키 변수의 값		admin 반환
			--%>
		${ck.value.value }<br>
	</c:forEach>
	
</body>
</html>






