from roominfo import room as Room
import datetime as dt
from datetime import datetime as dtdt
import os

timeformat = "%Y-%m-%d %H:%M:%S"
mydir = "D:\\Programming School\\coadings\\python_codes\\self_study"

if __name__ == "__main__":

    restd_file = []
    recov_files = os.listdir(mydir)
    for file in recov_files:
        full_file = os.path.join(mydir,file)
        if os.path.isfile(full_file):
            split_file = os.path.splitext(file)
            if split_file[1] = ".txt":
                restd_file.append = split_file[0]

                
                    
        
    room_datas = []
    while True:
        roomnum = input("roomnum:")
        if not roomnum.strip():
            break
        while True: 
            try:
                timein = dtdt.strptime(input("time entered:").strip(),timeformat)
                break
            except:
                pass
        while True:
            try:    
                timeout = input("time exited:").strip()
                if timeout:
                    timeout = dtdt.strptime(timeout,timeformat)
                    break
                else:
                    timeout = None
                    break
            except:
                print("write again:")
                pass
        room_datas.append(Room(roomnum,timein,timeout))

        fulldir = os.path.join(mydir,roomnum+".txt")
        with open(fulldir, 'a') as f:
            intime = dtdt.strftime(timein,timeformat)
            if timeout == None:
                f.write(f"{intime}|")
            else:
                timeout = dtdt.strftime(timeout,timeformat)
                f.write(f"{intime}|{timeout}")
                    
    for room in room_datas:
        print(room.roomnum,room.timein,room.timeout)
        print(room.time_used())

    
