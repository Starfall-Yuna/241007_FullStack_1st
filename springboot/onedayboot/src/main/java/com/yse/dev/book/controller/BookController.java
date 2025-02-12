package com.yse.dev.book.controller;

import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.validation.Errors;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

import com.yse.dev.book.dto.BookCreateDTO;
import com.yse.dev.book.dto.BookEditDTO;
import com.yse.dev.book.dto.BookEditResponseDTO;
import com.yse.dev.book.dto.BookListResponseDTO;
import com.yse.dev.book.dto.BookReadResponseDTO;
import com.yse.dev.book.service.BookService;

// 프레임워크 :: (언어X) 특정 언어를 목적에 맞게끔 설계한 도구/환경
//		Java라는 언어로 웹을 구축하기 위해 만들어진 프레임워크 :: Spring(톰캣) -> SpringBoot(자동화, 내장 서버 탑재)
// JPA 구조 :: (DB 필수) DB의 테이블 칼럼 구조 - 스프링부트의 엔티티(자바빈) 멤버 구조를 매핑(연결, 일체화)

@Controller		// (책과 관련된) 사용자가 접속을 요청하는 링크에 대해, 어느 로직을 수행할지 "중앙 제어"
public class BookController {
	@Autowired		// bs에 관련된 의존성 넣어줌
	private BookService bs;
	
	// GET 방식으로 "localhost:8080/book/create"에 접속할 때, create() 함수 실행
	// GET 방식 (브라우저 주소창에 링크를 입력하여 직접 접속하는 방식)
	@GetMapping("/book/create")
	public String create() {
		return "book/create";	// 탬플릿에 있는 book/create.html 찾아서 실행
	}
	
	// create.html에서 "저장 버튼"을 눌렀을 때 실행될 예정 (입력값 2개를 DTO로 전달)
	@PostMapping("/book/create")
	public String insert(BookCreateDTO bd) {
		// service를 통해서, 책 입력에 대한 기능 수행
		Integer bookId = this.bs.insert(bd);
		
		// read.html로 페이지 이동
		return String.format("redirect:/book/read/%s", bookId);
	}
	
	// @PathVariable :: 사용자가 접속하고자 하는 링크에서 필요한 값을 매개변수 활용
	@GetMapping("/book/read/{bookId}")
	public ModelAndView read(@PathVariable("bookId") Integer bookId) throws NoSuchElementException{
		// ModelAndView에 대한 mav 객체 생성 (사용자에게 보여줄 데이터(Model)/화면 정보(View) 정의)
		ModelAndView mav = new ModelAndView();
		
		// "책 정보 읽기"와 관련한 로직 함수 read() 실행 (bookId번째 책 정보 불러오기)
		//		- 원하는 데이터 찾기 성공 :: 찾은 책 데이터 brDTO로 저장
		//		- 원하는 데이터 찾기 실패 :: NoSuchElementException 예외 발생	
		//			-> try 실행을 중단하고, catch(NoSuchElementException) 이동
		BookReadResponseDTO brDTO = this.bs.read(bookId);
								
		// Model(데이터 구조, 실질적인 데이터) 정보 전송
		// 검색에 성공한 책 데이터를 mav에 포함
		mav.addObject("bd", brDTO);
		// 사용자에게 보여줄 화면 정보를 mav에 포함
		mav.setViewName("book/read");
		
		// "전달받은 데이터와 화면 정보를 기반으로, 사용자 요청에 대한 응답을 진행"
		return mav;
	}
	
	@PostMapping("/book/delete")
	// booId :: hidden 타입의 input을 통해서, 값이 전달됨
	public String delete(@RequestParam("bookId") Integer bookId) throws NoSuchElementException{
		// service에 있는 delete 기능 함수 수행
		this.bs.delete(bookId);
		
		// 책 데이터 삭제를 수행하면, 그 책과 연결된 댓글이 책에 대해 참조 불가능 	-> 500 에러
		// (엔티티 간 외래키 설정)
		
		// 페이지 이동
		return "redirect:/book/list";
	}
	
	// edit() :: DB에 있는 책 데이터를 수정할 때 활용 
	// 링크에 있는 Id값을 매개변수 bookId와 연결하여 사용
	@GetMapping("/book/edit/{Id}")
	public ModelAndView edit(@PathVariable("Id") Integer bookId) throws NoSuchElementException {
		// 사용자에게 보여줄 데이터와 화면 정보를 담을 공간 마련
		ModelAndView mav = new ModelAndView();
		
		// 사용자에게 보여줄, 기존 책 데이터의 정보 불러오기
		BookEditResponseDTO beDTO = this.bs.edit(bookId);
		
		// 사용자에게 보여줄 데이터(Model)와 화면 정보(View)를 mav에 담아주기
		mav.addObject("be", beDTO);
		mav.setViewName("book/edit");
		
		// 담겨진 정보를 기반으로, 사용자에게 보여주기
		return mav;
	}
	
