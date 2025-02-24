# list[0], tuple[3], ...
# dict['ㄱ'], dict['fruit'], ...

# 딕셔너리(dict) {} :: 비순차 저장
dict1 = {}          # 빈 딕셔너리 선언
word = dict()       # 빈 딕셔너리 선언
menu = {
#    key값 : value값
    '아메리카노': 2500,
    '카푸치노': 3000
}
print(type(word), type(menu))
print(menu)
print()

# 값 변경을 지원O, 값 삽입O
menu['아메리카노'] = 2800
menu['카푸치노'] = 3500
menu['물'] = 1000        # 값 삽입
print(menu)
print()

# 딕셔너리 관련 내장 함수
# keys(), values(), items() :: key값 불러오기, value값 불러오기, 딕셔너리 불러오기
print(menu.keys(), menu.values(), menu.items(), sep='\n')
# pop() :: 특정 key값의 요소 삭제
menu.pop('카푸치노')    # '카푸치노' key값 요소 삭제
print(menu)
# clear() :: 요소 전체 삭제 (truncate)
menu.clear()
print(menu)     # menu 출력은 되고 있지만, 빈 딕셔너리로 출력
# update() :: 딕셔너리 병합 (연결연산자(+))

# 인적사항(이름, 나이, 혈액형)을 입력을 받고
name = input('이름을 입력해주세요. ')
age = input('나이를 입력해주세요. ')
blood = input('혈액형을 입력해주세요. ')
# 입력값을 기반으로 딕셔너리(my_dict)를 구성한 뒤
my_dict = {
    '이름': name,
    '나이': age,
    '혈액형': blood
}
# 이를 아래 반복문을 통하여 출력을 수행하여라.
# 반복문이 3번 반복 수행
print(my_dict.items())      # my_dict.items() 크기 :: 3
for key, value in my_dict.items():
    print(f'{key}: {value}')
    # 이름: Lee
    # 나이: 30
    # 혈액형: A
    # 반복문 수행이 총 3번 이루어졌음
