package com.yse.dev.book.entity;

import java.time.LocalDateTime;

import org.hibernate.annotations.CreationTimestamp;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.FetchType;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

// 각 댓글에 대한 구성
@Entity 
@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class BookLog {
	 @Id
	 @GeneratedValue(strategy = GenerationType.IDENTITY)
	 private Integer bookLogId;
	
	 // N:1 관계 성립 (N: BookLog(댓글) / 1 : Book(책)) 	
	 @ManyToOne(fetch = FetchType.LAZY)		// -> 로딩을 천천히 한다.
	// BookLog의 book 내용을 Book의 book_id 칼럼을 통해 참조 (외래키)
	 @JoinColumn(name = "book_id")
	 private Book book;
	 
	 // 보통 String으로 정의된 멤버 -> VARCHAR로 연결
	 // String으로 정의를 하지만, DB에서의 타입은 TEXT로 지정함
	 @Column(columnDefinition = "TEXT")
	 private String comment;
	 
	 private Integer page;
	 
	 @CreationTimestamp
	 private LocalDateTime insertDateTime;
	 
	 // BookLog 칼럼 :: 댓글 고유번호(bookLogId), 댓글과 연결된 책 정보(book)
	 //		댓글 내용(comment), 책 페이지(page), 댓글 생성한 시점(insertDateTime)
}





