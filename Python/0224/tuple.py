# 튜플 () :: 다양한 자료형 값을 순차 저장 (상수처럼 값 변경 지원X -> 리스트보다 실행 속도 빠름)
tuple1 = ()         # 빈 튜플 선언
coffee = tuple()    # 빈 튜플 선언
shape = ('circle', 'triangle', 'rectangle', 'circle')
print(type(tuple1), type(coffee), type(shape))
print(shape)
print(shape[0:2])   # 0부터 2 이전까지의 값 슬라이싱
# shape[1] = 'dot'     # 에러 발생
# 연결연산자(+), 반복연산자(*) 통해서 연결/반복 가능
print()

# 튜플 관련 내장 함수
# 튜플 구성 자체를 변경X -> 요소 삽입/삭제 함수 지원X
# count() :: 특정 값의 개수
print(shape.count('circle'))     # shape 튜플에 'circle'값 개수
# index() :: 특정 값의 위치
print(shape.index('circle'))     # shape 튜플에 'circle'값 위치 (값이 중복되면, 가장 처음의 것을 출력)