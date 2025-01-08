<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>		<%-- java.util 패키지에 있는 모든 클래스를 해당 파일에 포함 --%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h3>환영합니다!!!</h3>
<%
	// 세션 값을 불러오기
	
	// 1. 서버에 있는 세션 이름 모두 불러오기 (Enumeration 타입 (Array과 유사))
	//		getAttribute(세션이름) 가동을 위한 사전 작업
	Enumeration en = session.getAttributeNames();

	// en의 크기 = 세션의 개수
	// 2. en을 통해서, 세션의 값을 불러오기
	while(en.hasMoreElements()){		// en에 접근할 요소가 더 있을 때
		// en에 있는 세션 이름을 하나씩 불러오기
		String name = (String)en.nextElement();
		
		// 불러온 세션 이름에 대한 값을 가져오기
		String value = session.getAttribute(name).toString();
		
		if(name.equals("session_id")){
			out.println(value+"님");
		}
	}
%>
<br>

<a href="logout">로그아웃</a>
</body>
</html>






