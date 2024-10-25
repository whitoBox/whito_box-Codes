names = []
i=1
while i<6:
    names.append(input(f"{i}번째 이름:"))
    names.append("/")
    i+=1
names.pop()

print("결과:",end='')
for name in names:
    print(name,end='')
