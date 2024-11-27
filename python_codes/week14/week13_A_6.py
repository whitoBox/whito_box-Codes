# week13_A_8_2.py
# id:20240000
# name:jang eunmee
import datetime as dt

timeformat = "%Y-%m-%d %H:%M:%S"

def diff_seconds(intime, outtime):
    if not outtime:
        outtime = dt.datetime.now()
    return (outtime - intime).total_seconds()

rooms = []
while True :
    room = input("강의실 호수:").strip()
    if not room:
        break

    while True:
        try:
            starttime = input("시작시간:").strip()
            if starttime:        
                starttime = dt.datetime.strptime(starttime, timeformat)
                break
        except:
            pass

    while True:
        try:
            stoptime = input("종료시간:").strip()
            if not stoptime:
                stoptime = None
            else:
                stoptime = dt.datetime.strptime(stoptime, timeformat)
            break
        except:
            pass
    
    room_info = {'num':room, 'in':starttime, 'out':stoptime}    
    rooms.append(room_info)


for room in rooms:
    print(room['num'], room['in'], room['out'])
    print(diff_seconds(room['in'], room['out']))





    
