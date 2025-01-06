<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="j" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- 스크립크릿 태그 통해서 쿠키 활용 --%>
<%-- 	<%
		// "check_cookie.java로부터 ck_1 쿠키 정보를 전달받으며 
		//	마저 응답할 것을 요청받았다."
		//		=> "check_cookie.java로부터 요청받았다." 
		//		-> request 통해서 쿠키 정보 받아냄
		Cookie ck_array[] = request.getCookies();
		
		for(int i=0; i<ck_array.length; i++){
			// i번째 쿠키 값을 value에 저장
			String name = ck_array[i].getName();
			String value = ck_array[i].getValue();
			
			out.println(name + ": " + value+"<br>"); 
		}
		
		// 쿠키가 몇개 있는지 확인
		System.out.println(ck_array.length);
	%> --%>
	
	<%-- JSTL 활용하여 쿠키 활용 --%>
	<%-- cookie에 있는 데이터들을 data라는 이름으로 하나씩 접근 --%>
	<%-- ${cookie} :: 요청으로 전달받은 쿠키 배열, 값을 기준으로 자동 정렬 --%>
	<j:forEach var="data" items="${cookie}">
		<%-- data.key : 쿠키 이름
			data.value : 쿠키 객체 자체
			data.value.value : 쿠키 값
		 --%>
		${data.value.value}	<br>
	</j:forEach>
</body>
</html>


