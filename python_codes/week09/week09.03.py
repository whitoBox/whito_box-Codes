#week09.03
data1  = [1,2,3,4]

summary = sum(data1)
maximum = max(data1)
minimum = min(data1)
average = sum(data1) / len(data1)

print(summary, maximum, minimum, average, sep=", ")

print('-'*30)
#-----------------------
for i in data1:
    print(i)
    
print('-'*30)
#-----------------------
for i in range(len(data1)):
    print(i)

print('-'*30)
#------------------------
for i in range(len(data1)):
    print(f"data1[{i}]:{data1[i]}")

print('-'*30)
#------------------------
for i in enumerate(data1):#튜플로 값 반환한다.
    print(f"data1[{i[0]}]:{i[1]}")

print('-'*30)
#------------------------
for i,j in enumerate(data1):
    print(f"data1[{i}]:{j}")

print('-'*30)
#------------------------
data2 =[[1,2,3],[10,20],[11,12,13,14]]

for i in data2:
    print(i)

print('-'*30)
#------------------------
for j in data2:
    print(f"sum:{sum(j)}")
    print(f"max:{max(j)}")
    print(f"min:{min(j)}")
    print(f"avr:{sum(j)/len(j)}\n")

print('-'*30)
#-------------------------
for i,j in enumerate(data2):
    print(f"{i+1}번째 :{j}")
    print(f"sum:{sum(j)}")
    print(f"max:{max(j)}")
    print(f"min:{min(j)}")
    print(f"avr:{sum(j)/len(j)}")

print('-'*30)
#------------------------
for i,j in enumerate(data2):
    print(f"{i+1}번째:",end='')
    for k,l in enumerate(j):
        print(f"[{k}]{l}",end=' ')
        
    print(f"\nsum:{sum(j)}")
    print(f"max:{max(j)}")
    print(f"min:{min(j)}")
    print(f"avr:{sum(j)/len(j)}")

print('-'*30)
#----------------------
data3 = {"김인하" : [1,2],
         "이인하" : [10,20,30,40,50,60,70],
         "송인하" : [11,12,13,14]}

for i in data3:
    print(i)

print('-'*30)
#-------------------------
for i in data3:
    print(data3[i])

print('-'*30)
#-------------------------
for i in data3:
    print(i,":",data3[i])

print('-'*30,'end')
#-------------------------
for i in data3:#try items(),try making it simipler
    print(i,":",end='')
    for j in range(len(data3[i])):#try enumerate
        print(f" [{j}]{data3[i][j]}",end='')
    print()
    print("sum",sum(data3[i]))
    print("max",max(data3[i]))
    print("min",min(data3[i]))
    print("avg",sum(data3[i])/len(data3[i]))
print('-'*30)
#-------------------------
