ptpt = {}
for i in range(5):
    name = input("이름:")
    score = input("점수:")
    ptpt[name]=score
print(ptpt)
sums=0
for i in ptpt.values():
    sums+=int(i)
print("전체평균:",sums/len(ptpt))
