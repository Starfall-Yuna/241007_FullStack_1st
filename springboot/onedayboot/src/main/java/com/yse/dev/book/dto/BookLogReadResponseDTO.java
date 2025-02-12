package com.yse.dev.book.dto;

import java.time.LocalDateTime;

import com.yse.dev.book.entity.BookLog;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
public class BookLogReadResponseDTO {
	// 댓글을 읽어올때 불러올 내용 :: 댓글 번호, 내용, 페이지, 삽입 시간
	private Integer BookLogId;
	private String comment;
	private Integer page;
	private LocalDateTime insertDateTime;
	
	// 댓글 데이터에 대한, 사용자에게 표시할 텍스트
	private String displayComment;
	
	public BookLogReadResponseDTO fromBookLog(BookLog bg) {
		// DB에 있는 댓글 데이터를 현재 DTO 형식으로 변환
		this.BookLogId = bg.getBookLogId();
		this.comment = bg.getComment();
		this.page = bg.getPage();
		this.insertDateTime = bg.getInsertDateTime();
		
		// 사용자에게 표시할 댓글 텍스트를 작성
		this.displayComment = (this.page == null ? "" : "(p."+String.valueOf(this.page)+".)") 
					+ this.comment;
		
		// 작성된 DTO를 반환
		return this;
	}
	public static BookLogReadResponseDTO BookLogFactory(BookLog bookLog) {
		BookLogReadResponseDTO brrDTO = new BookLogReadResponseDTO();
		brrDTO.fromBookLog(bookLog);
		return brrDTO;
	}
}



