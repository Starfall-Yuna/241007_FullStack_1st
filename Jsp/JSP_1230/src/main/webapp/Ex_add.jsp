<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	
	<h3>덧셈을 수행할 숫자를 입력해주세요</h3>
	<hr>
	
	<form action="Ex_add.jsp">
		<label>수 입력 </label>
		<input type="text" name="num" >
		
		<input type="submit" value="더하기" >
	</form>
	
	<%!
		// 톰캣 상에서 Ex_add.jsp를 처음 실행할 때에만 수행
		int result = 0;
	%>

	<%
		// Ex_add.jsp를 실행할때마다 수행
		// int result = 0;
	
		if(request.getParameter("num") != null){	// 입력란에 대해서 값이 전달되는 경우에만 수행
			// 숫자를 입력받는 input의 value값 당겨오기
			int n = Integer.parseInt(request.getParameter("num"));
			
			// 덧셈 수행
			result += n;	
		}
	%>
	
	<h4>덧셈 결과: <%=result %></h4>
	
		
	<%-- 
		* 선언된 것이 언제까지 유효한가?
		<% %>에서의 선언문 :: 해당되는 파일을 불러올 때마다 선언문 실행
		<%! %>에서의 선언문 :: 지정된 서버 상에서 파일을 초회 실행할 때 선언문 실행
					지정된 서버에 있어 파일을 재실행할 때엔 실행X
	 --%>
</body>
</html>








