package com.yse.dev.book.dto;

import lombok.Getter;
import lombok.NonNull;
import lombok.Setter;

// DTO :: 스프링부트 프로젝트 내부의 파일들끼리 정보를 전달할 때 쓰는 형식
// BookCreateDTO :: "책 입력"과 관련된 정보를 내부에서 전달할 때 쓰는 형식

@Getter		// 멤버 변수에 대한 get 함수 자동 생성
@Setter		// 멤버 변수에 대한 set 함수 자동 생성
public class BookCreateDTO {
	@NonNull
	private String title;
	
	@NonNull
	private Integer price;
}
