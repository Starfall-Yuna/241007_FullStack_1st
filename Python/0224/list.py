# 자료구조 :: 리스트, 튜플, 딕셔너리, 셋

# 리스트 [] :: "다양한 자료형" 값을 "순차" 저장
list1 = []          # 빈 리스트 생성
mbti = list()       # 빈 리스트 생성
fruits = ['apple', 'banana', 'mango']   # str형 값을 3개 삽입
introduce = ['Lee', 30, 171.1, False, "안녕하세요!!"]
print(type(mbti), type(fruits), type(introduce))
print(introduce)
print(len(introduce))       # 리스트 길이 반환
print(introduce[0:2])       # 0번~2번 이전까지 슬라이싱
# 리스트 원소값 수정
fruits[2] = 'lemon'
fruits[0] = 100
print('변경된 과일 리스트:', fruits)
print()

# 리스트 관련 내장 함수
# append() :: 리스트에 값 삽입 (뒤에서부터 순차 삽입)
mbti.append('ISTJ')
mbti.append('INFJ')
mbti.append('INTP')
print(mbti)
# insert() :: 리스트에 값 삽입 (삽입할 위치 지정)
fruits.insert(10, 'durian')     # 리스트의 길이보다 10이 크기 때문에, 리스트의 뒤쪽에 값 삽입
print(fruits)
# remove() :: 리스트 값 삭제 (삭제할 값 지정)
fruits.remove(100)      # 100이라는 값 삭제 (fruits[100] 삭제X)
print(fruits)
# pop() :: 리스트 값 삭제 (삭제할 위치 지정)
mbti.pop()      # 위치상 맨 뒤에 있는 값 삭제
print(mbti)
mbti.pop(0)     # mbti[0] 값 삭제
print(mbti)
print()

# reverse() :: 값 거꾸로 뒤집는 함수
print(introduce)
introduce.reverse()
print(introduce)
# 연결연산자(+) 통해서 리스트 연결 가능
print(introduce+mbti)
# 반복연산자(*) 통해서 리스트 반복 가능
# count() :: 특정 값에 대해서, 리스트에 존재하는 개수
print(fruits.count('durian'))   # 과일 리스트에 'durian' 값이 몇 개 존재하는가

# 스택과 큐... 파이썬에서 리스트 통해서 구현 가능