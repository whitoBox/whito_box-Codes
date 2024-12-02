# week13_A_11-1.py
# id:202444029
# name: 김요한
#시험 준비 공부
import room as Room
import os
from datetime import datetime as dt

dtFormat = "%Y-%m-%d %H:%M:%S"

#mypath이거 노트북에서 변경
mypath = "D:\\Programming School\\coadings\\python_codes\\week13"
myfile = "room.txt"
fullfile = os.path.join(mypath, myfile)

if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    datas = []
    room = Room.car1()
    if os.path.isfile(fullfile):
        print("복구한 정보입니다.")
        with open(fullfile, 'r') as F:
            prevdata = F.readlines()
            for pdatas in prevdata:
                datasep = pdatas.strip().split('|')
                room.room = datasep[0]
                room.startTime = dt.strptime(datasep[1],dtFormat)
                                             
                if datasep[2]:
                    room.endTime = dt.strptime(datasep[2],dtFormat)
                else:
                    room.endTIme = None
                datas.append(room)
                print(pdatas.strip())
                  
    while True:
        room = Room.car1()
        room.room = input("강의호수:").strip()
        if room.room == "":
           break
        while True:
            try:
                starttime = input("시작시간:").strip()
                if starttime:
                    room.startTime = dt.strptime(starttime,dtFormat)
                    break
            except:
                pass

        while True:
            try:
                endtime = input("종료시간:").strip()
                if not endtime:
                    room.endTime = None
                else:
                    room.endTime = dt.strptime(endtime,dtFormat)
                break
            except:
                pass
    
        datas.append(room)
        
    for i in datas:
        print(i.room,i.startTime,i.endTime)
        print(i.diff_seconds())

    with open(fullfile, "w", encoding = "utf-8") as f:
        for i in datas:
            starttime = dt.strftime(i.startTime,dtFormat)
            if not i.endTime:
                stoptime = ''
            else:
                stoptime = dt.strftime(i.endTime,dtFormat)
            f.write(f"{i.room}|{starttime}|{stoptime}\n")








