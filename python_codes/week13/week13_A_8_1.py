# week13_A_8_1.py
# id:202444029
# name: 김요한
#시험 준비 공부
import os
from datetime import datetime as dt

dtFormat = "%Y-%m-%d %H:%M:%S"

mypath = "D:\Programming School\coadings\python_codes\week13"
myfile = "lsit.txt"
fullfile = os.path.join(mypath, myfile)

def diff_seconds(timein,timeout):
    if not timeout:
        timeout = dt.now()
    return (timeout - timein).total_seconds()
    
if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    datas = []

    # 파일이 있으면 읽어서 rooms에 복구한다.
    
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








