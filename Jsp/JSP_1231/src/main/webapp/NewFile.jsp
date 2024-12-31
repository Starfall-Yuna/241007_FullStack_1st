<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<form action="Newfile.jsp" method="get">
		<label>이름 </label>
		<input type="text" name="n" >	<br>
		
		<label>성별</label>
		<input type="radio" name="g" value="남성">
		<label>남성</label>
		<input type="radio" name="g" value="여성">
		<label>여성</label>	<br>
		
		<label>취미</label>
		<input type="checkbox" name="h" value="운동">
		<label>운동</label>
		<input type="checkbox" name="h" value="독서">
		<label>독서</label>
		<input type="checkbox" name="h" value="게임">
		<label>게임</label>
		<input type="checkbox" name="h" value="명상">
		<label>명상</label>	<br>
		
		<input type="submit" value="POST실행">
	</form>
	<hr>
	
	<% if(request.getParameter("name")!=null && request.getParameter("gender")!=null){ %>
		<jsp:useBean id="stu" class="ex.Student" />
		<jsp:setProperty name="stu" property="*" />
	
	이름: <jsp:getProperty name="stu" property="name"/>
	성별: <jsp:getProperty name="stu" property="gender"/>
	<%} %>
</body>
</html>