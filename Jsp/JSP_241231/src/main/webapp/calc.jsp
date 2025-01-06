<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
   
<%-- 액션 태그 :: 자바 문법을 태그처럼 사용할 수 있게 한 문법 --%>
   
<jsp:useBean id="compute" class="ch07.Calculator" />
<%-- useBean :: 자바빈을 활용해서 객체를 생성하는 구문
	"ch07 패키지의 Calculator 자바빈을 활용하여 compute 객체 생성" 
	"Calculator compute = new Calculator()"와 동일 --%>
	
<jsp:setProperty name="compute" property="*" />
<%-- setProperty :: "멤버(Property)" + "설정한다(set)" 
	"compute 객체의 전체 멤버의 값을 설정한다." 
	html 입력란의 name과 자바빈 멤버의 이름이 같으면 자동으로 값 설정--%>
<%-- setProperty :: set() 함수처럼 작동 --%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>계산 결과 - useBean</title>
</head>
<body>
	<h2>계산 결과-useBean</h2>
	<hr>
	첫번째 숫자 : <jsp:getProperty name="compute" property="n1" />	<br>
	두번째 숫자 : <jsp:getProperty name="compute" property="n2" />	<br>
	연산자 : <jsp:getProperty name="compute" property="op" />		<br>
		<%-- getProperty :: get() 함수처럼 작동 --%>
	결과: <%=compute.calc() %>
</body>
</html>


