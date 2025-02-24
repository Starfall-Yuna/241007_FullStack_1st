# 문자열 포맷팅 :: .format()
# {}로 값을 표시할 위치 지정, format()를 통해서 값 호출
# hw = "Hello, World"
hw = "{}{}{}".format("Hello", ", ", "World")
print(hw)

element = "{2} {0} {1}".format('2', 25, [1, 2])
print(element)

# 'Friday'와 'Saturday'에 대해, 번호 인덱스로 접근X
today = 'Today is {today}, Tomorrow is {tomorrow}'.format(today='Friday', tomorrow='Saturday')