<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<!-- HTML 주석 -->
	<%-- JSP 주석 --%>
	
	<%-- 서버를 통해 값을 전달할 때,
		[name값]=[value값] 형식으로 값 전달 --%>
	
	<h3>아래 인적사항을 입력해주세요</h3>
	
	<%-- n과 g 값을 전달하면서 review.jsp로 돌아옴 --%>
	<form action="Review.jsp" method="get">
		<label>이름 </label>
		<input type="text" name="n" />
		<br>
		
		<label>성별 </label>
		<input type="radio" name="g" value="남성" >
		<label>남성</label>
		<input type="radio" name="g" value="여성">
		<label>여성</label>
		<br>
		
		<input type="submit" value="제출" >
	</form>
	
	<%-- info.jsp 내용을 review.jsp의 <form> 아래에 표현 --%>
	<%-- info.jsp의 body 내용이 삽입 --%>
	<%@ include file="info.jsp" %>
</body>
</html>