	// be :: edit.html에서 전달한 객체(th:object에 정의)의 내용
	// @Validated를 통해서 각 값에 대한 유효성 검사		-> (적합X) err에 에러내용 가게끔 설정
	@PostMapping("/book/edit/{bookId}")
	public ModelAndView update(@Validated BookEditDTO be, Errors err) {
		// 기능을 수행하기 이전, 에러가 발생했는지를 파악
		// x :: 유효성 검사 중 오류가 생긴 내역
		if(err.hasErrors()) {
			String errorMessage = 
					err.getFieldErrors()	// err에서 어떤 오류가 생겼는지에 대한 내용 가져오고
					.stream()				// 스트림으로 전환 (데이터를 표현하는 모드)
					.map(x -> x.getField() + " : " + x.getDefaultMessage())
					.collect(Collectors.joining("\n"));		// 작성된 데이터에 "\n"를 합쳐서 문자열 입력 마무리
			
			// 메시지값과 경로값을 보내어서, error422() 함수 수행 (유효성 검사 실패에 대하여 임의로 예외 처리)
			// 사용자에게 에러를 출력해서 보여주고 (errorMessage)
			// 사용자가 다시 수정하게끔 "/book/edit/{id}" 링크로 이동
			return this.error422(errorMessage, String.format("/book/edit/%s", be.getBookId()));
		}
		
		// 사용자 입력을 기반으로, Service를 통해 DB 데이터 수정 진행
		this.bs.update(be);
		
		// 사용자에게 보여줄 데이터와 화면 정보에 대해 저장할 공간 마련
		ModelAndView mav = new ModelAndView();
		
		// View의 정보로, 페이지 이동 수행
		// 컨트롤러의 @GetMapping("/book/read/{bookId}") 함수 수행
		mav.setViewName(String.format("redirect:/book/read/%s", be.getBookId()));
		
		// mav에 지정된 경로로 사용자에게 페이지 이동
		// url 링크 :: /book/edit/{id}(X)		/book/read/{id}(O)
		return mav;
	}
	
	// "/book/list"나 "/book"으로 접속할 시 아래 함수 수행
	// title(사용자가 요청하는 검색어), page()
	@GetMapping(value= {"/book/list", "/book"})
	public ModelAndView bookList(
			@RequestParam(name="title", required = false) String title, 
			@RequestParam(name="page", required = false) Integer page) {
		final int pageSize = 3;
		
		ModelAndView mav = new ModelAndView();
		
		// 사용자에게 표현할 화면 정보 담기 (list.html로 접속)
		mav.setViewName("/book/list");
		
		// title에 대해 검색을 하고, 적절히 정렬한 목록을 반환하는 BookService 함수 수행
		// 함수에 대한 결과값을 many_books로 저장
		List<BookListResponseDTO> many_books = this.bs.bookList(title, page, pageSize);
		
		// 사용자에게 표현할 데이터 담기 (검색&정렬 완료된 리스트)
		mav.addObject("book_list", many_books);
		
		// list.html로 추출한 책 데이터 전송하면서, 사용자에게 응답
		return mav;
	}
	
	// NoSuchElementException 예외 발생 시, 실행하던 것을 멈추고 해당 함수를 구동
	// 이 컨트롤러에 있는 함수 실행하다가, 이 예외가 발생할 시 자동으로 이 함수를 실행
	//	"try - catch문 중복 작성 방지"
	// 	현재로써는, read() edit() delete() 함수의 예외 처리를 진행 (throws NoSuchElementException이 있는 함수)
	@ExceptionHandler(NoSuchElementException.class)
	public ModelAndView noSuchElementExceptionHandler(NoSuchElementException ex) {
		// message에는 "책 정보가 없습니다." 저장
		// location에는 "/book/list" 저장
		return this.error422("책 정보가 없습니다.", "/book/list");
	}
	
	// 출력할 메시지 값과 이동할 경로 값을 매개변수로 받아서, 422.html 수행하는 함수
	private ModelAndView error422(String m, String l) {
		ModelAndView mav = new ModelAndView();
		// "접근할 수 없는 데이터" 라는 상태값 설정
		mav.setStatus(HttpStatus.UNPROCESSABLE_ENTITY);
		// 사용자에게 표시할 메시지를 "message" 이름으로 값 전달
		mav.addObject("message", m);
		// 위치 정보를 "location" 이름으로 값 전달
		mav.addObject("location", l);
		// common/error 폴더 안에 있는 422.html 화면 정보를 mav에 포함
		mav.setViewName("common/error/422");
		return mav;
	}
}





