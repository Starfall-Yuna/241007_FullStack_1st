package com.yse.dev.book.entity;

import java.time.LocalDateTime;

import org.hibernate.annotations.CreationTimestamp;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data			// (lombok) 멤버 변수 관련 함수 생성 (getter, setter, ...)
@Builder		// (lombok) 자동으로 생성자 만들어줌
@NoArgsConstructor		// 매개변수가 없는 생성자가 자동으로 만들어짐
@AllArgsConstructor		// 모든 멤버에 대한 매개변수가 있는 생성자가 자동으로 만들어짐
public class Book {
	// 각 책에 대한 데이터 입력 틀을 정의
	@Id		// bookId가 식별자(Primary Key)임을 선언
	@GeneratedValue(strategy = GenerationType.IDENTITY)		
		// 값을 자동으로 생성해줌 (책이 하나씩 들어오는대로 1, 2, 3, ... 순서대로 값이 들어감)
	private Integer bookId;
	
	@Column(length=200)		
	private String title;	// String(length=200) -> VARCHAR(200)
	
	private Integer price;
	
	@CreationTimestamp		// 데이터 생성된 시점의 시간 설정
	private LocalDateTime insertDateTime;
	
	// 여기까지 작성해서 실행하면, 총 4개의 칼럼을 가진 테이블 생성
	// Entity -> DB 서버와 직접 연결하여, 테이블에 접근
}



