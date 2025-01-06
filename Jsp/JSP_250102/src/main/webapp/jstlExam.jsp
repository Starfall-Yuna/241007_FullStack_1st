<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>JSTL 종합 예제</title>
</head>
<body>
	<h2>JSTL 종합 예제</h2>
	<hr>
	
	<h3>set, out</h3>
	<c:set var="product1" value="<h2>애플 아이폰</h2>" />
	<c:set var="product2" value="삼성 갤럭시 노트"/>
	<c:set var="intArray" value="${ [10,20,30,40,50] }" />
	
	<p>
		<%-- <c:out> default :: 해당되는 변수가 없을 때 대체 텍스트 --%>
		<%-- c:out :: 순수 텍스트로 불러오기 --%>
		product1(jstl): <c:out value="${product1}" default="Not Registered" />
	</p>
	<%-- ${} 안의 식에 대한 연산을 자동으로 수행 -> html 문법에 대한 연산도 같이 함 --%>
	<p>product1(el): ${product1}</p>
	<p>intArray[2]: ${intArray[2]} </p>
	<hr>
	
	<h3>forEach: 배열 출력</h3>
	<ul>
		<%--
			varStatus 속성 :: 리스트/배열에서 어느 위치를 탐색하는지를 의미
				(varStatus.index :: 탐색하고 있는 리스트/배열의 위치)
			var 속성 :: items에 순차적으로 접근하는 요소값
			items 속성 :: 실질적인 값 	(items의 크기만큼 반복 수행)
		--%>
		<c:forEach var="num" varStatus="i" items="${intArray}">
			<%-- 5번의 반복을 수행 --%>
			<li>${i.index} : ${num}</li>
		</c:forEach>
	</ul>
	<hr>
	
	<%-- 단일 조건문 :: <c:if> --%>
	<h3>if</h3>
	<c:if test="${!empty product2}">	<%-- "product2에 값이 있다면" -> 배정된 value값이 없으면 실행X--%>
		<p>
			<b>${product2} :: 이미 추가됨!!</b>
		</p>
	</c:if>
	
	<%-- 단일 조건문 2개 :: 아래 2개의 조건문은 독립적으로 작동을 함 --%>
	<c:set var="checkout" value="false" />
	<c:if test="${ checkout==true }">			<%-- if --%>
		<p>주문 제품 :: ${product2}</p>
	</c:if>
	<c:if test="${ checkout!=true }">			<%-- if --%>
		<p>주문 제품이 아님!!</p>
	</c:if>
	<hr>
	
	<%-- 복수 조건문 :: when 또는 otherwise 둘 중에 하나만 실행 --%>
	<h3>choose, when, otherwise</h3>
	<c:choose>
		<c:when test="${checkout==true }">		<%-- if --%>
			<p>주문 제품: ${product2 }</p>
		</c:when>
		<c:otherwise>							<%-- else --%>
			<p>주문 제품이 아님!!</p>
		</c:otherwise>
	</c:choose>
	<hr>
	
	<h3>forTokens</h3>
	<%--
		forTokens :: 주어진 여러 데이터에 있어서, 각 데이터를 구분하는 기호가 있을 때 활용
		
		- delims 속성 :: 각 데이터를 구분하는 기호 입력
			=> 이 속성을 통해서 {"Seoul", "Tokyo", "New York", "Toronto"} 배열로 구성
	 --%>
	<c:forTokens var="city" items="Seoul | Tokyo | New York | Toronto" delims="|" varStatus="i">
		<%-- 현재 접근한 요소가 배열의 첫번째일 때 
			= 현재 배열 번호가 0번일 때 --%>
		<c:if test="${ i.first==true }">도시 목록: </c:if>
		${city }
		<c:if test="${ i.last != true }">,</c:if>		<%-- 현재 접근한 요소가 배열의 마지막이 아닐 때, 쉼표 출력 --%>
	</c:forTokens>
</body>
</html>








