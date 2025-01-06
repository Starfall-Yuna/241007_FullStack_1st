<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
   // 1. 세션 객체 ss 생성 (HttpSession)	-> 서버에 있는 변수 접근 목적
   HttpSession ss = request.getSession();		// ss를 통해서, 세션 접근
   
   // 2. 세션에 저장된 변수로 방문 횟수(int) 불러오기 (getAttribute() -> 세션 변수 불러오기)
   //	int형 변수에 null값이 들어갈 일이 생기고, 거기에 대한 예외 처리해야할 때
   //		=> int(X), Integer(O)		< int는 단순 정수형, Integer는 Object형 정수형 >
   Integer visitCnt = (Integer) ss.getAttribute("visitCount");		// getAttribute() :: Object 타입 반환
   if(visitCnt == null){	// 홈페이지 첫 실행 :: 서버에 변수 존재X, null값이 나옴
	   visitCnt = 0;
   }
   
   // 3. 방문 횟수(visitCnt) 증가하여, 세션 갱신
   ++visitCnt;
   ss.setAttribute("visitCount", visitCnt);
   
   // 콘솔 상의 출력 :: 세션에 있는 변수값 출력
   // 1번째로 실행한 setAttribute() 값	=> 2번째로 실행했을 때의 getAttribute() 값이 향함
 	System.out.println((Integer) ss.getAttribute("visitCount"));
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>방문 카운터</h1>
	<p>당신은 이 페이지를 <%=visitCnt %>번 방문하셨습니다.</p>
	<%-- html 상 출력 :: visitCnt 변수값 출력 --%>
</body>
</html>