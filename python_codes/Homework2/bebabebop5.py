score1 = float(input("1학기 학점:"))
score1 = (score1+float(input("2학기 학점:")))/2
worktime = int(input("봉사시간:"))

if(score1>=3.5 and worktime>=8):
    money = "확정"
else:
    money = "탈락"
print("장학금 대상 여부 :",money)

