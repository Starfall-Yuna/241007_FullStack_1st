package com.yse.dev.book.dto;

import lombok.Getter;

@Getter
public class BookListResponseDTO {
	// 목록을 이루고 있는 요소 :: 책의 번호(id), 제목(title)
	private Integer bookId;
	private String title;
	
	public BookListResponseDTO(Integer bId, String t) {
		this.bookId = bId;
		this.title = t;
	}
}
