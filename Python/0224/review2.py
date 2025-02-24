# 연결연산자, 반복연산자 :: +, *
lang = 'C, '+'Java, '+'Python'
hello = "안녕하세요"*3
print(lang, hello, sep='\n')

# 선택연산자 :: [] (인덱싱)
print(lang[5])
# 범위 선택연산자 (슬라이싱)
# ['시작점' : '끝점'(포함X) : '스텝']
print(hello[:5])      # 처음부터 시작해서, 5번 이전까지 슬라이싱 진행
number_list = '1,2,3,4,5,6,7,8,9'
print(number_list[::2])     # 처음부터 2칸씩 건너뛰면서 끝까지 출력
print(number_list[::-1])    # 역순 정렬
print()

# 문자열은 불변의 자료형이다. (하나의 문자를 수정X)
# 파이썬에선, 값 변경하는게 아니라, 새로운 값으로 기존 값을 덮어씌우는 형식으로 진행
sentence = 'Today is Mooooonday...'
# upper(), lower() :: 각각 대문자/소문자로 변동
print('대문자로 변경 :', sentence.upper())
print('소문자로 변경 :', sentence.lower())
# swapcase() :: 대문자->소문자, 소문자->대문자 변동
print('소문자<->대문자 변경 :', sentence.swapcase())
# split() :: 특정 문자열을 기준으로 분리하여 -> 리스트로 반환
print(sentence.split(' '))      # 공백 기준으로 값 분리
# capitalize(), title(), ...

# 내장 함수 :: len(), min(), max(), isinstance()
print('문장의 길이:', len(sentence))
print('문장의 최대값/최소값:', min(sentence), max(sentence))
print('이 문장은 문자열(str)입니까?', isinstance(sentence, str))      # sentence의 자료형이 str형인지를 판별