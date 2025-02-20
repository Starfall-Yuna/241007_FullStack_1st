print("Hello")
print("I", "hate", "Python")

# 특정 변수값을 어떤 형식에 맞추어서 출력
name = 'Lee'
age = 30
height = 170.5
# 예상 출력값 : 제 이름은 (name값)이고, 나이는 (age값)살입니다.

# 1) f'string' 형식 출력 (파이썬 3 버전 지원)  => format의 f
#      {}를 통해서, 값을 넣을 위치와 넣을 값을 명시
print(f'제 이름은 {name}이고, 나이는 {age}살입니다.',
                                end='(f-string 형식 출력)\n')

# 2) .format() 함수 활용
#       {}를 통해서, 값을 삽입할 위치 지정
#       format()을 통해서, 넣을 값들을 명시
print('제 이름은 {}이고, 나이는 {}살입니다. 키는 {}cm입니다.'.format(name, age, height),
                                end='(format() 함수 활용)\n')

# 3) C-스타일 문자열 변환
#       서식지정자(%s, %d) 통해서, 값을 삽입할 위치 지정
#       % (넣을 값) 통해서, 넣을 값들을 명시
print('제 이름은 %s이고, 나이는 %d살입니다. 키는 %.3fcm입니다.' % (name, age, height),
                                end='(c-style 문자열 변환)\n')

