score = int(input("점수입력하셈:"))
grade = ''
if(-1 < score < 101):
    if(score>=90):
        grade = 'A'
    elif(score>=80):
        grade = 'B'
    elif(score>=70):
        grade = 'C'
    elif(score>=60):
        grade = 'D'
    else:
        grade = 'F'
    print(f"점수:{score}\n학점:{grade}")
else:
    print("불가")
    
