package com.yse.dev.book.service;

import org.springframework.stereotype.Service;

import com.yse.dev.book.dto.BookCreateDTO;
import com.yse.dev.book.entity.Book;
import com.yse.dev.book.entity.BookRepository;

// 서비스 :: 기능과 관련한 실제 로직을 구현한 파일

@Service
public class BookService {
	// 책 삽입/삭제/수정과 같은 기능 수행을 위하여 리포지토리(JpaRepository) 불러오기
	private BookRepository br;
	
	public BookService(BookRepository b) {
		// 서비스 파일을 활용하기 이전에, br에 대해서 활성화
		this.br = b;
	}
	
	// insert() :: 책 입력과 관련된 직접적인 기능
	// insert() 수행하기 이전에, DTO 통해서 책의 제목(title), 가격(price) 정보 받음
	public Integer insert(BookCreateDTO bd) {
		// 1. DB에 넣어줄 Book 엔티티(테이블)의 데이터 작성
		Book book_data = Book.builder()
				.title(bd.getTitle())	
				.price(bd.getPrice())	
				.build();
		// 전달받은 책 제목을 테이블의 title에 삽입
		// 전달받은 가격을 테이블의 price에 삽입
		
		// 2. 위에서 작성한 책 데이터를 리포지토리를 통해 삽입문 수행
		this.br.save(book_data);
		
		// 
		return book_data.getBookId();
	}
}




