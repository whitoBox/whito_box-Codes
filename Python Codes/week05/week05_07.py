#week 05_07

i=0
scores=[]
while i<5:
    i+=1
    score=input(f"{i}번째 점수:")
    #빈문자열이 들어오면 무조건 0점을 간주한다.
    if not score.strip():
        break
    scores.append(float(score))

if 0< len(scores):
    num = 0
    summ = 0
    for score in scores:
        num += 1
        summ += score
        print(f"{num}:{score}")
    print(f"avg:{summ/len(scores)}")
else:
    print("no scores")

