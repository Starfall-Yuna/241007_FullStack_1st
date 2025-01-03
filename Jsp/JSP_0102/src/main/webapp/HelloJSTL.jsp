<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%-- "JSTL 관련 라이브러리 uri를 c라는 이름으로 불러온다." --%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<% String name = "Lee"; %>

	<%-- 변수 선언(set) :: (var)변수이름 / (value)값 --%>
	<c:set var="name" value="LeeYuna" />
	
	<%-- 값 출력(out) :: (value)불러올 값 --%>
	<p>이름: <c:out value="이유나" /></p>
	<p>영어 이름: <c:out value="${name}" /></p>
	
	<%-- 단일 조건문(if) :: (test)조건식 --%>
	<%-- ${} :: 논리식에 대한 true/false 판별 가능 --%>
	<c:if test="${ 1+2!=4 }">
		<p>"1+2!=4"는 참입니다.</p>
	</c:if>
	<c:if test="${ 1+2==4 }">			<%-- else if가 아닌 순수 if --%>
		<p>"1+2!=4"는 거짓입니다.</p>
	</c:if>
	
	<%-- if - else if - else --%>
	<%-- 복수 조건문(choose) :: choose 태그 안으로, 선택지를 나열 (when, otherwise) --%>
	<c:choose>
		<%-- when :: if/else if와 유사, 조건식 필요 --%>
		<%-- otherwise :: else와 유사, 조건식 필요X + 가장 마지막에 작성 --%>
		<c:when test="${ 10>10 }"> 좌측의 값이 큽니다. </c:when>
		<c:when test="${ 10==10 }"> 두 값이 동일합니다. </c:when>
		<c:otherwise>우측의 값이 큽니다.</c:otherwise>		<%-- else와 동일, test 속성 없음 --%>
	</c:choose>
	<br>
	
	<%-- 반복문(forEach) ::  --%>
	<%-- for(int i=1; i<=10; i+=2) --%>
	<%-- i를 2씩 증가 + 1부터 10까지 돌게 한다. --%>
	<c:forEach var="i" begin="1" end="10" step="2">
		${i}
	</c:forEach>
</body>
</html>





