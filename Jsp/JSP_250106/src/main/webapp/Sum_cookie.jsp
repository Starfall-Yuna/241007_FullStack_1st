<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%	
	// 링크를 방문할 때마다 방문 횟수가 1씩 추가되는 페이지 구현
	// 방문 횟수 = 쿠키 개수
	// 	=> "링크를 방문할 때마다, 쿠키를 추가" -> "방문횟수 추가"
	//	=> "해당 jsp 파일을 불러올 때마다, 쿠키를 추가"
	
	// 쿠키 정보를 담는 배열 (이 페이지를 접속할 때마다, 존재하는 쿠키 불러오기)
	Cookie ck[] = request.getCookies();		// {name, value} 쌍으로 배열에 하나씩 저장
	
	// 쿠키 개수 = 방문 횟수
	int count = ck.length;
	System.out.println(count);
	
	// 방문횟수를 늘리기 위한 쿠키 객체 생성 (쿠키 이름과 값은 중요X, "쿠키 이름끼리 중복X")
	// 쿠키 이름 :: "visit1", "visit2", "visit3"...		(이 페이지 방문할 때마다 count값이 증가)
	Cookie new_ck = new Cookie("visit"+count, "0"); 
	
	// 각 쿠키의 유효시간은 하루로 설정(60s * 60m * 24h)
	new_ck.setMaxAge(60*60*24);
	
	// 새로 생성한 쿠키를 응답에 포함
	// sum_cookie.jsp의 response	=> sum_cookie.jsp의 request로 전달
	response.addCookie(new_ck);		// 브라우저로 쿠키 정보 저장한 상태
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<p>당신은 이 사이트를 총 <%=count %>번 방문하였습니다.</p>
	<p>(쿠키의 총 개수: <%=count %>개)</p>
	<p>각 쿠키는 하루가 지나면 소멸합니다.</p>
	
	<!-- count에 대한 값을 불러오기 -> 새로운 쿠키 삽입 -->
</body>
</html>