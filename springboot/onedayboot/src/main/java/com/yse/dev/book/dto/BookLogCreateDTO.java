package com.yse.dev.book.dto;

import jakarta.validation.constraints.Positive;
import lombok.Getter;
import lombok.NonNull;
import lombok.Setter;

@Getter
@Setter
public class BookLogCreateDTO {
	@NonNull
	@Positive
	private Integer bookId;		// 댓글을 등록한 책 id
	
	@NonNull
	private String comment;		// 댓글 내용
	
	private Integer page;		// 댓글을 남길 책 페이지
	
	// 50p - "ㅠㅠㅠ"
}
