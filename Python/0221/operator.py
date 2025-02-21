a, b = 2, 10

# 연산자 :: 연산을 수행하는 기호
# - 사칙연산자 :: +, -, *, /(일반 나누기), //(몫 반환), %(나머지 반환), **(제곱)
print(a/b)
print(a//b, a%b)
print(a**b)     # a의 b제곱
# - 대입연산자(=) :: "우측의 값을 좌측의 공간에 대입한다"
# - 복합 대입연산자 :: (사칙연산자) + (대입연산자)
a **= b     # a의 b제곱 값을, 변수 a에 저장
print(a)
a //= b     # a를 b로 나눈 몫을, 변수 a에 저장
print(a)

# 비교연산자 :: <, >, <=, >=, ==(같다), !=(다르다)
# 논리연산자 :: and(그리고), or(또는), not(아니다)
tf1 = (100 < 10) and (55 > 40)
tf2 = (100 < 10) or (55 > 40)
tf3 = not ('st' == 'st')       # !(True) = False
print('and의 결과값:', tf1)
print('or의 결과값:', tf2)
print('not의 결과값:', tf3)
# 식별연산자 :: is(~이다), is not(~가 아니다)
print(3 == 3.0)     # 값만 비교 -> True
print(3 is 3.0)     # 값과 타입을 함께 비교 -> False (자료형이 달라서)
print(3 is not 3.0) # 자료형이 다르고, 다른게 맞으니, True

# 연결연산자, 반복연산자 :: +, * (문자열에 대해서만 적용)
h, y, c, o = 'hey ', 'you ', 'come ', 'on'
sentence = h+y+c+o
print(sentence)
sentence2 = h*3
print(sentence2)
# 선택연산자 :: [] (인덱싱)
print('문장의 5번째 문자 : ', sentence[5])
print('문장의 10번째 문자: ', sentence[10])
print('문장의 (뒤에서부터) 1번째 문자: ',sentence[-1])
# 범위 선택연산자 (슬라이싱, 부분 문자열 반환)
# sentence = "hey you come on"
print('문장의 5~10번째 문자들: ', sentence[5:11])    # 5번째부터 10번째까지 슬라이싱
print('문장의 0~6번째 문자들: ', sentence[:7])     # 처음(0번)부터 7번 이전까지 슬라이싱
print('문장의 8~14번째 문자들: ', sentence[8:])     # 8번부터 끝까지 슬라이싱
# 문자열 대체 (문자열의 내장 함수)
st = "   I'm happy   "
print(st.upper())       # 소문자 -> 대문자
print(st.lower())       # 대문자 -> 소문자
print(st.strip())       # 처음/끝의 공백 제거