#import 파일이름 (현재파일과 같은 위치에 있어야함)

import os
os.path.exists()
os.path.isfile()#파일 존재여부
os.path.isdir()#폴더 존재여부
os.mkdir()#폴더 생성
os.listdir()#폴더내의 폴더의 파일 확인
os.remove()
os.path.join(a,b)#경로 연결
os.path.splitext()#파일명,확장자 분리
#'a','w' 로 파일 open 하면 파일 만들어짐

import random as rd
rd.randint(1,10)# 1~10
rd.randrange(1,10) #1~9
rd.choice("321321") #순서요소에서 1개 선택

import datetime
import datetime as dt
from datetime import datetime as dtdt
timeformat = "%Y-%m-%d %H:%M:%S"
datetime.datetime.now() 
datetime.datetime.strptime() #return: datetime
datetime.datetime.strftime() #return: str
datetime.timedelta()
dtdt.total_seconds()
time1 = dtdt(2024,8,26,11,16)
time2 = dt.timedelta(days=2,hours=2)
timenow = dtdt.now()
timenow.strftime(timeformat) #이거랑
dtdt.strftime(timenow,timeformat)#이거 같음

try:
    print("hello python")
except:
    pass

a = "aaabbbcccddd"
a[0],a[-1]
a.count('b') #3
a.find('c') #6
a.index('c') #6
a.upper()
a.lower()
a.strip()
a.split('bbb')
