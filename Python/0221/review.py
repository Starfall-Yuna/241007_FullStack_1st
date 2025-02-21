# 한 줄 주석
"""
    여러 줄 주석
"""

# 입/출력 함수 :: input() / print()
# 두 개의 숫자를 입력받고     (숫자형으로 입력값 전환)
n1 = float(input('첫번째 숫자를 입력해주세요. '))
n2 = float(input('두번째 숫자를 입력해주세요. '))

# 덧셈만 수행하기      => 수학적인 연산 필요
print("덧셈 결과", n1+n2, sep=", ", end="\n(덧셈을 종료합니다)")      # sep 매개변수(구분자), end 매개변수
print()
print()

# 자료형(5) :: int(정수), float(실수), complex(복소수), bool(진위), str(문자열)
#   강제 형변환 함수 :: int(), float(), complex(), bool(), str()
print(f'12345의 자료형 :: {type(12345)}')               # f'string' 포맷
print('12.3456의 자료형 :: %s' % (type(12.3456)))       # c-스타일 포맷
# print('12.3456의 자료형 :: %.2f' % (12.3456))         # c-스타일 포맷
print(f'(3.5+5j)의 자료형 :: {type(3.5+5j)}')           # f'string' 포맷
print('True의 자료형 :: {}'.format(type(True)))         # .format() 함수
print('\'a\'의 자료형 :: {}'.format(type('a')))         # .format() 함수
print('"apple"의 자료형 :: {}'.format(type("apple")))   # .format() 함수