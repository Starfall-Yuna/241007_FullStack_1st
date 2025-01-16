package com.yse.dev.book.dto;

import java.time.LocalDateTime;

import com.yse.dev.book.entity.Book;

import lombok.Getter;
import lombok.NoArgsConstructor;


@NoArgsConstructor		// 매개변수가 없는 생성자 자동 삽입
@Getter
public class BookEditResponseDTO {
	private Integer bookId;
	private String title;
	private Integer price;
	private LocalDateTime insertDateTime;
	
	// fromBook 함수는 EditResponseDTO 객체를 통하여 접근
	public BookEditResponseDTO fromBook(Book b) {
		this.bookId = b.getBookId();
		this.title = b.getTitle();
		this.price = b.getPrice();
		this.insertDateTime = b.getInsertDateTime();
		return this;
	}
	
	// static 함수 :: 객체를 생성하지 않고도 클래스를 통해 직접 함수 접근O
	public static BookEditResponseDTO BookFactory(Book b) {
		BookEditResponseDTO beDTO = new BookEditResponseDTO();
		beDTO.fromBook(b);
		return beDTO;
	}
}





