package com.yse.dev.book.entity;

import org.springframework.data.jpa.repository.JpaRepository;

// Jpa를 통하여, DB 서버에 직접적인 접근 가능 (데이터에 변동을 줄 수도 있음)

// 리포지토리에서 어떤 테이블에 접근할건지에 대한 내용이 필요해서, 엔티티의 정보가 필요
//		따라서, 둘은 웬만해서는 같은 패키지 안에 작성
// 엔티티 :: 스프링부트 - DB 서버 중간에 있어, 데이터 구조 정의
// 리포지토리 :: 현재 연결된 DB 서버의 Book 테이블에 있어 CRUD 작업 처리
//		Integer가 쓰인 이유 :: 해당되는 테이블의 PK 타입이 Integer라서
public interface BookRepository extends JpaRepository<Book, Integer>{
	
}
