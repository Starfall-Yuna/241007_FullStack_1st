package com.yse.dev.book.dto;

import com.yse.dev.book.entity.Book;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Positive;
import lombok.Getter;
import lombok.NonNull;
import lombok.Setter;

@Getter		// 각 멤버의 get 함수 자동 생성
@Setter		// 각 멤버의 set 함수 자동 생성
public class BookEditDTO {
	// bookId를 통해 데이터에 접근 & 접근한 데이터에 대해 입력값인 title, price 값으로 갱신
	@NonNull
	@Positive		// (Validation 소속) 값을 자연수로 제한함
	private Integer bookId;
	
	@NonNull		// (lombok 소속) null값을 갖지 않게 함				(null에 대해서만 제한)
	@NotBlank		// (Validation 소속) 빈 값(null)에 대해서 취급하지 않음	
					// 		(null, 빈값(""), 공백(" ")을 갖지 못함)
	private String title;
	
	@NonNull
	@Min(1000)		// (Validation 소속) 최소 1000 이상의 값을 가지게끔 제한함
	private Integer price;
	
	public Book fill(Book b) {
		// this.title, this.price	=> DTO에 있는 값 (프로젝트 내부에 있는 값)
		// DB와 맞닿아있는 엔티티의 데이터를 설정하고 있음
		//	=> 프로젝트 내부에 있는 값을 DB로 넘겨주고 있음
		//	=> fill() :: DB의 데이터 수정하는 함수
		b.setTitle(this.title);
		b.setPrice(this.price);
		return b;
	}
}




