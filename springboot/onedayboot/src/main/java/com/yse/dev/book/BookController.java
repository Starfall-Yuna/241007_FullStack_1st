package com.yse.dev.book;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

import com.yse.dev.book.dto.BookCreateDTO;
import com.yse.dev.book.service.BookService;

// 프레임워크 :: (언어X) 특정 언어를 목적에 맞게끔 설계한 도구/환경
//		Java라는 언어로 웹을 구축하기 위해 만들어진 프레임워크 :: Spring(톰캣) -> SpringBoot(자동화, 내장 서버 탑재)
// JPA 구조 :: (DB 필수) DB의 테이블 칼럼 구조 - 스프링부트의 엔티티(자바빈) 멤버 구조를 매핑(연결, 일체화)

@Controller		// (책과 관련된) 사용자가 접속을 요청하는 링크에 대해, 어느 로직을 수행할지 "중앙 제어"
public class BookController {
	@Autowired		// bs에 관련된 의존성 넣어줌
	private BookService bs;
	
	// GET 방식으로 "localhost:8080/book/create"에 접속할 때, create() 함수 실행
	// GET 방식 (브라우저 주소창에 링크를 입력하여 직접 접속하는 방식)
	@GetMapping("/book/create")
	public String create() {
		return "book/create";	// 탬플릿에 있는 book/create.html 찾아서 실행
	}
	
	// create.html에서 "저장 버튼"을 눌렀을 때 실행될 예정 (입력값 2개를 DTO로 전달)
	@PostMapping("/book/create")
	public String insert(BookCreateDTO bd) {
		// service를 통해서, 책 입력에 대한 기능 수행
		Integer bookId = this.bs.insert(bd);
		
		// read.html로 페이지 이동
		return String.format("redirect:/book/read/%s", bookId);
	}
}





