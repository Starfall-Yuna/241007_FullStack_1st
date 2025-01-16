package com.yse.dev.book.entity;

import org.springframework.data.jpa.repository.JpaRepository;

// 역할 :: 댓글(BookLog)에 대한 CRUD 수행
public interface BookLogRepository extends JpaRepository<BookLog, Integer>{

}
