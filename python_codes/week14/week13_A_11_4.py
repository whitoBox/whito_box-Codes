# week13_A_11_4.py
# id:202444029
# name:kim yo han

from room import Room2 as Room
from room import TimeStamp
import datetime as dt
import os
import random

timeformat = "%Y-%m-%d %H:%M:%S"
mypath = "D:\Programming School\coadings\python_codes\week14"

# A1_10 ~ A1-99
# A2_10 ~ S2_99
def gen_room_number():
    room_type =  ['A','S'] #"AS" <이거도 됨
    room_level = f"{random.randint(1,8)}"#1~8
    room_num = f"{random.randrange(10,100,1)}"#10~99까지
    room_choice_type = random.choice(room_type)#순번이 있는 요소에서 하나는 뽑아줌
    return f"{room_choice_type}{room_level}_{room_num}"

def gen_intime():             #timedelta 시간 뺴고 더하고 하는거(몰라 함 알아봐)
    return dt.datetime.now() - dt.timedelta(hours = random.randint(0,8),
                                            minutes = random.randint(0,60))

def gen_outtime():             #timedelta 시간 뺴고 더하고 하는거(몰라 함 알아봐)
    return dt.datetime.now() + dt.timedelta(hours = random.randint(1,48),
                                            minutes = random.randint(0,60))
    

if __name__ == "__main__":
    if not os.path.isdir(mypath):
        os.mkdir(mypath)

    rooms = []
    
    # 파일이 있으면 읽어서 rooms에 복구한다.
    members = os.listdir(mypath)
    for member in members:
        member_fullname = os.path.join(mypath,member)
        if os.path.isfile(member_fullname):
            file_ext = os.path.splitext(member)#return ["file.name.stuff", ".txt"]
            if len(file_ext) == 2 and file_ext[-1] == ".txt":
                number = file_ext[0].strip()
                room = Room(number)
                rooms.append(room)
                #rooms[number] = []
                
                with open(member_fullname, 'r', encoding="utf-8")as f:
                    for line in f: #모든 줄 이렇게 읽을수 있음
                        split_datas = line.strip().split('|')
                        if len(split_datas) == 2:
                            intime = dt.datetime.strptime(split_datas[0].strip(), timeformat)
                            if split_datas[1].strip():
                                outtime = dt.datetime.strptime(split_datas[1].strip(), timeformat)
                            else:
                                outtime = None
                            room.add_timestamp(intime,outtime)
            


    while True:
        room = input("빌릴거임?(Y)").strip()
        if not room:
            break
        room = gen_room_number()
        
        #아래 이거 0(없음),1(있음) 이거 외에 값 나오면 프로그램 잘못 만든거임
        search_room = [room_info for room_info in rooms if room_info.number == room]
        
        if not search_room:
            room_info = Room(room)
            rooms.append(room_info)
        else:
            room_info = search_room[0]
            for timestamp in room_info.history:
                if timestamp.is_rent():
                    stoptime = dt.datetime.strptime(stoptime, timeformat)
                    #반납(퇴실) 코드 작성해보기
                    continue

        while True:
            try:
                starttime = input("시작시간:").strip()
                if starttime:
                    starttime = dt.datetime.strptime(starttime, timeformat)
                    break
                else:
                    starttime = gen_intime()
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
                starttime = gen_intime()
                pass

        #rent_info = {"in": starttime, "out": stoptime}
        #rooms[room].append(rent_info)
        room_info.add_timestamp(starttime,stoptime)
        
        fullfile = os.path.join(mypath, room+".txt")

        with open(fullfile, 'a', encoding = 'utf-8') as f:
            intime = dt.datetime.strftime(starttime,timeformat)
            if not stoptime == None:
                outtime = dt.datetime.strftime(stoptime,timeformat)
                f.write(f"{intime}|{outtime}\n")
            else:
                f.write(f"{intime}|")
                #
        
    for room_info in rooms:
        print(room_info.number)
        for timestamp in room_info.history:
            print(timestamp.intime, timestamp.outtime)
            print(timestamp.diff_seconds())

    
