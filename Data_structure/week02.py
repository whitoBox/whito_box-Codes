num = int(input("10단위 수 입력 : "))g
#for i in range(1, num+1):
#    summ += i
summ = num * (num+1) // 2 #O(1)
print(summ)