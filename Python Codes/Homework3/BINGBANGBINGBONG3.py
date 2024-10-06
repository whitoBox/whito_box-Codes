import datetime
Byear = int(input("태어난 연:"))
age = (datetime.datetime.today().year - Byear) + 1
status = ''
if(26>=age>=8):
    if(age>=20):
        status = "대"
    elif(age>=17):
        status = "고등"
    elif(age>=14):
        status = "중" 
    else:
        status = "초등"
    print(f"결과:{status}학생")
else:
    print("결과:학생이 아닙니다.")
