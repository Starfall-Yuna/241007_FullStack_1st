package com.yse.dev.book.dto;

import com.yse.dev.book.entity.BookLog;

import lombok.Getter;

@Getter
public class BookLogCreateResponseDTO {
	private Integer bookLogId;
	private Integer bookId;
	private String comment;
	private Integer page;
	
	public BookLogCreateResponseDTO fromBookLog(BookLog bg) {
		// DB에 있는 내용을 DTO(사용자에게 표현할 화면의 내용)로 받아들이는 과정
		// DB -> 엔티티 -> "DTO" -> 화면 정보(View)
		this.bookLogId = bg.getBookLogId();
		this.bookId = bg.getBook().getBookId();
		this.comment = bg.getComment();
		this.page = bg.getPage();
		return this;
	}
}
