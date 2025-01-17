package com.yse.dev.book.service;

import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.stereotype.Service;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.data.domain.Sort.Direction;
import org.springframework.data.domain.Sort.Order;

import com.yse.dev.book.dto.BookCreateDTO;
import com.yse.dev.book.dto.BookEditDTO;
import com.yse.dev.book.dto.BookEditResponseDTO;
import com.yse.dev.book.dto.BookListResponseDTO;
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
	
	// update() :: DB의 내용을 수정하는 데에 활용	(프로젝트 내부 데이터 -> DB로)
	// beDTO :: 수정할 데이터의 id값, 수정하고자 하는 제목/가격
	public void update(BookEditDTO beDTO) throws NoSuchElementException{
		// id값을 기반으로 검색 수행하여서, 검색 결과를 b에 저장 ("Book 테이블 형식을 갖추어" DB에 전송할 예정)
		Book b = this.br.findById(beDTO.getBookId()).orElseThrow();
		
		// b :: 기존에 있는 책 데이터
		// save_b :: DB에 새로 덮어씌울 데이터 갖게끔 구성 (DB에 저장할 값)
		// fill() :: 사용자 입력값을 DB에 넘겨줄 객체 저장
		Book save_b = beDTO.fill(b);
		
		// 수정할 데이터를 삽입 시도
		this.br.save(save_b);
	}
	
	// bookList() :: 여러 개의 책 데이터를 목록으로 출력하는 함수
	// 매개변수 p :: 어느 페이지에 접근할 것인지에 대한 변수
	public List<BookListResponseDTO> bookList(String t, Integer p, Integer MaxSize){
		// DB 데이터 조회한 결과를 담아줄 공간 생성
		List<Book> books;
		
		// 현재 접속하고자 하는 페이지 값에 따른 처리
		if(p == null) {
			p = 0;
		}else {
			p -= 1;
		}
		
		// 사용자가 제시한 검색어가 있는지/없는지에 따른 값 처리
		if(t == null) {		// 검색어가 없을 때	-> 전체 데이터 조회
			Pageable pa = PageRequest.of(p, MaxSize, Direction.DESC, "insertDateTime");
				// "insertDateTime"을 기점으로 내림차순 정렬했을 때
				// p번 페이지를 펼치는데 MaxSize 이하의 데이터를 표시한다.	
				// Pageable :: 페이지 형식 정의하여, 실질적인 데이터 중 어떤 데이터를 뽑아올지 결정
			books = this.br.findAll(pa).toList();	// toList() :: List로 변환
		}
		else {	// 사용자가 입력한 검색어(t)가 있을 때			
			// 첫번째 매개변수 :: p	()
			// 두번째 매개변수 :: pageSize	(한 페이지에 표현할 최대 데이터 개수)
			// (ex) 20개의 데이터 조회	-> 한 페이지에 3개씩 하여 7페이지로 구성
			Pageable pa = PageRequest.of(p, MaxSize);		// 목록의 페이지 구성
			// sort 객체 :: "insertDateTime" 기점으로 내림차순 "정렬"할 수 있는 객체 
			//		늦게 삽입한 데이터일수록 상위에 출력이 되게끔 구성
			Sort s = Sort.by(Order.desc("insertDateTime"));
			// s에 있는 내용을 참고하며, Pageable 객체 안에 있는 정렬 함수(getSort()) 수행 
			pa.getSort().and(s);
			// 사용자가 제시한 검색어(t)와 결과 페이지 구성(pa)을 참고하며, DB에 대해 검색 수행
			// 그 검색 결과를 List(books)에 담아줌
			books = this.br.findByTitleContains(t, pa);
		}
		
		
		// books :: (늦게 삽입한 데이터가 상위로 정렬)
		//		검색어를 제목으로 포함하고 있는 데이터(t!=null) or 전체 데이터(t==null) 갖고 있음
		
		// books에 있는 요소 하나하나를 book으로 접근
		// 4개의 칼럼 데이터 중에서 2개의 칼럼 데이터(DTO)만 골라서 Controller로 전송
		return books
				.stream()		// 데이터 생성 모드 변환
				.map(book -> new BookListResponseDTO(book.getBookId(), book.getTitle()))
				.collect(Collectors.toList());
	}
}








