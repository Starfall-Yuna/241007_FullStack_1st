<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body> 
	<h3>반려동물 정보 입력</h3>
	<form method="get">
		<label>이름 </label>
		<input type="text" name="name">	<br>
		<label>성별</label>
		<input type="radio" name="gender" value="남자">
		<label>남자</label>
		<input type="radio" name="gender" value="여자">
		<label>여자</label>				<br>
	
		<input type="submit" value="GET실행" >
	</form>
	<hr>
	<h3>인적사항 정보 입력</h3>
	<form method="post">
		<label>이름 </label>
		<input type="text" name="name">	<br>
		<label>성별</label>
		<input type="radio" name="gender" value="남성">
		<label>남성</label>
		<input type="radio" name="gender" value="여성">
		<label>여성</label>				<br>
	
		<input type="submit" value="POST실행" >
	</form>
</body>
</html>