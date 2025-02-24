# 셋(set) :: 비순차 저장 (증복 허용X)     => 집합 개념
set1 = set()            # 빈 셋 선언
hello = set('Hello')    # 'Hello' 값을 셋에 초기화
number = {1,2,3,4,5}    # 딕셔너리와 같은 {}를 사용, but value값만 주었기 때문에 set으로 간주
print(type(hello), type(number))
print(hello)

# add() :: 요소 삽입
number.add(7)       # 요소 7 삽입
number.add(2)       # 명령 수행X (중복)
print(number)
# remove() :: 요소 삭제
number.remove(5)
print(number)
print()

s1 = {1,2,3,4,5}
s2 = {1,3,5,7,9}
# 교집합(&, intersection())
print(s1 & s2)      # s1에 존재하고(and), s2에도 존재하는 요소 출력
# 합집합(|, union())
print(s1 | s2)      # s1에 존재하거나(or), s2에 존재하는 요소 출력
# 차집합(-, difference())
print(s1 - s2)      # {1,2,3,4,5} - {1,3,5} = {2,4}