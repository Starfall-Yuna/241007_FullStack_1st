package com.yse.dev.book.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.yse.dev.book.dto.BookLogCreateDTO;
import com.yse.dev.book.dto.BookLogCreateResponseDTO;
import com.yse.dev.book.service.BookLogService;

// 공통점 :: 특정 링크에 대한 로직을 연결하여 "중앙 제어"
// @Controller :: (데이터를 넘겨줄 때도 있었지만) "화면 정보(View)"를 넘겨서 사용자에게 보여주는 역할
// @RestController :: "데이터 묶음(JSON)"을 웹 서버(스프링부트 내장서버/톰캣)로 응답을 전달
//			해당 프로젝트에선, DB에 있는 값을 불러오기 위한 컨트롤러
//			(스프링부트 내장서버 :: localhost:8080)

@RestController
@RequestMapping("/book-log")
public class BookLogController {
	// 실제 기능을 수행하기 위한 서비스 선언
	private BookLogService bls;
	
	// 서비스에 대해서 활성화
	@Autowired		// 필요한 의존성 자동 삽입
	public void setBookLogService(BookLogService bls) {
		this.bls = bls;
	}
	
	// read.html에서 ajax 통신 시도할 시
	// POST 방식으로 "localhost:8080/book-log/create"로 접속할 시 아래 함수 수행
	// bcDTO :: read.html에 있는 post_data 내용 전달받음
	@PostMapping("/create")
	public ResponseEntity<BookLogCreateResponseDTO> insert(@RequestBody BookLogCreateDTO bcDTO){
		// BookLogCreateDTO :: 사용자가 입력 or 링크에 있는 파라미터를 통해 전달받은 값
		//	(ex) (2번 책에 대한 댓글) 50p - "ㅠㅠㅠ"
		// {
		//		bookId: 2,
		//		page: 50,
		//		comment: "ㅠㅠㅠ"
		// }	=> 사용자가 "댓글 입력" 눌렀을 때, 이 형태로 insert()의 매개변수 값으로 전달
		// BookLogCreateResponseDTO :: 
		//		사용자가 방금 막 입력한 댓글의 내용을 확인할 수 있게끔, DB에 저장된 데이터를 다시 불러옴
		BookLogCreateResponseDTO bcrDTO = this.bls.insert(bcDTO);
		// bcrDTO :: DB에 저장한 댓글의 내용 
		//	(댓글의 고유 번호(댓글을 DB에 삽입 시 자동 생성값), 댓글을 단 책 번호, 내용, 페이지)
		
		// ResponseEntity :: "웹 서버로 전송"하는 응답 (bcrDTO의 데이터 묶음)
		// ok() :: "정상적"으로 웹 서버 전송 (DB로부터 사용자(html)에게 넘기기 위해)
		return ResponseEntity.ok(bcrDTO);
	}
}




