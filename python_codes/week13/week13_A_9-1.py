# week13_A_9_1.py
# id:202444029
# name: 김요한
#시험 준비 공부
import os
from datetime import datetime as dt

dtFormat = "%Y-%m-%d %H:%M:%S"

#mypath이거 노트북에서 변경
mypath = "D:\\school coadings\\whito_box-Codes\\python_codes\\week13"
myfile = "room.txt"
fullfile = os.path.join(mypath, myfile)


def diff_seconds(timein,timeout):
    if not timeout:
        timeout = dt.now()
    return (timeout - timein).total_seconds()

if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    datas = []

    # 파일이 있으면 읽어서 datas에 복구한다.   
    if os.path.isdir(mypath):
        print("복구한 정보입니다.")
        with open(fullfile, 'r') as F:
            prevdata = F.readlines()
            for pdatas in prevdata:
                datasep = pdatas.strip().split('|')
                dictconv = {'room':datasep[0],
                            'startTime':dt.strptime(datasep[1],dtFormat)}
                if datasep[2]:
                    dictconv['endTime'] = dt.strptime(datasep[2],dtFormat)
                else:
                    dictconv['endTime'] = None
                datas.append(dictconv)
                print(pdatas.strip())

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

    with open(fullfile, "w", encoding = "utf-8") as f:
        for info in datas:
            num = info["room"]
            starttime = dt.strftime(info['startTime'],dtFormat)
            if not info ['endTime']:
                stoptime = ''
            else:
                stoptime = dt.strftime(info['endTime'],dtFormat)

            f.write(f"{num}|{starttime}|{stoptime}\n")








