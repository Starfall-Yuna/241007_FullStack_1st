# 1~10 중 랜덤으로 숫자(secret)를 하나 뽑은 뒤, 사용자로부터 정수형 숫자(guess)를 하나 입력받는다
# secret과 guess의 숫자를 순차 출력한 뒤, 동일하다면 "정답입니다" 아니라면 "오답입니다"를 출력한다
# 난수를 뽑아내는 함수는 아래의 구문을 참조하여 활용하기
# import random
# random.randint(start, end)

# 1) 1~10 중 난수 뽑아내기
import random
secret = random.randint(1, 10)

# 2) 사용자로부터 정수 입력받기
guess = int(input('추측하고 있는 숫자를 입력해주세요 '))

# 3) 난수값과 입력값을 순차 출력
print("랜덤으로 뽑은 숫자: ", secret)
print("사용자가 입력한 숫자: ", guess)

# 4) 두 값이 동일한지 아닌지 판별+출력        => if-else
if secret==guess :
    print("정답입니다!")
else :
    print("오답입니다...")
