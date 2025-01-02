<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- EL 연산 :: ${연산식} --%>
	<p> ${"이유나"} </p>
	<p> 10+10 = ${10+10}</p>
	<p> 100*5 = ${100*5}</p>
	<p> 4 >= 10 = ${4>=10}</p>
	
	<%!
		String hello="HelloWorld";
		int add(int a, int b){
			return a+b;
		}
	%>
	<p> hello 변수값 출력: <%=hello %></p>
	<p> add(5, 10) 값 출력: <%= add(5,10) %></p>
	
	<script>
		console.log(`100+100은 ${100+100}입니다.`);
	</script>
</body>
</html>




