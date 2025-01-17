package com.yse.dev.book.service;

import org.springframework.stereotype.Service;

import com.yse.dev.book.dto.BookLogCreateDTO;
import com.yse.dev.book.dto.BookLogCreateResponseDTO;
import com.yse.dev.book.entity.Book;
import com.yse.dev.book.entity.BookLog;
import com.yse.dev.book.entity.BookLogRepository;
import com.yse.dev.book.entity.BookRepository;

// BookLog(책 댓글)에 대한 실질적인 로직 실행
@Service
public class BookLogService {
	// br :: 댓글이 있는 책 검색 수행
	// blr :: 댓글에 대한 CRUD(삽입/삭제/수정 ...) 수행
	private BookRepository br;
	private BookLogRepository blr;
	
	public BookLogService(BookRepository br, BookLogRepository blr) {
		this.br = br;
		this.blr = blr;
	}
	
	// insert() :: 댓글 데이터 삽입 수행 + 삽입한 데이터를 사용자에게 보여주기
	// BookLogCreateDTO :: 책 댓글 삽입에 필요한 내용을 담고 있는 DTO
	//		"댓글의 <내용>과 댓글을 달려하는 <페이지>가 어떻게 되고, 이 댓글은 <어느 책>과 연결이 되는가?"
	// BookLogCreateResponseDTO :: 
	public BookLogCreateResponseDTO insert(BookLogCreateDTO bcDTO) {
		// * 책 댓글 내용을 DB에 저장
		// 댓글이랑 연결된 책의 id를 통해 책 데이터 검색을 하고, 이걸 b에 저장
		Book b = this.br.findById(bcDTO.getBookId()).orElseThrow();
		
		// builder()를 통한, DB에 넣을 책 댓글 데이터를 구성
		BookLog bg = BookLog.builder()
				.book(b)
				.comment(bcDTO.getComment())
				.page(bcDTO.getPage())
				.build();
		
		// 데이터가 구성된 책 댓글 내용을 DB에 삽입 (BookLog 테이블 삽입)
		// 막 삽입한 데이터를 불러와서 bg에 다시 저장
		bg = this.blr.save(bg);
		
		
		// * 사용자에게 보여줄 댓글 내용을 전달
		// 사용자에게 보여줄 내용을 담을 공간(bcrDTO) 마련
		BookLogCreateResponseDTO bcrDTO =  new BookLogCreateResponseDTO();
		
		// DB에 있는 댓글 내용을 bcrDTO에 담기
		bcrDTO.fromBookLog(bg);
		
		return bcrDTO;
	}
}




