# int형 보충 :: 10/2/8/16진수

# 값 삽입
num10 = 1000    # 10진수
num2 = 0b1000   # 2진수 (0b 추가 삽입)
num8 = 0o1000   # 8진수 (0o 추가 삽입)
num16 = 0x1000  # 16진수 (0x 추가 삽입)

# 값 출력 :: print()는 기본적으로 숫자를 10진법으로 출력
print(num10, num2, num8, num16, sep="\n")
print()
# 값 출력 (10/2/8/16진수로 각각 출력)
print(num10, bin(num2), oct(num8), hex(num16), sep="\n")
