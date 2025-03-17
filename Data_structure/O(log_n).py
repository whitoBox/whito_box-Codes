import random
guessnum = random.randint(1,100)
count = 0
while(True):
    count += 1
    player = int(input("1-100 사이 값을 맞추시오"))
    if player == guessnum:
        print(f"attempt :{count}")
        print("correct!")
        break
    elif player > guessnum:
        print("under")
    else:
        print("over")

