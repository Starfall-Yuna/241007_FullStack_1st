# 자료형(타입) :: 정보의 형태
# 정수형(int), 실수형(float), 복소수형(complex), 진위형(bool), 문자열형(str)
# 변수를 선언할 때엔, 자료형 명시를 하면 안 됌

# 정수형 (int)     (웬만한 큰/작은 숫자도 무리없이 저장O)
# C/C++/Java에서의 int형 크기 :: 4바이트
# Python에서의 int형 크기 :: 28바이트
vint1 = 3
print(f'vint1의 값, 자료형 :: {vint1}, {type(vint1)}')
vint2 = 9000000000
print(f'vint2의 값, 자료형 :: {vint2}, {type(vint2)}')
print()

# C/C++/Java float와 double형 차이 :: 정밀도(소수점 아래로 얼마나 저장할 수 있는가) 차이
# 실수형 (float)         (double형이 존재X)
vfloat1 = 1.234
print(f'vfloat1의 값, 자료형 :: {vfloat1}, {type(vfloat1)}')
vfloat2 = 0.000111222333444555
print(f'vfloat2의 값, 자료형 :: {vfloat2}, {type(vfloat2)}')
vfloat3 = 0.00000001    # 0이 7개
print(f'vfloat3의 값 :: {vfloat3}')      # e 표기법(지수 표현)을 통해서 출력됌
    # 출력값 :: 1e-08      => 1 * 10^(-8)
vfloat4 = 10000000000000000
vfloat4 = float(vfloat4)                # float형에 한해서만, 지수 표현 지원
print(f'vfloat4의 값 :: {vfloat4}')
print()

# 복소수형 (complex)        => 허수(j) 개념 포함
vcom = 2 + 3j
print(f'vcom의 값, 자료형 :: {vcom}, {type(vcom)}')
print()

# 진위형 (bool)
# 참(True)과 거짓(False)만 저장, 특정 논리식에 대한 판별값 표현할 때 활용
# true와 false는 진위형 값으로 취급X
vbool1 = True
print(f'vbool1의 값, 자료형 :: {vbool1}, {type(vbool1)}')
vbool2 = (1==4) | (5<7)
print(f'vbool2의 값, 자료형 :: {vbool2}, {type(vbool2)}')
print()

# 파이썬에서는, 문자형과 문자열형을 구분X
# 문자열형 (str) :: ''(작은따옴표) 또는 ""(큰따옴표)로 문자열 표현
st1 = 'Hello World'
st2 = "Bye World"
st3 = """여러 줄로
문자열 표현할 때엔
이렇게 합니다 """
print(st1, st2, st3, sep="\n")
print(type(st1), type(st2), type(st3))
print()

# 이스케이프 문자 (\', \")
# 적당하게 ''(작은따옴표)랑 ""(큰따옴표)를 번갈아가며 사용
st4 = 'I\'m happy'
st5 = "I'm sad"
st6 = "누군가 말하였다, \"배고파!!\""
st7 = '누군가 대답하였다, "먹어!!!!"'
print(st4, st5, st6, st7, sep="\n")
print()

# 파이썬에서는, 문자형과 문자열형을 구분X
s = 'Hallo'     # 'H', 'a', 'l', 'l', 'o', 다른 언어들처럼 리스트/배열의 형식대로 저장X
s = 'Hi, World'
print(s[1])     # 하나의 문자에 대해 접근O
s[1] = 'e'   # 하나의 문자를 수정X