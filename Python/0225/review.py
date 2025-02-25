# 자료구조 :: 리스트, 튜플, 딕셔너리, 셋

# 1. 리스트 [] :: "다양한 자료형" 데이터 순차 저장 (일반적인 배열)
list1 = []      # list1 = list()
introduce = ['Lee', 30, 171.1, False]
print(type(introduce), introduce)
# 인덱싱(값 조회), 슬라이싱(리스트 잘라내기) 지원
introduce[2] = 168.5    # 값 수정O
# append() :: 리스트 뒤로 값 삽입
# insert() :: 지정된 위치에 값 삽입
introduce.append('안녕하세요')
introduce.insert(2, 7)      # 2번 공간에 7 데이터 삽입
# remove() :: 값을 기반으로 값 삭제
# pop() :: 위치를 기반으로 값 삭제
introduce.remove(False)     # False값 삭제
introduce.pop()             # 위치 지정X -> 맨 뒷값 삭제
introduce.pop(1)            # 1번 공간 데이터 삭제
print(introduce)
print()

# 2. 튜플 () :: "다양한 자료형" 순차 저장 (값 수정X -> 리스트보단 속도 빠름)
tuple1 = ()     # tuple1 = tuple()
shape = ('원', '삼각형', '사각형', '원')
print(type(shape), shape)
# 인덱싱, 슬라이싱 지원
# shape[2] = '직사각형'    # 값 수정 지원X
# 값 삽입/삭제 지원X
print(shape.count('원'))     # '원' 데이터 개수 구하기
print(shape.index('원'))     # '원' 데이터 위치 구하기 (여러 개가 존재 -> 앞에 있는 데이터 위주)
print()


# 3. 딕셔너리 {} :: 비순차 저장
dict1 = {}      # dict1 = dict()
menu = {
    # 'key값': 'value값'
    '볼펜': 1000,
    '필통': 2500,
    '지우개': 500
}
print(type(menu),  menu)
# 값 변경/삽입 매우 용이O
# 기존 key값 존재하면 변경, 존재하지 않으면 자동으로 삽입
menu['볼펜'] = 1500       # 값 변경
menu['형광펜'] = 1300     # 값 삽입
print(menu)
# pop() :: 지정된 key에 대한 값 삭제
menu.pop('필통')          # key가 '필통'인 값을 삭제
print(menu)
# clear() :: 딕셔너리의 전체 데이터 삭제 (DB truncate 작동 방식이랑 유사)
# keys(), values(), items() :: key만 반환 / value값만 반환 / key-value 쌍으로 모두 반환
#     "반복문"을 통한 딕셔너리 순회
print(menu.keys())
print(menu.values())
print(menu.items())
print()


# 셋(set) {} :: 비순차 저장, 중복 허용X      => 집합의 개념 (특정 원소 접근X)
set1 = set()
number = {1,3,5,7,9}    # 딕셔너리랑 달리, 값만 나열
print(type(number), number)
# print(number[1])      [0]~[4]이라고 하는, 영역 번호가 주어져있지 않은 상태 -> 원소 접근X
# add(), remove() :: 값 삽입/삭제
number.add(8)       # 8 값 삽입
number.add(5)       # 5 값 기존에 존재 -> 명령 무시
number.remove(9)    # 9 값 삭제
print(number)
# (s1과 s2라는 셋이 존재한다 가정)
# 교집합(&, intersection())      => s1에 존재하고, s2에도 존재하는 원소 반환
# 합집합(|, union())             => s1에 존재하거나, s2에 존재하는 원소 반환
# 차집합(-, difference())        => s1에 존재하고 s2에 존재하지 않거나 (s1-s2)
#                                   s2에 존재하고 s1에 존재하지 않는 원소 반환 (s2-s1)