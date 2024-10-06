import random
Rnum = random.randint(1,100)
Inum = 0
trys = 0
print("+++숫자를 맞춰보세요.(1~100)+++")
while(Inum!=Rnum):
    Inum = int(input("입력:"))
    if(Inum>Rnum):
        print("숫자가 큽니다.")
    else:
        print("숫자가 작습니다")
    trys += 1
print(f"{Inum}가 정답입니다. 도전 횟수는 {trys}번 입니다.")
