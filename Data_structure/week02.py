num = int(input("10단위 수 입력 : "))
summ = 0
#for i in range(1, num+1):
#    summ += i
summ = num * (num+1) // 2
print(summ)