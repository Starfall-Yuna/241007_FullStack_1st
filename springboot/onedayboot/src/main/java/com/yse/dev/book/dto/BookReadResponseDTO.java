package com.yse.dev.book.dto;

import java.time.LocalDateTime;

import com.yse.dev.book.entity.Book;

import lombok.Getter;
import lombok.NoArgsConstructor;

// 책 상세 페이지를 불러올 때 사용할 DTO
// BookReadResponseDTO :: 
//	"응답으로 수행할 책 정보 확인"과 관련된 정보를 내부에서 전달할 때 쓰는 형식

// @Setter가 없는 이유 :: 기존에 있는 책 정보를 불러오기만 하기 때문에
@NoArgsConstructor		// 매개변수가 없는 생성자 자동 삽입
@Getter
public class BookReadResponseDTO {
	// Book 엔티티(테이블) 내용 :: 4가지(제목, 가격, id번호, 데이터 생성시간)
	// DB와 소통하기 위해 있는 엔티티(X), 프로젝트에서 사용자에게 정보를 표시하기 위해 있는 DTO(O)
	private Integer bookId;
	private String title;
	private Integer price;
	private LocalDateTime insertDateTime;
	
	// Book 엔티티(외부)의 데이터를 매개변수로, DTO(내부) 형식으로 반환
	// fromBook() :: DTO 객체의 멤버값 설정
	public BookReadResponseDTO fromBook(Book b) {
		// DB로부터 데이터를 받아서, DTO 내용 채워줌
		this.bookId = b.getBookId();	// DB 테이블의 book_id값을 DTO의 bookId로 전달
		this.title = b.getTitle();
		this.price = b.getPrice();
		this.insertDateTime = b.getInsertDateTime();
		return this;	// 내용을 채워넣은 DTO 객체 넘겨줌
	}
	
	// BookFactory() :: DB로부터 데이터를 가져와서, 응답 페이지로 전달할 DTO 생성
	public static BookReadResponseDTO BookFactory(Book b) {
		// 책 상세 페이지에 표시할 데이터를 담을 공간 마련
		BookReadResponseDTO brDTO = new BookReadResponseDTO();
		// fromBook() 통해서, DB를 참조하며 페이지로 전달할 데이터 담음
		brDTO.fromBook(b);
		// 완성된 데이터 묶음을 반환
		return brDTO;
	}
}





