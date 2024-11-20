# week13_A_8_1.py
# id:202444029
# name: 김요한

#시험 준비 공부



def diff_seconds(timein,timeout):
    if not timeout:
        timeout = dt.now()
    return (timein - timeout).total_seconds()
    
import datetime
from datetime import datetime as dt
dtFormat = "%Y-%m-%d %H:%M:%S"

datas = []
while True:
    data = {}
    data['room'] = input("강의호수:").strip()
    if data['room'] == "":
       break
    
    while True:
        try:
            starttime = input("시작시간:").strip()
            if starttime:
                data['startTime'] = dt.strptime(starttime,dtFormat)
                break
        except:
            pass

    while True:
        try:
            endtime = input("종료시간:").strip()
            if not endtime:
                data['endTime'] = None
            else:
                data['endTime'] = dt.strptime(endtime,dtFormat)
            break
        except:
            pass
    
    datas.append(data)

for info in datas:
    print(info['room'],info['startTime'],info['endTime'])
    print(diff_seconds(info['startTime'],info['endTime']))








