from datetime import datetime as dtdt
import datetime as dt
import car as Car
import os

mydir = "D:\\Programming School\\coadings\\python_codes\\self_study"
myfile = "cardatas.txt"
fulldir = os.path.join(mydir,myfile)
timeformat = "%Y-%m-%d %H:%M:%S"
cars = []

recov_datas = os.listdir(mydir)
for rdata in recov_datas:
    if os.path.isfile(rdata):
        checkfile = os.path.join(mydir,rdata)
        split_type = os.path.splitext(checkfile)
        if split_type[1] == ".txt":
            

while True:
    carnum = input("차량번호:").strip()
    if carnum == "":
        break
    
    while True:
        try:
            intime =  dtdt.strptime(input("입차시간:").strip(),timeformat)
            break
        except:
            pass
        
    while True:
        try:   
            outtime = input("출차시간:").strip()
            if outtime == "":
                outtime = None
                break
            else:
                outtime = dtdt.strptime(outtime,timeformat)
                break
        except:
            pass
        
    car = Car.car1
    cars.append(car(carnum,intime,outtime))

for data in cars:
    print(data.carnum, data.intime, data.outtime)
    print(data.diff_seconds())

for data in cars:
    fulldir = os.path.join(mydir,data.carnum+".txt")
    with open(fulldir, 'a') as f:
        timein = dtdt.strftime(data.intime,timeformat)
        if data.outtime == None:
            timeout = None
        else:
            timeout = dtdt.strftime(data.outtime,timeformat)
        f.write(f"{data.carnum}|{timein}|{timeout}\n")
