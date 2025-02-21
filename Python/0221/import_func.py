# 내장 함수 :: 파이썬에 기본적으로 포함되어있는 함수

# 강제 형변환 함수(5) :: int(), float(), complex(), bool(), str()
# type() :: 자료형 반환 함수
print(type(1), type(10.01), type('st'))

# len() :: 길이 반환 함수
print(len('hello World!!!!'))       # 문자열의 길이 반환 :: 15
print(len([1, 2, 3, 4, 5]))         # 리스트의 길이 반환 :: 5
print()

# max(), min() :: 최대값, 최소값 반환 함수
print(max('abcdefg'))               # 문자열의 최대값 :: g     (파이썬에서도 아스키 코드 지원)
print(min([2,8,9,-4,0]))            # 리스트의 최소값 :: -4

# isinstance(값(v), 자료형(t)) :: v의 자료형이 t인지를 "판별" (결과값이 True/False)
example = '123'
print('\'123\'이 정수형인가?', isinstance(example, int))
print('int(\'123\')이 정수형인가?', isinstance(int(example), int))

# 2개의 문자열을 입력받고
s1 = input('첫번째 문자열을 입력하시오 ')
s2 = input('두번째 문자열을 입력하시오 ')
# 이들 중, 긴 문자열의 길이를 출력하라     => max(), len()
#      => 두 문자열의 길이를 비교하고, 그 중 큰 것
#      => len(s1)과 len(s2)를 비교해서, 그 중 큰 것
print(f'{s1}과 {s2} 중, 긴 문자열의 길이는 {max(len(s1), len(s2))}입니다.')