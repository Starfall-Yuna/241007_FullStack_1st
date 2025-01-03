<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%-- c:set => 변수 선언 & 값 설정 --%>
	<%-- html 파일 입력값(param.start, param.end)을 전달받아야 함 --%>
	<c:set var="s" value="${ param.start }"/>
	<c:set var="e" value="${ param.end }"/>
	<c:set var="sum" value="0" />		<%-- int sum = 0; --%>

	<%-- 홀수 나열하여 출력, start부터 end까지 반복문을 돌리면서 홀수만 출력 --%>
	<%-- for(int i=${s}; i<=${e}; i++) --%>
	홀수 출력: 
	<c:forEach var="i" begin="${ s}" end="${ e}" step="1">
		<c:if test="${ i%2 != 0 }">		<%-- 현재의 i가 홀수일 때 --%>
			${i }
		</c:if>
	</c:forEach>
	<br>

	<%-- 짝수 나열하여 출력 --%>
	<%-- for(int i=${s}; i<=${e}; i++) --%>
	짝수 출력:
	<c:forEach var="i" begin="${s }" end="${e }" step="1">
		<c:if test="${ i%2 == 0 }">		<%-- 현재의 i가 짝수일 때 --%>
			${i }
		</c:if>
	</c:forEach>
	<br>
	
	<%-- start ~ end까지의 총합 구하여 출력 --%>
	<c:forEach var="i" begin="${s}" end="${e}" step="1">
		<%-- i를 통해서 전체 총합 구하기 --%>
		<c:set var="sum" value="${sum+i}" />		<%-- (값 설정) sum += i; --%>
	</c:forEach>
	
	${s}부터 ${e}까지의 숫자 총합은 ${sum}입니다.
</body>
</html>





