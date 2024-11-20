# week13_A_1.py
# id:202444029
# name: 김요한

#시험 준비 공부

datas = []
while True:
    data = {}
    data['room'] = input("강의호수:").strip()

    if data['room'] == "":
       break
    
    data['startTime'] = input("시작시간:")
    data['endTime'] = input("종료시간:")
    datas.append(data)
    
for info in datas:
    print(info['room'],info['startTime'],info['endTime'])
