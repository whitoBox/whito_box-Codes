# week13_02.py
# id:202444029
# name: 김요한

import datetime
from datetime import datetime as dt

#datetime -> str -> file(text)
#file(text) -> str ->datetime
# %Y %m %d %H %M %S %f 시간 포맷

dtFormat = "%Y-%m-%d"#<- 이거 바꿔서 실험해본다.

d1 = dt.now()
d2 = dt.strftime(d1, dtFormat) #f: format datetime -> str
d3 = dt.strptime(d2, dtFormat) #p: parse str -> datetime
dt.strptime
print(type(d2),d2)
print(type(d3),d3)

print("-"*30)


d1 = datetime.datetime(2030,10,2,18,0,2,200)
d2 = datetime.datetime(2031,10,3,17,3,3,202)

td = d2 - d1
print(type(td),td)#itmedelta 
#365 days, 23:03:01.000002
print(td.days)
#print(td.hours)
print(td.seconds)
print(td.microseconds)
print(td.total_seconds())#이거를 잘 써야한다 한다.

d3 = d1 + datetime.timedelta(days=7)
d4 = d2 + datetime.timedelta(days=-7)
print(d3)
print(d4)


