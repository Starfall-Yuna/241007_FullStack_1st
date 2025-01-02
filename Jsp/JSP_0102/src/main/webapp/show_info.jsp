<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h3>회원 정보 출력</h3>
	<p>
		이름: ${param.name }	<br>
		이메일: ${param.email }		<br>
	</p>

	<%-- add_info.jsp의 내용을 해당 위치에 포함
		add_info.jsp의 내용에 접근할 때 2개의 값을 전송 --%>
	<jsp:include page="add_info.jsp">
		<jsp:param name="n" value="LeeYuna" />
		<jsp:param name="e" value="@" />
	</jsp:include>
	
	<form action="review_action.html">
		<input type="submit" value="회원가입 폼으로 돌아가기" />
	</form>
</body>
</html>