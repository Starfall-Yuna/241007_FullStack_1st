# 조건문
# if 조건식:
#     실행할 코드

# 반복문 :: 특정 조건 만족할 때마다 반복할 구문 표현
# :(콜론), 들여쓰기 주의하기
# while, for

# 무한 반복에 걸리지 않게끔 주의
# while 조건식:
#     반복할 명령문
n = 1
while n<=5 :        # n이 5보다 작거나 같을 때 반복
    print(n, end=" ")
    n += 1        # n++
print()


# 1. 빈 리스트[] sageon 생성
sageon = []

# 2. n을 입력받고, n개의 문자열을 입력받고, 문자열을 하나씩 sageon에 삽입
n = int(input('입력받을 문자열의 개수를 입력하세요. '))
i = 1
while i<=n:
    word = input('사전에 넣을 문자열을 입력하세요. ')
    sageon.append(word)
    i += 1

# 3. sageon에 대해서 검색할 문자열(search) 입력받기
search = input('사전에 검색할 문자열을 입력하세요. ')

# 4. sageon에 대해, search 문자열이 존재하는지에 대한 결과 출력하기 (존재하면 결과 출력은 1번만)
index = 0
tf = False
while index < n:
    # sageon 리스트 값을 하나씩 접근하면서, search와 같은지 판별
    if sageon[index] == search:
        tf = True
    index += 1
if tf == True:
    print('사전에 존재하는 문자열입니다.')
else:
    print('사전에 없는 문자열입니다.')