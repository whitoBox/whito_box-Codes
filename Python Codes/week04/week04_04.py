#04_04

moto= ['honda','yamaha','suzuki']
print(moto)

#요소 변경 
moto[0] = 'bmw'
print(moto)

#추가하기
moto.append('vespa')
print(moto)

#삽입하기
moto.insert(10,'ducati')#10번째는 없는데 그냥 끝부분에 값을 넣어줌
print(moto)

moto = ['honda','yamaha','suzuki','bmw','ducati','velpa','kia']
del moto[2]
print(moto)

del moto[-3]
print(moto)

del moto[:2]
print(moto)

del moto[:]#슬라이싱 전체 .. moto.clear() 동일 .. 모든 요소를 삭제
print(moto)

#index out of range
"""del moto[10]
   print(moto)"""

moto = ['honda','yamaha','suzuki','bmw','ducati','velpa','kia']

popdata = moto.pop()#마지막 대이터 때오기
print(moto,popdata)

popdata = moto.pop()
print(moto,popdata)

popdata = moto.pop(2)
print(moto,popdata)

moto.remove('yamaha')
print(moto)

target = 'YAMAHA'
if target in moto:
    moto.remove('YAMAHA')
    print(moto)
else:
    print(f"{target} 없음")

target = 20
if target < len(moto):
    popdata = moto.pop(target)
    print(moto, popdata)
else:
    print(f"{target} 인덱스 사용 불가")
