package com.yse.dev.book.service;

import java.util.NoSuchElementException;

import org.springframework.stereotype.Service;

import com.yse.dev.book.dto.BookCreateDTO;
import com.yse.dev.book.dto.BookEditResponseDTO;
import com.yse.dev.book.dto.BookReadResponseDTO;
import com.yse.dev.book.entity.Book;
import com.yse.dev.book.entity.BookRepository;

// 서비스 :: 기능과 관련한 실제 로직을 구현한 파일

@Service
public class BookService {
	// 책 삽입/삭제/수정과 같은 기능 수행을 위하여 리포지토리(JpaRepository) 불러오기
	private BookRepository br;
	
	public BookService(BookRepository b) {
		// 서비스 파일을 활용하기 이전에, br에 대해서 활성화
		this.br = b;
	}
	
	// insert() :: 책 입력과 관련된 직접적인 기능
	// insert() 수행하기 이전에, DTO 통해서 책의 제목(title), 가격(price) 정보 받음
	public Integer insert(BookCreateDTO bd) {
		// 1. DB에 넣어줄 Book 엔티티(테이블)의 데이터 작성
		Book book_data = Book.builder()
				.title(bd.getTitle())	
				.price(bd.getPrice())	
				.build();
		// 전달받은 책 제목을 테이블의 title에 삽입
		// 전달받은 가격을 테이블의 price에 삽입
		
		// 2. 위에서 작성한 책 데이터를 리포지토리를 통해 삽입문(save()) 수행
		this.br.save(book_data);
 
		return book_data.getBookId();
	}
	
	// read() :: "책 정보 읽기"와 관련된 직접적인 로직 실행
	// NoSuchElementException :: 사용자가 요청한 요소가 실제로 DB에 존재하지 않을 때 예외처리 발생
	public BookReadResponseDTO read(Integer bookId) throws NoSuchElementException{	
		// findById(bookId) :: 전달받은 bookId를 참고해서, @Id(PK) 기준으로 데이터 찾기
		// orElseThrow() :: 만약에 데이터를 찾지 못하면, 예외처리 발생
		Book b = this.br.findById(bookId).orElseThrow();
		
		// DTO 형식의 객체 생성 (책 정보 읽기와 관련하여 필요한 데이터를 저장할 공간 마련)
		BookReadResponseDTO brDTO = new BookReadResponseDTO();	// DB에 있는 4개 데이터 저장할 수 있는 객체 마련
		// DB에 있는 데이터로, DTO 객체 내용을 채워넣기
		brDTO.fromBook(b);
		
		// 4개의 데이터가 모두 채워졌다면, 전달할 데이터 형식이 완성 -> 보내주기
		return brDTO;
	}
	
	// delete() :: 기존에 있는 책 정보를 제거하는 기능 수행
	//		어느 데이터를 제거할건지에 대한 단서 :: bookId
	// 		존재하지 않는 데이터에 대해 제거를 수행하려했다면 	-> NoSuchElementException 예외 발생
	public void delete(Integer bookId) throws NoSuchElementException {
		// DB로부터 제거할 데이터 검색 (findById())
		Book b = this.br.findById(bookId).orElseThrow();
		
		// DB에 있는 검색된 데이터에 대해 제거
		this.br.delete(b);
	}
	
	// edit() :: DB에 있는 책 데이터를 수정하는 함수
	// id값이 bookId인 책 데이터를 수정하기 위해 -> 매개변수로 받고 있음
	// 수정하고자 하는 데이터가 DB에 없다면 -> 예외 발생
	public BookEditResponseDTO edit(Integer bookId) throws NoSuchElementException{
		// 수정할 책 데이터에 대해 DB 상 검색
		// 만약에 존재하지 않는 데이터인 경우엔, edit() 실행 중단하고 예외 발생
		Book b = this.br.findById(bookId).orElseThrow();
		
		// 별도로 만든 DTO 객체를 활용
//		BookEditResponseDTO beDTO = new BookEditResponseDTO();
//		beDTO.fromBook(b);
//		return beDTO;
		
		// DTO 객체 별도로 만들지 않고 함수 결과를 바로 반환
		return BookEditResponseDTO.BookFactory(b);
	}
}




