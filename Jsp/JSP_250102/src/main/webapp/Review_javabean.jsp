<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<% // 자바문법 + html 문법 섞여 -> 가독성 떨어질 수 있음 %>

	<%-- Java Bean(=클래스) :: 객체를 만들어내는 틀
		각각의 유저 / 게시판 / 상품 / ... --%>
	<%-- 자바빈과 관련된 액션 태그 :: useBean, setProperty, getProperty --%>
	
	<%-- useBean :: (id)객체 이름 / (class)객체 생성 시 활용할 자바빈(클래스)  --%>
	<%-- User user1 = new User(); 	"생성자 실행" --%>
	<jsp:useBean id="user1"  class="ex.User" />
	<h3>User 객체의 기본값</h3>
	<p>이름: <%=user1.getName() %> </p>
	<p>이메일: <%=user1.getEmail() %></p>
	<hr>
	
	<%
		String name="LeeYuna";
		String email="dbskakfl57913@gmail.com";
	%>
	
	<%-- user1의 변수값 설정 --%>
	<%-- setProperty :: (name)접근할 객체이름 / (property)접근할 멤버변수 / (value) 설정할 값 --%>
	<jsp:setProperty name="user1" property="name" value="<%=name %>" />
	<jsp:setProperty name="user1" property="email" value="${email}" />
	
	<%-- user1의 변수값 불러오기 --%>]
	<%-- getProperty :: (name)접근할 객체이름 / (property)접근할 멤버변수 --%>
	<h3>User 객체의 설정된 값</h3>
	<p>이름: <jsp:getProperty name="user1" property="name" /></p>
	<p>이메일: <jsp:getProperty name="user1" property="email" /> </p>
</body> 
</html>




