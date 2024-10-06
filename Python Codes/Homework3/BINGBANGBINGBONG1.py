num = int(input("4자리 정수 입력:"))
sums=0
j=1000
for i in range(4):
    sums += num//j
    num %= j
    j /= 10
print(sums) 
