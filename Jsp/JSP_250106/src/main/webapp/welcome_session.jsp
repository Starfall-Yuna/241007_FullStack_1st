<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.util.*" %>		<%-- java.util에 있는 모든 클래스를 해당 파일에 포함 --%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h3>환영합니다!</h3>
<%
	// 서버에 세션 변수 삽입

	// en에는 세션의 이름들 전달받음 ("id_session", "pw_session")
	Enumeration en = session.getAttributeNames();	

	int size = 0;
	while(en.hasMoreElements()){	// en에 대해 탐색할 원소가 더 있을 때 (이 뒤로 원소가 더 없으면 false 반환)
		// 세션 이름(key), 세션 값(value)을 불러오기
		String key = en.nextElement().toString();	// en의 다음 원소 탐색 -> String형으로 변환
		String value = session.getAttribute(key).toString();	// 특정 세션 이름에 대한 값을 불러오기 -> String형으로 변환
		
		if(value.equals("admin")){		// 현재 세션값이 "admin"이라면,
			out.println(value+"님");
		}
		size++;		// 세션의 개수만큼 반복문 실행 -> size++도 실행
	}
	
	System.out.println("생성된 세션의 개수: "+size);
	
	// 톰캣의 work directory를 청소하면, 세션을 없앨 수 있음
%>

<a href="logout">로그아웃</a>		<%-- localhost:8080/JSP_250106/logout 으로 접속 --%>

</body>
</html>


