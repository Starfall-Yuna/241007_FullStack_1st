# 함수 :: 명령문의 묶음
# 들여쓰기, :(콜론) 주의

# def 함수이름(매개변수이름, ...):
#     수행할 명령문

# 내용이 빈 함수 안으로는 반드시 pass 키워드 써줘야 함
def nothing():
    "나중에 내용을 추가할 계획입니다."
    pass

def sayHello():
    "인사를 수행하는 함수입니다."       # 함수의 설명(Docstring) 적을 수 있음
    print("안녕하세요, 반갑습니다")
    print('sayHello() 함수가 종료됩니다.')

# 함수 호출은, 함수가 정의된 뒤의 줄부터 사용을 해야함
nothing()
sayHello()      # sayHello() 함수 호출

# 여러 값을 한번에 반환 -> 튜플 형태로 반환
# 이러한 반환값을 변수에 저장하면 -> 값 수정 원활하지 않음
def return_num(a, b):
    return a, b
print(type(return_num(10, 100)))
print(return_num(10, 100))

def add(num1, num2):
    return num1+num2
def sub(num1, num2):
    return num1-num2
def mul(num1, num2):
    return num1*num2
def div(num1, num2):
    # 파이썬에서는 함수의 반환형 명시X -> 반환형에 유동적
    if num2 != 0:
        return num1/num2     # 연산 가능한 경우엔, float형 반환
    else:
        return '0으로 나눌 수 없습니다'      # 연산이 불가능한 경우엔, str형 반환

# 2개의 숫자랑 1개의 연산자 입력
n1 = int(input('첫번째 숫자를 입력해주세요. '))
n2 = int(input('두번째 숫자를 입력해주세요. '))
oper = input('연산자를 입력해주세요. ')
# 연산자 oper에 따라서, 사칙연산 수행 (+, -, *, /)
if oper == '+':
    print('덧셈 결과:', add(n1, n2))
elif oper == '-':
    print('뺄셈 결과:', sub(n1, n2))
elif oper == '*':
    print('곱셈 결과:', mul(n1, n2))
elif oper == '/':
    print('나눗셈 결과:', div(n1, n2))
else:
    print('존재하지 않는 연산자입니다.')